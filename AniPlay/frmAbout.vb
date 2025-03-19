Imports System.Drawing.Drawing2D

Public Class frmAbout

    Public Property Username As String
    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblUser.Text = $"Welcome, {Username}"

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
        Me.Hide()
        frmCostumeDashboard.Show()
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        ' Set Cart button as active
        Me.Hide()
        frmCart.Show()
    End Sub

    Private Sub btnActiveList_Click(sender As Object, e As EventArgs) Handles btnActiveList.Click
        ' Set Active List button as active
        Me.Hide()
        frmActive.Show()
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