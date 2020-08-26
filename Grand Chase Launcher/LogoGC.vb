Public Class logo
    Private Sub logo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransparencyKey = Me.BackColor
        My.Forms.logo.Hide()
        My.Forms.banner.ShowDialog()
    End Sub
End Class
