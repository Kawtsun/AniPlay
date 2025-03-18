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
        Panel3 = New Panel()
        btnReturn = New Button()
        Label4 = New Label()
        DateTimeDateReturned = New DateTimePicker()
        lblCostumeName = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        btnAbout = New Button()
        btnActive = New Button()
        btnCart = New Button()
        btnShop = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
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
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(14, 17)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1240, 502)
        Panel2.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(btnReturn)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(DateTimeDateReturned)
        Panel3.Controls.Add(lblCostumeName)
        Panel3.Location = New Point(14, 75)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1212, 118)
        Panel3.TabIndex = 1
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.MediumSeaGreen
        btnReturn.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnReturn.ForeColor = Color.White
        btnReturn.Location = New Point(1038, 34)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(142, 51)
        btnReturn.TabIndex = 7
        btnReturn.Text = "Return"
        btnReturn.TextAlign = ContentAlignment.TopCenter
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Katibeh", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label4.Location = New Point(450, 46)
        Label4.Name = "Label4"
        Label4.Size = New Size(169, 38)
        Label4.TabIndex = 2
        Label4.Text = "Date Returned:"
        ' 
        ' DateTimeDateReturned
        ' 
        DateTimeDateReturned.CalendarFont = New Font("Katibeh", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        DateTimeDateReturned.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimeDateReturned.Location = New Point(634, 45)
        DateTimeDateReturned.Name = "DateTimeDateReturned"
        DateTimeDateReturned.Size = New Size(398, 39)
        DateTimeDateReturned.TabIndex = 1
        ' 
        ' lblCostumeName
        ' 
        lblCostumeName.AutoSize = True
        lblCostumeName.Font = New Font("Katibeh", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        lblCostumeName.Location = New Point(50, 33)
        lblCostumeName.Name = "lblCostumeName"
        lblCostumeName.Size = New Size(168, 38)
        lblCostumeName.TabIndex = 0
        lblCostumeName.Text = "Costume Name"
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
        PictureBox1.Location = New Point(46, 25)
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
        Label1.Location = New Point(183, 52)
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
        btnAbout.Location = New Point(1133, 52)
        btnAbout.Name = "btnAbout"
        btnAbout.Size = New Size(119, 51)
        btnAbout.TabIndex = 3
        btnAbout.Text = "About"
        btnAbout.TextAlign = ContentAlignment.TopCenter
        btnAbout.UseVisualStyleBackColor = False
        ' 
        ' btnActive
        ' 
        btnActive.BackColor = Color.MediumSeaGreen
        btnActive.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnActive.ForeColor = Color.White
        btnActive.Location = New Point(1008, 52)
        btnActive.Name = "btnActive"
        btnActive.Size = New Size(119, 51)
        btnActive.TabIndex = 4
        btnActive.Text = "Active"
        btnActive.TextAlign = ContentAlignment.TopCenter
        btnActive.UseVisualStyleBackColor = False
        ' 
        ' btnCart
        ' 
        btnCart.BackColor = Color.MediumSeaGreen
        btnCart.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnCart.ForeColor = Color.White
        btnCart.Location = New Point(883, 52)
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
        btnShop.Location = New Point(758, 52)
        btnShop.Name = "btnShop"
        btnShop.Size = New Size(119, 51)
        btnShop.TabIndex = 6
        btnShop.Text = "Shop"
        btnShop.TextAlign = ContentAlignment.TopCenter
        btnShop.UseVisualStyleBackColor = False
        ' 
        ' frmActive
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1264, 681)
        Controls.Add(btnShop)
        Controls.Add(btnCart)
        Controls.Add(btnActive)
        Controls.Add(btnAbout)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "frmActive"
        Text = "Active Rental"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnActive As Button
    Friend WithEvents btnCart As Button
    Friend WithEvents btnShop As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblCostumeName As Label
    Friend WithEvents DateTimeDateReturned As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents btnReturn As Button
End Class
