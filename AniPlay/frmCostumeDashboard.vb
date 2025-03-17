Public Class frmCostumeDashboard
    Public Property CurrentUser As User

    Private Sub frmCostumeDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        If CurrentUser IsNot Nothing Then
            lblUser.Text = $"Welcome, {CurrentUser.name}"
        Else
            lblUser.Text = "Welcome, User!"
        End If
    End Sub
End Class