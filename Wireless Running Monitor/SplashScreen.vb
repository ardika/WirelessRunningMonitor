Public NotInheritable Class SplashScreen

    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If My.Application.Info.Title <> "" Then
            lblTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            lblTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        lblVer.Text = "Versi 2.2.1.0"

    End Sub
End Class
