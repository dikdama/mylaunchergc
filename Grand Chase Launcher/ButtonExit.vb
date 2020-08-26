Imports System.ComponentModel
Public Class ButtonExit
    Public Event Click(sender, e)
    Public Event MouseMove(sender, e)
    Public Event MouseLeave(sender, e)
    Public Event MouseDown(sender, e)
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        RaiseEvent Click(sender, e)
    End Sub
    Private Sub ButtonExit_MouseMove(sender As Object, e As EventArgs) Handles MyBase.MouseMove
        BackgroundImage = My.Resources.close2
        RaiseEvent MouseMove(sender, e)
    End Sub
    Private Sub ButtonExit_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        BackgroundImage = My.Resources.close1
        RaiseEvent MouseLeave(sender, e)
    End Sub
    Private Sub ButtonExit_MouseDown(sender As Object, e As EventArgs) Handles MyBase.MouseDown
        BackgroundImage = My.Resources.close3
        RaiseEvent MouseDown(sender, e)
    End Sub
End Class
