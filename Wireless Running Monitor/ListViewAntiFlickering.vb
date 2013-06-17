Public Class ListViewAntiFlickering
    Inherits ListView

    Public Sub New()
        Me.DoubleBuffered = True
    End Sub
End Class
