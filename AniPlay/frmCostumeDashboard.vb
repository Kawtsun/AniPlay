Imports System.Drawing.Drawing2D
Public Class frmCostumeDashboard
    Public Property CurrentUser As User

    Public Property Username As String
    Public Property Name As String
    Public Property Email As String

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
        If Not String.IsNullOrEmpty(Username) Then
            lblUser.Text = $"Welcome, {Username}"
        Else
            lblUser.Text = "Welcome, User!"
        End If

        MakePictureBoxCircular(PictureBoxLogo)

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
        New CostumeItem With {.Name = "AI", .ImagePath = basePath & "ai.jpg", .RentalPricePerDay = 1500, .Category = "Women"},
        New CostumeItem With {.Name = "Frieren", .ImagePath = basePath & "frieren.jpg", .RentalPricePerDay = 1800, .Category = "Women"},
        New CostumeItem With {.Name = "Homura", .ImagePath = basePath & "homura.jpg", .RentalPricePerDay = 1200, .Category = "Women"},
        New CostumeItem With {.Name = "Junko", .ImagePath = basePath & "junko.jpg", .RentalPricePerDay = 2000, .Category = "Women"},
        New CostumeItem With {.Name = "Kita", .ImagePath = basePath & "kita.jpg", .RentalPricePerDay = 1700, .Category = "Women"},
        New CostumeItem With {.Name = "Madoka", .ImagePath = basePath & "madoka.jpg", .RentalPricePerDay = 2300, .Category = "Women"},
        New CostumeItem With {.Name = "McQueen", .ImagePath = basePath & "mcqueen.jpg", .RentalPricePerDay = 1600, .Category = "Women"},
        New CostumeItem With {.Name = "Mortis", .ImagePath = basePath & "mortis.jpg", .RentalPricePerDay = 2100, .Category = "Women"},
        New CostumeItem With {.Name = "Sora", .ImagePath = basePath & "bcsora.jpg", .RentalPricePerDay = 1500, .Category = "Men"},
        New CostumeItem With {.Name = "Choji", .ImagePath = basePath & "choji.jpg", .RentalPricePerDay = 1800, .Category = "Men"},
        New CostumeItem With {.Name = "Deku", .ImagePath = basePath & "deku.jpg", .RentalPricePerDay = 2600, .Category = "Men"},
        New CostumeItem With {.Name = "Gilgamesh", .ImagePath = basePath & "gilgamesh1.jpg", .RentalPricePerDay = 2200, .Category = "Men"},
        New CostumeItem With {.Name = "Hayato", .ImagePath = basePath & "hayato.jpg", .RentalPricePerDay = 1500, .Category = "Men"},
        New CostumeItem With {.Name = "Hoshina", .ImagePath = basePath & "hoshina.jpg", .RentalPricePerDay = 2300, .Category = "Men"},
        New CostumeItem With {.Name = "Ichikawa", .ImagePath = basePath & "ichikawa1.jpg", .RentalPricePerDay = 1400, .Category = "Men"},
        New CostumeItem With {.Name = "Okarun", .ImagePath = basePath & "kentakakura.jpg", .RentalPricePerDay = 2100, .Category = "Men"},
        New CostumeItem With {.Name = "Takakura", .ImagePath = basePath & "kentakakura1.jpg", .RentalPricePerDay = 2300, .Category = "Men"},
        New CostumeItem With {.Name = "Kirito", .ImagePath = basePath & "kirito.jpg", .RentalPricePerDay = 2500, .Category = "Men"},
        New CostumeItem With {.Name = "Kongming", .ImagePath = basePath & "kongming.jpg", .RentalPricePerDay = 2900, .Category = "Men"},
        New CostumeItem With {.Name = "Red hair guy", .ImagePath = basePath & "ons1.jpg", .RentalPricePerDay = 2100, .Category = "Men"},
        New CostumeItem With {.Name = "Sakura", .ImagePath = basePath & "sakura.jpg", .RentalPricePerDay = 2300, .Category = "Men"},
        New CostumeItem With {.Name = "Subaru", .ImagePath = basePath & "subaru1.jpg", .RentalPricePerDay = 1300, .Category = "Men"},
        New CostumeItem With {.Name = "Sung Jinwoo", .ImagePath = basePath & "sungjinwoo.jpg", .RentalPricePerDay = 2900, .Category = "Men"},
        New CostumeItem With {.Name = "Togame", .ImagePath = basePath & "togame.jpg", .RentalPricePerDay = 1200, .Category = "Men"},
        New CostumeItem With {.Name = "Loid", .ImagePath = basePath & "loid.jpg", .RentalPricePerDay = 1100, .Category = "Men"},
        New CostumeItem With {.Name = "Aira", .ImagePath = basePath & "aira.jpg", .RentalPricePerDay = 1800, .Category = "Women"},
        New CostumeItem With {.Name = "Akagi", .ImagePath = basePath & "akagi.jpg", .RentalPricePerDay = 1900, .Category = "Women"},
        New CostumeItem With {.Name = "Akane", .ImagePath = basePath & "akane.jpg", .RentalPricePerDay = 1700, .Category = "Women"},
        New CostumeItem With {.Name = "Anya", .ImagePath = basePath & "anya.jpg", .RentalPricePerDay = 1400, .Category = "Women"},
        New CostumeItem With {.Name = "Ayase", .ImagePath = basePath & "ayase.jpg", .RentalPricePerDay = 1600, .Category = "Women"},
        New CostumeItem With {.Name = "Beatrice", .ImagePath = basePath & "beatrice.jpg", .RentalPricePerDay = 1800, .Category = "Women"},
        New CostumeItem With {.Name = "Chisato", .ImagePath = basePath & "chisato.jpg", .RentalPricePerDay = 1900, .Category = "Women"},
        New CostumeItem With {.Name = "Echidna", .ImagePath = basePath & "echidna.jpg", .RentalPricePerDay = 2900, .Category = "Women"},
        New CostumeItem With {.Name = "Eiko", .ImagePath = basePath & "eiko.jpg", .RentalPricePerDay = 1700, .Category = "Women"},
        New CostumeItem With {.Name = "Emilia", .ImagePath = basePath & "emilia.jpg", .RentalPricePerDay = 2800, .Category = "Women"},
        New CostumeItem With {.Name = "Emilia Cloak", .ImagePath = basePath & "emilia1.jpg", .RentalPricePerDay = 1500, .Category = "Women"},
        New CostumeItem With {.Name = "Enterprise", .ImagePath = basePath & "enterprise.jpg", .RentalPricePerDay = 2700, .Category = "Women"},
        New CostumeItem With {.Name = "Erza", .ImagePath = basePath & "erza.jpg", .RentalPricePerDay = 2300, .Category = "Women"},
        New CostumeItem With {.Name = "Fiona", .ImagePath = basePath & "fiona1.jpg", .RentalPricePerDay = 1300, .Category = "Women"},
        New CostumeItem With {.Name = "Inui", .ImagePath = basePath & "inui.jpg", .RentalPricePerDay = 2100, .Category = "Women"},
        New CostumeItem With {.Name = "Marin Yukata", .ImagePath = basePath & "marin.jpg", .RentalPricePerDay = 2500, .Category = "Women"},
        New CostumeItem With {.Name = "Memchu", .ImagePath = basePath & "memchu.jpg", .RentalPricePerDay = 2300, .Category = "Women"},
        New CostumeItem With {.Name = "Nijika", .ImagePath = basePath & "nijika.jpg", .RentalPricePerDay = 1800, .Category = "Women"},
        New CostumeItem With {.Name = "Power", .ImagePath = basePath & "power.jpg", .RentalPricePerDay = 2200, .Category = "Women"},
        New CostumeItem With {.Name = "Ram", .ImagePath = basePath & "ram.jpg", .RentalPricePerDay = 2500, .Category = "Women"},
        New CostumeItem With {.Name = "Rem", .ImagePath = basePath & "rem.jpg", .RentalPricePerDay = 2500, .Category = "Women"},
        New CostumeItem With {.Name = "Shinomiya", .ImagePath = basePath & "shinomiya.jpg", .RentalPricePerDay = 2100, .Category = "Women"},
        New CostumeItem With {.Name = "Takina", .ImagePath = basePath & "takina.jpg", .RentalPricePerDay = 2200, .Category = "Women"},
        New CostumeItem With {.Name = "Tsuyu", .ImagePath = basePath & "tsuyu.jpg", .RentalPricePerDay = 2300, .Category = "Women"},
        New CostumeItem With {.Name = "Yamada", .ImagePath = basePath & "yamada.jpg", .RentalPricePerDay = 1800, .Category = "Women"},
        New CostumeItem With {.Name = "Yor", .ImagePath = basePath & "yor.jpg", .RentalPricePerDay = 2200, .Category = "Women"},
        New CostumeItem With {.Name = "Yor Casual", .ImagePath = basePath & "yor1.jpg", .RentalPricePerDay = 1800, .Category = "Women"},
        New CostumeItem With {.Name = "Yui", .ImagePath = basePath & "yui.jpg", .RentalPricePerDay = 1600, .Category = "Women"},
        New CostumeItem With {.Name = "Zero Two", .ImagePath = basePath & "zerotwo.jpg", .RentalPricePerDay = 2500, .Category = "Women"},
        New CostumeItem With {.Name = "Axe", .ImagePath = basePath & "axe.jpg", .RentalPricePerDay = 2300, .Category = "Accessories"},
        New CostumeItem With {.Name = "BroadSword", .ImagePath = basePath & "broadsword.jpg", .RentalPricePerDay = 2600, .Category = "Accessories"},
        New CostumeItem With {.Name = "Cap", .ImagePath = basePath & "cap.jpg", .RentalPricePerDay = 1100, .Category = "Accessories"},
        New CostumeItem With {.Name = "Crown", .ImagePath = basePath & "crown.jpg", .RentalPricePerDay = 2000, .Category = "Accessories"},
        New CostumeItem With {.Name = "Daggers", .ImagePath = basePath & "dagger.jpg", .RentalPricePerDay = 2300, .Category = "Accessories"},
        New CostumeItem With {.Name = "Archer's Weapon", .ImagePath = basePath & "dagger2.jpg", .RentalPricePerDay = 2100, .Category = "Accessories"},
        New CostumeItem With {.Name = "Earrings", .ImagePath = basePath & "earring.jpg", .RentalPricePerDay = 1300, .Category = "Accessories"},
        New CostumeItem With {.Name = "Earrings", .ImagePath = basePath & "earring2.jpg", .RentalPricePerDay = 1300, .Category = "Accessories"},
        New CostumeItem With {.Name = "Elden Ring Set", .ImagePath = basePath & "eldenring.jpg", .RentalPricePerDay = 3000, .Category = "Accessories"},
        New CostumeItem With {.Name = "Katana", .ImagePath = basePath & "katana1.jpg", .RentalPricePerDay = 2300, .Category = "Accessories"},
        New CostumeItem With {.Name = "Katana", .ImagePath = basePath & "katana2.jpg", .RentalPricePerDay = 2300, .Category = "Accessories"},
        New CostumeItem With {.Name = "Katana", .ImagePath = basePath & "katana3.jpg", .RentalPricePerDay = 2300, .Category = "Accessories"},
        New CostumeItem With {.Name = "Mask", .ImagePath = basePath & "mask.jpg", .RentalPricePerDay = 1400, .Category = "Accessories"},
        New CostumeItem With {.Name = "Scythe", .ImagePath = basePath & "scythe.jpg", .RentalPricePerDay = 2400, .Category = "Accessories"},
        New CostumeItem With {.Name = "Scythe", .ImagePath = basePath & "scythe1.jpg", .RentalPricePerDay = 2400, .Category = "Accessories"},
        New CostumeItem With {.Name = "Staff", .ImagePath = basePath & "staff.jpg", .RentalPricePerDay = 1200, .Category = "Accessories"},
        New CostumeItem With {.Name = "Sword", .ImagePath = basePath & "sword1.jpg", .RentalPricePerDay = 2000, .Category = "Accessories"},
        New CostumeItem With {.Name = "Sword", .ImagePath = basePath & "sword2.jpg", .RentalPricePerDay = 2000, .Category = "Accessories"},
        New CostumeItem With {.Name = "Sword", .ImagePath = basePath & "sword3.jpg", .RentalPricePerDay = 2000, .Category = "Accessories"},
        New CostumeItem With {.Name = "Sword", .ImagePath = basePath & "sword4.jpg", .RentalPricePerDay = 2000, .Category = "Accessories"},
        New CostumeItem With {.Name = "Weapon", .ImagePath = basePath & "weapon1.jpg", .RentalPricePerDay = 2600, .Category = "Accessories"},
        New CostumeItem With {.Name = "Weapon", .ImagePath = basePath & "weapon2.jpg", .RentalPricePerDay = 1700, .Category = "Accessories"}
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

        'If CurrentUser IsNot Nothing Then
        '    frmCartInstance.Username = CurrentUser.username
        '    frmCartInstance.Name = CurrentUser.name
        '    frmCartInstance.Email = CurrentUser.email
        'End If

        'Me.Hide()
        'frmCartInstance.Show()

        Dim cartForm As New frmCart()

        ' Pass user data to frmCart
        If CurrentUser IsNot Nothing Then
            cartForm.Username = CurrentUser.username
            cartForm.Name = CurrentUser.name
            cartForm.Email = CurrentUser.email
        End If

        Me.Hide()
        cartForm.Show()
    End Sub

    Private Sub btnActiveList_Click(sender As Object, e As EventArgs) Handles btnActiveList.Click
        Dim activeForm As New frmActive()
        activeForm.Username = Username ' Pass the username
        activeForm.Name = Name ' Pass the name
        activeForm.Email = Email ' Pass the email
        Me.Hide()
        activeForm.Show()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim aboutForm As New frmAbout()
        aboutForm.Username = Username ' Pass the username
        aboutForm.Name = Name ' Pass the name
        aboutForm.Email = Email ' Pass the email
        Me.Hide()
        aboutForm.Show()
    End Sub


    Private Sub frmCostumeDashboard_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        SetActiveNavButton(btnShop)
        If CurrentUser IsNot Nothing Then
            lblUser.Text = $"Welcome, {CurrentUser.username}"
        Else
            lblUser.Text = "Welcome, User!"
        End If
    End Sub

    Private Sub MakePictureBoxCircular(pictureBox As PictureBox)
        ' Create a circular GraphicsPath
        Dim circlePath As New GraphicsPath()
        circlePath.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height)

        ' Set the region of the PictureBox to the circular path
        pictureBox.Region = New Region(circlePath)
    End Sub
End Class
