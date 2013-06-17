<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tmrDataSpeed = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkZEnable = New System.Windows.Forms.CheckBox()
        Me.chkYEnable = New System.Windows.Forms.CheckBox()
        Me.lblTimerStarter = New System.Windows.Forms.Label()
        Me.chkXEnable = New System.Windows.Forms.CheckBox()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.lblH = New System.Windows.Forms.Label()
        Me.lblDS = New System.Windows.Forms.Label()
        Me.lblS = New System.Windows.Forms.Label()
        Me.lblM = New System.Windows.Forms.Label()
        Me.gbCharacteristicY = New System.Windows.Forms.GroupBox()
        Me.lblYDistance = New System.Windows.Forms.Label()
        Me.lblYAvgVelo = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lblYCurrentVeloState = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.lblYCurrentVelo = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.lblYAvgAcc = New System.Windows.Forms.Label()
        Me.lblYCurrentAccState = New System.Windows.Forms.Label()
        Me.lblYCurrentAcc = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.gbCharacteristicX = New System.Windows.Forms.GroupBox()
        Me.lblXAvgVelo = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblXDistance = New System.Windows.Forms.Label()
        Me.lblXCurrentVeloState = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblXCurrentVelo = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lblXAvgAcc = New System.Windows.Forms.Label()
        Me.lblXCurrentAccState = New System.Windows.Forms.Label()
        Me.lblXCurrentAcc = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.gbCharacteristicZ = New System.Windows.Forms.GroupBox()
        Me.lblZAvgVelo = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblZCurrentVeloState = New System.Windows.Forms.Label()
        Me.lblZDistance = New System.Windows.Forms.Label()
        Me.lblZAvgAcc = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblZCurrentVelo = New System.Windows.Forms.Label()
        Me.lblZCurrentAccState = New System.Windows.Forms.Label()
        Me.lblZCurrentAcc = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListViewAcceleration = New Wireless_Running_Monitor.ListViewAntiFlickering()
        Me.colT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colZ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colX = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colY = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListViewVelocity = New Wireless_Running_Monitor.ListViewAntiFlickering()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ListViewDistance = New Wireless_Running_Monitor.ListViewAntiFlickering()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.cmdSaveGraph = New System.Windows.Forms.Button()
        Me.ChartDistanceVelocity = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.pbOpen = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDataSpeed = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrConnectionController = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDataReader = New System.Windows.Forms.Timer(Me.components)
        Me.tbCC = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.picTrafficLight = New System.Windows.Forms.PictureBox()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.pnlConnectionCriteria = New System.Windows.Forms.Panel()
        Me.rbNoCriteria = New System.Windows.Forms.RadioButton()
        Me.txtDistanceLimit = New System.Windows.Forms.TextBox()
        Me.rbDistanceCriteria = New System.Windows.Forms.RadioButton()
        Me.rbConnectionCriteriaTimeout = New System.Windows.Forms.RadioButton()
        Me.txtConnectionTimeout = New System.Windows.Forms.TextBox()
        Me.cmdAutoConnect = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdListen = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.pnlCalibration = New System.Windows.Forms.Panel()
        Me.txtThetaCalibration = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdDeleteCalibration = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblXMax = New System.Windows.Forms.Label()
        Me.lblYMax = New System.Windows.Forms.Label()
        Me.lblZMax = New System.Windows.Forms.Label()
        Me.lblXMin = New System.Windows.Forms.Label()
        Me.lblZMin = New System.Windows.Forms.Label()
        Me.cmdCalibrate = New System.Windows.Forms.Button()
        Me.lblYMin = New System.Windows.Forms.Label()
        Me.pbCalibrating = New System.Windows.Forms.ProgressBar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukaFileMonitoringToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpanFileMonitoringToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrAutoConnect = New System.Windows.Forms.Timer(Me.components)
        Me.tmrVisualizeData = New System.Windows.Forms.Timer(Me.components)
        Me.tmrStopwatch = New System.Windows.Forms.Timer(Me.components)
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukaHasilMonitoringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpanHasilMonitoringToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukaFileMonitoringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpanFileMonitoringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukaFileMonitoringToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpanFileMonitoringToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.strip = New System.Windows.Forms.StatusStrip()
        Me.pbOpenFile = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblPacketSpeed = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCharacteristicY.SuspendLayout()
        Me.gbCharacteristicX.SuspendLayout()
        Me.gbCharacteristicZ.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.ChartDistanceVelocity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbCC.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.picTrafficLight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConnectionCriteria.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.pnlCalibration.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.strip.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrDataSpeed
        '
        Me.tmrDataSpeed.Interval = 1000
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkZEnable)
        Me.GroupBox2.Controls.Add(Me.chkYEnable)
        Me.GroupBox2.Controls.Add(Me.lblTimerStarter)
        Me.GroupBox2.Controls.Add(Me.chkXEnable)
        Me.GroupBox2.Controls.Add(Me.cmdClear)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(544, 440)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Akuisisi"
        '
        'chkZEnable
        '
        Me.chkZEnable.AutoSize = True
        Me.chkZEnable.Checked = True
        Me.chkZEnable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkZEnable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkZEnable.ForeColor = System.Drawing.Color.Blue
        Me.chkZEnable.Location = New System.Drawing.Point(10, 20)
        Me.chkZEnable.Name = "chkZEnable"
        Me.chkZEnable.Size = New System.Drawing.Size(124, 17)
        Me.chkZEnable.TabIndex = 40
        Me.chkZEnable.Text = "Sumbu-Z (Utama)"
        Me.chkZEnable.UseVisualStyleBackColor = True
        '
        'chkYEnable
        '
        Me.chkYEnable.AutoSize = True
        Me.chkYEnable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkYEnable.ForeColor = System.Drawing.Color.Red
        Me.chkYEnable.Location = New System.Drawing.Point(251, 20)
        Me.chkYEnable.Name = "chkYEnable"
        Me.chkYEnable.Size = New System.Drawing.Size(76, 17)
        Me.chkYEnable.TabIndex = 39
        Me.chkYEnable.Text = "Sumbu-Y"
        Me.chkYEnable.UseVisualStyleBackColor = True
        '
        'lblTimerStarter
        '
        Me.lblTimerStarter.AutoSize = True
        Me.lblTimerStarter.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimerStarter.ForeColor = System.Drawing.Color.Red
        Me.lblTimerStarter.Location = New System.Drawing.Point(450, 19)
        Me.lblTimerStarter.Name = "lblTimerStarter"
        Me.lblTimerStarter.Size = New System.Drawing.Size(0, 29)
        Me.lblTimerStarter.TabIndex = 72
        Me.lblTimerStarter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkXEnable
        '
        Me.chkXEnable.AutoSize = True
        Me.chkXEnable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkXEnable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkXEnable.Location = New System.Drawing.Point(153, 20)
        Me.chkXEnable.Name = "chkXEnable"
        Me.chkXEnable.Size = New System.Drawing.Size(76, 17)
        Me.chkXEnable.TabIndex = 38
        Me.chkXEnable.Text = "Sumbu-X"
        Me.chkXEnable.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Image = Global.Wireless_Running_Monitor.My.Resources.Resources._1355335698_gtk_clear
        Me.cmdClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClear.Location = New System.Drawing.Point(415, 405)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(119, 29)
        Me.cmdClear.TabIndex = 31
        Me.cmdClear.Text = "Bersihkan"
        Me.cmdClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.ImageList = Me.ImageList
        Me.TabControl1.Location = New System.Drawing.Point(10, 42)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(524, 361)
        Me.TabControl1.TabIndex = 30
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.PictureBox1)
        Me.TabPage7.Controls.Add(Me.Label51)
        Me.TabPage7.Controls.Add(Me.Label50)
        Me.TabPage7.Controls.Add(Me.Label49)
        Me.TabPage7.Controls.Add(Me.Label48)
        Me.TabPage7.Controls.Add(Me.lblH)
        Me.TabPage7.Controls.Add(Me.lblDS)
        Me.TabPage7.Controls.Add(Me.lblS)
        Me.TabPage7.Controls.Add(Me.lblM)
        Me.TabPage7.Controls.Add(Me.gbCharacteristicY)
        Me.TabPage7.Controls.Add(Me.gbCharacteristicX)
        Me.TabPage7.Controls.Add(Me.gbCharacteristicZ)
        Me.TabPage7.ImageIndex = 2
        Me.TabPage7.Location = New System.Drawing.Point(4, 23)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(516, 334)
        Me.TabPage7.TabIndex = 4
        Me.TabPage7.Text = "Karakteristik"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Wireless_Running_Monitor.My.Resources.Resources._1355332350_chronometer
        Me.PictureBox1.Location = New System.Drawing.Point(261, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(449, 45)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(43, 11)
        Me.Label51.TabIndex = 11
        Me.Label51.Text = "Desidetik"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(399, 44)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(27, 11)
        Me.Label50.TabIndex = 10
        Me.Label50.Text = "Detik"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(348, 44)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(28, 11)
        Me.Label49.TabIndex = 9
        Me.Label49.Text = "Menit"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(297, 45)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(22, 11)
        Me.Label48.TabIndex = 8
        Me.Label48.Text = "Jam"
        '
        'lblH
        '
        Me.lblH.BackColor = System.Drawing.Color.LightGray
        Me.lblH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblH.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblH.Location = New System.Drawing.Point(299, 13)
        Me.lblH.Name = "lblH"
        Me.lblH.Size = New System.Drawing.Size(46, 31)
        Me.lblH.TabIndex = 6
        Me.lblH.Text = "0"
        Me.lblH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDS
        '
        Me.lblDS.BackColor = System.Drawing.Color.LightGray
        Me.lblDS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDS.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDS.Location = New System.Drawing.Point(451, 13)
        Me.lblDS.Name = "lblDS"
        Me.lblDS.Size = New System.Drawing.Size(46, 31)
        Me.lblDS.TabIndex = 5
        Me.lblDS.Text = "0"
        Me.lblDS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblS
        '
        Me.lblS.BackColor = System.Drawing.Color.LightGray
        Me.lblS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblS.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS.Location = New System.Drawing.Point(401, 13)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(46, 31)
        Me.lblS.TabIndex = 4
        Me.lblS.Text = "0"
        Me.lblS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblM
        '
        Me.lblM.BackColor = System.Drawing.Color.LightGray
        Me.lblM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblM.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblM.Location = New System.Drawing.Point(350, 13)
        Me.lblM.Name = "lblM"
        Me.lblM.Size = New System.Drawing.Size(46, 31)
        Me.lblM.TabIndex = 3
        Me.lblM.Text = "0"
        Me.lblM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbCharacteristicY
        '
        Me.gbCharacteristicY.Controls.Add(Me.lblYDistance)
        Me.gbCharacteristicY.Controls.Add(Me.lblYAvgVelo)
        Me.gbCharacteristicY.Controls.Add(Me.Label35)
        Me.gbCharacteristicY.Controls.Add(Me.lblYCurrentVeloState)
        Me.gbCharacteristicY.Controls.Add(Me.Label39)
        Me.gbCharacteristicY.Controls.Add(Me.lblYCurrentVelo)
        Me.gbCharacteristicY.Controls.Add(Me.Label45)
        Me.gbCharacteristicY.Controls.Add(Me.Label41)
        Me.gbCharacteristicY.Controls.Add(Me.lblYAvgAcc)
        Me.gbCharacteristicY.Controls.Add(Me.lblYCurrentAccState)
        Me.gbCharacteristicY.Controls.Add(Me.lblYCurrentAcc)
        Me.gbCharacteristicY.Controls.Add(Me.Label47)
        Me.gbCharacteristicY.ForeColor = System.Drawing.Color.Red
        Me.gbCharacteristicY.Location = New System.Drawing.Point(349, 69)
        Me.gbCharacteristicY.Name = "gbCharacteristicY"
        Me.gbCharacteristicY.Size = New System.Drawing.Size(150, 254)
        Me.gbCharacteristicY.TabIndex = 2
        Me.gbCharacteristicY.TabStop = False
        Me.gbCharacteristicY.Text = "Sumbu-Y"
        '
        'lblYDistance
        '
        Me.lblYDistance.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYDistance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYDistance.ForeColor = System.Drawing.Color.Red
        Me.lblYDistance.Location = New System.Drawing.Point(15, 138)
        Me.lblYDistance.Name = "lblYDistance"
        Me.lblYDistance.Size = New System.Drawing.Size(119, 17)
        Me.lblYDistance.TabIndex = 25
        Me.lblYDistance.Text = "0"
        '
        'lblYAvgVelo
        '
        Me.lblYAvgVelo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYAvgVelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYAvgVelo.ForeColor = System.Drawing.Color.Red
        Me.lblYAvgVelo.Location = New System.Drawing.Point(35, 222)
        Me.lblYAvgVelo.Name = "lblYAvgVelo"
        Me.lblYAvgVelo.Size = New System.Drawing.Size(99, 17)
        Me.lblYAvgVelo.TabIndex = 22
        Me.lblYAvgVelo.Text = "0"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(28, 118)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(93, 13)
        Me.Label35.TabIndex = 24
        Me.Label35.Text = "Jarak Tempuh (m)"
        '
        'lblYCurrentVeloState
        '
        Me.lblYCurrentVeloState.AutoSize = True
        Me.lblYCurrentVeloState.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYCurrentVeloState.ForeColor = System.Drawing.Color.Black
        Me.lblYCurrentVeloState.Location = New System.Drawing.Point(12, 97)
        Me.lblYCurrentVeloState.Name = "lblYCurrentVeloState"
        Me.lblYCurrentVeloState.Size = New System.Drawing.Size(17, 13)
        Me.lblYCurrentVeloState.TabIndex = 20
        Me.lblYCurrentVeloState.Tag = "state"
        Me.lblYCurrentVeloState.Text = "—"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(7, 202)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(136, 13)
        Me.Label39.TabIndex = 21
        Me.Label39.Text = "Kecepatan Rata-rata (m/s)"
        '
        'lblYCurrentVelo
        '
        Me.lblYCurrentVelo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYCurrentVelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYCurrentVelo.ForeColor = System.Drawing.Color.Red
        Me.lblYCurrentVelo.Location = New System.Drawing.Point(35, 96)
        Me.lblYCurrentVelo.Name = "lblYCurrentVelo"
        Me.lblYCurrentVelo.Size = New System.Drawing.Size(99, 17)
        Me.lblYCurrentVelo.TabIndex = 19
        Me.lblYCurrentVelo.Text = "0"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(12, 75)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(126, 13)
        Me.Label45.TabIndex = 15
        Me.Label45.Text = "Kecepatan Saat Ini (m/s)"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(4, 160)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(145, 13)
        Me.Label41.TabIndex = 18
        Me.Label41.Text = "Percepatan Rata-rata (m/s²)"
        '
        'lblYAvgAcc
        '
        Me.lblYAvgAcc.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYAvgAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYAvgAcc.ForeColor = System.Drawing.Color.Red
        Me.lblYAvgAcc.Location = New System.Drawing.Point(35, 180)
        Me.lblYAvgAcc.Name = "lblYAvgAcc"
        Me.lblYAvgAcc.Size = New System.Drawing.Size(99, 17)
        Me.lblYAvgAcc.TabIndex = 16
        Me.lblYAvgAcc.Text = "0"
        '
        'lblYCurrentAccState
        '
        Me.lblYCurrentAccState.AutoSize = True
        Me.lblYCurrentAccState.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYCurrentAccState.ForeColor = System.Drawing.Color.Black
        Me.lblYCurrentAccState.Location = New System.Drawing.Point(12, 48)
        Me.lblYCurrentAccState.Name = "lblYCurrentAccState"
        Me.lblYCurrentAccState.Size = New System.Drawing.Size(17, 13)
        Me.lblYCurrentAccState.TabIndex = 12
        Me.lblYCurrentAccState.Tag = "state"
        Me.lblYCurrentAccState.Text = "—"
        '
        'lblYCurrentAcc
        '
        Me.lblYCurrentAcc.BackColor = System.Drawing.Color.Gainsboro
        Me.lblYCurrentAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYCurrentAcc.ForeColor = System.Drawing.Color.Red
        Me.lblYCurrentAcc.Location = New System.Drawing.Point(35, 47)
        Me.lblYCurrentAcc.Name = "lblYCurrentAcc"
        Me.lblYCurrentAcc.Size = New System.Drawing.Size(99, 17)
        Me.lblYCurrentAcc.TabIndex = 13
        Me.lblYCurrentAcc.Text = "0"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(8, 25)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(135, 13)
        Me.Label47.TabIndex = 14
        Me.Label47.Text = "Percepatan Saat Ini (m/s²)"
        '
        'gbCharacteristicX
        '
        Me.gbCharacteristicX.Controls.Add(Me.lblXAvgVelo)
        Me.gbCharacteristicX.Controls.Add(Me.Label25)
        Me.gbCharacteristicX.Controls.Add(Me.lblXDistance)
        Me.gbCharacteristicX.Controls.Add(Me.lblXCurrentVeloState)
        Me.gbCharacteristicX.Controls.Add(Me.Label21)
        Me.gbCharacteristicX.Controls.Add(Me.Label27)
        Me.gbCharacteristicX.Controls.Add(Me.lblXCurrentVelo)
        Me.gbCharacteristicX.Controls.Add(Me.Label31)
        Me.gbCharacteristicX.Controls.Add(Me.lblXAvgAcc)
        Me.gbCharacteristicX.Controls.Add(Me.lblXCurrentAccState)
        Me.gbCharacteristicX.Controls.Add(Me.lblXCurrentAcc)
        Me.gbCharacteristicX.Controls.Add(Me.Label33)
        Me.gbCharacteristicX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbCharacteristicX.Location = New System.Drawing.Point(181, 70)
        Me.gbCharacteristicX.Name = "gbCharacteristicX"
        Me.gbCharacteristicX.Size = New System.Drawing.Size(150, 254)
        Me.gbCharacteristicX.TabIndex = 1
        Me.gbCharacteristicX.TabStop = False
        Me.gbCharacteristicX.Text = "Sumbu-X"
        '
        'lblXAvgVelo
        '
        Me.lblXAvgVelo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblXAvgVelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblXAvgVelo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblXAvgVelo.Location = New System.Drawing.Point(33, 221)
        Me.lblXAvgVelo.Name = "lblXAvgVelo"
        Me.lblXAvgVelo.Size = New System.Drawing.Size(99, 17)
        Me.lblXAvgVelo.TabIndex = 22
        Me.lblXAvgVelo.Text = "0"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(5, 201)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(136, 13)
        Me.Label25.TabIndex = 21
        Me.Label25.Text = "Kecepatan Rata-rata (m/s)"
        '
        'lblXDistance
        '
        Me.lblXDistance.BackColor = System.Drawing.Color.Gainsboro
        Me.lblXDistance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblXDistance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblXDistance.Location = New System.Drawing.Point(9, 137)
        Me.lblXDistance.Name = "lblXDistance"
        Me.lblXDistance.Size = New System.Drawing.Size(123, 17)
        Me.lblXDistance.TabIndex = 25
        Me.lblXDistance.Text = "0"
        '
        'lblXCurrentVeloState
        '
        Me.lblXCurrentVeloState.AutoSize = True
        Me.lblXCurrentVeloState.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXCurrentVeloState.ForeColor = System.Drawing.Color.Black
        Me.lblXCurrentVeloState.Location = New System.Drawing.Point(10, 95)
        Me.lblXCurrentVeloState.Name = "lblXCurrentVeloState"
        Me.lblXCurrentVeloState.Size = New System.Drawing.Size(17, 13)
        Me.lblXCurrentVeloState.TabIndex = 20
        Me.lblXCurrentVeloState.Tag = "state"
        Me.lblXCurrentVeloState.Text = "—"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(26, 117)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(93, 13)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "Jarak Tempuh (m)"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(2, 159)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(145, 13)
        Me.Label27.TabIndex = 18
        Me.Label27.Text = "Percepatan Rata-rata (m/s²)"
        '
        'lblXCurrentVelo
        '
        Me.lblXCurrentVelo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblXCurrentVelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblXCurrentVelo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblXCurrentVelo.Location = New System.Drawing.Point(33, 94)
        Me.lblXCurrentVelo.Name = "lblXCurrentVelo"
        Me.lblXCurrentVelo.Size = New System.Drawing.Size(99, 17)
        Me.lblXCurrentVelo.TabIndex = 19
        Me.lblXCurrentVelo.Text = "0"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(10, 73)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(126, 13)
        Me.Label31.TabIndex = 15
        Me.Label31.Text = "Kecepatan Saat Ini (m/s)"
        '
        'lblXAvgAcc
        '
        Me.lblXAvgAcc.BackColor = System.Drawing.Color.Gainsboro
        Me.lblXAvgAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblXAvgAcc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblXAvgAcc.Location = New System.Drawing.Point(33, 179)
        Me.lblXAvgAcc.Name = "lblXAvgAcc"
        Me.lblXAvgAcc.Size = New System.Drawing.Size(99, 17)
        Me.lblXAvgAcc.TabIndex = 16
        Me.lblXAvgAcc.Text = "0"
        '
        'lblXCurrentAccState
        '
        Me.lblXCurrentAccState.AutoSize = True
        Me.lblXCurrentAccState.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXCurrentAccState.ForeColor = System.Drawing.Color.Black
        Me.lblXCurrentAccState.Location = New System.Drawing.Point(10, 47)
        Me.lblXCurrentAccState.Name = "lblXCurrentAccState"
        Me.lblXCurrentAccState.Size = New System.Drawing.Size(17, 13)
        Me.lblXCurrentAccState.TabIndex = 12
        Me.lblXCurrentAccState.Tag = "state"
        Me.lblXCurrentAccState.Text = "—"
        '
        'lblXCurrentAcc
        '
        Me.lblXCurrentAcc.BackColor = System.Drawing.Color.Gainsboro
        Me.lblXCurrentAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblXCurrentAcc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblXCurrentAcc.Location = New System.Drawing.Point(33, 46)
        Me.lblXCurrentAcc.Name = "lblXCurrentAcc"
        Me.lblXCurrentAcc.Size = New System.Drawing.Size(99, 17)
        Me.lblXCurrentAcc.TabIndex = 13
        Me.lblXCurrentAcc.Text = "0"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(6, 24)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(135, 13)
        Me.Label33.TabIndex = 14
        Me.Label33.Text = "Percepatan Saat Ini (m/s²)"
        '
        'gbCharacteristicZ
        '
        Me.gbCharacteristicZ.BackColor = System.Drawing.Color.Transparent
        Me.gbCharacteristicZ.Controls.Add(Me.lblZAvgVelo)
        Me.gbCharacteristicZ.Controls.Add(Me.Label14)
        Me.gbCharacteristicZ.Controls.Add(Me.Label16)
        Me.gbCharacteristicZ.Controls.Add(Me.lblZCurrentVeloState)
        Me.gbCharacteristicZ.Controls.Add(Me.lblZDistance)
        Me.gbCharacteristicZ.Controls.Add(Me.lblZAvgAcc)
        Me.gbCharacteristicZ.Controls.Add(Me.Label17)
        Me.gbCharacteristicZ.Controls.Add(Me.lblZCurrentVelo)
        Me.gbCharacteristicZ.Controls.Add(Me.lblZCurrentAccState)
        Me.gbCharacteristicZ.Controls.Add(Me.lblZCurrentAcc)
        Me.gbCharacteristicZ.Controls.Add(Me.Label8)
        Me.gbCharacteristicZ.Controls.Add(Me.Label1)
        Me.gbCharacteristicZ.ForeColor = System.Drawing.Color.Blue
        Me.gbCharacteristicZ.Location = New System.Drawing.Point(14, 69)
        Me.gbCharacteristicZ.Name = "gbCharacteristicZ"
        Me.gbCharacteristicZ.Size = New System.Drawing.Size(150, 254)
        Me.gbCharacteristicZ.TabIndex = 0
        Me.gbCharacteristicZ.TabStop = False
        Me.gbCharacteristicZ.Text = "Sumbu-Z (Utama)"
        '
        'lblZAvgVelo
        '
        Me.lblZAvgVelo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblZAvgVelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblZAvgVelo.ForeColor = System.Drawing.Color.Blue
        Me.lblZAvgVelo.Location = New System.Drawing.Point(35, 222)
        Me.lblZAvgVelo.Name = "lblZAvgVelo"
        Me.lblZAvgVelo.Size = New System.Drawing.Size(99, 17)
        Me.lblZAvgVelo.TabIndex = 8
        Me.lblZAvgVelo.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(7, 202)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Kecepatan Rata-rata (m/s)"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(4, 160)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(145, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Percepatan Rata-rata (m/s²)"
        '
        'lblZCurrentVeloState
        '
        Me.lblZCurrentVeloState.AutoSize = True
        Me.lblZCurrentVeloState.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZCurrentVeloState.ForeColor = System.Drawing.Color.Black
        Me.lblZCurrentVeloState.Location = New System.Drawing.Point(13, 95)
        Me.lblZCurrentVeloState.Name = "lblZCurrentVeloState"
        Me.lblZCurrentVeloState.Size = New System.Drawing.Size(17, 13)
        Me.lblZCurrentVeloState.TabIndex = 6
        Me.lblZCurrentVeloState.Tag = "state"
        Me.lblZCurrentVeloState.Text = "—"
        '
        'lblZDistance
        '
        Me.lblZDistance.BackColor = System.Drawing.Color.Gainsboro
        Me.lblZDistance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblZDistance.ForeColor = System.Drawing.Color.Blue
        Me.lblZDistance.Location = New System.Drawing.Point(11, 138)
        Me.lblZDistance.Name = "lblZDistance"
        Me.lblZDistance.Size = New System.Drawing.Size(123, 17)
        Me.lblZDistance.TabIndex = 11
        Me.lblZDistance.Text = "0"
        '
        'lblZAvgAcc
        '
        Me.lblZAvgAcc.BackColor = System.Drawing.Color.Gainsboro
        Me.lblZAvgAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblZAvgAcc.ForeColor = System.Drawing.Color.Blue
        Me.lblZAvgAcc.Location = New System.Drawing.Point(35, 180)
        Me.lblZAvgAcc.Name = "lblZAvgAcc"
        Me.lblZAvgAcc.Size = New System.Drawing.Size(99, 17)
        Me.lblZAvgAcc.TabIndex = 2
        Me.lblZAvgAcc.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(28, 118)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 13)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Jarak Tempuh (m)"
        '
        'lblZCurrentVelo
        '
        Me.lblZCurrentVelo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblZCurrentVelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblZCurrentVelo.ForeColor = System.Drawing.Color.Blue
        Me.lblZCurrentVelo.Location = New System.Drawing.Point(36, 94)
        Me.lblZCurrentVelo.Name = "lblZCurrentVelo"
        Me.lblZCurrentVelo.Size = New System.Drawing.Size(99, 17)
        Me.lblZCurrentVelo.TabIndex = 5
        Me.lblZCurrentVelo.Text = "0"
        '
        'lblZCurrentAccState
        '
        Me.lblZCurrentAccState.AutoSize = True
        Me.lblZCurrentAccState.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZCurrentAccState.ForeColor = System.Drawing.Color.Black
        Me.lblZCurrentAccState.Location = New System.Drawing.Point(12, 48)
        Me.lblZCurrentAccState.Name = "lblZCurrentAccState"
        Me.lblZCurrentAccState.Size = New System.Drawing.Size(17, 13)
        Me.lblZCurrentAccState.TabIndex = 0
        Me.lblZCurrentAccState.Tag = "state"
        Me.lblZCurrentAccState.Text = "—"
        '
        'lblZCurrentAcc
        '
        Me.lblZCurrentAcc.BackColor = System.Drawing.Color.Gainsboro
        Me.lblZCurrentAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblZCurrentAcc.ForeColor = System.Drawing.Color.Blue
        Me.lblZCurrentAcc.Location = New System.Drawing.Point(35, 47)
        Me.lblZCurrentAcc.Name = "lblZCurrentAcc"
        Me.lblZCurrentAcc.Size = New System.Drawing.Size(99, 17)
        Me.lblZCurrentAcc.TabIndex = 0
        Me.lblZCurrentAcc.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(13, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Kecepatan Saat Ini (m/s)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Percepatan Saat Ini (m/s²)"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ListViewAcceleration)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(516, 334)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Percepatan"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ListViewAcceleration
        '
        Me.ListViewAcceleration.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colT, Me.colZ, Me.colX, Me.colY})
        Me.ListViewAcceleration.FullRowSelect = True
        Me.ListViewAcceleration.GridLines = True
        Me.ListViewAcceleration.Location = New System.Drawing.Point(6, 6)
        Me.ListViewAcceleration.MultiSelect = False
        Me.ListViewAcceleration.Name = "ListViewAcceleration"
        Me.ListViewAcceleration.Size = New System.Drawing.Size(508, 323)
        Me.ListViewAcceleration.TabIndex = 11
        Me.ListViewAcceleration.UseCompatibleStateImageBehavior = False
        Me.ListViewAcceleration.View = System.Windows.Forms.View.Details
        '
        'colT
        '
        Me.colT.Text = "Waktu (detik)"
        Me.colT.Width = 107
        '
        'colZ
        '
        Me.colZ.Text = "Sumbu-Z (Utama) (m/s²)"
        Me.colZ.Width = 131
        '
        'colX
        '
        Me.colX.Text = "Sumbu-X (m/s²)"
        Me.colX.Width = 131
        '
        'colY
        '
        Me.colY.Text = "Sumbu-Y (m/s²)"
        Me.colY.Width = 131
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListViewVelocity)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(516, 334)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Kecepatan"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListViewVelocity
        '
        Me.ListViewVelocity.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListViewVelocity.FullRowSelect = True
        Me.ListViewVelocity.GridLines = True
        Me.ListViewVelocity.Location = New System.Drawing.Point(6, 6)
        Me.ListViewVelocity.MultiSelect = False
        Me.ListViewVelocity.Name = "ListViewVelocity"
        Me.ListViewVelocity.Size = New System.Drawing.Size(508, 323)
        Me.ListViewVelocity.TabIndex = 12
        Me.ListViewVelocity.UseCompatibleStateImageBehavior = False
        Me.ListViewVelocity.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Waktu (detik)"
        Me.ColumnHeader1.Width = 107
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Sumbu-Z (Utama) (m/s)"
        Me.ColumnHeader2.Width = 131
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Sumbu-X (m/s)"
        Me.ColumnHeader3.Width = 131
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Sumbu-Y (m/s)"
        Me.ColumnHeader4.Width = 131
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ListViewDistance)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(516, 334)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Jarak"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ListViewDistance
        '
        Me.ListViewDistance.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListViewDistance.FullRowSelect = True
        Me.ListViewDistance.GridLines = True
        Me.ListViewDistance.Location = New System.Drawing.Point(6, 6)
        Me.ListViewDistance.MultiSelect = False
        Me.ListViewDistance.Name = "ListViewDistance"
        Me.ListViewDistance.Size = New System.Drawing.Size(508, 323)
        Me.ListViewDistance.TabIndex = 12
        Me.ListViewDistance.UseCompatibleStateImageBehavior = False
        Me.ListViewDistance.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Waktu (detik)"
        Me.ColumnHeader5.Width = 107
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Sumbu-Z (Utama) (m)"
        Me.ColumnHeader6.Width = 131
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Sumbu-X (m)"
        Me.ColumnHeader7.Width = 131
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Sumbu-Y (m)"
        Me.ColumnHeader8.Width = 131
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.cmdSaveGraph)
        Me.TabPage6.Controls.Add(Me.ChartDistanceVelocity)
        Me.TabPage6.ImageIndex = 4
        Me.TabPage6.Location = New System.Drawing.Point(4, 23)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(516, 334)
        Me.TabPage6.TabIndex = 3
        Me.TabPage6.Text = "Grafik Jarak-Kecepatan (Sumbu-Z)"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'cmdSaveGraph
        '
        Me.cmdSaveGraph.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveGraph.Location = New System.Drawing.Point(424, 312)
        Me.cmdSaveGraph.Name = "cmdSaveGraph"
        Me.cmdSaveGraph.Size = New System.Drawing.Size(91, 21)
        Me.cmdSaveGraph.TabIndex = 42
        Me.cmdSaveGraph.Text = "Simpan Grafik"
        Me.cmdSaveGraph.UseVisualStyleBackColor = True
        '
        'ChartDistanceVelocity
        '
        Me.ChartDistanceVelocity.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Graphics
        ChartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle
        ChartArea1.AxisX.InterlacedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer))
        ChartArea1.AxisX.Interval = 10.0R
        ChartArea1.AxisX.IsInterlaced = True
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelAutoFitMaxFontSize = 7
        ChartArea1.AxisX.LabelStyle.Angle = -90
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.Maximum = 250.0R
        ChartArea1.AxisX.Minimum = 0.0R
        ChartArea1.AxisX.ScaleBreakStyle.Enabled = True
        ChartArea1.AxisX.Title = "Jarak (m)"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        ChartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle
        ChartArea1.AxisY.InterlacedColor = System.Drawing.Color.White
        ChartArea1.AxisY.Interval = 2.0R
        ChartArea1.AxisY.Maximum = 50.0R
        ChartArea1.AxisY.Minimum = 0.0R
        ChartArea1.AxisY.Title = "Kecepatan (m/s)"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.Blue
        ChartArea1.CursorX.AutoScroll = False
        ChartArea1.Name = "ChartArea1"
        ChartArea1.ShadowColor = System.Drawing.Color.White
        Me.ChartDistanceVelocity.ChartAreas.Add(ChartArea1)
        Me.ChartDistanceVelocity.Cursor = System.Windows.Forms.Cursors.Cross
        Legend1.Name = "Legend1"
        Me.ChartDistanceVelocity.Legends.Add(Legend1)
        Me.ChartDistanceVelocity.Location = New System.Drawing.Point(-18, -22)
        Me.ChartDistanceVelocity.Name = "ChartDistanceVelocity"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.Color.Blue
        Series1.IsVisibleInLegend = False
        Series1.Legend = "Legend1"
        Series1.Name = "Kecepatan"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Me.ChartDistanceVelocity.Series.Add(Series1)
        Me.ChartDistanceVelocity.Size = New System.Drawing.Size(550, 365)
        Me.ChartDistanceVelocity.TabIndex = 41
        Me.ChartDistanceVelocity.Text = "Grafik Jarak-Kecepatan"
        Me.ChartDistanceVelocity.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal
        Title1.Name = "Grafik Jarak-Kecepatan"
        Me.ChartDistanceVelocity.Titles.Add(Title1)
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "1355330323_Gnome-System-Log-Out-32.png")
        Me.ImageList.Images.SetKeyName(1, "1355330473_RerunCalibration.png")
        Me.ImageList.Images.SetKeyName(2, "1355330287_user_run.png")
        Me.ImageList.Images.SetKeyName(3, "1355336283_graph.png")
        Me.ImageList.Images.SetKeyName(4, "1355340352_Stat.png")
        Me.ImageList.Images.SetKeyName(5, "1355340805_RunCalibration.png")
        Me.ImageList.Images.SetKeyName(6, "1355340986_satellite-connection.png")
        '
        'pbOpen
        '
        Me.pbOpen.Name = "pbOpen"
        Me.pbOpen.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(72, 17)
        Me.ToolStripStatusLabel1.Text = "Data Speed: "
        '
        'lblDataSpeed
        '
        Me.lblDataSpeed.Name = "lblDataSpeed"
        Me.lblDataSpeed.Size = New System.Drawing.Size(13, 17)
        Me.lblDataSpeed.Text = "0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(98, 17)
        Me.ToolStripStatusLabel2.Text = "packet(s)/second"
        '
        'tmrConnectionController
        '
        Me.tmrConnectionController.Interval = 1
        '
        'tmrDataReader
        '
        Me.tmrDataReader.Interval = 1
        '
        'tbCC
        '
        Me.tbCC.Controls.Add(Me.TabPage4)
        Me.tbCC.Controls.Add(Me.TabPage5)
        Me.tbCC.ImageList = Me.ImageList
        Me.tbCC.Location = New System.Drawing.Point(12, 35)
        Me.tbCC.Name = "tbCC"
        Me.tbCC.SelectedIndex = 0
        Me.tbCC.Size = New System.Drawing.Size(545, 115)
        Me.tbCC.TabIndex = 42
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.picTrafficLight)
        Me.TabPage4.Controls.Add(Me.lblConnection)
        Me.TabPage4.Controls.Add(Me.pnlConnectionCriteria)
        Me.TabPage4.Controls.Add(Me.cmdAutoConnect)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.cmdListen)
        Me.TabPage4.Controls.Add(Me.ComboBox1)
        Me.TabPage4.ImageIndex = 6
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(537, 88)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Koneksi & Mulai"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'picTrafficLight
        '
        Me.picTrafficLight.Image = Global.Wireless_Running_Monitor.My.Resources.Resources._0
        Me.picTrafficLight.Location = New System.Drawing.Point(399, 4)
        Me.picTrafficLight.Name = "picTrafficLight"
        Me.picTrafficLight.Size = New System.Drawing.Size(132, 49)
        Me.picTrafficLight.TabIndex = 74
        Me.picTrafficLight.TabStop = False
        Me.picTrafficLight.Tag = "0"
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.ForeColor = System.Drawing.Color.Red
        Me.lblConnection.Location = New System.Drawing.Point(8, 68)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(71, 13)
        Me.lblConnection.TabIndex = 65
        Me.lblConnection.Text = "Disconnected"
        '
        'pnlConnectionCriteria
        '
        Me.pnlConnectionCriteria.Controls.Add(Me.rbNoCriteria)
        Me.pnlConnectionCriteria.Controls.Add(Me.txtDistanceLimit)
        Me.pnlConnectionCriteria.Controls.Add(Me.rbDistanceCriteria)
        Me.pnlConnectionCriteria.Controls.Add(Me.rbConnectionCriteriaTimeout)
        Me.pnlConnectionCriteria.Controls.Add(Me.txtConnectionTimeout)
        Me.pnlConnectionCriteria.Location = New System.Drawing.Point(141, 4)
        Me.pnlConnectionCriteria.Name = "pnlConnectionCriteria"
        Me.pnlConnectionCriteria.Size = New System.Drawing.Size(253, 79)
        Me.pnlConnectionCriteria.TabIndex = 73
        '
        'rbNoCriteria
        '
        Me.rbNoCriteria.AutoSize = True
        Me.rbNoCriteria.Checked = True
        Me.rbNoCriteria.Location = New System.Drawing.Point(10, 2)
        Me.rbNoCriteria.Name = "rbNoCriteria"
        Me.rbNoCriteria.Size = New System.Drawing.Size(92, 17)
        Me.rbNoCriteria.TabIndex = 76
        Me.rbNoCriteria.TabStop = True
        Me.rbNoCriteria.Text = "Tanpa Kriteria"
        Me.rbNoCriteria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbNoCriteria.UseVisualStyleBackColor = True
        '
        'txtDistanceLimit
        '
        Me.txtDistanceLimit.Enabled = False
        Me.txtDistanceLimit.Location = New System.Drawing.Point(155, 56)
        Me.txtDistanceLimit.Name = "txtDistanceLimit"
        Me.txtDistanceLimit.Size = New System.Drawing.Size(88, 21)
        Me.txtDistanceLimit.TabIndex = 75
        '
        'rbDistanceCriteria
        '
        Me.rbDistanceCriteria.AutoSize = True
        Me.rbDistanceCriteria.Location = New System.Drawing.Point(10, 56)
        Me.rbDistanceCriteria.Name = "rbDistanceCriteria"
        Me.rbDistanceCriteria.Size = New System.Drawing.Size(137, 17)
        Me.rbDistanceCriteria.TabIndex = 74
        Me.rbDistanceCriteria.Text = "Berdasarkan Jarak (m):"
        Me.rbDistanceCriteria.UseVisualStyleBackColor = True
        '
        'rbConnectionCriteriaTimeout
        '
        Me.rbConnectionCriteriaTimeout.AutoSize = True
        Me.rbConnectionCriteriaTimeout.Location = New System.Drawing.Point(10, 29)
        Me.rbConnectionCriteriaTimeout.Name = "rbConnectionCriteriaTimeout"
        Me.rbConnectionCriteriaTimeout.Size = New System.Drawing.Size(139, 17)
        Me.rbConnectionCriteriaTimeout.TabIndex = 73
        Me.rbConnectionCriteriaTimeout.Text = "Berdasarkan Waktu (s):"
        Me.rbConnectionCriteriaTimeout.UseVisualStyleBackColor = True
        '
        'txtConnectionTimeout
        '
        Me.txtConnectionTimeout.Enabled = False
        Me.txtConnectionTimeout.Location = New System.Drawing.Point(155, 27)
        Me.txtConnectionTimeout.Name = "txtConnectionTimeout"
        Me.txtConnectionTimeout.Size = New System.Drawing.Size(88, 21)
        Me.txtConnectionTimeout.TabIndex = 72
        '
        'cmdAutoConnect
        '
        Me.cmdAutoConnect.Image = Global.Wireless_Running_Monitor.My.Resources.Resources._1355332809_disconnect
        Me.cmdAutoConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAutoConnect.Location = New System.Drawing.Point(9, 29)
        Me.cmdAutoConnect.Name = "cmdAutoConnect"
        Me.cmdAutoConnect.Size = New System.Drawing.Size(126, 30)
        Me.cmdAutoConnect.TabIndex = 60
        Me.cmdAutoConnect.Text = "Koneksikan Kembali"
        Me.cmdAutoConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAutoConnect.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Port"
        '
        'cmdListen
        '
        Me.cmdListen.Enabled = False
        Me.cmdListen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdListen.ImageKey = "1355330323_Gnome-System-Log-Out-32.png"
        Me.cmdListen.Location = New System.Drawing.Point(400, 54)
        Me.cmdListen.Name = "cmdListen"
        Me.cmdListen.Size = New System.Drawing.Size(131, 30)
        Me.cmdListen.TabIndex = 64
        Me.cmdListen.Text = "Mulai"
        Me.cmdListen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdListen.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(40, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(95, 21)
        Me.ComboBox1.TabIndex = 62
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.pnlCalibration)
        Me.TabPage5.ImageIndex = 5
        Me.TabPage5.Location = New System.Drawing.Point(4, 23)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(537, 88)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Kalibrasi"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'pnlCalibration
        '
        Me.pnlCalibration.Controls.Add(Me.txtThetaCalibration)
        Me.pnlCalibration.Controls.Add(Me.Label5)
        Me.pnlCalibration.Controls.Add(Me.Label2)
        Me.pnlCalibration.Controls.Add(Me.cmdDeleteCalibration)
        Me.pnlCalibration.Controls.Add(Me.Label3)
        Me.pnlCalibration.Controls.Add(Me.Label4)
        Me.pnlCalibration.Controls.Add(Me.lblXMax)
        Me.pnlCalibration.Controls.Add(Me.lblYMax)
        Me.pnlCalibration.Controls.Add(Me.lblZMax)
        Me.pnlCalibration.Controls.Add(Me.lblXMin)
        Me.pnlCalibration.Controls.Add(Me.lblZMin)
        Me.pnlCalibration.Controls.Add(Me.cmdCalibrate)
        Me.pnlCalibration.Controls.Add(Me.lblYMin)
        Me.pnlCalibration.Controls.Add(Me.pbCalibrating)
        Me.pnlCalibration.Enabled = False
        Me.pnlCalibration.Location = New System.Drawing.Point(6, 6)
        Me.pnlCalibration.Name = "pnlCalibration"
        Me.pnlCalibration.Size = New System.Drawing.Size(401, 80)
        Me.pnlCalibration.TabIndex = 43
        '
        'txtThetaCalibration
        '
        Me.txtThetaCalibration.Enabled = False
        Me.txtThetaCalibration.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThetaCalibration.Location = New System.Drawing.Point(64, 61)
        Me.txtThetaCalibration.Name = "txtThetaCalibration"
        Me.txtThetaCalibration.Size = New System.Drawing.Size(74, 18)
        Me.txtThetaCalibration.TabIndex = 56
        Me.txtThetaCalibration.Text = "0,0153846153846154"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Θ "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "X Offset: "
        '
        'cmdDeleteCalibration
        '
        Me.cmdDeleteCalibration.Image = Global.Wireless_Running_Monitor.My.Resources.Resources._1355340724_RejectCalibration
        Me.cmdDeleteCalibration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDeleteCalibration.Location = New System.Drawing.Point(273, 5)
        Me.cmdDeleteCalibration.Name = "cmdDeleteCalibration"
        Me.cmdDeleteCalibration.Size = New System.Drawing.Size(125, 44)
        Me.cmdDeleteCalibration.TabIndex = 54
        Me.cmdDeleteCalibration.Text = "Hapus Kalibrasi"
        Me.cmdDeleteCalibration.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDeleteCalibration.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Y Offset: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Z Offset: "
        '
        'lblXMax
        '
        Me.lblXMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblXMax.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblXMax.Location = New System.Drawing.Point(108, 3)
        Me.lblXMax.Name = "lblXMax"
        Me.lblXMax.Size = New System.Drawing.Size(30, 15)
        Me.lblXMax.TabIndex = 48
        Me.lblXMax.Text = "0"
        Me.lblXMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYMax
        '
        Me.lblYMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYMax.ForeColor = System.Drawing.Color.Blue
        Me.lblYMax.Location = New System.Drawing.Point(108, 23)
        Me.lblYMax.Name = "lblYMax"
        Me.lblYMax.Size = New System.Drawing.Size(30, 15)
        Me.lblYMax.TabIndex = 49
        Me.lblYMax.Text = "0"
        Me.lblYMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblZMax
        '
        Me.lblZMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblZMax.ForeColor = System.Drawing.Color.Red
        Me.lblZMax.Location = New System.Drawing.Point(108, 42)
        Me.lblZMax.Name = "lblZMax"
        Me.lblZMax.Size = New System.Drawing.Size(30, 15)
        Me.lblZMax.TabIndex = 50
        Me.lblZMax.Text = "0"
        Me.lblZMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblXMin
        '
        Me.lblXMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblXMin.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblXMin.Location = New System.Drawing.Point(64, 3)
        Me.lblXMin.Name = "lblXMin"
        Me.lblXMin.Size = New System.Drawing.Size(30, 15)
        Me.lblXMin.TabIndex = 51
        Me.lblXMin.Text = "0"
        '
        'lblZMin
        '
        Me.lblZMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblZMin.ForeColor = System.Drawing.Color.Red
        Me.lblZMin.Location = New System.Drawing.Point(64, 42)
        Me.lblZMin.Name = "lblZMin"
        Me.lblZMin.Size = New System.Drawing.Size(30, 15)
        Me.lblZMin.TabIndex = 53
        Me.lblZMin.Text = "0"
        '
        'cmdCalibrate
        '
        Me.cmdCalibrate.Image = Global.Wireless_Running_Monitor.My.Resources.Resources._1355330473_RerunCalibration
        Me.cmdCalibrate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCalibrate.Location = New System.Drawing.Point(147, 5)
        Me.cmdCalibrate.Name = "cmdCalibrate"
        Me.cmdCalibrate.Size = New System.Drawing.Size(120, 44)
        Me.cmdCalibrate.TabIndex = 44
        Me.cmdCalibrate.Text = "Kalibrasi Ulang"
        Me.cmdCalibrate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCalibrate.UseVisualStyleBackColor = True
        '
        'lblYMin
        '
        Me.lblYMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYMin.ForeColor = System.Drawing.Color.Blue
        Me.lblYMin.Location = New System.Drawing.Point(64, 23)
        Me.lblYMin.Name = "lblYMin"
        Me.lblYMin.Size = New System.Drawing.Size(30, 15)
        Me.lblYMin.TabIndex = 52
        Me.lblYMin.Text = "0"
        '
        'pbCalibrating
        '
        Me.pbCalibrating.Location = New System.Drawing.Point(147, 61)
        Me.pbCalibrating.Name = "pbCalibrating"
        Me.pbCalibrating.Size = New System.Drawing.Size(251, 14)
        Me.pbCalibrating.TabIndex = 43
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem3})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(571, 24)
        Me.MenuStrip1.TabIndex = 43
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem3
        '
        Me.MenuToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BukaFileMonitoringToolStripMenuItem2, Me.SimpanFileMonitoringToolStripMenuItem2, Me.TentangToolStripMenuItem3})
        Me.MenuToolStripMenuItem3.Image = Global.Wireless_Running_Monitor.My.Resources.Resources._1355330233_flag_indonesia
        Me.MenuToolStripMenuItem3.Name = "MenuToolStripMenuItem3"
        Me.MenuToolStripMenuItem3.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MenuToolStripMenuItem3.Size = New System.Drawing.Size(66, 20)
        Me.MenuToolStripMenuItem3.Text = "&Menu"
        '
        'BukaFileMonitoringToolStripMenuItem2
        '
        Me.BukaFileMonitoringToolStripMenuItem2.Image = Global.Wireless_Running_Monitor.My.Resources.Resources._1355329731_folderopen1
        Me.BukaFileMonitoringToolStripMenuItem2.Name = "BukaFileMonitoringToolStripMenuItem2"
        Me.BukaFileMonitoringToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BukaFileMonitoringToolStripMenuItem2.Size = New System.Drawing.Size(238, 22)
        Me.BukaFileMonitoringToolStripMenuItem2.Text = "&Buka File Monitoring"
        '
        'SimpanFileMonitoringToolStripMenuItem2
        '
        Me.SimpanFileMonitoringToolStripMenuItem2.Image = Global.Wireless_Running_Monitor.My.Resources.Resources._1355329674_disk
        Me.SimpanFileMonitoringToolStripMenuItem2.Name = "SimpanFileMonitoringToolStripMenuItem2"
        Me.SimpanFileMonitoringToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SimpanFileMonitoringToolStripMenuItem2.Size = New System.Drawing.Size(238, 22)
        Me.SimpanFileMonitoringToolStripMenuItem2.Text = "&Simpan File Monitoring"
        '
        'TentangToolStripMenuItem3
        '
        Me.TentangToolStripMenuItem3.Image = Global.Wireless_Running_Monitor.My.Resources.Resources._1355329890_About
        Me.TentangToolStripMenuItem3.Name = "TentangToolStripMenuItem3"
        Me.TentangToolStripMenuItem3.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TentangToolStripMenuItem3.Size = New System.Drawing.Size(238, 22)
        Me.TentangToolStripMenuItem3.Text = "&Tentang"
        '
        'tmrAutoConnect
        '
        Me.tmrAutoConnect.Interval = 1
        '
        'tmrVisualizeData
        '
        Me.tmrVisualizeData.Interval = 1
        '
        'tmrStopwatch
        '
        Me.tmrStopwatch.Enabled = True
        Me.tmrStopwatch.Interval = 1
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BukaHasilMonitoringToolStripMenuItem, Me.SimpanHasilMonitoringToolStripMenuItem1, Me.TentangToolStripMenuItem})
        Me.MenuToolStripMenuItem.Image = Global.Wireless_Running_Monitor.My.Resources.Resources._1355330233_flag_indonesia
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'BukaHasilMonitoringToolStripMenuItem
        '
        Me.BukaHasilMonitoringToolStripMenuItem.Image = Global.Wireless_Running_Monitor.My.Resources.Resources._1355329731_folderopen1
        Me.BukaHasilMonitoringToolStripMenuItem.Name = "BukaHasilMonitoringToolStripMenuItem"
        Me.BukaHasilMonitoringToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.BukaHasilMonitoringToolStripMenuItem.Text = "Buka File Monitoring"
        '
        'SimpanHasilMonitoringToolStripMenuItem1
        '
        Me.SimpanHasilMonitoringToolStripMenuItem1.Image = Global.Wireless_Running_Monitor.My.Resources.Resources._1355329674_disk
        Me.SimpanHasilMonitoringToolStripMenuItem1.Name = "SimpanHasilMonitoringToolStripMenuItem1"
        Me.SimpanHasilMonitoringToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
        Me.SimpanHasilMonitoringToolStripMenuItem1.Text = "Simpan Hasil Monitoring"
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.Image = Global.Wireless_Running_Monitor.My.Resources.Resources._1355329890_About
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.TentangToolStripMenuItem.Text = "Tentang"
        '
        'MenuToolStripMenuItem1
        '
        Me.MenuToolStripMenuItem1.Name = "MenuToolStripMenuItem1"
        Me.MenuToolStripMenuItem1.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem1.Text = "Menu"
        '
        'BukaFileMonitoringToolStripMenuItem
        '
        Me.BukaFileMonitoringToolStripMenuItem.Name = "BukaFileMonitoringToolStripMenuItem"
        Me.BukaFileMonitoringToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.BukaFileMonitoringToolStripMenuItem.Text = "Buka File Monitoring"
        '
        'SimpanFileMonitoringToolStripMenuItem
        '
        Me.SimpanFileMonitoringToolStripMenuItem.Name = "SimpanFileMonitoringToolStripMenuItem"
        Me.SimpanFileMonitoringToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.SimpanFileMonitoringToolStripMenuItem.Text = "Simpan File Monitoring"
        '
        'TentangToolStripMenuItem1
        '
        Me.TentangToolStripMenuItem1.Name = "TentangToolStripMenuItem1"
        Me.TentangToolStripMenuItem1.Size = New System.Drawing.Size(198, 22)
        Me.TentangToolStripMenuItem1.Text = "Tentang"
        '
        'MenuToolStripMenuItem2
        '
        Me.MenuToolStripMenuItem2.Image = Global.Wireless_Running_Monitor.My.Resources.Resources._1355330233_flag_indonesia
        Me.MenuToolStripMenuItem2.Name = "MenuToolStripMenuItem2"
        Me.MenuToolStripMenuItem2.Size = New System.Drawing.Size(66, 20)
        Me.MenuToolStripMenuItem2.Text = "Menu"
        '
        'BukaFileMonitoringToolStripMenuItem1
        '
        Me.BukaFileMonitoringToolStripMenuItem1.Image = Global.Wireless_Running_Monitor.My.Resources.Resources._1355329731_folderopen1
        Me.BukaFileMonitoringToolStripMenuItem1.Name = "BukaFileMonitoringToolStripMenuItem1"
        Me.BukaFileMonitoringToolStripMenuItem1.Size = New System.Drawing.Size(198, 22)
        Me.BukaFileMonitoringToolStripMenuItem1.Text = "Buka File Monitoring"
        '
        'SimpanFileMonitoringToolStripMenuItem1
        '
        Me.SimpanFileMonitoringToolStripMenuItem1.Image = Global.Wireless_Running_Monitor.My.Resources.Resources._1355329674_disk
        Me.SimpanFileMonitoringToolStripMenuItem1.Name = "SimpanFileMonitoringToolStripMenuItem1"
        Me.SimpanFileMonitoringToolStripMenuItem1.Size = New System.Drawing.Size(198, 22)
        Me.SimpanFileMonitoringToolStripMenuItem1.Text = "Simpan File Monitoring"
        '
        'TentangToolStripMenuItem2
        '
        Me.TentangToolStripMenuItem2.Image = Global.Wireless_Running_Monitor.My.Resources.Resources._1355329890_About
        Me.TentangToolStripMenuItem2.Name = "TentangToolStripMenuItem2"
        Me.TentangToolStripMenuItem2.Size = New System.Drawing.Size(198, 22)
        Me.TentangToolStripMenuItem2.Text = "Tentang"
        '
        'strip
        '
        Me.strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pbOpenFile, Me.ToolStripStatusLabel3, Me.lblPacketSpeed, Me.ToolStripStatusLabel4})
        Me.strip.Location = New System.Drawing.Point(0, 560)
        Me.strip.Name = "strip"
        Me.strip.Size = New System.Drawing.Size(571, 22)
        Me.strip.TabIndex = 44
        Me.strip.Text = "StatusStrip1"
        '
        'pbOpenFile
        '
        Me.pbOpenFile.Name = "pbOpenFile"
        Me.pbOpenFile.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(92, 17)
        Me.ToolStripStatusLabel3.Text = "Kecepatan Data:"
        '
        'lblPacketSpeed
        '
        Me.lblPacketSpeed.Name = "lblPacketSpeed"
        Me.lblPacketSpeed.Size = New System.Drawing.Size(13, 17)
        Me.lblPacketSpeed.Text = "0"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(67, 17)
        Me.ToolStripStatusLabel4.Text = "paket/detik"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 582)
        Me.Controls.Add(Me.strip)
        Me.Controls.Add(Me.tbCC)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wireless Running Monitor"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCharacteristicY.ResumeLayout(False)
        Me.gbCharacteristicY.PerformLayout()
        Me.gbCharacteristicX.ResumeLayout(False)
        Me.gbCharacteristicX.PerformLayout()
        Me.gbCharacteristicZ.ResumeLayout(False)
        Me.gbCharacteristicZ.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        CType(Me.ChartDistanceVelocity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbCC.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.picTrafficLight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConnectionCriteria.ResumeLayout(False)
        Me.pnlConnectionCriteria.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.pnlCalibration.ResumeLayout(False)
        Me.pnlCalibration.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.strip.ResumeLayout(False)
        Me.strip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrDataSpeed As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkZEnable As System.Windows.Forms.CheckBox
    Friend WithEvents chkYEnable As System.Windows.Forms.CheckBox
    Friend WithEvents chkXEnable As System.Windows.Forms.CheckBox
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ListViewAcceleration As Wireless_Running_Monitor.ListViewAntiFlickering
    Friend WithEvents colT As System.Windows.Forms.ColumnHeader
    Friend WithEvents colX As System.Windows.Forms.ColumnHeader
    Friend WithEvents colY As System.Windows.Forms.ColumnHeader
    Friend WithEvents colZ As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents pbOpen As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDataSpeed As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmrConnectionController As System.Windows.Forms.Timer
    Friend WithEvents tmrDataReader As System.Windows.Forms.Timer
    Friend WithEvents tbCC As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents cmdAutoConnect As System.Windows.Forms.Button
    Friend WithEvents lblTimerStarter As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdListen As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents ChartDistanceVelocity As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BukaHasilMonitoringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpanHasilMonitoringToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrAutoConnect As System.Windows.Forms.Timer
    Friend WithEvents pnlConnectionCriteria As System.Windows.Forms.Panel
    Friend WithEvents rbNoCriteria As System.Windows.Forms.RadioButton
    Friend WithEvents txtDistanceLimit As System.Windows.Forms.TextBox
    Friend WithEvents rbDistanceCriteria As System.Windows.Forms.RadioButton
    Friend WithEvents rbConnectionCriteriaTimeout As System.Windows.Forms.RadioButton
    Friend WithEvents txtConnectionTimeout As System.Windows.Forms.TextBox
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents gbCharacteristicY As System.Windows.Forms.GroupBox
    Friend WithEvents gbCharacteristicX As System.Windows.Forms.GroupBox
    Friend WithEvents gbCharacteristicZ As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblZCurrentAcc As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblZCurrentAccState As System.Windows.Forms.Label
    Friend WithEvents lblH As System.Windows.Forms.Label
    Friend WithEvents lblDS As System.Windows.Forms.Label
    Friend WithEvents lblS As System.Windows.Forms.Label
    Friend WithEvents lblM As System.Windows.Forms.Label
    Friend WithEvents lblZDistance As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblZAvgVelo As System.Windows.Forms.Label
    Friend WithEvents lblZCurrentVeloState As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblZCurrentVelo As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblZAvgAcc As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents lblYDistance As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents lblYAvgVelo As System.Windows.Forms.Label
    Friend WithEvents lblYCurrentVeloState As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents lblYCurrentVelo As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents lblYAvgAcc As System.Windows.Forms.Label
    Friend WithEvents lblYCurrentAccState As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents lblYCurrentAcc As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents lblXDistance As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblXAvgVelo As System.Windows.Forms.Label
    Friend WithEvents lblXCurrentVeloState As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblXCurrentVelo As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lblXAvgAcc As System.Windows.Forms.Label
    Friend WithEvents lblXCurrentAccState As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents lblXCurrentAcc As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents tmrVisualizeData As System.Windows.Forms.Timer
    Friend WithEvents ListViewVelocity As Wireless_Running_Monitor.ListViewAntiFlickering
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListViewDistance As Wireless_Running_Monitor.ListViewAntiFlickering
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlCalibration As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdDeleteCalibration As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblXMax As System.Windows.Forms.Label
    Friend WithEvents lblYMax As System.Windows.Forms.Label
    Friend WithEvents lblZMax As System.Windows.Forms.Label
    Friend WithEvents lblXMin As System.Windows.Forms.Label
    Friend WithEvents lblZMin As System.Windows.Forms.Label
    Friend WithEvents cmdCalibrate As System.Windows.Forms.Button
    Friend WithEvents lblYMin As System.Windows.Forms.Label
    Friend WithEvents pbCalibrating As System.Windows.Forms.ProgressBar
    Friend WithEvents tmrStopwatch As System.Windows.Forms.Timer
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblConnection As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtThetaCalibration As System.Windows.Forms.TextBox
    Friend WithEvents picTrafficLight As System.Windows.Forms.PictureBox
    Friend WithEvents MenuToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BukaFileMonitoringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpanFileMonitoringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BukaFileMonitoringToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpanFileMonitoringToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BukaFileMonitoringToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpanFileMonitoringToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents strip As System.Windows.Forms.StatusStrip
    Friend WithEvents pbOpenFile As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblPacketSpeed As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmdSaveGraph As System.Windows.Forms.Button

End Class
