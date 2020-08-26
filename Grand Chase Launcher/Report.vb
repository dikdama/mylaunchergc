Imports System.ComponentModel
Public Class Report
    Public Event Click(sender, e)
    Public Event MouseMove(sender, e)
    Public Event MouseLeave(sender, e)
    Private Sub ButtonReport_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        RaiseEvent Click(sender, e)
    End Sub
    Private Sub ButtonReport_MouseMove(sender As Object, e As EventArgs) Handles MyBase.MouseMove
        BackgroundImage = My.Resources.report2
        RaiseEvent MouseMove(sender, e)
    End Sub
    Private Sub ButtonReport_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        BackgroundImage = My.Resources.report1
        RaiseEvent MouseLeave(sender, e)
    End Sub
End Class

