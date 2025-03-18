Public Class frmCart
    ' Method to set the active button for navigation
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
        SetActiveNavButton(btnShop)

        Me.Hide()
        frmCostumeDashboard.Show()
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        ' Set Cart button as active
        SetActiveNavButton(btnCart)
    End Sub

    Private Sub btnActiveList_Click(sender As Object, e As EventArgs) Handles btnActiveList.Click
        ' Set Active List button as active
        SetActiveNavButton(btnActiveList)

        ' Example: Show a message or navigate to Active List
        MessageBox.Show("Navigating to Active List page...")
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        ' Set About button as active
        SetActiveNavButton(btnAbout)

        ' Example: Show a message or navigate to About page
        MessageBox.Show("Navigating to About page...")
    End Sub

    Private Sub frmCart_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        ' Set Cart button as active when the form becomes visible
        SetActiveNavButton(btnCart)
    End Sub

    ' Public method to update the cart display
    Public Sub UpdateCartDisplay(cartData As List(Of frmCostumeDashboard.CartItem))
        ' Clear existing items in PanelCartList
        PanelCartList.Controls.Clear()

        Dim outerMargin As Integer = 30
        Dim verticalSpacing As Integer = 20
        Dim panelWidth As Integer = PanelCartList.Width - 70
        Dim panelHeight As Integer = 250 ' Adjusted panel height for larger image and elements
        Dim imageWidth As Integer = 300 ' Increased image size
        Dim imageHeight As Integer = imageWidth * 3 \ 4 ' Maintain aspect ratio

        For Each item In cartData
            ' Create an individual panel for each cart item
            Dim itemPanel As New Panel() With {
                .Width = panelWidth,
                .Height = panelHeight,
                .BackColor = Color.White,
                .BorderStyle = BorderStyle.FixedSingle
            }

            ' Position the panel
            itemPanel.Top = (cartData.IndexOf(item) * (itemPanel.Height + verticalSpacing)) + outerMargin
            itemPanel.Left = outerMargin

            ' Add PictureBox for the item image (Aspect Ratio maintained)
            Dim pictureBox As New PictureBox() With {
                .Image = Image.FromFile(item.ImagePath),
                .SizeMode = PictureBoxSizeMode.Zoom,
                .Width = imageWidth,
                .Height = imageHeight,
                .Top = 10,
                .Left = 10
            }
            itemPanel.Controls.Add(pictureBox)

            ' Add Label for the item name
            Dim nameLabel As New Label() With {
                .Text = item.Name,
                .Font = New Font("Katibeh", 20, FontStyle.Regular), ' Increased font size
                .ForeColor = Color.Navy,
                .AutoSize = False,
                .Width = panelWidth - imageWidth - 30,
                .Height = 40,
                .Top = 30,
                .Left = pictureBox.Left + pictureBox.Width + 15,
                .TextAlign = ContentAlignment.MiddleLeft
            }
            itemPanel.Controls.Add(nameLabel)

            ' Add Label for the item price
            Dim priceLabel As New Label() With {
                .Text = item.Price,
                .Font = New Font("Katibeh", 16, FontStyle.Regular), ' Increased font size
                .ForeColor = Color.Black,
                .AutoSize = False,
                .Width = panelWidth - imageWidth - 30,
                .Height = 30,
                .Top = nameLabel.Top + nameLabel.Height + 10,
                .Left = nameLabel.Left,
                .TextAlign = ContentAlignment.MiddleLeft
            }
            itemPanel.Controls.Add(priceLabel)

            ' Add "Remove" Button at the bottom of the panel
            Dim removeButton As New Button() With {
                .Text = "Remove",
                .Width = 200, ' Increased width
                .Height = 50, ' Increased height
                .BackColor = Color.Tomato,
                .ForeColor = Color.White,
                .FlatStyle = FlatStyle.Standard,
                .Top = panelHeight - 60, ' Positioned at the bottom with padding
                .Left = (panelWidth - 230), ' Slightly to the right
                .Font = New Font("Katibeh", 18, FontStyle.Regular),
                .Cursor = Cursors.Hand,
                .TextAlign = ContentAlignment.TopCenter
            }
            AddHandler removeButton.Click, Sub(senderButton, eArgs)
                                               cartData.Remove(item) ' Remove the item from the cart
                                               UpdateCartDisplay(cartData) ' Refresh the display
                                           End Sub
            itemPanel.Controls.Add(removeButton)

            ' Add the item panel to PanelCartList
            PanelCartList.Controls.Add(itemPanel)
        Next

        ' Add "Checkout" Button at the bottom of the list
        Dim checkoutButton As New Button() With {
            .Text = "Checkout",
            .Width = panelWidth,
            .Height = 50,
            .BackColor = Color.MediumSeaGreen,
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .Top = (cartData.Count * (panelHeight + verticalSpacing)) + outerMargin,
            .Left = outerMargin
        }
        AddHandler checkoutButton.Click, Sub(senderButton, eArgs)
                                             MessageBox.Show("Proceeding to checkout!")
                                         End Sub
        PanelCartList.Controls.Add(checkoutButton)
    End Sub
End Class
