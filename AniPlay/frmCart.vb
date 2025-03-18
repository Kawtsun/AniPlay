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
        activeButton.Font = New Font("Katibeh", 20, FontStyle.Regular) ' Bold font for active button
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
    Private Sub frmCart_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        ' Set Shop button as active by default
        SetActiveNavButton(btnCart)
    End Sub
End Class