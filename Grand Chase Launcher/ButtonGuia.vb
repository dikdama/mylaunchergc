Imports System.ComponentModel
Public Class ButtonGuia
    Public Event Click(sender, e)
    Public Event MouseMove(sender, e)
    Public Event MouseLeave(sender, e)
    Public Event MouseDown(sender, e)
    Private Sub ButtonGuia_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        RaiseEvent Click(sender, e)
    End Sub
    Private Sub ButtonGuia_MouseMove(sender As Object, e As EventArgs) Handles MyBase.MouseMove
        BackgroundImage = My.Resources.button22
        RaiseEvent MouseMove(sender, e)
    End Sub
    Private Sub ButtonGuia_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        BackgroundImage = My.Resources.button21
        RaiseEvent MouseLeave(sender, e)
    End Sub
    Private Sub ButtonGuia_MouseDown(sender As Object, e As EventArgs) Handles MyBase.MouseDown
        BackgroundImage = My.Resources.button23
        RaiseEvent MouseDown(sender, e)
    End Sub
End Class
