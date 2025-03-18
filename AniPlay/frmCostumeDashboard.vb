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
        Public Property Price As String
        Public Property Category As String
    End Class

    ' Class to store cart item information
    Public Class CartItem
        Public Property Name As String
        Public Property ImagePath As String
        Public Property Price As String
    End Class

    ' Initialize the form
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
                .Height = imageHeight + 50 + buttonHeight + (innerSpacing * 3),
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

            ' Add Label for price
            Dim priceLabel As New Label() With {
                .Text = costume.Price,
                .Font = New Font("Katibeh", 16, FontStyle.Regular),
                .ForeColor = Color.Black,
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
                .Top = itemPanel.Height - buttonHeight,
                .BackColor = Color.MediumSeaGreen,
                .ForeColor = Color.White,
                .FlatStyle = FlatStyle.Standard,
                .Font = New Font("Katibeh", 18, FontStyle.Regular),
                .Cursor = Cursors.Hand,
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

    ' Add an item to the cart with validation for duplicates
    Private Sub AddToCart(costume As CostumeItem)
        ' Check if the costume is already in the cart
        Dim isAlreadyInCart As Boolean = cartData.Any(Function(item) item.Name = costume.Name)

        If isAlreadyInCart Then
            ' Show a warning if the item is already in the cart
            MessageBox.Show($"The costume '{costume.Name}' is already in the cart!", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Add the costume to the cart
            cartData.Add(New CartItem With {
                .Name = costume.Name,
                .ImagePath = costume.ImagePath,
                .Price = costume.Price
            })

            ' Update the cart display in frmCart
            frmCartInstance.UpdateCartDisplay(cartData)

            ' Show confirmation message
            MessageBox.Show($"{costume.Name} has been added to your cart!", "Item Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Show the Cart form
    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        Me.Hide()
        frmCartInstance.Show()
    End Sub
End Class
