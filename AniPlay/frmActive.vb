Public Class frmActive
    ' Property to hold active rentals
    Private activeRentals As List(Of ActiveRental) = New List(Of ActiveRental)()

    ' Load active rentals into the panel
    Public Sub LoadActiveRentals(data As List(Of ActiveRental))
        If activeRentals Is Nothing Then
            activeRentals = New List(Of ActiveRental)()
        End If

        ' Add new rentals to the list
        activeRentals.AddRange(data)

        ' Display updated rentals
        DisplayActiveRentals()
    End Sub

    ' Display active rentals in PanelActiveRental
    Private Sub DisplayActiveRentals()
        PanelActiveRental.Controls.Clear()

        Dim outerMargin As Integer = 20
        Dim panelWidth As Integer = PanelActiveRental.Width - 40
        Dim panelHeight As Integer = 280 ' Adjust height to accommodate all elements
        Dim verticalSpacing As Integer = 20
        Dim contentMargin As Integer = 15

        For Each rental In activeRentals
            ' Main panel for rental
            Dim rentalPanel As New Panel() With {
                .Width = panelWidth,
                .Height = panelHeight,
                .BackColor = Color.White,
                .BorderStyle = BorderStyle.FixedSingle,
                .Padding = New Padding(10),
                .Tag = rental ' Store rental details
            }

            rentalPanel.Top = (activeRentals.IndexOf(rental) * (panelHeight + verticalSpacing)) + outerMargin
            rentalPanel.Left = outerMargin

            ' Add a header for Rental No
            Dim rentalNoLabel As New Label() With {
                .Text = $"Rental No: {rental.RentalNo}",
                .Font = New Font("Katibeh", 20, FontStyle.Regular),
                .ForeColor = Color.Black,
                .AutoSize = False,
                .Width = panelWidth - (2 * contentMargin),
                .Height = 30,
                .TextAlign = ContentAlignment.MiddleLeft,
                .Left = contentMargin
            }
            rentalPanel.Controls.Add(rentalNoLabel)

            ' Add a label for customer info
            Dim customerInfoLabel As New Label() With {
                .Text = $"Customer: {rental.Name} - #{rental.ContactNo}" & vbCrLf & $"Email: {rental.Email}",
                .Font = New Font("Katibeh", 18, FontStyle.Regular),
                .ForeColor = Color.Black,
                .AutoSize = False,
                .Height = 30,
                .Width = panelWidth - (2 * contentMargin),
                .Top = rentalNoLabel.Bottom + 20,
                .Left = contentMargin
            }
            rentalPanel.Controls.Add(customerInfoLabel)

            ' Add rental details
            Dim rentalDetailsLabel As New Label() With {
                .Text = $"Rental Period: {rental.DateFrom.ToShortDateString()} to {rental.DateUntil.ToShortDateString()}" & vbCrLf &
                        $"Duration: {(rental.DateUntil - rental.DateFrom).Days + 1} Day(s)" & vbCrLf &
                        $"Total Price: {rental.TotalPrice:C2}",
                .Font = New Font("Katibeh", 18, FontStyle.Regular),
                .ForeColor = Color.Black,
                .AutoSize = False,
                .Height = 30,
                .Width = panelWidth - (2 * contentMargin),
                .Top = customerInfoLabel.Bottom + 20,
                .Left = contentMargin
            }
            rentalPanel.Controls.Add(rentalDetailsLabel)

            ' Add label for return date
            Dim returnDateLabel As New Label() With {
                .Text = "Return Date:",
                .Font = New Font("Katibeh", 18, FontStyle.Regular),
                .ForeColor = Color.Black,
                .AutoSize = False,
                .Height = 30,
                .Width = 100,
                .Top = rentalDetailsLabel.Bottom + 20,
                .Left = contentMargin
            }
            rentalPanel.Controls.Add(returnDateLabel)

            ' Add DateTimePicker for return date
            Dim dateReturnedPicker As New DateTimePicker() With {
                .Name = "DateTimeDateReturned",
                .Font = New Font("Katibeh", 18, FontStyle.Regular),
                .Width = 300,
                .Top = returnDateLabel.Top,
                .Left = returnDateLabel.Right + 10
            }
            rentalPanel.Controls.Add(dateReturnedPicker)

            ' Add Return Button
            Dim returnButton As New Button() With {
                .Name = "btnReturn",
                .Text = "Return",
                .Font = New Font("Katibeh", 18, FontStyle.Regular),
                .Width = panelWidth,
                .Height = 40,
                .BackColor = Color.MediumSeaGreen,
                .ForeColor = Color.White,
                .FlatStyle = FlatStyle.Flat,
                .Top = dateReturnedPicker.Bottom + 10,
                .Left = contentMargin,
                .Enabled = False
            }
            AddHandler returnButton.Click, Sub(sender, e) HandleReturn(rental, dateReturnedPicker.Value)
            rentalPanel.Controls.Add(returnButton)

            ' Enable return button when a date is selected
            AddHandler dateReturnedPicker.ValueChanged, Sub(sender, e)
                                                            returnButton.Enabled = True
                                                        End Sub

            ' Add the main panel to the container
            PanelActiveRental.Controls.Add(rentalPanel)

            ' Add panel click event to show additional details
            AddHandler rentalPanel.Click, Sub(sender, e) ShowRentalDetails(rentalPanel.Tag)
        Next
    End Sub

    Private Sub HandleReturn(rental As ActiveRental, returnDate As DateTime)
        Dim message As String = $"Rental No: {rental.RentalNo}" & vbCrLf &
                                $"Rental Period: {rental.DateFrom.ToShortDateString()} to {rental.DateUntil.ToShortDateString()}" & vbCrLf &
                                $"Return Date: {returnDate.ToShortDateString()}" & vbCrLf

        If returnDate > rental.DateUntil Then
            Dim daysLate As Integer = (returnDate - rental.DateUntil).Days
            Dim lateFees As Decimal = daysLate * (rental.DailyPrice * 0.05)
            message &= $"Duration of Late Return: {daysLate} Day(s)" & vbCrLf &
                       $"Late Fees: {lateFees:C2}"
        Else
            message &= "No Late Fees Incurred."
        End If

        MessageBox.Show(message, "Return Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowRentalDetails(rentalDetails As ActiveRental)
        MessageBox.Show($"Rental No: {rentalDetails.RentalNo}" & vbCrLf &
                        $"Name: {rentalDetails.Name}" & vbCrLf &
                        $"Email: {rentalDetails.Email}" & vbCrLf &
                        $"Address: {rentalDetails.Address}" & vbCrLf &
                        $"Contact No: {rentalDetails.ContactNo}" & vbCrLf &
                        $"Date Rented: {rentalDetails.DateFrom.ToShortDateString()} to {rentalDetails.DateUntil.ToShortDateString()}" & vbCrLf &
                        $"Duration: {(rentalDetails.DateUntil - rentalDetails.DateFrom).Days + 1} Day(s)" & vbCrLf &
                        $"Subtotal: {rentalDetails.SubTotal:C2}" & vbCrLf &
                        $"Discount: {rentalDetails.Discount:C2}" & vbCrLf &
                        $"Total Price: {rentalDetails.TotalPrice:C2}",
                        "Rental Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
