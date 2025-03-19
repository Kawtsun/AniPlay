<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCart
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
        Panel2 = New Panel()
        PanelCartList = New Panel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBoxLogo = New PictureBox()
        Label9 = New Label()
        btnAbout = New Button()
        btnActiveList = New Button()
        btnShop = New Button()
        btnCart = New Button()
        lblUser = New Label()
        PictureBox3 = New PictureBox()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.BackColor = Color.DarkSalmon
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(PanelCartList)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(-1, 139)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1263, 542)
        Panel2.TabIndex = 1
        ' 
        ' PanelCartList
        ' 
        PanelCartList.AutoScroll = True
        PanelCartList.BackColor = Color.Teal
        PanelCartList.Location = New Point(291, 32)
        PanelCartList.Name = "PanelCartList"
        PanelCartList.Size = New Size(675, 496)
        PanelCartList.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.pngwing_com_8_
        PictureBox1.Location = New Point(11, 232)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(274, 305)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.pngwing_com_6_
        PictureBox2.Location = New Point(981, 220)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(267, 317)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.BackgroundImageLayout = ImageLayout.None
        PictureBoxLogo.Image = My.Resources.Resources.logo2
        PictureBoxLogo.Location = New Point(47, 18)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(100, 100)
        PictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxLogo.TabIndex = 4
        PictureBoxLogo.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Magneto", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(190, 47)
        Label9.Name = "Label9"
        Label9.Size = New Size(165, 41)
        Label9.TabIndex = 25
        Label9.Text = "AniPlay"
        ' 
        ' btnAbout
        ' 
        btnAbout.BackColor = Color.MediumSeaGreen
        btnAbout.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnAbout.ForeColor = Color.White
        btnAbout.Location = New Point(1133, 47)
        btnAbout.Name = "btnAbout"
        btnAbout.Size = New Size(119, 51)
        btnAbout.TabIndex = 29
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
        btnActiveList.TabIndex = 28
        btnActiveList.Text = "Active"
        btnActiveList.TextAlign = ContentAlignment.TopCenter
        btnActiveList.UseVisualStyleBackColor = False
        ' 
        ' btnShop
        ' 
        btnShop.BackColor = Color.MediumSeaGreen
        btnShop.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnShop.ForeColor = Color.White
        btnShop.Location = New Point(758, 47)
        btnShop.Name = "btnShop"
        btnShop.Size = New Size(119, 51)
        btnShop.TabIndex = 27
        btnShop.Text = "Shop"
        btnShop.TextAlign = ContentAlignment.TopCenter
        btnShop.UseVisualStyleBackColor = False
        ' 
        ' btnCart
        ' 
        btnCart.BackColor = Color.MediumSeaGreen
        btnCart.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnCart.ForeColor = Color.White
        btnCart.Location = New Point(883, 47)
        btnCart.Name = "btnCart"
        btnCart.Size = New Size(119, 51)
        btnCart.TabIndex = 26
        btnCart.Text = "Cart"
        btnCart.TextAlign = ContentAlignment.TopCenter
        btnCart.UseVisualStyleBackColor = False
        ' 
        ' lblUser
        ' 
        lblUser.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        lblUser.ForeColor = Color.White
        lblUser.Location = New Point(758, 7)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(494, 35)
        lblUser.TabIndex = 30
        lblUser.Text = "Label1"
        lblUser.TextAlign = ContentAlignment.TopRight
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.frieren1212
        PictureBox3.Location = New Point(309, -4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(475, 147)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 31
        PictureBox3.TabStop = False
        ' 
        ' frmCart
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1264, 681)
        Controls.Add(lblUser)
        Controls.Add(btnAbout)
        Controls.Add(btnActiveList)
        Controls.Add(btnShop)
        Controls.Add(btnCart)
        Controls.Add(Label9)
        Controls.Add(PictureBoxLogo)
        Controls.Add(Panel2)
        Controls.Add(PictureBox3)
        Name = "frmCart"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cart"
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnActiveList As Button
    Friend WithEvents btnShop As Button
    Friend WithEvents btnCart As Button
    Friend WithEvents lblUser As Label
    Friend WithEvents PanelCartList As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
