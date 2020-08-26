Imports System.ComponentModel
Public Class ButtonDoar
    Public Event Click(sender, e)
    Public Event MouseMove(sender, e)
    Public Event MouseLeave(sender, e)
    Public Event MouseDown(sender, e)
    Private Sub ButtonDoar_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        RaiseEvent Click(sender, e)
    End Sub
    Private Sub ButtonDoar_MouseMove(sender As Object, e As EventArgs) Handles MyBase.MouseMove
        BackgroundImage = My.Resources.button32
        RaiseEvent MouseMove(sender, e)
    End Sub
    Private Sub ButtonDoar_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        BackgroundImage = My.Resources.button31
        RaiseEvent MouseLeave(sender, e)
    End Sub
    Private Sub ButtonDoar_MouseDown(sender As Object, e As EventArgs) Handles MyBase.MouseDown
        BackgroundImage = My.Resources.button33
        RaiseEvent MouseDown(sender, e)
    End Sub
End Class