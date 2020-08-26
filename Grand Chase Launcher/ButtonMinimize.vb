Imports System.ComponentModel
Public Class ButtonMinimize
    Public Event Click(sender, e)
    Public Event MouseMove(sender, e)
    Public Event MouseLeave(sender, e)
    Public Event MouseDown(sender, e)
    Private Sub ButtonMinimize_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        RaiseEvent Click(sender, e)
    End Sub
    Private Sub ButtonMinimize_MouseMove(sender As Object, e As EventArgs) Handles MyBase.MouseMove
        BackgroundImage = My.Resources.minimize2
        RaiseEvent MouseMove(sender, e)
    End Sub
    Private Sub ButtonMinimize_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        BackgroundImage = My.Resources.minimize1
        RaiseEvent MouseLeave(sender, e)
    End Sub
    Private Sub ButtonMinimize_MouseDown(sender As Object, e As EventArgs) Handles MyBase.MouseDown
        BackgroundImage = My.Resources.minimize3
        RaiseEvent MouseDown(sender, e)
    End Sub

End Class
