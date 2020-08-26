Public Class banner
    Dim flag As Boolean = False
    Private Sub launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransparencyKey = Me.BackColor
        Dim unused = My.Application.SaveMySettingsOnExit()
    End Sub

    Private Sub logogc_Click(sender As Object, e As EventArgs) Handles logogc.Click
        'System.Diagnostics.Process.Start("")
    End Sub
    Private Sub ButtonExit1_Click(sender As Object, e As Object) Handles ButtonExit1.Click
        My.Forms.logo.Close()
        Close()
    End Sub
    Private Sub ButtonInicio1_Click(sender As Object, e As Object) Handles ButtonInicio1.Click
        'System.Diagnostics.Process.Start("")
    End Sub
    Private Sub ButtonMinimize1_Click(sender As Object, e As Object) Handles ButtonMinimize1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class