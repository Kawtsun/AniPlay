<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActive
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Panel2 = New Panel()
        PanelActiveRental = New Panel()
        PanelRentalList = New Panel()
        lblDuration = New Label()
        lblDate = New Label()
        btnReturn = New Button()
        datePickerReturn = New DateTimePicker()
        lblRentalNo = New Label()
        lblInformation = New Label()
        lblDiscount = New Label()
        lblTotalPrice = New Label()
        lblContactNo = New Label()
        lblAddress = New Label()
        lblEmail = New Label()
        lblName = New Label()
        PanelListItem = New Panel()
        lblTotal = New Label()
        Label3 = New Label()
        DataGridViewItemList = New DataGridView()
        lblSubTotal = New Label()
        lblTotalFees = New Label()
        lblLateFees = New Label()
        lblThankyou = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        btnAbout = New Button()
        btnActiveList = New Button()
        btnCart = New Button()
        btnShop = New Button()
        lblUser = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        PanelActiveRental.SuspendLayout()
        PanelRentalList.SuspendLayout()
        PanelListItem.SuspendLayout()
        CType(DataGridViewItemList, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSalmon
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(-2, 140)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1269, 542)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Teal
        Panel2.Controls.Add(PanelActiveRental)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(89, 20)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1087, 496)
        Panel2.TabIndex = 0
        ' 
        ' PanelActiveRental
        ' 
        PanelActiveRental.BackColor = Color.White
        PanelActiveRental.Controls.Add(PanelRentalList)
        PanelActiveRental.Controls.Add(lblInformation)
        PanelActiveRental.Controls.Add(lblDiscount)
        PanelActiveRental.Controls.Add(lblTotalPrice)
        PanelActiveRental.Controls.Add(lblContactNo)
        PanelActiveRental.Controls.Add(lblAddress)
        PanelActiveRental.Controls.Add(lblEmail)
        PanelActiveRental.Controls.Add(lblName)
        PanelActiveRental.Controls.Add(PanelListItem)
        PanelActiveRental.Controls.Add(lblTotalFees)
        PanelActiveRental.Controls.Add(lblLateFees)
        PanelActiveRental.Controls.Add(lblThankyou)
        PanelActiveRental.Location = New Point(35, 69)
        PanelActiveRental.Name = "PanelActiveRental"
        PanelActiveRental.Size = New Size(1018, 406)
        PanelActiveRental.TabIndex = 1
        ' 
        ' PanelRentalList
        ' 
        PanelRentalList.BorderStyle = BorderStyle.FixedSingle
        PanelRentalList.Controls.Add(lblDuration)
        PanelRentalList.Controls.Add(lblDate)
        PanelRentalList.Controls.Add(btnReturn)
        PanelRentalList.Controls.Add(datePickerReturn)
        PanelRentalList.Controls.Add(lblRentalNo)
        PanelRentalList.Location = New Point(20, 15)
        PanelRentalList.Name = "PanelRentalList"
        PanelRentalList.Size = New Size(584, 192)
        PanelRentalList.TabIndex = 19
        ' 
        ' lblDuration
        ' 
        lblDuration.Font = New Font("Katibeh", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        lblDuration.ForeColor = Color.Black
        lblDuration.Location = New Point(13, 83)
        lblDuration.Name = "lblDuration"
        lblDuration.Size = New Size(237, 29)
        lblDuration.TabIndex = 14
        lblDuration.Text = "Duration"
        ' 
        ' lblDate
        ' 
        lblDate.Font = New Font("Katibeh", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        lblDate.ForeColor = Color.Black
        lblDate.Location = New Point(297, 22)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(269, 59)
        lblDate.TabIndex = 13
        lblDate.Text = "Date"
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.MediumSeaGreen
        btnReturn.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnReturn.ForeColor = Color.White
        btnReturn.Location = New Point(403, 122)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(163, 51)
        btnReturn.TabIndex = 7
        btnReturn.Text = "Return"
        btnReturn.TextAlign = ContentAlignment.TopCenter
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' datePickerReturn
        ' 
        datePickerReturn.Font = New Font("Katibeh", 18F)
        datePickerReturn.Location = New Point(13, 137)
        datePickerReturn.Name = "datePickerReturn"
        datePickerReturn.Size = New Size(384, 36)
        datePickerReturn.TabIndex = 12
        ' 
        ' lblRentalNo
        ' 
        lblRentalNo.AutoSize = True
        lblRentalNo.Font = New Font("Katibeh", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        lblRentalNo.ForeColor = Color.Black
        lblRentalNo.Location = New Point(13, 11)
        lblRentalNo.Name = "lblRentalNo"
        lblRentalNo.Size = New Size(125, 42)
        lblRentalNo.TabIndex = 2
        lblRentalNo.Text = "Rental No"
        ' 
        ' lblInformation
        ' 
        lblInformation.Font = New Font("Katibeh", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        lblInformation.ForeColor = Color.MediumSeaGreen
        lblInformation.Location = New Point(20, 204)
        lblInformation.Name = "lblInformation"
        lblInformation.Size = New Size(251, 32)
        lblInformation.TabIndex = 18
        lblInformation.Text = "Information:"
        lblInformation.TextAlign = ContentAlignment.MiddleLeft
        lblInformation.Visible = False
        ' 
        ' lblDiscount
        ' 
        lblDiscount.Font = New Font("Katibeh", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        lblDiscount.ForeColor = Color.Black
        lblDiscount.Location = New Point(318, 236)
        lblDiscount.Name = "lblDiscount"
        lblDiscount.Size = New Size(251, 32)
        lblDiscount.TabIndex = 17
        lblDiscount.Text = "Discount:"
        lblDiscount.TextAlign = ContentAlignment.MiddleLeft
        lblDiscount.Visible = False
        ' 
        ' lblTotalPrice
        ' 
        lblTotalPrice.Font = New Font("Katibeh", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        lblTotalPrice.ForeColor = Color.Black
        lblTotalPrice.Location = New Point(318, 268)
        lblTotalPrice.Name = "lblTotalPrice"
        lblTotalPrice.Size = New Size(251, 32)
        lblTotalPrice.TabIndex = 16
        lblTotalPrice.Text = "Total Price:"
        lblTotalPrice.TextAlign = ContentAlignment.MiddleLeft
        lblTotalPrice.Visible = False
        ' 
        ' lblContactNo
        ' 
        lblContactNo.Font = New Font("Katibeh", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        lblContactNo.ForeColor = Color.Black
        lblContactNo.Location = New Point(20, 332)
        lblContactNo.Name = "lblContactNo"
        lblContactNo.Size = New Size(251, 32)
        lblContactNo.TabIndex = 15
        lblContactNo.Text = "Contact No:"
        lblContactNo.TextAlign = ContentAlignment.MiddleLeft
        lblContactNo.Visible = False
        ' 
        ' lblAddress
        ' 
        lblAddress.Font = New Font("Katibeh", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        lblAddress.ForeColor = Color.Black
        lblAddress.Location = New Point(20, 300)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(251, 32)
        lblAddress.TabIndex = 14
        lblAddress.Text = "Address:"
        lblAddress.TextAlign = ContentAlignment.MiddleLeft
        lblAddress.Visible = False
        ' 
        ' lblEmail
        ' 
        lblEmail.Font = New Font("Katibeh", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        lblEmail.ForeColor = Color.Black
        lblEmail.Location = New Point(20, 268)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(251, 32)
        lblEmail.TabIndex = 13
        lblEmail.Text = "Email:"
        lblEmail.TextAlign = ContentAlignment.MiddleLeft
        lblEmail.Visible = False
        ' 
        ' lblName
        ' 
        lblName.Font = New Font("Katibeh", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        lblName.ForeColor = Color.Black
        lblName.Location = New Point(20, 236)
        lblName.Name = "lblName"
        lblName.Size = New Size(251, 32)
        lblName.TabIndex = 12
        lblName.Text = "Name:"
        lblName.TextAlign = ContentAlignment.MiddleLeft
        lblName.Visible = False
        ' 
        ' PanelListItem
        ' 
        PanelListItem.BackColor = Color.DarkSalmon
        PanelListItem.Controls.Add(lblTotal)
        PanelListItem.Controls.Add(Label3)
        PanelListItem.Controls.Add(DataGridViewItemList)
        PanelListItem.Controls.Add(lblSubTotal)
        PanelListItem.Location = New Point(621, 0)
        PanelListItem.Name = "PanelListItem"
        PanelListItem.Size = New Size(397, 406)
        PanelListItem.TabIndex = 11
        ' 
        ' lblTotal
        ' 
        lblTotal.Font = New Font("Katibeh", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        lblTotal.ForeColor = Color.Black
        lblTotal.Location = New Point(15, 331)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(183, 65)
        lblTotal.TabIndex = 23
        lblTotal.Text = "Total:"
        lblTotal.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Katibeh", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(15, 3)
        Label3.Name = "Label3"
        Label3.Size = New Size(251, 32)
        Label3.TabIndex = 22
        Label3.Text = "Cosplay List"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DataGridViewItemList
        ' 
        DataGridViewItemList.AllowUserToAddRows = False
        DataGridViewItemList.AllowUserToDeleteRows = False
        DataGridViewItemList.AllowUserToResizeColumns = False
        DataGridViewItemList.AllowUserToResizeRows = False
        DataGridViewItemList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewItemList.Location = New Point(15, 38)
        DataGridViewItemList.Name = "DataGridViewItemList"
        DataGridViewItemList.ShowEditingIcon = False
        DataGridViewItemList.Size = New Size(369, 281)
        DataGridViewItemList.TabIndex = 21
        ' 
        ' lblSubTotal
        ' 
        lblSubTotal.Font = New Font("Katibeh", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        lblSubTotal.ForeColor = Color.Black
        lblSubTotal.Location = New Point(215, 332)
        lblSubTotal.Name = "lblSubTotal"
        lblSubTotal.Size = New Size(169, 64)
        lblSubTotal.TabIndex = 20
        lblSubTotal.Text = "Sub Total:"
        lblSubTotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblTotalFees
        ' 
        lblTotalFees.Font = New Font("Katibeh", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        lblTotalFees.ForeColor = Color.Black
        lblTotalFees.Location = New Point(318, 332)
        lblTotalFees.Name = "lblTotalFees"
        lblTotalFees.Size = New Size(251, 32)
        lblTotalFees.TabIndex = 10
        lblTotalFees.Text = "Total Amount Paid:"
        lblTotalFees.TextAlign = ContentAlignment.MiddleLeft
        lblTotalFees.Visible = False
        ' 
        ' lblLateFees
        ' 
        lblLateFees.Font = New Font("Katibeh", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        lblLateFees.ForeColor = Color.Black
        lblLateFees.Location = New Point(318, 300)
        lblLateFees.Name = "lblLateFees"
        lblLateFees.Size = New Size(251, 32)
        lblLateFees.TabIndex = 9
        lblLateFees.Text = "Late Fees:"
        lblLateFees.TextAlign = ContentAlignment.MiddleLeft
        lblLateFees.Visible = False
        ' 
        ' lblThankyou
        ' 
        lblThankyou.Font = New Font("Katibeh", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        lblThankyou.ForeColor = Color.Red
        lblThankyou.Location = New Point(120, 364)
        lblThankyou.Name = "lblThankyou"
        lblThankyou.Size = New Size(359, 32)
        lblThankyou.TabIndex = 8
        lblThankyou.Text = "Thank you! for shopping with us. Come back again."
        lblThankyou.TextAlign = ContentAlignment.MiddleCenter
        lblThankyou.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Katibeh", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(14, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(162, 42)
        Label2.TabIndex = 0
        Label2.Text = "Active Rental"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo2
        PictureBox1.Location = New Point(47, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Magneto", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(190, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 41)
        Label1.TabIndex = 2
        Label1.Text = "AniPlay"
        ' 
        ' btnAbout
        ' 
        btnAbout.BackColor = Color.MediumSeaGreen
        btnAbout.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnAbout.ForeColor = Color.White
        btnAbout.Location = New Point(1133, 47)
        btnAbout.Name = "btnAbout"
        btnAbout.Size = New Size(119, 51)
        btnAbout.TabIndex = 3
        btnAbout.Text = "About"
        btnAbout.TextAlign = ContentAlignment.TopCenter
        btnAbout.UseVisualStyleBackColor = False
        ' 
        ' btnActiveList
        ' 
        btnActiveList.BackColor = Color.MediumSeaGreen
        btnActiveList.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnActiveList.ForeColor = Color.White
        btnActiveList.Location = New Point(1008, 47)
        btnActiveList.Name = "btnActiveList"
        btnActiveList.Size = New Size(119, 51)
        btnActiveList.TabIndex = 4
        btnActiveList.Text = "Active"
        btnActiveList.TextAlign = ContentAlignment.TopCenter
        btnActiveList.UseVisualStyleBackColor = False
        ' 
        ' btnCart
        ' 
        btnCart.BackColor = Color.MediumSeaGreen
        btnCart.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnCart.ForeColor = Color.White
        btnCart.Location = New Point(883, 47)
        btnCart.Name = "btnCart"
        btnCart.Size = New Size(119, 51)
        btnCart.TabIndex = 5
        btnCart.Text = "Cart"
        btnCart.TextAlign = ContentAlignment.TopCenter
        btnCart.UseVisualStyleBackColor = False
        ' 
        ' btnShop
        ' 
        btnShop.BackColor = Color.MediumSeaGreen
        btnShop.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnShop.ForeColor = Color.White
        btnShop.Location = New Point(758, 47)
        btnShop.Name = "btnShop"
        btnShop.Size = New Size(119, 51)
        btnShop.TabIndex = 6
        btnShop.Text = "Shop"
        btnShop.TextAlign = ContentAlignment.TopCenter
        btnShop.UseVisualStyleBackColor = False
        ' 
        ' lblUser
        ' 
        lblUser.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        lblUser.ForeColor = Color.White
        lblUser.Location = New Point(758, 7)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(494, 35)
        lblUser.TabIndex = 1
        lblUser.Text = "Label1"
        lblUser.TextAlign = ContentAlignment.TopRight
        ' 
        ' frmActive
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1264, 681)
        Controls.Add(lblUser)
        Controls.Add(btnShop)
        Controls.Add(btnCart)
        Controls.Add(btnActiveList)
        Controls.Add(btnAbout)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "frmActive"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Active Rental"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        PanelActiveRental.ResumeLayout(False)
        PanelRentalList.ResumeLayout(False)
        PanelRentalList.PerformLayout()
        PanelListItem.ResumeLayout(False)
        CType(DataGridViewItemList, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnActiveList As Button
    Friend WithEvents btnCart As Button
    Friend WithEvents btnShop As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelActiveRental As Panel
    Friend WithEvents lblThankyou As Label
    Friend WithEvents lblLateFees As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblTotalFees As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblName As Label
    Friend WithEvents PanelListItem As Panel
    Friend WithEvents lblContactNo As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents lblInformation As Label
    Friend WithEvents PanelRentalList As Panel
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblRentalNo As Label
    Friend WithEvents datePickerReturn As DateTimePicker
    Friend WithEvents lblDate As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblDuration As Label
    Friend WithEvents DataGridViewItemList As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotal As Label
End Class
