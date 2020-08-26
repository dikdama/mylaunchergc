Imports System.ComponentModel
Public Class ButtonStaff
    Public Event Click(sender, e)
    Public Event MouseMove(sender, e)
    Public Event MouseLeave(sender, e)
    Public Event MouseDown(sender, e)
    Private Sub ButtonStaff_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        RaiseEvent Click(sender, e)
    End Sub
    Private Sub ButtonStaff_MouseMove(sender As Object, e As EventArgs) Handles MyBase.MouseMove
        BackgroundImage = My.Resources.button42
        RaiseEvent MouseMove(sender, e)
    End Sub
    Private Sub ButtonStaff_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        BackgroundImage = My.Resources.button41
        RaiseEvent MouseLeave(sender, e)
    End Sub
    Private Sub ButtonStaff_MouseDown(sender As Object, e As EventArgs) Handles MyBase.MouseDown
        BackgroundImage = My.Resources.button43
        RaiseEvent MouseDown(sender, e)
    End Sub
End Class