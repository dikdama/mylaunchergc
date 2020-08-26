Imports System.ComponentModel
Public Class ButtonInicio
    Public Event Click(sender, e)
    Public Event MouseMove(sender, e)
    Public Event MouseLeave(sender, e)
    Public Event MouseDown(sender, e)
    Private Sub ButtonInicio_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        RaiseEvent Click(sender, e)
    End Sub
    Private Sub ButtonInicio_MouseMove(sender As Object, e As EventArgs) Handles MyBase.MouseMove
        BackgroundImage = My.Resources.button12
        RaiseEvent MouseMove(sender, e)
    End Sub
    Private Sub ButtonInicio_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        BackgroundImage = My.Resources.button11
        RaiseEvent MouseLeave(sender, e)
    End Sub
    Private Sub ButtonInicio_MouseDown(sender As Object, e As EventArgs) Handles MyBase.MouseDown
        BackgroundImage = My.Resources.button131
        RaiseEvent MouseDown(sender, e)
    End Sub
End Class
