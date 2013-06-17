Imports System.IO.Ports
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1
    Private Serial As SerialPort = New SerialPort
    Private CurrentX, CurrentY, CurrentZ As Integer
    Private PacketCount As Long
    Private LastPacketCount As Long
    Private DataSpeed As Integer
    Private BeginRead As Boolean   ' flag mulai membaca setelah perhitungan mundur selesai
    Private TimerStarter As Integer
    Private IsDataReadyToVisualize As Boolean = False

    ' kalibrasi
    Private XMax, YMax, ZMax, XMin, YMin, ZMin As Integer
    Private IsCalibrating As Boolean = False

    ' perhitungan & visualisasi data
    Private Const DEFAULT_THETA As Double = 0.0153846153846154 ' interval pembacaan data, dg kondisi default 65 paket/detik
    Private THETA As Double = DEFAULT_THETA
    Private Const G As Double = 9.8
    Private XDistance, YDistance, ZDistance As Double
    Private XVelocity, YVelocity, ZVelocity As Double
    Private XAcceleration, YAcceleration, ZAcceleration As Double

    ' offline data reading
    Private FilePathName As String = ""
    Private IsOffline As Boolean = False
    Private Const INFILE_PACKET_DELIMITER As String = " "

    ' kriteria koneksi berjalan
    Private Enum ConnectionBased
        None   ' tak berbatas
        TimeBased  ' berbatas waktu
        DistanceBased ' berbatas jarak
    End Enum

    ' fitur autoconnect
    Private AutoConnectTimeout As Integer
    Private Const PING_REPLY As String = "unnes!"
    Private Const AUTO_CONNECT_TIMEOUT As Integer = 100  ' batas timeout ping untuk tiap serialport yg terdeteksi
    Private AutoConnectCurrentSerialPort As Integer
    Private AutoConnectPingReply As String = ""

    ' pembatas koneksi
    Private ConnectionTypeBased As ConnectionBased
    Private DistanceLimit As Double
    Private VelocityLimit As Double
    Private TimeLimit As Long

    Private AccelerometerDataProccessor As Accelerometer

    ' suara
    Private BeepSound As Byte()
    Private Gunshot As Byte()

    ' karakteristik lari 
    Private Const UP As String = "▲"
    Private Const DOWN As String = "▼"
    Private Const NEUTRAL As String = "—"

    Sub AddNewDataToChart(ByVal Distance As Double, ByVal Velocity As Double)
        ChartDistanceVelocity.Series(0).Points.AddXY(Distance, Velocity)
    End Sub

    Sub AddNewDataToListView(ByVal ListViewToUpdate As ListView, ByVal X As Double, ByVal Y As Double, ByVal Z As Double)
        Dim t As Double = (ListViewToUpdate.Items.Count + 1) * THETA
        Dim st As String = t.ToString
        Dim lenstr As Integer
        If (st.IndexOf(","c) >= 0) Then
            lenstr = st.IndexOf(","c) + 4
            If (lenstr <= st.Length) Then
                st = st.Substring(0, lenstr)
            End If

        End If
        With ListViewToUpdate.Items.Add(st)
            .SubItems.Add(Z)
            .SubItems.Add(X)
            .SubItems.Add(Y)
        End With
        If (ListViewToUpdate.Items.Count > 0) Then
            ListViewToUpdate.EnsureVisible(ListViewToUpdate.Items.Count - 1)
        End If
    End Sub

    Private Sub TrafficLight(ByVal Time As Integer)
        Select Case Time
            Case Is >= 3
                picTrafficLight.Image = My.Resources._3
            Case 2
                picTrafficLight.Image = My.Resources._2
            Case Is = 1
                picTrafficLight.Image = My.Resources._1
            Case Is <= 0
                picTrafficLight.Image = My.Resources._0
        End Select
        picTrafficLight.Tag = Time.ToString
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If (Serial.IsOpen) Then
            Serial.Write("r"c)  ' mereset modul akselerometer
            Serial.Close()
        End If
        SplashScreen.Close()
        AboutBox.Close()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If ListViewAcceleration.Items.Count > 0 Then
            cmdClear.PerformClick()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AccelerometerDataProccessor = New Accelerometer(chkXEnable.Checked, chkYEnable.Checked, chkZEnable.Checked, THETA)
        ComboBox1.Items.AddRange(IO.Ports.SerialPort.GetPortNames)
        If (ComboBox1.Items.Count) Then
            ComboBox1.SelectedIndex = 0
        End If
        With Serial
            .BaudRate = 9600
            .Parity = Parity.None
            .StopBits = StopBits.One
            .DataBits = 8
            .Handshake = Handshake.XOnXOff
            .NewLine = Chr(10)
        End With
        lblXMax.Text = XMax
        lblYMax.Text = YMax
        lblZMax.Text = ZMax
        ErrorConnection()
        LoadSounds()
        TrafficLight(0)
    End Sub

    Private Sub LoadSounds()
        Dim sound_reader As BinaryReader = New BinaryReader(My.Resources.beep)
        BeepSound = sound_reader.ReadBytes(My.Resources.beep.Capacity)
        sound_reader = New BinaryReader(My.Resources.gunshot)
        Gunshot = sound_reader.ReadBytes(My.Resources.gunshot.Capacity)
    End Sub

    Private Sub VisualizeCurrentInformation(ByVal AxisSelect As Accelerometer.Axis, _
                                        ByVal Acc As Double, ByVal Velo As Double)
        Dim lblCurrAccPtr As Label = Nothing
        Dim lblCurrVeloPtr As Label = Nothing
        Dim lblCurrAccStatePtr As Label = Nothing
        Dim lblCurrVeloStatePtr As Label = Nothing

        Select Case AxisSelect
            Case Accelerometer.Axis.X
                lblCurrAccPtr = lblXCurrentAcc
                lblCurrVeloPtr = lblXCurrentVelo
                lblCurrAccStatePtr = lblXCurrentAccState
                lblCurrVeloStatePtr = lblXCurrentVeloState
                lblXDistance.Text = XDistance.ToString
            Case Accelerometer.Axis.Y
                lblCurrAccPtr = lblYCurrentAcc
                lblCurrVeloPtr = lblYCurrentVelo
                lblCurrAccStatePtr = lblYCurrentAccState
                lblCurrVeloStatePtr = lblYCurrentVeloState
                lblYDistance.Text = YDistance.ToString
            Case Accelerometer.Axis.Z
                lblCurrAccPtr = lblZCurrentAcc
                lblCurrVeloPtr = lblZCurrentVelo
                lblCurrAccStatePtr = lblZCurrentAccState
                lblCurrVeloStatePtr = lblZCurrentVeloState
                lblZDistance.Text = ZDistance.ToString
        End Select

        If (Acc > Double.Parse(lblCurrAccPtr.Text)) Then   ' jika perceptanan naik
            lblCurrAccStatePtr.Text = UP
            lblCurrAccStatePtr.ForeColor = Color.Lime
        ElseIf (Double.Parse(lblCurrAccPtr.Text) = Acc) Then  ' jika percepatan tetap
            lblCurrAccStatePtr.Text = NEUTRAL
            lblCurrAccStatePtr.ForeColor = Color.Blue
        ElseIf (Acc < Double.Parse(lblCurrAccPtr.Text)) Then
            lblCurrAccStatePtr.Text = DOWN   ' jika percepatan turun
            lblCurrAccStatePtr.ForeColor = Color.Red
        End If
        lblCurrAccPtr.Text = Acc.ToString

        If (Velo > Double.Parse(lblCurrVeloPtr.Text)) Then   ' jika keceptanan naik
            lblCurrVeloStatePtr.Text = UP
            lblCurrVeloStatePtr.ForeColor = Color.Lime
        ElseIf (Double.Parse(lblCurrVeloPtr.Text) = Velo) Then  ' jika kecepatan tetap
            lblCurrVeloStatePtr.Text = NEUTRAL
            lblCurrVeloStatePtr.ForeColor = Color.Blue
        ElseIf (Velo < Double.Parse(lblCurrVeloPtr.Text)) Then
            lblCurrVeloStatePtr.Text = DOWN   ' jika kecepatan turun
            lblCurrVeloStatePtr.ForeColor = Color.Red
        End If
        lblCurrVeloPtr.Text = Velo.ToString
    End Sub

    Private Sub VisualizeCharacteristic(ByVal AxisSelect As Accelerometer.Axis)
        Dim lblAvgAccPtr As Label
        Dim lblAvgVeloPtr As Label
        Dim lblDistancePtr As Label
        Dim AccSum, VeloSum As Double
        Dim i As Integer


        Select Case AxisSelect
            Case Accelerometer.Axis.X
                lblAvgAccPtr = lblXAvgAcc
                lblAvgVeloPtr = lblXAvgVelo
                lblDistancePtr = lblXDistance
                If (chkXEnable.Checked Or IsOffline) Then
                    For i = 0 To ListViewAcceleration.Items.Count - 1
                        AccSum += Double.Parse(ListViewAcceleration.Items(i).SubItems(2).Text)
                    Next
                    For i = 0 To ListViewVelocity.Items.Count - 1
                        VeloSum += Double.Parse(ListViewVelocity.Items(i).SubItems(2).Text)
                    Next
                    lblDistancePtr.Text = ListViewDistance.Items(ListViewDistance.Items.Count - 1).SubItems(2).Text
                End If
            Case Accelerometer.Axis.Y
                lblAvgAccPtr = lblYAvgAcc
                lblAvgVeloPtr = lblYAvgVelo
                lblDistancePtr = lblYDistance
                If (chkYEnable.Checked Or IsOffline) Then
                    For i = 0 To ListViewAcceleration.Items.Count - 1
                        AccSum += Double.Parse(ListViewAcceleration.Items(i).SubItems(3).Text)
                    Next
                    For i = 0 To ListViewVelocity.Items.Count - 1
                        VeloSum += Double.Parse(ListViewVelocity.Items(i).SubItems(3).Text)
                    Next
                    lblDistancePtr.Text = ListViewDistance.Items(ListViewDistance.Items.Count - 1).SubItems(3).Text
                End If
            Case Accelerometer.Axis.Z
                lblAvgAccPtr = lblZAvgAcc
                lblAvgVeloPtr = lblZAvgVelo
                lblDistancePtr = lblZDistance
                If (chkZEnable.Checked Or IsOffline) Then
                    For i = 0 To ListViewAcceleration.Items.Count - 1
                        AccSum += Double.Parse(ListViewAcceleration.Items(i).SubItems(1).Text)
                    Next
                    For i = 0 To ListViewVelocity.Items.Count - 1
                        VeloSum += Double.Parse(ListViewVelocity.Items(i).SubItems(1).Text)
                    Next
                    lblDistancePtr.Text = ListViewDistance.Items(ListViewDistance.Items.Count - 1).SubItems(1).Text
                End If
        End Select
        If (ListViewAcceleration.Items.Count = 0) Then
            lblAvgAccPtr.Text = "0"
        Else
        End If
        If (ListViewVelocity.Items.Count = 0) Then
            lblAvgVeloPtr.Text = "0"
        End If
        If (ListViewDistance.Items.Count = 0) Then
            lblDistancePtr.Text = "0"
        End If
        If (ListViewAcceleration.Items.Count = 0 Or _
            ListViewVelocity.Items.Count = 0 Or ListViewDistance.Items.Count = 0) Then
            Exit Sub
        End If
        lblAvgAccPtr.Text = AccSum / ListViewAcceleration.Items.Count
        lblAvgVeloPtr.Text = VeloSum / ListViewVelocity.Items.Count
    End Sub

    Private Sub RefreshCalibratingLabel()
        lblXMax.Text = AccelerometerDataProccessor.GetMaxCalibrationValue(Accelerometer.Axis.X)
        lblYMax.Text = AccelerometerDataProccessor.GetMaxCalibrationValue(Accelerometer.Axis.Y)
        lblZMax.Text = AccelerometerDataProccessor.GetMaxCalibrationValue(Accelerometer.Axis.Z)
        lblXMin.Text = AccelerometerDataProccessor.GetMinCalibrationValue(Accelerometer.Axis.X)
        lblYMin.Text = AccelerometerDataProccessor.GetMinCalibrationValue(Accelerometer.Axis.Y)
        lblZMin.Text = AccelerometerDataProccessor.GetMinCalibrationValue(Accelerometer.Axis.Z)
    End Sub

    Private Sub chkXEnable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkXEnable.CheckedChanged
        If (Not IsNothing(AccelerometerDataProccessor)) Then
            AccelerometerDataProccessor.SetReadingOnAxis(Accelerometer.Axis.X, chkXEnable.Checked)
        End If
    End Sub

    Private Sub chkYEnable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkYEnable.CheckedChanged
        If (Not IsNothing(AccelerometerDataProccessor)) Then
            AccelerometerDataProccessor.SetReadingOnAxis(Accelerometer.Axis.Y, chkYEnable.Checked)
        End If
    End Sub

    Private Sub chkZEnable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkZEnable.CheckedChanged
        If (Not IsNothing(AccelerometerDataProccessor)) Then
            AccelerometerDataProccessor.SetReadingOnAxis(Accelerometer.Axis.Z, chkZEnable.Checked)
        End If
    End Sub

    Private Sub ClearChart()
        'ChartDistanceVelocity.BeginInit()
        ChartDistanceVelocity.Series(0).Points.Clear()
        'ChartDistanceVelocity.Series(0).Points.Clear()
        'ChartDistanceVelocity.Series(0).Points.Clear()
        'ChartDistanceVelocity.EndInit()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        If (ListViewAcceleration.Items.Count > 0) Then
            If (MsgBox("Apakah anda ingin menyimpan hasil monitoring terakhir kedalam file?", vbYesNo + vbQuestion, "Simpan") = vbYes) Then
                SimpanFileMonitoringToolStripMenuItem2.PerformClick()
            End If
        End If
        ListViewAcceleration.Items.Clear()
        ListViewDistance.Items.Clear()
        ListViewVelocity.Items.Clear()
        ClearCharacteristic()
        ClearChart()
    End Sub

    Private Sub txtConnectionTimeout_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) Then
            Exit Sub
        End If
    End Sub


    Private Sub txtDistanceLimit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) Or Not (e.KeyChar = ".") Then
            Exit Sub
        End If
    End Sub

    Private Sub txtVelocityLimit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) Or Not (e.KeyChar = ".") Then
            Exit Sub
        End If
    End Sub


    Private Sub tmrConnectionController_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrConnectionController.Tick
        If (Not BeginRead And Not IsCalibrating And TimerStarter >= 1) Then
            My.Computer.Audio.Play(BeepSound, AudioPlayMode.Background)
            'BeepSound = My.Resources.beep   ' reload stream wav
            TrafficLight(TimerStarter)
            TimerStarter -= 1
            If (TimerStarter = 0) Then
                My.Computer.Audio.Play(Gunshot, AudioPlayMode.Background)
                'Gunshot = My.Resources.gunshot  ' reload stream wav
                BeginRead = True
                tmrConnectionController.Interval = 1
                cmdAutoConnect.Enabled = False
            ElseIf (TimerStarter = -1) Then
                TrafficLight(0)
            End If
        ElseIf (BeginRead) Then
            Select Case ConnectionTypeBased
                Case ConnectionBased.DistanceBased
                    If (ZDistance > DistanceLimit) Then
                        cmdListen.PerformClick()
                        tmrConnectionController.Enabled = False
                        Exit Sub
                    End If
                Case ConnectionBased.TimeBased

            End Select
        End If

    End Sub

    Private Sub ErrorConnection()
        tmrDataReader.Enabled = False
        tmrDataSpeed.Enabled = False
        tmrVisualizeData.Enabled = False
        tmrConnectionController.Enabled = False
        BeginRead = False
        TrafficLight(0)
        lblConnection.Text = "Disconnected"
        lblConnection.ForeColor = Color.Red
        cmdListen.Text = "Mulai"
        cmdListen.Image = My.Resources._1355330323_Gnome_System_Log_Out_32
        cmdListen.Enabled = False
        pnlCalibration.Enabled = False
        pnlConnectionCriteria.Enabled = False
        ResetStopwatch()
    End Sub

    Private Sub tmrDataReader_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDataReader.Tick
        If (Not Serial.IsOpen) Then
            ErrorConnection()
            MsgBox("Koneksi Error", MsgBoxStyle.Critical, "Error")
            cmdAutoConnect.Enabled = True
            Exit Sub
        End If
        If (Serial.BytesToRead) Then

            'Dim NewTransmission As String = ""
            'Do Until (Serial.BytesToRead And Serial.ReadByte = 10)
            '    'Application.DoEvents()
            'Loop
            'Do Until (Serial.BytesToRead And Serial.ReadByte = 10)
            '    NewTransmission = NewTransmission & ChrW(Serial.ReadChar)
            'Loop
            'line = Serial.ReadLine
            'Debug.Print(line)
            'If (line.Length < 12) Then
            '    Exit Sub
            'End If
            AccelerometerDataProccessor.SupplyNewTransmission(Serial.ReadExisting())
            'line = ""
            If (Not IsCalibrating) Then
                IsDataReadyToVisualize = False
                ' poros x
                If (chkXEnable.Checked) Then
                    XAcceleration = AccelerometerDataProccessor.ReadLastAcceleration(Accelerometer.Axis.X)
                    XVelocity = AccelerometerDataProccessor.ReadCurrentVelocity(Accelerometer.Axis.X)
                    XDistance = AccelerometerDataProccessor.ReadComulativeDistance(Accelerometer.Axis.X)
                Else
                    XAcceleration = 0
                    XVelocity = 0
                    XDistance = 0
                End If

                ' poros y
                If (chkYEnable.Checked) Then
                    YAcceleration = AccelerometerDataProccessor.ReadLastAcceleration(Accelerometer.Axis.Y)
                    YVelocity = AccelerometerDataProccessor.ReadCurrentVelocity(Accelerometer.Axis.Y)
                    YDistance = AccelerometerDataProccessor.ReadComulativeDistance(Accelerometer.Axis.Y)
                Else
                    YAcceleration = 0
                    YVelocity = 0
                    YDistance = 0
                End If

                ' poros z
                If (chkZEnable.Checked) Then
                    ZAcceleration = AccelerometerDataProccessor.ReadLastAcceleration(Accelerometer.Axis.Z)
                    ZVelocity = AccelerometerDataProccessor.ReadCurrentVelocity(Accelerometer.Axis.Z)
                    ZDistance = AccelerometerDataProccessor.ReadComulativeDistance(Accelerometer.Axis.Z)
                Else
                    ZAcceleration = 0
                    ZVelocity = 0
                    ZDistance = 0
                End If
                IsDataReadyToVisualize = True
            End If
        Else
            If (Serial.IsOpen) Then
                Serial.Write("t"c)
            End If
        End If
    End Sub

    Private Sub cmdListen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdListen.Click
        Dim calibrationtimeout As Integer = 20000 ' timeout kalibrasi = 20detik
        Dim calibration_start As Integer
        Dim calibration_time As Integer

        ClearCharacteristic()
        ResetStopwatch()
        If (cmdListen.Text = "Mulai") Then
            cmdClear.PerformClick()
            BeginRead = False
            'ListViewAcceleration.Visible = False
            'ListViewVelocity.Visible = False
            'ListViewDistance.Visible = False
            'ChartDistanceVelocity.Visible = False
            cmdClear.Enabled = False
            pnlConnectionCriteria.Enabled = False
            TimerStarter = 3
            pnlCalibration.Enabled = False
            cmdListen.Enabled = False
            tmrConnectionController.Interval = 1000  ' set untuk perhitungan mundur
            tmrConnectionController.Enabled = True  ' mulai perhitungan
            calibration_start = Now.Millisecond
            Do Until BeginRead Or (calibration_time >= calibrationtimeout)
                calibration_time = Now.Millisecond - calibration_start
                Application.DoEvents()
            Loop
            If (calibration_time >= calibrationtimeout) Then
                MsgBox("Kalibrati Timeout!", MsgBoxStyle.Critical, "Error")
            End If
            cmdListen.Text = "Berhenti"
            cmdListen.Image = My.Resources.Resources._1355334115_button_stop_red
            cmdListen.Enabled = True
            AccelerometerDataProccessor.BeginProccessing()
            Select Case ConnectionTypeBased
                Case ConnectionBased.DistanceBased
                    DistanceLimit = Double.Parse(txtDistanceLimit.Text)
                    If (DistanceLimit <= 0) Then
                        MsgBox("Error Batas Jarak!", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End If
                    tmrConnectionController.Interval = 1
                    tmrConnectionController.Enabled = True
                    If (DistanceLimit <= 250) Then
                        ChartDistanceVelocity.ChartAreas(0).AxisX.Maximum = DistanceLimit
                    Else
                        ChartDistanceVelocity.ChartAreas(0).AxisX.Maximum = 250
                    End If
                Case ConnectionBased.TimeBased
                    TimeLimit = Long.Parse(txtConnectionTimeout.Text)
                    If (TimeLimit <= 0) Then
                        MsgBox("Error Batas Waktu!", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End If
                    tmrConnectionController.Interval = 1
                    tmrConnectionController.Enabled = True
            End Select
            lblConnection.Text = "Connected"
            cmdListen.Text = "Selesai"
            tmrDataReader.Enabled = True
            tmrDataSpeed.Enabled = True
            tmrVisualizeData.Enabled = True
            BeginRead = True

        Else
            AccelerometerDataProccessor.EndProccessing()
            'ListViewAcceleration.Visible = True
            'ListViewVelocity.Visible = True
            'ListViewDistance.Visible = True
            'ChartDistanceVelocity.Visible = True
            VisualizeCharacteristic(Accelerometer.Axis.X)
            VisualizeCharacteristic(Accelerometer.Axis.Y)
            VisualizeCharacteristic(Accelerometer.Axis.Z)
            tmrDataReader.Enabled = False
            tmrDataSpeed.Enabled = False
            tmrVisualizeData.Enabled = False
            cmdAutoConnect.Enabled = True
            If (Serial.IsOpen) Then
                Serial.Write("t"c)
            End If
            cmdListen.Text = "Mulai"
            cmdListen.Image = My.Resources.Resources._1355330323_Gnome_System_Log_Out_32
            lblPacketSpeed.Text = "0"
            LastPacketCount = 0
            PacketCount = 0
            pnlCalibration.Enabled = True
            BeginRead = False
            pnlConnectionCriteria.Enabled = True
            cmdClear.Enabled = True
        End If
    End Sub

    Private Sub cmdAutoConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAutoConnect.Click
        ComboBox1.Items.Clear()
        ComboBox1.Items.AddRange(SerialPort.GetPortNames())
        If (ComboBox1.Items.Count <= 0) Then
            MsgBox("Tidak Ada Serial Port yang Terdeteksi", MsgBoxStyle.Critical, "Error")
            lblConnection.Text = "Disconnected"
            lblConnection.ForeColor = Color.Red
            cmdListen.Enabled = False
            pnlConnectionCriteria.Enabled = False
            pnlCalibration.Enabled = False
            Exit Sub
        Else
            ComboBox1.SelectedIndex = 0
        End If
        If (Serial.IsOpen) Then
            Serial.Write("r"c)
            Serial.Close()
        End If
        cmdAutoConnect.Enabled = False
        ComboBox1.Enabled = False
        cmdListen.Enabled = False
        AutoConnectTimeout = 0
        AutoConnectCurrentSerialPort = 0
        AutoConnectPingReply = ""
        lblConnection.Text = "Mencari Perangkat.."
        tmrAutoConnect.Enabled = True
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblConnection.Click

    End Sub

    Private Sub tmrAutoConnect_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAutoConnect.Tick
        If (Not Serial.IsOpen) Then
            Try
                Serial.PortName = ComboBox1.Items(AutoConnectCurrentSerialPort).ToString
                Serial.Open()
            Catch ex As Exception
                If (Serial.IsOpen) Then
                    Serial.Close()
                End If
            End Try
            AutoConnectCurrentSerialPort += 1
            AutoConnectTimeout = 0
            ' mencoba melakukan protocol testing pada setiap port yg terdeteksi
            If (Serial.IsOpen) Then
                Serial.Write("p"c)
            End If

        Else
            If (AutoConnectTimeout >= AUTO_CONNECT_TIMEOUT) Then
                If (Serial.IsOpen) Then
                    Serial.Close()
                End If
                cmdListen.Enabled = False
                lblConnection.Text = "Disconnected"
                lblConnection.ForeColor = Color.Red
                cmdListen.Enabled = False
                pnlConnectionCriteria.Enabled = False
                pnlCalibration.Enabled = False
                Exit Sub
            End If
            If (AutoConnectPingReply.Contains(PING_REPLY)) Then
                cmdAutoConnect.Enabled = True
                cmdListen.Enabled = True
                lblConnection.Text = "Connected"
                lblConnection.ForeColor = Color.Green
                ComboBox1.SelectedIndex = AutoConnectCurrentSerialPort - 1
                AutoConnectTimeout = 0
                AutoConnectPingReply = ""
                AutoConnectCurrentSerialPort = 0
                tmrAutoConnect.Enabled = False
                pnlCalibration.Enabled = True
                If (Serial.IsOpen) Then
                    Serial.DiscardInBuffer()
                    Serial.Write("t")
                End If
                Exit Sub
            End If
            If (Serial.BytesToRead) Then
                AutoConnectPingReply = AutoConnectPingReply & Serial.ReadExisting
            Else
                Serial.Write("p"c)
            End If
            AutoConnectTimeout += 1
        End If
        If (AutoConnectCurrentSerialPort > ComboBox1.Items.Count) Then
            ' jika index serialport yang dicoba melebihi batas
            cmdListen.Enabled = False
            ComboBox1.Enabled = True
            cmdAutoConnect.Enabled = True
            tmrAutoConnect.Enabled = False
            AutoConnectPingReply = ""
            AutoConnectTimeout = 0
            tmrAutoConnect.Enabled = False
            AutoConnectCurrentSerialPort = 0
            lblConnection.Text = "Disconnected"
            MsgBox("Modul accelerometer tidak terdeteksi!" & vbNewLine & _
                   "Cabut modul receiver dan matikan terlebih dahulu modul akselerometer lalu coba kembali", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
    End Sub

    Private Sub tmrListViewRefresher_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ListViewAcceleration.EnsureVisible(ListViewAcceleration.Items.Count - 1)
        ListViewVelocity.EnsureVisible(ListViewVelocity.Items.Count - 1)
        ListViewDistance.EnsureVisible(ListViewDistance.Items.Count - 1)
    End Sub

    Private Sub rbConnectionCriteriaTimeout_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbConnectionCriteriaTimeout.CheckedChanged
        If (rbConnectionCriteriaTimeout.Checked) Then
            txtConnectionTimeout.Enabled = True
            txtDistanceLimit.Enabled = False
            ConnectionTypeBased = ConnectionBased.TimeBased
        End If
    End Sub

    Private Sub rbNoCriteria_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoCriteria.CheckedChanged
        If (rbNoCriteria.Checked) Then
            txtConnectionTimeout.Enabled = False
            txtDistanceLimit.Enabled = False
            ConnectionTypeBased = ConnectionBased.None
        End If
    End Sub

    Private Sub rbDistanceCriteria_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDistanceCriteria.CheckedChanged
        If (rbDistanceCriteria.Checked) Then
            txtConnectionTimeout.Enabled = False
            txtDistanceLimit.Enabled = True
            ConnectionTypeBased = ConnectionBased.DistanceBased
        End If
    End Sub

    Private Sub tmrVisualizeData_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrVisualizeData.Tick
        If (IsDataReadyToVisualize) Then
            VisualizeCurrentInformation(Accelerometer.Axis.X, XAcceleration, XVelocity)
            VisualizeCurrentInformation(Accelerometer.Axis.Y, YAcceleration, YVelocity)
            VisualizeCurrentInformation(Accelerometer.Axis.Z, ZAcceleration, ZVelocity)
            AddNewDataToListView(ListViewAcceleration, XAcceleration, YAcceleration, ZAcceleration)
            AddNewDataToListView(ListViewVelocity, XVelocity, YVelocity, ZVelocity)
            AddNewDataToListView(ListViewDistance, XDistance, YDistance, ZDistance)
            If (ZDistance <= ChartDistanceVelocity.ChartAreas(0).AxisX.Maximum _
                And ZVelocity <= ChartDistanceVelocity.ChartAreas(0).AxisY.Maximum _
                And ZDistance >= 0 And ZVelocity >= 0) Then ' jika tidak melewati batas chart
                AddNewDataToChart(ZDistance, ZVelocity)
            End If

        End If
    End Sub

    Private Sub ClearCharacteristic()
        Dim LabelItem As Label
        For Each LabelItem In gbCharacteristicX.Controls
            If (LabelItem.Tag = "state") Then ' mencari label state
                LabelItem.Text = NEUTRAL
                LabelItem.ForeColor = Color.Blue
            ElseIf (Not LabelItem.AutoSize) Then   ' label nilai karakteristik
                LabelItem.Text = "0"
            End If
        Next
        For Each LabelItem In gbCharacteristicY.Controls
            If (LabelItem.Tag = "state") Then
                LabelItem.Text = NEUTRAL
                LabelItem.ForeColor = Color.Blue
            ElseIf (Not LabelItem.AutoSize) Then
                LabelItem.Text = "0"
            End If
        Next
        For Each LabelItem In gbCharacteristicZ.Controls
            If (LabelItem.Tag = "state") Then
                LabelItem.Text = NEUTRAL
                LabelItem.ForeColor = Color.Blue
            ElseIf (Not LabelItem.AutoSize) Then
                LabelItem.Text = "0"
            End If
        Next
    End Sub


    Private Sub cmdCalibrate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalibrate.Click
        'Dim milis_begin_calibration As Long
        'Dim milis_time_calibration_esplased As Long

        cmdCalibrate.Enabled = False
        cmdDeleteCalibration.Enabled = False
        cmdDeleteCalibration.PerformClick()
        cmdListen.PerformClick()
        IsCalibrating = True
        cmdListen.Enabled = False
        AccelerometerDataProccessor.BeginCalibrating()
        tmrDataReader.Enabled = True
        tbCC.Enabled = False
        'milis_begin_calibration = My.Computer.Clock.TickCount
        Do Until (AccelerometerDataProccessor.GetCalibratingProgress >= 1)
            pbCalibrating.Value = pbCalibrating.Maximum * AccelerometerDataProccessor.GetCalibratingProgress
            Application.DoEvents()
        Loop
        'milis_time_calibration_esplased = My.Computer.Clock.TickCount - milis_begin_calibration
        'THETA = 1 / (AccelerometerDataProccessor.ProcessedDataCount / (milis_time_calibration_esplased / 1000))
        'If (txtThetaCalibration.Text = "") Then
        '    THETA = DEFAULT_THETA
        'Else
        '    If Not (Double.TryParse(txtThetaCalibration.Text, THETA)) Then
        '        THETA = DEFAULT_THETA
        '    Else
        '        THETA = Double.Parse(txtThetaCalibration.Text)
        '    End If
        'End If
        'txtThetaCalibration.Text = THETA.ToString
        cmdListen.PerformClick()
        AccelerometerDataProccessor.EndCalibrating()
        cmdCalibrate.Enabled = True
        cmdDeleteCalibration.Enabled = True
        tbCC.Enabled = True
        RefreshCalibratingLabel()
        pbCalibrating.Value = 0
        cmdListen.Enabled = True
        tmrDataReader.Enabled = False
        IsCalibrating = False
    End Sub

    Private Sub cmdDeleteCalibration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteCalibration.Click
        ' hapus nilai offset sebelumnya
        AccelerometerDataProccessor.ClearCalibration()
        RefreshCalibratingLabel()
    End Sub

    Private Sub tmrStopwatch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrStopwatch.Tick
        If (BeginRead) Then
            StepStopwatch()
        End If
    End Sub

    Private Sub ResetStopwatch()
        lblDS.Text = "0"
        lblS.Text = "0"
        lblM.Text = "0"
        lblH.Text = "0"
    End Sub

    Private Sub StepStopwatch()
        Dim ds, s, m, h As Integer
        ds = Integer.Parse(lblDS.Text)
        s = Integer.Parse(lblS.Text)
        m = Integer.Parse(lblM.Text)
        h = Integer.Parse(lblH.Text)

        If (ds = 60) Then
            s = s + 1
            ds = 0
        Else
            ds += 1
        End If

        If (s = 60) Then
            s = 0
            m = m + 1
        End If

        If (m = 60) Then
            m = 0
            h = h + 1
        End If

        lblDS.Text = ds.ToString
        lblS.Text = s.ToString
        lblM.Text = m.ToString
        lblH.Text = h.ToString

        If (ConnectionTypeBased = ConnectionBased.TimeBased) Then
            If (s >= TimeLimit) Then
                cmdListen.PerformClick()
                tmrConnectionController.Enabled = False
            End If
        End If
    End Sub

    Private Sub tmrDataSpeed_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDataSpeed.Tick
        If (IsCalibrating) Then
            LastPacketCount = 0
            PacketCount = 0
        End If
        If (picTrafficLight.Tag = "1") Then
            TrafficLight(0) ' matiin lampu ijo
        End If
        PacketCount = ListViewAcceleration.Items.Count
        DataSpeed = (PacketCount - LastPacketCount)
        lblPacketSpeed.Text = DataSpeed.ToString
        LastPacketCount = PacketCount
    End Sub

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        cmdAutoConnect.PerformClick()
    End Sub

    Private Sub txtThetaCalibration_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtThetaCalibration.KeyPress
        If (Not Char.IsDigit(e.KeyChar) And Not e.KeyChar = "."c And Not e.KeyChar = ChrW(8)) Then
            e.KeyChar = ChrW(0)
        End If
    End Sub
    Private Sub SimpanFileMonitoringToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanFileMonitoringToolStripMenuItem2.Click
        Dim SaveDlg As SaveFileDialog = New SaveFileDialog
        Dim fileiowriter As StreamWriter
        Dim line As String = ""

        With SaveDlg
            .Filter = "Wireless Running Monitoring File | *.wrm"
            .ShowDialog()
            If .FileName <> "" Then
                fileiowriter = New StreamWriter(.FileName)
                For i = 0 To ListViewAcceleration.Items.Count - 1
                    line = ListViewAcceleration.Items(i).SubItems(1).Text & INFILE_PACKET_DELIMITER & _
                        ListViewAcceleration.Items(i).SubItems(2).Text & _
                        INFILE_PACKET_DELIMITER & ListViewAcceleration.Items(i).SubItems(3).Text
                    fileiowriter.WriteLine(line)
                    line = ""
                    Application.DoEvents()
                Next
                fileiowriter.Close()
                MsgBox("Tersimpan!", MsgBoxStyle.Information, "Simpan")
            End If
        End With
    End Sub

    Private Sub TentangToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TentangToolStripMenuItem3.Click
        AboutBox.ShowDialog(Me)
    End Sub

    Private Sub BukaFileMonitoringToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BukaFileMonitoringToolStripMenuItem2.Click
        On Error GoTo ErrorOpenFile
        Dim OpenDlg As OpenFileDialog = New OpenFileDialog
        Dim fileioreader As StreamReader
        Dim line As String = ""
        Dim line_count As Integer = 0
        Dim element() As String

        If ListViewAcceleration.Items.Count > 0 Then
            cmdClear.PerformClick()
        End If
        With OpenDlg
            .Filter = "Wireless Running Monitoring File | *.wrm"
            .ShowDialog()
            If .FileName <> "" And File.Exists(.FileName) Then
                fileioreader = New StreamReader(.FileName)
                BukaFileMonitoringToolStripMenuItem2.Enabled = False
                SimpanFileMonitoringToolStripMenuItem2.Enabled = False
                tbCC.Enabled = False
                cmdClear.Enabled = False
                ' menghitung baris
                Do Until (fileioreader.EndOfStream)
                    fileioreader.ReadLine()
                    line_count += 1
                Loop
                pbOpenFile.Minimum = 0
                pbOpenFile.Maximum = line_count
                fileioreader = New StreamReader(.FileName)
                cmdClear.PerformClick()
                Dim OfflineProcessor As Accelerometer = New Accelerometer(True, True, True, THETA)
                OfflineProcessor.BeginProccessing()
                IsOffline = True
                ClearCharacteristic()
                line_count = 0
                Do Until (fileioreader.EndOfStream)
                    line_count += 1
                    line = fileioreader.ReadLine
                    element = line.Split(INFILE_PACKET_DELIMITER)
                    XAcceleration = Double.Parse(element(1))
                    YAcceleration = Double.Parse(element(2))
                    ZAcceleration = Double.Parse(element(0))

                    ' memberi supply transmisi offline pada obyek accelerometer data processor
                    OfflineProcessor.SupplyNewOfflineTransmission(XAcceleration, YAcceleration, ZAcceleration)
                    XVelocity = OfflineProcessor.ReadCurrentVelocity(Accelerometer.Axis.X)
                    YVelocity = OfflineProcessor.ReadCurrentVelocity(Accelerometer.Axis.Y)
                    ZVelocity = OfflineProcessor.ReadCurrentVelocity(Accelerometer.Axis.Z)
                    XDistance = OfflineProcessor.ReadComulativeDistance(Accelerometer.Axis.X)
                    YDistance = OfflineProcessor.ReadComulativeDistance(Accelerometer.Axis.Y)
                    ZDistance = OfflineProcessor.ReadComulativeDistance(Accelerometer.Axis.Z)

                    ' visualisasikan data
                    VisualizeCurrentInformation(Accelerometer.Axis.X, XAcceleration, XVelocity)
                    VisualizeCurrentInformation(Accelerometer.Axis.Y, YAcceleration, YVelocity)
                    VisualizeCurrentInformation(Accelerometer.Axis.Z, ZAcceleration, ZVelocity)
                    AddNewDataToListView(ListViewAcceleration, XAcceleration, YAcceleration, ZAcceleration)
                    AddNewDataToListView(ListViewVelocity, XVelocity, YVelocity, ZVelocity)
                    AddNewDataToListView(ListViewDistance, XDistance, YDistance, ZDistance)
                    AddNewDataToChart(ZDistance, ZVelocity)

                    pbOpenFile.Value += 1
                    Application.DoEvents()
                Loop
                OfflineProcessor.EndProccessing()
                fileioreader.Close()
                ClearCharacteristic()
                VisualizeCharacteristic(Accelerometer.Axis.X)
                VisualizeCharacteristic(Accelerometer.Axis.Y)
                VisualizeCharacteristic(Accelerometer.Axis.Z)
                IsOffline = False
                pbOpenFile.Value = 0
                BukaFileMonitoringToolStripMenuItem2.Enabled = True
                SimpanFileMonitoringToolStripMenuItem2.Enabled = True
                tbCC.Enabled = True
                cmdClear.Enabled = True
            End If
        End With
        Exit Sub
ErrorOpenFile:
        MsgBox("Error dalam membuka file!" & vbCrLf & "Terjadi kesalahan pembacaan data di baris ke: " & line_count, MsgBoxStyle.Critical, "Error")
        tbCC.Enabled = True
        cmdClear.Enabled = True
        BukaFileMonitoringToolStripMenuItem2.Enabled = True
        SimpanFileMonitoringToolStripMenuItem2.Enabled = True
        Exit Sub
    End Sub

    Private Sub cmdSaveGraph_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveGraph.Click
        Dim SaveDlg As SaveFileDialog = New SaveFileDialog

        With SaveDlg
            .Filter = "File Gambar Microosoft Bitmap (BMP) | *.bmp"
            .ShowDialog()
            If .FileName <> "" Then
                Try
                    ChartDistanceVelocity.SaveImage(.FileName, Imaging.ImageFormat.Bmp)
                Catch ex As Exception
                    MsgBox("Gagal menyimpan grafik!", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End Try
                MsgBox("Tersimpan!", MsgBoxStyle.Information, "Simpan")
            End If
        End With
    End Sub
End Class
