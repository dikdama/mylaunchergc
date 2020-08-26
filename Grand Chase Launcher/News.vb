Imports System.ComponentModel
Public Class News
    Public Event Click(sender, e)
    Public Event MouseMove(sender, e)
    Public Event MouseLeave(sender, e)
    Private Sub ButtonNews_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        RaiseEvent Click(sender, e)
    End Sub
    Private Sub ButtonNews_MouseMove(sender As Object, e As EventArgs) Handles MyBase.MouseMove
        BackgroundImage = My.Resources.news2
        RaiseEvent MouseMove(sender, e)
    End Sub
    Private Sub ButtonNews_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        BackgroundImage = My.Resources.news1
        RaiseEvent MouseLeave(sender, e)
    End Sub
End Class
