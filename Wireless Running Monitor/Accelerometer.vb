' Wireless Running Monitor v2.0
' Class Accelerometer Data Proccessor 
' Universitas Negeri Semarang
' Last Update: 18:58 WIB 11 Desember 2012
' coded by: Nurkholish Ardi Firdaus

Imports System.Text.RegularExpressions


Public Class Accelerometer
    ' variabel kalibrasi
    Private _CalibratingDataX As List(Of Integer) = New List(Of Integer)
    Private _CalibratingDataY As List(Of Integer) = New List(Of Integer)
    Private _CalibratingDataZ As List(Of Integer) = New List(Of Integer)
    Private Const _CALIBRATING_DATA_MAX As Integer = 100
    Private _XMax, _YMax, _ZMax, _XMin, _YMin, _ZMin As Integer
    Private _CalibratingProgress As Single

    ' variabel penghitung paket
    Private _PacketCount As Long
    Private _LastPacketCount As Long
    Private _DataSpeed As Integer


    ' variabel perhitungan
    Private _CurrentXCount, _CurrentYCount, _CurrentZCount As Integer
    Private _THETA As Double
    Private Const _G_PER_COUNT As Double = 0.016
    Private Const _G As Double = 9.80665
    Private _XVelocity, _YVelocity, _ZVelocity As Double
    Private _XAcc, _YAcc, _ZAcc As Double
    Private _XDistance, _YDistance, _ZDistance As Double
    Private _Last_XVelocity, _Last_YVelocity, _Last_ZVelocity As Double
    Private _Last_XAcc, _Last_YAcc, _Last_ZAcc As Double
    Private _Last_XDistance, _Last_YDistance, _Last_ZDistance As Double

    ' flag status pembacaan
    Private _IsBeginProccessing As Boolean = False   ' jika sedang memproses
    Private _IsCalibrating As Boolean = False ' jika sedang mengkalibrasi
    Private _IsCalibrated As Boolean = False
    Private _XReading, _YReading, _ZReading As Boolean

    ' regular expression untuk menextract data
    Private TransmissionRegex As Regex

    Public Enum Axis
        X
        Y
        Z
    End Enum

    Public Sub New(ByVal ReadingX As Boolean, ByVal ReadingY As Boolean, _
                   ByVal ReadingZ As Boolean, ByVal Theta As Double)
        _CalibratingDataX = New List(Of Integer)
        _CalibratingDataY = New List(Of Integer)
        _CalibratingDataZ = New List(Of Integer)
        _THETA = Theta
        TransmissionRegex = New Regex("X(.*)Y(.*)Z(.*)\n")
        _XReading = ReadingX
        _YReading = ReadingY
        _ZReading = ReadingZ
        ClearCalculationVariables()
    End Sub

    Public ReadOnly Property ProcessedDataCount
        Get
            Return _PacketCount
        End Get
    End Property

    Public ReadOnly Property GetCalibratingProgress
        Get
            Return _CalibratingProgress
        End Get
    End Property

    Public Sub SupplyNewOfflineTransmission(ByVal XAcc As Double, ByVal YAcc As Double, ByVal ZAcc As Double)
        _XAcc = XAcc
        _YAcc = YAcc
        _ZAcc = ZAcc
        ProcessVelocity()
        ProcessDistance()
    End Sub

    Public Sub SupplyNewTransmission(ByVal NewTransmission As String)
        Static buffer As String
        buffer &= NewTransmission
        Dim m As Match = TransmissionRegex.Match(buffer)

        If (m.Success) Then
            _CurrentXCount = Integer.Parse(m.Groups(m.Groups.Count - 3).Value.Trim)
            _CurrentYCount = Integer.Parse(m.Groups(m.Groups.Count - 2).Value.Trim)
            _CurrentZCount = Integer.Parse(m.Groups(m.Groups.Count - 1).Value.Trim)
            '_CurrentXCount = Integer.Parse(NewTransmission.Substring(0, 4).Trim)
            '_CurrentYCount = Integer.Parse(NewTransmission.Substring(4, 4).Trim)
            '_CurrentZCount = Integer.Parse(NewTransmission.Substring(8, 4).Trim)
            buffer = ""
            If (_IsBeginProccessing And _IsCalibrated) Then
                If (_CurrentXCount <= _XMax And _CurrentXCount >= _XMin) Then
                    _CurrentXCount = 0
                End If
                If (_CurrentYCount <= _YMax And _CurrentYCount >= _YMin) Then
                    _CurrentYCount = 0
                End If
                If (_CurrentZCount <= _ZMax And _CurrentZCount >= _ZMin) Then
                    _CurrentZCount = 0
                End If
            End If

            If (_IsCalibrating) Then
                If (_CalibratingProgress < 1) Then
                    _CalibratingDataX.Add(_CurrentXCount)
                    _CalibratingDataY.Add(_CurrentYCount)
                    _CalibratingDataZ.Add(_CurrentZCount)
                End If
                _CalibratingProgress = _CalibratingDataX.Count / _CALIBRATING_DATA_MAX
            ElseIf (_IsBeginProccessing) Then
                ProcessAcceleration()
                ProcessVelocity()
                ProcessDistance()
            End If
            _PacketCount += 1
        Else

        End If
    End Sub

    Public Sub ClearPacketCounter()
        _PacketCount = 0
    End Sub

    Public Function ReadLastAcceleration(ByVal AxisSelect As Axis) As Double
        Select Case AxisSelect
            Case Axis.X
                Return _XAcc
            Case Axis.Y
                Return _YAcc
            Case Axis.Z
                Return _ZAcc
        End Select
    End Function

    Public Function ReadCurrentVelocity(ByVal AxisSelect As Axis) As Double
        Select Case AxisSelect
            Case Axis.X
                Return _XVelocity
            Case Axis.Y
                Return _YVelocity
            Case Axis.Z
                Return _ZVelocity
        End Select
    End Function

    Public Function ReadComulativeDistance(ByVal AxisSelect As Axis) As Double
        Select Case AxisSelect
            Case Axis.X
                Return _XDistance
            Case Axis.Y
                Return _YDistance
            Case Axis.Z
                Return _ZDistance
        End Select
    End Function

    Public Sub SetTheta(ByVal Theta As Double)
        _THETA = Theta
    End Sub

    Public Sub DeleteCalibration()
        _XMin = 0
        _YMin = 0
        _ZMin = 0
        _XMax = 0
        _YMax = 0
        _ZMax = 0
        _IsCalibrated = False
    End Sub

    Public Sub SetReadingOnAxis(ByVal AxisSelect As Axis, ByVal IsReading As Boolean)
        Select Case AxisSelect
            Case Axis.X
                _XReading = IsReading
            Case Axis.Y
                _YReading = IsReading
            Case Axis.Z
                _YReading = IsReading
        End Select
    End Sub

    Public Function IsReadingOnAxis(ByVal AxisSelect As Axis) As Boolean
        Select Case AxisSelect
            Case Axis.X
                Return _XReading
            Case Axis.Y
                Return _YReading
            Case Axis.Z
                Return _ZReading
        End Select
    End Function

    Public Sub BeginCalibrating()
        _IsCalibrating = True
        _IsBeginProccessing = False
        _CalibratingProgress = 0
        ClearPacketCounter()
    End Sub

    Public Sub ClearCalibration()
        _XMax = 0
        _XMin = 0
        _YMax = 0
        _YMin = 0
        _ZMax = 0
        _ZMin = 0
    End Sub

    Private Sub ClearCalculationVariables()
        _CurrentXCount = 0
        _CurrentYCount = 0
        _CurrentZCount = 0
        _LastPacketCount = 0
        _XAcc = 0
        _YAcc = 0
        _ZAcc = 0
        _XDistance = 0
        _YDistance = 0
        _ZDistance = 0
        _XVelocity = 0
        _YVelocity = 0
        _ZVelocity = 0
        _Last_XAcc = 0
        _Last_XDistance = 0
        _Last_XVelocity = 0
        _Last_YAcc = 0
        _Last_YDistance = 0
        _Last_YVelocity = 0
        _Last_ZAcc = 0
        _Last_ZDistance = 0
        _Last_ZVelocity = 0
        _PacketCount = 0
    End Sub

    Public Sub EndCalibrating()
        _IsCalibrating = False
        _IsBeginProccessing = False
        ' mengurutkan data kalibrasi dari terkecil hingga terbesar
        _CalibratingDataX.Sort()
        _CalibratingDataY.Sort()
        _CalibratingDataZ.Sort()
        ' mendapatkan data kalibrasi terkecil
        _XMin = _CalibratingDataX.Item(0)
        _YMin = _CalibratingDataY.Item(0)
        _ZMin = _CalibratingDataZ.Item(0)
        ' mendapatkan data kalibrasi terbesar
        _XMax = _CalibratingDataX.Item(_CalibratingDataX.Count - 1)
        _YMax = _CalibratingDataY.Item(_CalibratingDataY.Count - 1)
        _ZMax = _CalibratingDataZ.Item(_CalibratingDataZ.Count - 1)
        _CalibratingDataX.Clear()
        _CalibratingDataY.Clear()
        _CalibratingDataZ.Clear()
        _IsCalibrated = True
    End Sub

    Public Function GetMinCalibrationValue(ByVal AxisSelect As Axis) As Integer
        Select Case AxisSelect
            Case Axis.X
                Return _XMin
            Case Axis.Y
                Return _YMin
            Case Axis.Z
                Return _ZMin
        End Select
    End Function

    Public Function GetMaxCalibrationValue(ByVal AxisSelect As Axis) As Integer
        Select Case AxisSelect
            Case Axis.X
                Return _XMax
            Case Axis.Y
                Return _YMax
            Case Axis.Z
                Return _ZMax
        End Select
    End Function

    Public Sub BeginProccessing()
        ClearCalculationVariables()
        _IsCalibrating = False
        _IsBeginProccessing = True
        ClearPacketCounter()
    End Sub

    Public Sub EndProccessing()
        _IsCalibrating = False
        _IsBeginProccessing = False
        _PacketCount = 0
    End Sub

    Private Sub ProcessAcceleration()
        If (_XReading) Then
            _XAcc = _CurrentXCount * _G_PER_COUNT * _G
        Else
            _XAcc = 0
        End If
        If (_YReading) Then
            _YAcc = _CurrentYCount * _G_PER_COUNT * _G
        Else
            _YAcc = 0
        End If
        If (_ZReading) Then
            _ZAcc = _CurrentZCount * _G_PER_COUNT * _G
        Else
            _ZAcc = 0
        End If
    End Sub

    Private Sub ProcessVelocity()
        _XVelocity = _Last_XVelocity + (((_XAcc + _Last_XAcc) * _THETA)) / 2
        _YVelocity = _Last_YVelocity + (((_YAcc + _Last_YAcc) * _THETA)) / 2
        _ZVelocity = _Last_ZVelocity + (((_ZAcc + _Last_ZAcc) * _THETA)) / 2
        _Last_XAcc = _XAcc
        _Last_YAcc = _YAcc
        _Last_ZAcc = _ZAcc
    End Sub

    Private Sub ProcessDistance()
        _XDistance = _Last_XDistance + (((_XVelocity + _Last_XVelocity) * _THETA)) / 2
        _YDistance = _Last_YDistance + (((_YVelocity + _Last_YVelocity) * _THETA)) / 2
        _ZDistance = _Last_ZDistance + (((_ZVelocity + _Last_ZVelocity) * _THETA)) / 2
        _Last_XVelocity = _XVelocity
        _Last_YVelocity = _YVelocity
        _Last_ZVelocity = _ZVelocity
        _Last_XDistance = _XDistance
        _Last_YDistance = _YDistance
        _Last_ZDistance = _ZDistance
    End Sub
End Class
