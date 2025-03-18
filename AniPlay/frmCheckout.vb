Public Class frmCheckout
    Private checkoutData As List(Of frmCostumeDashboard.CartItem)
    Private rentalDuration As Integer = 1 ' Default duration: 1 day
    Private discount As Decimal = 0 ' Default discount: 0

    ' Load checkout data (cart items and subtotal)
    Public Sub LoadCheckoutData(data As List(Of frmCostumeDashboard.CartItem), initialSubtotal As Decimal)
        checkoutData = data
        rentalDuration = 1 ' Ensure the duration starts at 1 day
        discount = 0 ' Reset any applied discounts
        UpdateSubtotal() ' Initialize the subtotal
    End Sub

    ' Method to dynamically update the subtotal
    Private Sub UpdateSubtotal()
        ' Calculate the total price based on rental duration and any discount
        Dim totalPrice As Decimal = checkoutData.Sum(Function(item) item.RentalPricePerDay * rentalDuration)
        Dim discountedPrice As Decimal = totalPrice - discount

        ' Update the labels dynamically
        If lblSubTotal IsNot Nothing Then
            lblSubTotal.Text = discountedPrice.ToString("C2") ' Display the subtotal with discount applied
        End If

        If lblDuration IsNot Nothing Then
            lblDuration.Text = rentalDuration.ToString() ' Update rental duration display
        End If

        If lblDiscount IsNot Nothing Then
            lblDiscount.Text = discount.ToString("C2") ' Update the discount display
        End If
    End Sub

    ' Event handler for increasing rental duration
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If lblDuration IsNot Nothing Then
            rentalDuration += 1 ' Increase the rental duration
            lblDuration.Text = rentalDuration.ToString() ' Update the label
            UpdateSubtotal() ' Recalculate the subtotal
        End If
    End Sub

    ' Event handler for decreasing rental duration
    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        If lblDuration IsNot Nothing AndAlso rentalDuration > 1 Then
            rentalDuration -= 1 ' Decrease the rental duration (minimum of 1 day)
            lblDuration.Text = rentalDuration.ToString() ' Update the label
            UpdateSubtotal() ' Recalculate the subtotal
        End If
    End Sub

    ' Form load event
    Private Sub frmCheckout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure labels are initialized properly
        If lblDuration IsNot Nothing Then
            lblDuration.Text = rentalDuration.ToString() ' Set the initial duration
        End If
        If lblDiscount IsNot Nothing Then
            lblDiscount.Text = discount.ToString("C2") ' Set the initial discount
        End If
        UpdateSubtotal() ' Initialize the subtotal display
    End Sub
End Class
