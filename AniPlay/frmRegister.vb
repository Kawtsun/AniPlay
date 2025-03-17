Public Class frmRegister
    Public RegisteredUsers As New List(Of User)

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim newUser As New User() With {
        .name = txtName.Text,
        .email = txtEmail.Text,
        .username = txtUsername.Text,
        .password = txtPassword.Text
    }

        RegisteredUsers.Add(newUser)
        MessageBox.Show("User registered successfully!")

        Dim loginForm As frmLogin()
        frmLogin.RegisteredUsers = Me.RegisteredUsers
        frmLogin.Show()
        Me.Hide()
    End Sub

End Class
