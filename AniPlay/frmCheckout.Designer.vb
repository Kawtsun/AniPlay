<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckout
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
        PanelCheckoutList = New Panel()
        lblDiscount = New Label()
        Label14 = New Label()
        lblSubTotal = New Label()
        lblDuration = New Label()
        lblFinalTotal = New Label()
        Label12 = New Label()
        btnProceed = New Button()
        txtEmail = New TextBox()
        Label11 = New Label()
        Label10 = New Label()
        LabelTOtalPrice = New Label()
        DateTimeUntil = New DateTimePicker()
        Label8 = New Label()
        DateTimeFrom = New DateTimePicker()
        txtAddress = New TextBox()
        txtContactNo = New TextBox()
        txtName = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        btnAbout = New Button()
        btnActive = New Button()
        btnCart = New Button()
        btnShop = New Button()
        Label1 = New Label()
        Panel1.SuspendLayout()
        PanelCheckoutList.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSalmon
        Panel1.Controls.Add(PanelCheckoutList)
        Panel1.Location = New Point(0, 142)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1263, 542)
        Panel1.TabIndex = 0
        ' 
        ' PanelCheckoutList
        ' 
        PanelCheckoutList.BackColor = Color.Teal
        PanelCheckoutList.Controls.Add(lblDiscount)
        PanelCheckoutList.Controls.Add(Label14)
        PanelCheckoutList.Controls.Add(lblSubTotal)
        PanelCheckoutList.Controls.Add(lblDuration)
        PanelCheckoutList.Controls.Add(lblFinalTotal)
        PanelCheckoutList.Controls.Add(Label12)
        PanelCheckoutList.Controls.Add(btnProceed)
        PanelCheckoutList.Controls.Add(txtEmail)
        PanelCheckoutList.Controls.Add(Label11)
        PanelCheckoutList.Controls.Add(Label10)
        PanelCheckoutList.Controls.Add(LabelTOtalPrice)
        PanelCheckoutList.Controls.Add(DateTimeUntil)
        PanelCheckoutList.Controls.Add(Label8)
        PanelCheckoutList.Controls.Add(DateTimeFrom)
        PanelCheckoutList.Controls.Add(txtAddress)
        PanelCheckoutList.Controls.Add(txtContactNo)
        PanelCheckoutList.Controls.Add(txtName)
        PanelCheckoutList.Controls.Add(Label7)
        PanelCheckoutList.Controls.Add(Label6)
        PanelCheckoutList.Controls.Add(Label5)
        PanelCheckoutList.Controls.Add(Label4)
        PanelCheckoutList.Controls.Add(Label3)
        PanelCheckoutList.Controls.Add(Label2)
        PanelCheckoutList.ForeColor = Color.White
        PanelCheckoutList.Location = New Point(12, 25)
        PanelCheckoutList.Name = "PanelCheckoutList"
        PanelCheckoutList.Size = New Size(1240, 502)
        PanelCheckoutList.TabIndex = 0
        ' 
        ' lblDiscount
        ' 
        lblDiscount.BackColor = Color.White
        lblDiscount.Font = New Font("Katibeh", 18F)
        lblDiscount.ForeColor = Color.Black
        lblDiscount.Location = New Point(766, 310)
        lblDiscount.Name = "lblDiscount"
        lblDiscount.Size = New Size(224, 36)
        lblDiscount.TabIndex = 26
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Katibeh", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label14.Location = New Point(647, 311)
        Label14.Name = "Label14"
        Label14.Size = New Size(97, 35)
        Label14.TabIndex = 25
        Label14.Text = "Discount"
        ' 
        ' lblSubTotal
        ' 
        lblSubTotal.BackColor = Color.White
        lblSubTotal.Font = New Font("Katibeh", 18F)
        lblSubTotal.ForeColor = Color.Black
        lblSubTotal.Location = New Point(766, 262)
        lblSubTotal.Name = "lblSubTotal"
        lblSubTotal.Size = New Size(224, 36)
        lblSubTotal.TabIndex = 24
        ' 
        ' lblDuration
        ' 
        lblDuration.BackColor = Color.White
        lblDuration.Font = New Font("Katibeh", 18F)
        lblDuration.ForeColor = Color.Black
        lblDuration.Location = New Point(766, 212)
        lblDuration.Name = "lblDuration"
        lblDuration.Size = New Size(224, 36)
        lblDuration.TabIndex = 23
        ' 
        ' lblFinalTotal
        ' 
        lblFinalTotal.BackColor = Color.White
        lblFinalTotal.Font = New Font("Katibeh", 18F)
        lblFinalTotal.ForeColor = Color.Black
        lblFinalTotal.Location = New Point(766, 355)
        lblFinalTotal.Name = "lblFinalTotal"
        lblFinalTotal.Size = New Size(224, 36)
        lblFinalTotal.TabIndex = 22
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Katibeh", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label12.Location = New Point(647, 213)
        Label12.Name = "Label12"
        Label12.Size = New Size(98, 35)
        Label12.TabIndex = 18
        Label12.Text = "Duration"
        ' 
        ' btnProceed
        ' 
        btnProceed.BackColor = Color.MediumSeaGreen
        btnProceed.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnProceed.ForeColor = Color.White
        btnProceed.Location = New Point(523, 415)
        btnProceed.Name = "btnProceed"
        btnProceed.Size = New Size(189, 51)
        btnProceed.TabIndex = 7
        btnProceed.Text = "Proceed"
        btnProceed.TextAlign = ContentAlignment.TopCenter
        btnProceed.UseVisualStyleBackColor = False
        ' 
        ' txtEmail
        ' 
        txtEmail.Enabled = False
        txtEmail.Font = New Font("Katibeh", 18F)
        txtEmail.Location = New Point(188, 160)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(384, 36)
        txtEmail.TabIndex = 17
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Katibeh", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label11.Location = New Point(38, 164)
        Label11.Name = "Label11"
        Label11.Size = New Size(68, 35)
        Label11.TabIndex = 16
        Label11.Text = "Email"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Katibeh", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label10.Location = New Point(647, 262)
        Label10.Name = "Label10"
        Label10.Size = New Size(105, 35)
        Label10.TabIndex = 14
        Label10.Text = "Sub Total:"
        ' 
        ' LabelTOtalPrice
        ' 
        LabelTOtalPrice.AutoSize = True
        LabelTOtalPrice.Font = New Font("Katibeh", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        LabelTOtalPrice.Location = New Point(647, 357)
        LabelTOtalPrice.Name = "LabelTOtalPrice"
        LabelTOtalPrice.Size = New Size(114, 35)
        LabelTOtalPrice.TabIndex = 12
        LabelTOtalPrice.Text = "Total Price"
        ' 
        ' DateTimeUntil
        ' 
        DateTimeUntil.Font = New Font("Katibeh", 18F)
        DateTimeUntil.Location = New Point(766, 160)
        DateTimeUntil.Name = "DateTimeUntil"
        DateTimeUntil.Size = New Size(384, 36)
        DateTimeUntil.TabIndex = 11
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Katibeh", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label8.Location = New Point(647, 164)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 35)
        Label8.TabIndex = 10
        Label8.Text = "Until:"
        ' 
        ' DateTimeFrom
        ' 
        DateTimeFrom.Enabled = False
        DateTimeFrom.Font = New Font("Katibeh", 18F)
        DateTimeFrom.Location = New Point(766, 108)
        DateTimeFrom.Name = "DateTimeFrom"
        DateTimeFrom.Size = New Size(384, 36)
        DateTimeFrom.TabIndex = 9
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Katibeh", 18F)
        txtAddress.Location = New Point(188, 212)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(384, 36)
        txtAddress.TabIndex = 8
        ' 
        ' txtContactNo
        ' 
        txtContactNo.Font = New Font("Katibeh", 18F)
        txtContactNo.Location = New Point(188, 262)
        txtContactNo.Name = "txtContactNo"
        txtContactNo.Size = New Size(384, 36)
        txtContactNo.TabIndex = 7
        ' 
        ' txtName
        ' 
        txtName.Enabled = False
        txtName.Font = New Font("Katibeh", 18F)
        txtName.Location = New Point(188, 109)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(384, 36)
        txtName.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Katibeh", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label7.Location = New Point(647, 109)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 35)
        Label7.TabIndex = 5
        Label7.Text = "From:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Katibeh", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label6.Location = New Point(647, 61)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 35)
        Label6.TabIndex = 4
        Label6.Text = "Renting:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Katibeh", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label5.Location = New Point(38, 216)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 35)
        Label5.TabIndex = 3
        Label5.Text = "Address"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Katibeh", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label4.Location = New Point(38, 266)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 35)
        Label4.TabIndex = 2
        Label4.Text = "Contact No."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Katibeh", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label3.Location = New Point(38, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 35)
        Label3.TabIndex = 1
        Label3.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Katibeh", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(34, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(167, 58)
        Label2.TabIndex = 0
        Label2.Text = "Checkout"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo2
        PictureBox1.Location = New Point(46, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' btnAbout
        ' 
        btnAbout.BackColor = Color.MediumSeaGreen
        btnAbout.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnAbout.ForeColor = Color.White
        btnAbout.Location = New Point(1133, 50)
        btnAbout.Name = "btnAbout"
        btnAbout.Size = New Size(119, 51)
        btnAbout.TabIndex = 2
        btnAbout.Text = "About"
        btnAbout.TextAlign = ContentAlignment.TopCenter
        btnAbout.UseVisualStyleBackColor = False
        ' 
        ' btnActive
        ' 
        btnActive.BackColor = Color.MediumSeaGreen
        btnActive.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnActive.ForeColor = Color.White
        btnActive.Location = New Point(1008, 50)
        btnActive.Name = "btnActive"
        btnActive.Size = New Size(119, 51)
        btnActive.TabIndex = 3
        btnActive.Text = "Active"
        btnActive.TextAlign = ContentAlignment.TopCenter
        btnActive.UseVisualStyleBackColor = False
        ' 
        ' btnCart
        ' 
        btnCart.BackColor = Color.MediumSeaGreen
        btnCart.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnCart.ForeColor = Color.White
        btnCart.Location = New Point(883, 50)
        btnCart.Name = "btnCart"
        btnCart.Size = New Size(119, 51)
        btnCart.TabIndex = 4
        btnCart.Text = "Cart"
        btnCart.TextAlign = ContentAlignment.TopCenter
        btnCart.UseVisualStyleBackColor = False
        ' 
        ' btnShop
        ' 
        btnShop.BackColor = Color.MediumSeaGreen
        btnShop.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnShop.ForeColor = Color.White
        btnShop.Location = New Point(758, 50)
        btnShop.Name = "btnShop"
        btnShop.Size = New Size(119, 51)
        btnShop.TabIndex = 5
        btnShop.Text = "Shop"
        btnShop.TextAlign = ContentAlignment.TopCenter
        btnShop.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Magneto", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(177, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 41)
        Label1.TabIndex = 6
        Label1.Text = "AniPlay"
        ' 
        ' frmCheckout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1264, 681)
        Controls.Add(Label1)
        Controls.Add(btnShop)
        Controls.Add(btnCart)
        Controls.Add(btnActive)
        Controls.Add(btnAbout)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "frmCheckout"
        Text = "Checkout"
        Panel1.ResumeLayout(False)
        PanelCheckoutList.ResumeLayout(False)
        PanelCheckoutList.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnActive As Button
    Friend WithEvents btnCart As Button
    Friend WithEvents btnShop As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelCheckoutList As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents DateTimeFrom As DateTimePicker
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents DateTimeUntil As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelTOtalPrice As Label
    Friend WithEvents Label13 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnProceed As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblFinalTotal As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents Label14 As Label

End Class
