Imports System.ComponentModel
Public Class ButtonAtualizar
    Public Event Click(sender, e)
    Public Event MouseMove(sender, e)
    Public Event MouseClick(sender, e)
    Public Event MouseLeave(sender, e)

    Private Sub ButtonAtualizar_MouseMove(sender As Object, e As EventArgs) Handles MyBase.MouseMove
        BackgroundImage = My.Resources.ready2
        RaiseEvent MouseMove(sender, e)
    End Sub
    Private Sub ButtonAtualizar_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        BackgroundImage = My.Resources.stat72
        RaiseEvent MouseLeave(sender, e)
    End Sub
    Private Sub ButtonAtualizar_MouseClick(sender As Object, e As EventArgs) Handles MyBase.MouseClick
        BackgroundImage = My.Resources.ready
        RaiseEvent MouseClick(sender, e)
    End Sub
End Class
