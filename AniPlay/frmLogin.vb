Public Class frmLogin
    Public RegisteredUsers As List(Of User)

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Dim user = RegisteredUsers.FirstOrDefault(Function(u) u.username = username AndAlso u.password = password)

        If user IsNot Nothing Then
            MessageBox.Show($"Welcome, {user.name}!")
        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub

    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked
        Me.Hide()
        frmRegister.Show()
    End Sub
End Class
