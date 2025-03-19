Public Class frmCostumeDashboard
    Public Property CurrentUser As User
    Private costumeData As List(Of CostumeItem) ' List to store all costume data
    Private cartData As List(Of CartItem) = New List(Of CartItem)() ' List to store cart items

    ' Declare an instance of frmCart
    Private frmCartInstance As New frmCart()

    ' Class to store costume information
    Private Class CostumeItem
        Public Property Name As String
        Public Property ImagePath As String
        Public Property RentalPricePerDay As Decimal ' Store price as Decimal
        Public Property Category As String
    End Class

    ' Class to store cart item information
    Public Class CartItem
        Public Property Name As String
        Public Property ImagePath As String
        Public Property RentalPricePerDay As Decimal ' Store price per day
        Public Property RentalDays As Integer ' Number of rental days

    End Class

    ' Initialize the form
    Private Sub frmCostumeDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Display welcome message
        If CurrentUser IsNot Nothing Then
            lblUser.Text = $"Welcome, {CurrentUser.username}"
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
            New CostumeItem With {.Name = "AI", .ImagePath = basePath & "ai.jpg", .RentalPricePerDay = 1500, .Category = "All"},
            New CostumeItem With {.Name = "Frieren", .ImagePath = basePath & "frieren.jpg", .RentalPricePerDay = 1800, .Category = "Women"},
            New CostumeItem With {.Name = "Homura", .ImagePath = basePath & "homura.jpg", .RentalPricePerDay = 1200, .Category = "Women"},
            New CostumeItem With {.Name = "Junko", .ImagePath = basePath & "junko.jpg", .RentalPricePerDay = 2000, .Category = "Women"},
            New CostumeItem With {.Name = "Kita", .ImagePath = basePath & "kita.jpg", .RentalPricePerDay = 1700, .Category = "Men"},
            New CostumeItem With {.Name = "Madoka", .ImagePath = basePath & "madoka.jpg", .RentalPricePerDay = 2300, .Category = "Accessories"},
            New CostumeItem With {.Name = "McQueen", .ImagePath = basePath & "mcqueen.jpg", .RentalPricePerDay = 1600, .Category = "Men"},
            New CostumeItem With {.Name = "Mortis", .ImagePath = basePath & "mortis.jpg", .RentalPricePerDay = 2100, .Category = "Accessories"}
        }
    End Sub

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
        activeButton.Font = New Font("Katibeh", 20, FontStyle.Bold) ' Bold font for active button
        activeButton.TextAlign = ContentAlignment.TopCenter
    End Sub

    ' Event handler for category buttons
    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnAll.Click, btnWomen.Click, btnMen.Click, btnAccessories.Click
        ' Cast the sender to a Button
        Dim clickedButton As Button = DirectCast(sender, Button)

        ' Set the clicked button as active
        SetActiveButton(clickedButton)

        ' Determine the selected category based on the button's text
        Dim selectedCategory As String = clickedButton.Text

        ' Display costumes based on the selected category
        DisplayCostumes(selectedCategory)
    End Sub

    ' Display costumes based on category
    Private Sub DisplayCostumes(category As String)
        Panel2.Controls.Clear() ' Clear existing items in Panel2

        Dim outerMargin As Integer = 20
        Dim verticalPadding As Integer = 25
        Dim imagesPerRow As Integer = 3
        Dim imageWidth As Integer = 320 ' Fixed width
        Dim imageHeight As Integer = imageWidth * 3 \ 4
        Dim buttonHeight As Integer = 60 ' Button height for consistent design
        Dim innerSpacing As Integer = 20 ' Space between elements

        ' Filter costumes by category or show all if "All" is selected
        Dim filteredCostumes = costumeData.Where(Function(c) c.Category = category Or category = "All").ToList()

        For Each costume In filteredCostumes
            ' Create a container panel for each costume
            Dim itemPanel As New Panel() With {
                .Width = imageWidth,
                .Height = imageHeight + 70 + buttonHeight + (innerSpacing * 3),
                .BackColor = Color.White,
                .BorderStyle = BorderStyle.FixedSingle
            }

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

            ' Add Label for Rental Price/Day
            Dim rentalPriceLabel As New Label() With {
                .Text = $"Rental Price/Day: ₱{costume.RentalPricePerDay}",
                .Font = New Font("Katibeh", 16, FontStyle.Regular),
                .ForeColor = Color.Black,
                .Height = 30,
                .Width = imageWidth,
                .Top = nameLabel.Top + nameLabel.Height + innerSpacing,
                .TextAlign = ContentAlignment.MiddleCenter
            }
            itemPanel.Controls.Add(rentalPriceLabel)

            ' Add "Add to Cart" Button
            Dim addButton As New Button() With {
                .Text = "Add to Cart",
                .Width = imageWidth,
                .Height = buttonHeight,
                .BackColor = Color.MediumSeaGreen,
                .ForeColor = Color.White,
                .FlatStyle = FlatStyle.Standard,
                .Font = New Font("Katibeh", 18, FontStyle.Regular),
                .Top = rentalPriceLabel.Top + rentalPriceLabel.Height + innerSpacing,
                .TextAlign = ContentAlignment.MiddleCenter
            }
            AddHandler addButton.Click, Sub(senderButton, eArgs)
                                            AddToCart(costume)
                                        End Sub
            itemPanel.Controls.Add(addButton)

            ' Add the item panel to Panel2
            Panel2.Controls.Add(itemPanel)
        Next
    End Sub

    ' Add an item to the cart
    ' Add an item to the cart
    Private Sub AddToCart(costume As CostumeItem)
        ' Check for duplicates in the shared CartItemList
        If frmCart.CartItemList.Any(Function(c) c.Name = costume.Name) Then
            MessageBox.Show($"{costume.Name} is already in the cart!", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' Add item to the shared CartItemList
            frmCart.CartItemList.Add(New frmCostumeDashboard.CartItem With {
            .Name = costume.Name,
            .ImagePath = costume.ImagePath,
            .RentalPricePerDay = costume.RentalPricePerDay,
            .RentalDays = 1 ' Default to 1 day
        })

            ' Update the cart display using the shared CartItemList
            If frmCart.Instance IsNot Nothing Then
                frmCart.Instance.UpdateCartDisplay(frmCart.CartItemList)
            End If

            MessageBox.Show($"{costume.Name} added to the cart!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
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
    'Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click
    '    ' Set Cart button as active
    '    SetActiveNavButton(btnCart)
    'End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click

        If CurrentUser IsNot Nothing Then
            frmCartInstance.Username = CurrentUser.username
            frmCartInstance.Name = CurrentUser.name
            frmCartInstance.Email = CurrentUser.email
        End If

        Me.Hide()
        frmCartInstance.Show()
    End Sub

    Private Sub btnActiveList_Click(sender As Object, e As EventArgs) Handles btnActiveList.Click
        Me.Hide()
        frmActive.Show()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Me.Hide()
        frmAbout.Show()
    End Sub

    Private Sub frmCostumeDashboard_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        SetActiveNavButton(btnShop)
    End Sub
End Class
