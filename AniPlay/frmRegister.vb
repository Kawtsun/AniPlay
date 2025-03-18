Public Class frmRegister
    Public RegisteredUsers As New List(Of User)

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Check if any fields are empty
        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
           String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
           String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtConfirmPassword.Text) Then

            MessageBox.Show("Please fill in all the fields.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if the password and confirm password match
        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Password do not match. Please try again.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Proceed to create a new user
        Dim newUser As New User() With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .username = txtUsername.Text,
            .password = txtPassword.Text
        }

        RegisteredUsers.Add(newUser)
        MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Pass the updated RegisteredUsers list to the login form
        frmLogin.RegisteredUsers = Me.RegisteredUsers
        frmLogin.Show()
        Me.Hide()
    End Sub


End Class
