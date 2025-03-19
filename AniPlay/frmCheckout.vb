Imports AniPlay.frmActive

Imports System.Drawing.Drawing2D
Public Class frmCheckout
    Public Property CurrentUser As User
    Public Property Username As String
    Public Property Name As String
    Public Property Email As String

    Private checkoutData As List(Of frmCostumeDashboard.CartItem)
    Private baseTotalPrice As Decimal ' Total price for 1 day before discounts
    Private baseDiscountRate As Decimal ' Fixed base discount (5%)
    Private additionalDiscountRate As Decimal = 0 ' Additional discount rate based on duration
    Private rentalDuration As Integer = 1 ' Default duration: 1 day

    ' Load checkout data (cart items, subtotal, and base discount)
    Public Sub LoadCheckoutData(data As List(Of frmCostumeDashboard.CartItem), subtotal As Decimal, baseDiscount As Decimal)
        checkoutData = data
        baseTotalPrice = subtotal
        baseDiscountRate = If(baseDiscount > 0, 0.05, 0) ' Set base discount rate only if discount > 0
        UpdateDisplay() ' Update all labels dynamically
    End Sub


    ' Method to dynamically calculate and update the subtotal, discounts, and final total
    Private Sub UpdateDisplay()
        ' Calculate total price before discounts (scaled by duration)
        Dim totalBeforeDiscounts As Decimal = baseTotalPrice * rentalDuration

        ' Calculate the additional discount rate based on duration
        If rentalDuration >= 10 Then
            additionalDiscountRate = 0.2 ' 20% discount for 10+ days
        ElseIf rentalDuration >= 5 Then
            additionalDiscountRate = 0.1 ' 10% discount for 5–9 days
        Else
            additionalDiscountRate = 0 ' No additional discount for <5 days
        End If

        ' Calculate discounts
        Dim baseDiscountValue As Decimal = totalBeforeDiscounts * baseDiscountRate ' Base discount (5%)
        Dim additionalDiscountValue As Decimal = totalBeforeDiscounts * additionalDiscountRate ' Additional discount
        Dim totalDiscount As Decimal = baseDiscountValue + additionalDiscountValue ' Combined discount
        Dim totalAfterDiscounts As Decimal = totalBeforeDiscounts - totalDiscount ' Final price

        ' Update labels dynamically
        If lblDuration IsNot Nothing Then
            lblDuration.Text = $"{rentalDuration} Day(s)" ' Update duration label
        End If

        If lblSubTotal IsNot Nothing Then
            lblSubTotal.Text = totalBeforeDiscounts.ToString("C2") ' Display total before discounts
        End If

        If lblDiscount IsNot Nothing Then
            Dim totalDiscountPercentage As Decimal = (baseDiscountRate + additionalDiscountRate) * 100
            lblDiscount.Text = $"{totalDiscount.ToString("C2")} | {totalDiscountPercentage}%" ' Display discount details
        End If

        If lblFinalTotal IsNot Nothing Then
            lblFinalTotal.Text = totalAfterDiscounts.ToString("C2") ' Display final total price
        End If
    End Sub

    ' Handle date changes to recalculate the duration and prices
    Private Sub DateTime_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeFrom.ValueChanged, DateTimeUntil.ValueChanged
        If DateTimeUntil.Value >= DateTimeFrom.Value Then
            rentalDuration = (DateTimeUntil.Value - DateTimeFrom.Value).Days + 1 ' Calculate duration (inclusive)
            UpdateDisplay() ' Recalculate and update everything
        Else
            ' Validation: Ensure the return date is not earlier than the start date
            MessageBox.Show("The return date must be later than or equal to the start date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DateTimeUntil.Value = DateTimeFrom.Value ' Reset the return date to match the start date
        End If
    End Sub

    ' Form load event
    Private Sub frmCheckout_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If Not String.IsNullOrEmpty(Username) Then
            lblUser.Text = $"Welcome, {Username}"
            lblName.Text = Name
            lblEmail.Text = Email
        Else
            lblUser.Text = "Welcome, User!"
        End If

        MakePictureBoxCircular(PictureBoxLogo)

        ' Initialize the date pickers
        DateTimeFrom.Value = DateTime.Now.Date ' Default to today's date
        DateTimeUntil.Value = DateTime.Now.Date ' Default to today's date

        ' Initialize labels
        lblDuration.Text = $"{rentalDuration} Day(s)" ' Default duration to 1 day
        lblDiscount.Text = "₱0.00 | 0%" ' Default to no discount
        lblFinalTotal.Text = baseTotalPrice.ToString("C2") ' Initialize with subtotal

        ' Update display
        UpdateDisplay()
    End Sub

    ' Event for Proceed button
    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        ' Create an instance of frmActive
        Dim frmActiveInstance As New frmActive()

        frmActiveInstance.Username = Username ' Pass the Username to frmActive
        frmActiveInstance.Email = Email ' Pass the Email (optional)
        frmActiveInstance.CurrentUser = CurrentUser ' Optional: If you're using the full user object

        ' Prepare data to pass to frmActive
        Dim rentalDetails As New ActiveRental With {
            .RentalNo = Guid.NewGuid().ToString().Substring(0, 8), ' Generate a unique Rental No
            .Name = Name,
            .Email = Email,
            .Address = txtAddress.Text, ' Replace with actual data
            .ContactNo = txtContactNo.Text, ' Replace with actual data
            .DateFrom = DateTimeFrom.Value,
            .DateUntil = DateTimeUntil.Value,
            .SubTotal = baseTotalPrice,
            .Discount = baseTotalPrice * (baseDiscountRate + additionalDiscountRate),
            .TotalPrice = baseTotalPrice * rentalDuration - baseTotalPrice * (baseDiscountRate + additionalDiscountRate),
            .DailyPrice = baseTotalPrice / rentalDuration ' Calculate daily price
        }

        ' Send data to frmActive
        frmActiveInstance.LoadActiveRentals(New List(Of ActiveRental) From {rentalDetails})

        ' Show frmActive
        frmActiveInstance.Show()

        ' Optionally, hide or close frmCheckout
        Me.Hide()
    End Sub

    Private Sub MakePictureBoxCircular(pictureBox As PictureBox)
        ' Create a circular GraphicsPath
        Dim circlePath As New GraphicsPath()
        circlePath.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height)

        ' Set the region of the PictureBox to the circular path
        pictureBox.Region = New Region(circlePath)
    End Sub


End Class
