﻿Imports System.Drawing.Drawing2D
Public Class frmLogin
    Public RegisteredUsers As List(Of User)

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Check if there are no registered users
        If RegisteredUsers Is Nothing OrElse RegisteredUsers.Count = 0 Then
            MessageBox.Show("No users have been registered yet. Please register first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Proceed with the login process
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Dim user = RegisteredUsers.FirstOrDefault(Function(u) u.username = username AndAlso u.password = password)

        If user IsNot Nothing Then
            MessageBox.Show($"Welcome, {user.username}!", "Login Success")
            Dim dashboard As New frmCostumeDashboard()
            dashboard.CurrentUser = user
            Me.Hide()
            dashboard.Show()
        Else
            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked
        Me.Hide()
        frmRegister.Show()
    End Sub

    Private Sub MakePictureBoxCircular(pictureBox As PictureBox)
        ' Create a circular GraphicsPath
        Dim circlePath As New GraphicsPath()
        circlePath.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height)

        ' Set the region of the PictureBox to the circular path
        pictureBox.Region = New Region(circlePath)
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        MakePictureBoxCircular(PictureBoxLogo)
    End Sub
End Class
