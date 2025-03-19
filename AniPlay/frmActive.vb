Public Class frmActive

    Public Property Username As String
    Private activeRentals As List(Of ActiveRental) = New List(Of ActiveRental)()

    ' Load active rentals into the panel
    Public Sub LoadActiveRentals(data As List(Of ActiveRental))
        If activeRentals Is Nothing Then
            activeRentals = New List(Of ActiveRental)()
        End If

        ' Add new rentals to the list
        activeRentals.AddRange(data)

        ' Display the first rental's details in PanelRentalList
        If activeRentals.Count > 0 Then
            UpdatePanelRentalList(activeRentals.First())
        End If

        ' Hide the labels initially
        ResetLabelsVisibility()
    End Sub

    ' Update PanelRentalList
    Private Sub UpdatePanelRentalList(rental As ActiveRental)
        ' Populate PanelRentalList with rental information
        lblRentalNo.Text = $"Rental No: {rental.RentalNo}"
        lblDate.Text = $"From: {rental.DateFrom.ToShortDateString()} To: {rental.DateUntil.ToShortDateString()}"
        lblDuration.Text = $"Duration: {(rental.DateUntil - rental.DateFrom).Days + 1} Day(s)"
    End Sub

    ' Handle the Return Button Click
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        frmCart.CartItemList.Clear()

        ' Update the cart UI to reflect the cleared state
        If frmCart.Instance IsNot Nothing Then
            frmCart.Instance.UpdateCartDisplay(New List(Of frmCostumeDashboard.CartItem))
        End If

        If activeRentals.Count = 0 Then Return ' No rentals to process

        Dim rental = activeRentals.First() ' Process the first rental
        Dim returnDate As Date = datePickerReturn.Value

        ' Use today's date as default if no date is selected
        If returnDate = datePickerReturn.MinDate Then
            returnDate = Date.Now
        End If

        datePickerReturn.Enabled = False

        ' Update labels with rental information
        lblName.Text = $"Name: {rental.Name}"
        lblEmail.Text = $"Email: {rental.Email}"
        lblAddress.Text = $"Address: {rental.Address}"
        lblContactNo.Text = $"Contact No: {rental.ContactNo}"
        lblDiscount.Text = $"Discount: {rental.Discount:C2}"
        lblTotalPrice.Text = $"Total Price: {rental.TotalPrice:C2}"
        lblDate.Text = $"From: {rental.DateFrom.ToShortDateString()} To: {rental.DateUntil.ToShortDateString()}"
        lblDuration.Text = $"Duration: {(rental.DateUntil - rental.DateFrom).Days + 1} Day(s)"

        ' Calculate late fees
        Dim lateFees As Decimal = 0
        Dim daysLate As Integer = 0
        If returnDate > rental.DateUntil Then
            daysLate = (returnDate - rental.DateUntil).Days
            lateFees = daysLate * (rental.DailyPrice * 0.05)
            lblLateFees.Text = $"Late Fees: {lateFees:C2} ({daysLate} Day(s))"
        Else
            ' Explicitly show 0 late fees if none occur
            lblLateFees.Text = "Late Fees: ₱0.00"
        End If
        lblLateFees.Visible = True ' Ensure the label is always visible

        ' Update Total Fees to include late fees if applicable
        Dim totalFees As Decimal = rental.TotalPrice + lateFees
        lblTotalFees.Text = $"Total Amount Paid: {totalFees:C2}"
        lblTotalFees.Visible = True ' Always visible

        ' Disable btnReturn after processing
        btnReturn.Enabled = False

        ' Make all other labels visible, including Thankyou and Information
        SetLabelsVisibility(True)
        lblThankyou.Visible = True
        lblInformation.Visible = True
    End Sub

    ' Reset visibility of labels (initially hidden)
    Private Sub ResetLabelsVisibility()
        lblName.Visible = False
        lblEmail.Visible = False
        lblAddress.Visible = False
        lblContactNo.Visible = False
        lblDiscount.Visible = False
        lblTotalPrice.Visible = False
        lblDate.Visible = True ' Always visible for rental info
        lblDuration.Visible = True ' Always visible for rental info
        lblLateFees.Visible = False
        lblTotalFees.Visible = False
        lblThankyou.Visible = False
        lblInformation.Visible = False
    End Sub

    ' Set visibility of labels to True/False
    Private Sub SetLabelsVisibility(isVisible As Boolean)
        lblName.Visible = isVisible
        lblEmail.Visible = isVisible
        lblAddress.Visible = isVisible
        lblContactNo.Visible = isVisible
        lblDiscount.Visible = isVisible
        lblTotalPrice.Visible = isVisible
        lblLateFees.Visible = isVisible
        lblTotalFees.Visible = isVisible
    End Sub

    Private Sub InitializeDataGridView()
        ' Clear any existing columns
        DataGridViewItemList.Columns.Clear()

        ' Add columns with AutoSizeMode set to Fill
        Dim colNo As New DataGridViewTextBoxColumn With {
        .Name = "No",
        .HeaderText = "No",
        .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    }
        DataGridViewItemList.Columns.Add(colNo)

        Dim colName As New DataGridViewTextBoxColumn With {
        .Name = "Name",
        .HeaderText = "Name",
        .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    }
        DataGridViewItemList.Columns.Add(colName)

        Dim colPrice As New DataGridViewTextBoxColumn With {
        .Name = "Price",
        .HeaderText = "Price",
        .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    }
        DataGridViewItemList.Columns.Add(colPrice)

        ' Enable row auto-sizing
        DataGridViewItemList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewItemList.RowHeadersVisible = False ' Hide row headers for cleaner appearance
    End Sub


    ' Populate PanelListItem
    Private Sub PopulateDataGridViewItemList()
        ' Clear existing rows
        DataGridViewItemList.Rows.Clear()

        ' Counter for item number
        Dim itemCounter As Integer = 1
        Dim subtotal As Decimal = 0

        ' Loop through CartItemList and add items to the DataGridView
        For Each item In frmCart.CartItemList
            DataGridViewItemList.Rows.Add(itemCounter, item.Name, $"{item.RentalPricePerDay:C2}")
            subtotal += item.RentalPricePerDay ' Add to the subtotal
            itemCounter += 1
        Next

        ' Dynamically adjust row height
        DataGridViewItemList.RowTemplate.Height = (DataGridViewItemList.ClientSize.Height - DataGridViewItemList.ColumnHeadersHeight) \ Math.Max(1, DataGridViewItemList.RowCount)

        ' Update the lblSubTotal with the computed subtotal
        lblSubTotal.Text = $"Subtotal: {subtotal:C2}"

        ' Calculate and display the total with duration
        If activeRentals.Count > 0 Then
            Dim rental = activeRentals.First() ' Assuming rentals exist
            Dim duration As Integer = (rental.DateUntil - rental.DateFrom).Days + 1
            Dim totalWithDuration As Decimal = subtotal * duration
            lblTotal.Text = $"Total for {duration} Day(s): {totalWithDuration:C2}"
            lblTotal.Visible = True ' Ensure visibility
        End If
    End Sub

    Private Sub ApplyFontToDataGridView()
        ' Apply the "Katibeh" font to the entire DataGridView
        DataGridViewItemList.DefaultCellStyle.Font = New Font("Katibeh", 16, FontStyle.Regular)

        ' Apply font to the column headers
        DataGridViewItemList.ColumnHeadersDefaultCellStyle.Font = New Font("Katibeh", 20, FontStyle.Regular)
    End Sub


    ' Form Load Event
    Private Sub frmActive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUser.Text = $"Welcome, {Username}"
        ResetLabelsVisibility() ' Hide labels on load

        ' Initialize the DataGridView structure
        InitializeDataGridView()

        ' Populate the DataGridView with items
        PopulateDataGridViewItemList()

        ApplyFontToDataGridView()

        ' Display rental details in the panel
        If activeRentals.Count > 0 Then
            UpdatePanelRentalList(activeRentals.First())
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
    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click
        ' Set Cart button as active
        Me.Hide()
        frmCostumeDashboard.Show()
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        Me.Hide()
        frmCart.Show()
    End Sub

    Private Sub btnActiveList_Click(sender As Object, e As EventArgs) Handles btnActiveList.Click
        'SetActiveNavButton(btnActiveList)
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Me.Hide()
        frmAbout.Show()
    End Sub

    Private Sub frmActive_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        SetActiveNavButton(btnActiveList)
    End Sub
End Class
