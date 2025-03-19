<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCostumeDashboard
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
        lblUser = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBoxLogo = New PictureBox()
        btnCart = New Button()
        btnAll = New Button()
        btnWomen = New Button()
        btnMen = New Button()
        btnAccessories = New Button()
        Label1 = New Label()
        btnShop = New Button()
        btnActiveList = New Button()
        btnAbout = New Button()
        Label9 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblUser
        ' 
        lblUser.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        lblUser.ForeColor = Color.White
        lblUser.Location = New Point(758, 7)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(494, 35)
        lblUser.TabIndex = 0
        lblUser.Text = "Label1"
        lblUser.TextAlign = ContentAlignment.TopRight
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSalmon
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(190, 140)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1074, 542)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1074, 542)
        Panel2.TabIndex = 0
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.BackgroundImageLayout = ImageLayout.None
        PictureBoxLogo.Image = My.Resources.Resources.logo2
        PictureBoxLogo.Location = New Point(47, 18)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(100, 100)
        PictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxLogo.TabIndex = 3
        PictureBoxLogo.TabStop = False
        ' 
        ' btnCart
        ' 
        btnCart.BackColor = Color.MediumSeaGreen
        btnCart.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnCart.ForeColor = Color.White
        btnCart.Location = New Point(883, 47)
        btnCart.Name = "btnCart"
        btnCart.Size = New Size(119, 51)
        btnCart.TabIndex = 15
        btnCart.Text = "Cart"
        btnCart.TextAlign = ContentAlignment.TopCenter
        btnCart.UseVisualStyleBackColor = False
        ' 
        ' btnAll
        ' 
        btnAll.BackColor = Color.MediumSeaGreen
        btnAll.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnAll.ForeColor = Color.White
        btnAll.Location = New Point(12, 194)
        btnAll.Name = "btnAll"
        btnAll.Size = New Size(160, 51)
        btnAll.TabIndex = 16
        btnAll.Text = "All"
        btnAll.TextAlign = ContentAlignment.TopCenter
        btnAll.UseVisualStyleBackColor = False
        ' 
        ' btnWomen
        ' 
        btnWomen.BackColor = Color.MediumSeaGreen
        btnWomen.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnWomen.ForeColor = Color.White
        btnWomen.Location = New Point(12, 272)
        btnWomen.Name = "btnWomen"
        btnWomen.Size = New Size(160, 51)
        btnWomen.TabIndex = 17
        btnWomen.Text = "Women"
        btnWomen.TextAlign = ContentAlignment.TopCenter
        btnWomen.UseVisualStyleBackColor = False
        ' 
        ' btnMen
        ' 
        btnMen.BackColor = Color.MediumSeaGreen
        btnMen.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnMen.ForeColor = Color.White
        btnMen.Location = New Point(12, 350)
        btnMen.Name = "btnMen"
        btnMen.Size = New Size(160, 51)
        btnMen.TabIndex = 18
        btnMen.Text = "Men"
        btnMen.TextAlign = ContentAlignment.TopCenter
        btnMen.UseVisualStyleBackColor = False
        ' 
        ' btnAccessories
        ' 
        btnAccessories.BackColor = Color.MediumSeaGreen
        btnAccessories.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnAccessories.ForeColor = Color.White
        btnAccessories.Location = New Point(12, 428)
        btnAccessories.Name = "btnAccessories"
        btnAccessories.Size = New Size(160, 51)
        btnAccessories.TabIndex = 19
        btnAccessories.Text = "Accessories"
        btnAccessories.TextAlign = ContentAlignment.TopCenter
        btnAccessories.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(43, 140)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 32)
        Label1.TabIndex = 20
        Label1.Text = "Categories"
        ' 
        ' btnShop
        ' 
        btnShop.BackColor = Color.MediumSeaGreen
        btnShop.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnShop.ForeColor = Color.White
        btnShop.Location = New Point(758, 47)
        btnShop.Name = "btnShop"
        btnShop.Size = New Size(119, 51)
        btnShop.TabIndex = 21
        btnShop.Text = "Shop"
        btnShop.TextAlign = ContentAlignment.TopCenter
        btnShop.UseVisualStyleBackColor = False
        ' 
        ' btnActiveList
        ' 
        btnActiveList.BackColor = Color.MediumSeaGreen
        btnActiveList.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnActiveList.ForeColor = Color.White
        btnActiveList.Location = New Point(1008, 47)
        btnActiveList.Name = "btnActiveList"
        btnActiveList.Size = New Size(119, 51)
        btnActiveList.TabIndex = 22
        btnActiveList.Text = "Active"
        btnActiveList.TextAlign = ContentAlignment.TopCenter
        btnActiveList.UseVisualStyleBackColor = False
        ' 
        ' btnAbout
        ' 
        btnAbout.BackColor = Color.MediumSeaGreen
        btnAbout.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnAbout.ForeColor = Color.White
        btnAbout.Location = New Point(1133, 47)
        btnAbout.Name = "btnAbout"
        btnAbout.Size = New Size(119, 51)
        btnAbout.TabIndex = 23
        btnAbout.Text = "About"
        btnAbout.TextAlign = ContentAlignment.TopCenter
        btnAbout.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Magneto", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(190, 47)
        Label9.Name = "Label9"
        Label9.Size = New Size(165, 41)
        Label9.TabIndex = 24
        Label9.Text = "AniPlay"
        ' 
        ' frmCostumeDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1264, 681)
        Controls.Add(Label9)
        Controls.Add(btnAbout)
        Controls.Add(btnActiveList)
        Controls.Add(btnShop)
        Controls.Add(Label1)
        Controls.Add(btnAccessories)
        Controls.Add(btnMen)
        Controls.Add(btnWomen)
        Controls.Add(btnAll)
        Controls.Add(btnCart)
        Controls.Add(PictureBoxLogo)
        Controls.Add(Panel1)
        Controls.Add(lblUser)
        Name = "frmCostumeDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Costume Dashboard"
        Panel1.ResumeLayout(False)
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUser As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents btnCart As Button
    Friend WithEvents btnAll As Button
    Friend WithEvents btnWomen As Button
    Friend WithEvents btnMen As Button
    Friend WithEvents btnAccessories As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnShop As Button
    Friend WithEvents btnActiveList As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents Label9 As Label
End Class
