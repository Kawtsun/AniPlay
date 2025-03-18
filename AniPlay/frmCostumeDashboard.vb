Public Class frmCostumeDashboard
    Public Property CurrentUser As User
    Private costumeData As List(Of CostumeItem) ' List to store all costume data

    ' Class to store costume information
    Private Class CostumeItem
        Public Property Name As String
        Public Property ImagePath As String
        Public Property Price As String
        Public Property Category As String
    End Class

    ' Method to set the active button
    Private Sub SetActiveButton(activeButton As Button)
        ' Reset the appearance of all category buttons
        For Each btn In New Button() {btnAll, btnWomen, btnMen, btnAccessories}
            btn.BackColor = Color.White ' Default color for inactive buttons
            btn.ForeColor = Color.Black ' Default text color
            btn.Font = New Font("Katibeh", 20, FontStyle.Regular) ' Reset font to "Katibeh" in regular style
            btn.TextAlign = ContentAlignment.TopCenter
        Next

        ' Highlight the active button
        activeButton.BackColor = Color.MediumSeaGreen ' Active button color
        activeButton.ForeColor = Color.White ' Active text color
        activeButton.Font = New Font("Katibeh", 20, FontStyle.Regular) ' Bold font for active button
        activeButton.TextAlign = ContentAlignment.TopCenter
    End Sub

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
        activeButton.Font = New Font("Katibeh", 20, FontStyle.Regular) ' Bold font for active button
    End Sub

    ' Event handlers for navigation buttons
    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click
        ' Set Shop button as active
        SetActiveNavButton(btnShop)

        ' Logic to navigate to the Shop page
        ' Example: Show the Shop panel or open the Shop form
        MessageBox.Show("Navigating to Shop page...")
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        ' Set Cart button as active
        SetActiveNavButton(btnCart)

        Me.Hide()
        frmCart.Show()
    End Sub

    Private Sub btnActiveList_Click(sender As Object, e As EventArgs) Handles btnActiveList.Click
        ' Set Cart button as active
        SetActiveNavButton(btnActiveList)

        ' Logic to navigate to the Cart page
        ' Example: Show the Cart panel or open the Cart form
        MessageBox.Show("Navigating to Active List page...")
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        ' Set About button as active
        SetActiveNavButton(btnAbout)

        ' Logic to navigate to the About page
        ' Example: Show the About panel or open the About form
        MessageBox.Show("Navigating to About page...")
    End Sub

    Private Sub frmCostumeDashboard_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        ' Set Shop button as active by default
        SetActiveNavButton(btnShop)
    End Sub

    ' Load event: initializes the form
    Private Sub frmCostumeDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Display welcome message
        If CurrentUser IsNot Nothing Then
            lblUser.Text = $"Welcome, {CurrentUser.name}"
        Else
            lblUser.Text = "Welcome, User!"
        End If

        ' Initialize costume data
        InitializeCostumeData()

        ' Display all costumes by default
        DisplayCostumes("All")

        ' Set "All" button as active by default
        SetActiveButton(btnAll)
    End Sub



    ' Initialize costume data
    Private Sub InitializeCostumeData()
        Dim basePath As String = AppDomain.CurrentDomain.BaseDirectory & "Resources\"

        costumeData = New List(Of CostumeItem) From {
            New CostumeItem With {.Name = "AI", .ImagePath = basePath & "ai.jpg", .Price = "₱1,500", .Category = "All"},
            New CostumeItem With {.Name = "Frieren", .ImagePath = basePath & "frieren.jpg", .Price = "₱1,800", .Category = "Women"},
            New CostumeItem With {.Name = "Homura", .ImagePath = basePath & "homura.jpg", .Price = "₱1,200", .Category = "Women"},
            New CostumeItem With {.Name = "Junko", .ImagePath = basePath & "junko.jpg", .Price = "₱2,000", .Category = "Women"},
            New CostumeItem With {.Name = "Kita", .ImagePath = basePath & "kita.jpg", .Price = "₱1,700", .Category = "Men"},
            New CostumeItem With {.Name = "Madoka", .ImagePath = basePath & "madoka.jpg", .Price = "₱2,300", .Category = "Accessories"},
            New CostumeItem With {.Name = "McQueen", .ImagePath = basePath & "mcqueen.jpg", .Price = "₱1,600", .Category = "Men"},
            New CostumeItem With {.Name = "Mortis", .ImagePath = basePath & "mortis.jpg", .Price = "₱2,100", .Category = "Accessories"}
        }
    End Sub

    ' Display costumes based on category
    Private Sub DisplayCostumes(category As String)
        Panel2.Controls.Clear() ' Clear existing items in Panel2

        ' Filter costumes by category or show all if "All" is selected
        Dim filteredCostumes = costumeData.Where(Function(c) c.Category = category Or category = "All").ToList()

        Dim outerMargin As Integer = 20
        Dim verticalPadding As Integer = 25
        Dim imagesPerRow As Integer = 3
        Dim imageWidth As Integer = 325 ' Fixed width
        Dim imageHeight As Integer = imageWidth * 3 \ 4
        Dim buttonHeight As Integer = 60 ' Button height for consistent design
        Dim innerSpacing As Integer = 20 ' Space between elements

        For Each costume In filteredCostumes
            ' Create a container panel for each costume
            Dim itemPanel As New Panel() With {
                .Width = imageWidth,
                .Height = imageHeight + 50 + buttonHeight + (innerSpacing * 3),
                .BackColor = Color.White,
                .BorderStyle = BorderStyle.FixedSingle
            }

            ' Positioning logic
            Dim column As Integer = filteredCostumes.IndexOf(costume) Mod imagesPerRow
            Dim row As Integer = Math.Floor(filteredCostumes.IndexOf(costume) / imagesPerRow)
            itemPanel.Left = outerMargin + (column * (imageWidth + outerMargin))
            itemPanel.Top = outerMargin + (row * (itemPanel.Height + verticalPadding))

            ' Add PictureBox for image
            Dim pictureBox As New PictureBox() With {
                .Image = Image.FromFile(costume.ImagePath),
                .SizeMode = PictureBoxSizeMode.Zoom,
                .Width = imageWidth,
                .Height = imageHeight,
                .Top = 10,
                .Left = 0
            }
            itemPanel.Controls.Add(pictureBox)

            ' Add Label for name
            Dim nameLabel As New Label() With {
                .Text = costume.Name,
                .Font = New Font("Katibeh", 20, FontStyle.Regular),
                .ForeColor = Color.Navy,
                .Height = 30,
                .Width = imageWidth,
                .TextAlign = ContentAlignment.MiddleCenter,
                .Top = pictureBox.Top + pictureBox.Height + innerSpacing
            }
            itemPanel.Controls.Add(nameLabel)

            ' Add Label for price
            Dim priceLabel As New Label() With {
                .Text = costume.Price,
                .Font = New Font("Katibeh", 18, FontStyle.Regular),
                .ForeColor = Color.Black,
                .Height = 30,
                .Width = imageWidth,
                .TextAlign = ContentAlignment.MiddleCenter,
                .Top = nameLabel.Top + nameLabel.Height + innerSpacing
            }
            itemPanel.Controls.Add(priceLabel)

            ' Add "Add to Cart" Button
            Dim addButton As New Button() With {
                .Text = "Add to Cart",
                .Width = imageWidth,
                .Height = buttonHeight,
                .Left = 0,
                .Top = itemPanel.Height - buttonHeight - 0,
                .BackColor = Color.MediumSeaGreen,
                .ForeColor = Color.White,
                .FlatStyle = FlatStyle.Standard,
                .Font = New Font("Katibeh", 18, FontStyle.Regular),
                .Cursor = Cursors.Hand,
                .TextAlign = ContentAlignment.MiddleCenter
            }
            AddHandler addButton.Click, Sub(senderButton, eArgs)
                                            MessageBox.Show($"Added {costume.Name} to the cart!")
                                        End Sub
            itemPanel.Controls.Add(addButton)

            ' Add the item panel to Panel2
            Panel2.Controls.Add(itemPanel)
        Next
    End Sub

    ' Event handler for category buttons
    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnAll.Click, btnWomen.Click, btnMen.Click, btnAccessories.Click
        Dim button = DirectCast(sender, Button)
        Dim category As String = button.Text ' Category name is based on button text

        ' Display costumes for the selected category
        DisplayCostumes(category)

        ' Set the clicked button as active
        SetActiveButton(button)
    End Sub


End Class
