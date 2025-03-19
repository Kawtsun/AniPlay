Imports System.Drawing.Drawing2D

Public Class frmAbout
    Public Property CurrentUser As User
    Public Property Username As String
    Public Property Name As String
    Public Property Email As String

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not String.IsNullOrEmpty(Username) Then
            lblUser.Text = $"Welcome, {Username}"
        Else
            lblUser.Text = "Welcome, User!"
        End If

        MakePictureBoxCircular(PictureBoxLogo)
        MakePictureBoxCircular(PictureBoxProgrammer1)
        MakePictureBoxCircular(PictureBoxProgrammer2)
    End Sub

    Private Sub SetActiveNavButton(activeButton As Button)
        ' Reset the appearance of all navigation buttons
        For Each btn In New Button() {btnShop, btnCart, btnActiveList, btnAbout}
            btn.BackColor = Color.White ' Default color for inactive buttons
            btn.ForeColor = Color.Black ' Default text color
            btn.Font = New Font("Katibeh", 20, FontStyle.Regular) ' Reset font to "Katibeh" in regular style
        Next

        ' Highlight the active button
        activeButton.BackColor = Color.MediumSeaGreen ' Active button color
        activeButton.ForeColor = Color.White ' Active text color
        activeButton.Font = New Font("Katibeh", 20, FontStyle.Bold) ' Bold font for active button
    End Sub

    ' Event handlers for navigation buttons
    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click
        ' Set Shop button as active
        Dim Shop As New frmCostumeDashboard()
        Shop.Username = Username ' Pass the username
        Shop.Name = Name ' Pass the name
        Shop.Email = Email ' Pass the email
        Me.Hide()
        Shop.Show()
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        ' Set Cart button as active
        Dim Cart As New frmCart()
        Cart.Username = Username ' Pass the username
        Cart.Name = Name ' Pass the name
        Cart.Email = Email ' Pass the email
        Me.Hide()
        Cart.Show()
    End Sub

    Private Sub btnActiveList_Click(sender As Object, e As EventArgs) Handles btnActiveList.Click
        ' Set Active List button as active
        Dim active As New frmActive()
        active.Username = Username ' Pass the username
        active.Name = Name ' Pass the name
        active.Email = Email ' Pass the email
        Me.Hide()
        active.Show()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        ' Set About button as active
        'Me.Hide()
        'frmAbout.Show()
    End Sub

    Private Sub frmAbout_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        SetActiveNavButton(btnAbout)

    End Sub

    Private Sub MakePictureBoxCircular(pictureBox As PictureBox)
        ' Create a circular GraphicsPath
        Dim circlePath As New GraphicsPath()
        circlePath.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height)

        ' Set the region of the PictureBox to the circular path
        pictureBox.Region = New Region(circlePath)
    End Sub


End Class