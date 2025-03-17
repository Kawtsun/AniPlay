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
        Dim panelWidth As Integer = 1054 ' Width of the main container panel
        Dim panelHeight As Integer = 542 ' Height of the main container panel

        ' Margins and dimensions
        Dim outerMargin As Integer = 20 ' Margin on both sides of the layout
        Dim verticalPadding As Integer = 25 ' Vertical spacing between rows
        Dim imagesPerRow As Integer = 3 ' Number of items per row

        ' Calculate item dimensions dynamically
        Dim totalHorizontalMargin As Integer = outerMargin * 2 ' Total left and right margins
        Dim availableWidth As Integer = panelWidth - totalHorizontalMargin ' Usable width for items
        Dim imageWidth As Integer = (availableWidth - (imagesPerRow - 1) * outerMargin) \ imagesPerRow ' Fit items with spacing
        Dim imageHeight As Integer = imageWidth * 3 \ 4 ' Maintain a 4:3 aspect ratio
        Dim buttonHeight As Integer = 60 ' Button height for larger text
        Dim innerSpacing As Integer = 15 ' Space between the image, label, and button

        ' Example prices array
        Dim prices As String() = {"₱1,500", "₱1,800", "₱1,200", "₱2,000", "₱1,700", "₱2,300", "₱1,600", "₱2,100"}

        For i As Integer = 0 To imagePaths.Length - 1
            ' Create a container panel for each item
            Dim itemPanel As New Panel()
            itemPanel.Width = imageWidth ' Set panel width
            itemPanel.Height = imageHeight + buttonHeight + innerSpacing + 50 ' Adjusted height to avoid cutting off the button
            itemPanel.BackColor = Color.White ' Background for clarity
            itemPanel.BorderStyle = BorderStyle.FixedSingle ' Add a border to visually distinguish panels

            ' Calculate position of the panel
            Dim column As Integer = i Mod imagesPerRow
            Dim row As Integer = Math.Floor(i / imagesPerRow)
            itemPanel.Left = outerMargin + (column * (imageWidth + outerMargin)) ' Calculate horizontal position
            itemPanel.Top = outerMargin + (row * (itemPanel.Height + verticalPadding)) ' Calculate vertical position

            ' Create and configure PictureBox with top padding
            Dim pictureBox As New PictureBox()
            pictureBox.Image = Image.FromFile(imagePaths(i))
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom
            pictureBox.Width = imageWidth
            pictureBox.Height = imageHeight
            pictureBox.Top = 10 ' Padding at the top for spacing
            pictureBox.Left = 0 ' Align to the left

            ' Add PictureBox to the panel
            itemPanel.Controls.Add(pictureBox)

            ' Create and configure the price Label
            Dim priceLabel As New Label()
            priceLabel.Text = prices(i) ' Assign price
            priceLabel.Font = New Font("Katibeh", 16, FontStyle.Regular) ' Font styling
            priceLabel.ForeColor = Color.Black ' Set text color
            priceLabel.Width = imageWidth
            priceLabel.TextAlign = ContentAlignment.MiddleCenter ' Center-align text
            priceLabel.Top = pictureBox.Top + pictureBox.Height + innerSpacing ' Position below image
            priceLabel.Left = 0 ' Align to the left

            ' Add Label to the panel
            itemPanel.Controls.Add(priceLabel)

            ' Create and configure Button with custom styling
            Dim addButton As New Button()
            addButton.Text = "Add to Cart"
            addButton.Width = imageWidth
            addButton.Height = buttonHeight
            addButton.Left = 0 ' Align to the left of the panel

            ' Adjust button position to place it near the bottom of the panel
            addButton.Top = itemPanel.Height - buttonHeight ' Align the button flush with the panel's bottom edge

            ' Apply styling to the button
            addButton.BackColor = Color.MediumSeaGreen ' Set button background color
            addButton.ForeColor = Color.White ' Set button text color
            addButton.FlatStyle = FlatStyle.Standard ' Use standard button style
            addButton.Font = New Font("Katibeh", 20, FontStyle.Regular) ' Font size 20, Regular style
            addButton.Cursor = Cursors.Hand ' Display hand cursor on hover
            addButton.TextAlign = ContentAlignment.MiddleCenter ' Center the text within the button

            ' Add the button click event handler
            AddHandler addButton.Click, Sub(senderButton, eArgs)
                                            MessageBox.Show($"Added {imagePaths(i)} to the cart!")
                                        End Sub

            ' Add the button to the panel
            itemPanel.Controls.Add(addButton)

            ' Add the item panel to the main panel
            Panel2.Controls.Add(itemPanel)
        Next
    End Sub
End Class