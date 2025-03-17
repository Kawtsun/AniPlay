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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCart))
        Panel1 = New Panel()
        Label1 = New Label()
        btnCart = New Button()
        btnShop = New Button()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        btnCheckout = New Button()
        Panel4 = New Panel()
        Button4 = New Button()
        PictureBox3 = New PictureBox()
        Panel3 = New Panel()
        lblDescription = New Label()
        btnRemove = New Button()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnCart)
        Panel1.Controls.Add(btnShop)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(0, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1265, 170)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(1053, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 32)
        Label1.TabIndex = 4
        Label1.Text = "Welcome User!"
        ' 
        ' btnCart
        ' 
        btnCart.BackColor = Color.MediumSeaGreen
        btnCart.Font = New Font("Katibeh", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnCart.ForeColor = Color.White
        btnCart.Location = New Point(864, 59)
        btnCart.Name = "btnCart"
        btnCart.Size = New Size(169, 51)
        btnCart.TabIndex = 3
        btnCart.Text = "Cart"
        btnCart.TextAlign = ContentAlignment.TopCenter
        btnCart.UseVisualStyleBackColor = False
        ' 
        ' btnShop
        ' 
        btnShop.BackColor = Color.MediumSeaGreen
        btnShop.Font = New Font("Katibeh", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnShop.ForeColor = Color.White
        btnShop.Location = New Point(686, 59)
        btnShop.Name = "btnShop"
        btnShop.Size = New Size(159, 51)
        btnShop.TabIndex = 2
        btnShop.Text = "Shop"
        btnShop.TextAlign = ContentAlignment.TopCenter
        btnShop.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(61, 30)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(104, 105)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Teal
        Panel2.Controls.Add(btnCheckout)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(32, 185)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1196, 491)
        Panel2.TabIndex = 1
        ' 
        ' btnCheckout
        ' 
        btnCheckout.BackColor = Color.MediumSeaGreen
        btnCheckout.Font = New Font("Katibeh", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnCheckout.ForeColor = Color.White
        btnCheckout.Location = New Point(509, 433)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.Size = New Size(159, 51)
        btnCheckout.TabIndex = 5
        btnCheckout.Text = "Checkout"
        btnCheckout.TextAlign = ContentAlignment.TopCenter
        btnCheckout.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.MintCream
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(Button4)
        Panel4.Controls.Add(PictureBox3)
        Panel4.Location = New Point(47, 252)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1094, 166)
        Panel4.TabIndex = 1
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Tomato
        Button4.Font = New Font("Katibeh", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(918, 101)
        Button4.Name = "Button4"
        Button4.Size = New Size(159, 51)
        Button4.TabIndex = 6
        Button4.Text = "Remove"
        Button4.TextAlign = ContentAlignment.TopCenter
        Button4.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Location = New Point(32, 30)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(126, 113)
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.MintCream
        Panel3.Controls.Add(lblDescription)
        Panel3.Controls.Add(btnRemove)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Location = New Point(47, 66)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1094, 166)
        Panel3.TabIndex = 0
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.BackColor = SystemColors.Window
        lblDescription.Font = New Font("Katibeh", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        lblDescription.Location = New Point(179, 27)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(167, 25)
        lblDescription.TabIndex = 6
        lblDescription.Text = "Descriptions bla bla bla"
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = Color.Tomato
        btnRemove.Font = New Font("Katibeh", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnRemove.ForeColor = Color.White
        btnRemove.Location = New Point(918, 102)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(159, 51)
        btnRemove.TabIndex = 5
        btnRemove.Text = "Remove"
        btnRemove.TextAlign = ContentAlignment.TopCenter
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(32, 27)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(126, 116)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Window
        Label2.Font = New Font("Katibeh", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label2.Location = New Point(179, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(167, 25)
        Label2.TabIndex = 7
        Label2.Text = "Descriptions bla bla bla"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' frmCart
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSalmon
        ClientSize = New Size(1264, 681)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "frmCart"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCart As Button
    Friend WithEvents btnShop As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents lblDescription As Label
    Friend WithEvents btnCheckout As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
