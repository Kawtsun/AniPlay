Public Class frmCostumeDashboard
    Public Property CurrentUser As User

    Private Sub frmCostumeDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        If CurrentUser IsNot Nothing Then
            lblUser.Text = $"Welcome, {CurrentUser.name}"
        Else
            lblUser.Text = "Welcome, User!"
        End If

        'Cosplay Pictures
        Dim imagePaths As String() = {
            "D:\Coding Projects\AniPlay\AniPlay\Resources\ai.jpg",
            "D:\Coding Projects\AniPlay\AniPlay\Resources\frieren.jpg",
            "D:\Coding Projects\AniPlay\AniPlay\Resources\homura.jpg",
            "D:\Coding Projects\AniPlay\AniPlay\Resources\junko.jpg",
            "D:\Coding Projects\AniPlay\AniPlay\Resources\kita.jpg",
            "D:\Coding Projects\AniPlay\AniPlay\Resources\madoka.jpg",
            "D:\Coding Projects\AniPlay\AniPlay\Resources\mcqueen.jpg",
            "D:\Coding Projects\AniPlay\AniPlay\Resources\mortis.jpg"
        } ' Add your image paths here

        ' Panel dimensions
        Dim panelWidth As Integer = 1054 '1074
        Dim panelHeight As Integer = 542

        ' Margins and dimensions
        Dim outerMargin As Integer = 30 ' Spacing from the panel edges
        Dim innerSpacing As Integer = 15 ' Space between the image and the button
        Dim horizontalPadding As Integer = 20 ' Space between items in the same row
        Dim verticalPadding As Integer = 30 ' Space between rows
        Dim imagesPerRow As Integer = 3 ' Number of images per row

        ' Calculate image dimensions
        Dim imageWidth As Integer = (panelWidth - (outerMargin * 2) - (horizontalPadding * (imagesPerRow - 1))) \ imagesPerRow
        Dim imageHeight As Integer = imageWidth * 3 \ 4 ' Maintain a 4:3 aspect ratio
        Dim buttonHeight As Integer = 60 ' Height adjusted for larger text

        For i As Integer = 0 To imagePaths.Length - 1
            ' Create a container panel for each item
            Dim itemPanel As New Panel()
            itemPanel.Width = imageWidth
            itemPanel.Height = imageHeight + buttonHeight + innerSpacing
            itemPanel.BackColor = Color.White ' Optional for a clean look

            ' Calculate position for the container panel
            Dim column As Integer = i Mod imagesPerRow
            Dim row As Integer = Math.Floor(i / imagesPerRow)
            itemPanel.Left = outerMargin + (column * (imageWidth + horizontalPadding))
            itemPanel.Top = outerMargin + (row * (itemPanel.Height + verticalPadding))

            ' Create and configure PictureBox
            Dim pictureBox As New PictureBox()
            pictureBox.Image = Image.FromFile(imagePaths(i))
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom
            pictureBox.Width = imageWidth
            pictureBox.Height = imageHeight
            pictureBox.Top = 0 ' Top of the panel
            pictureBox.Left = 0 ' Align to the left of the panel

            ' Add PictureBox to the container panel
            itemPanel.Controls.Add(pictureBox)

            ' Create and configure Button with custom styling
            Dim addButton As New Button()
            addButton.Text = "Add to Cart"
            addButton.Width = imageWidth
            addButton.Height = buttonHeight
            addButton.Left = 0 ' Align to the left of the panel
            addButton.Top = pictureBox.Height + innerSpacing ' Place below the image

            ' Apply styling to the button
            addButton.BackColor = Color.MediumSeaGreen ' Set button background color
            addButton.ForeColor = Color.White ' Set button text color
            addButton.FlatStyle = FlatStyle.Standard ' Set to Standard
            addButton.Font = New Font("Katibeh", 20, FontStyle.Regular) ' Set font size to 20, Regular style
            addButton.Cursor = Cursors.Hand ' Display a hand cursor on hover
            addButton.TextAlign = ContentAlignment.MiddleCenter ' Center the text

            ' Add click event handler for the button
            AddHandler addButton.Click, Sub(senderButton, eArgs)
                                            MessageBox.Show($"Added {imagePaths(i)} to the cart!")
                                        End Sub

            ' Add Button to the container panel
            itemPanel.Controls.Add(addButton)

            ' Add the container panel to the main Panel
            Panel2.Controls.Add(itemPanel)
        Next

    End Sub
End Class