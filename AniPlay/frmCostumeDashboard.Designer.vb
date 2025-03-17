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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCostumeDashboard))
        lblUser = New Label()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        btnCart = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblUser
        ' 
        lblUser.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        lblUser.ForeColor = Color.White
        lblUser.Location = New Point(1025, 48)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(227, 70)
        lblUser.TabIndex = 0
        lblUser.Text = "Label1"
        lblUser.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkSalmon
        Panel1.Location = New Point(190, 140)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1074, 542)
        Panel1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(47, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' btnCart
        ' 
        btnCart.BackColor = Color.MediumSeaGreen
        btnCart.Font = New Font("Katibeh", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnCart.ForeColor = Color.White
        btnCart.Location = New Point(900, 44)
        btnCart.Name = "btnCart"
        btnCart.Size = New Size(119, 51)
        btnCart.TabIndex = 15
        btnCart.Text = "Cart"
        btnCart.TextAlign = ContentAlignment.TopCenter
        btnCart.UseVisualStyleBackColor = False
        ' 
        ' frmCostumeDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1264, 681)
        Controls.Add(btnCart)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(lblUser)
        Name = "frmCostumeDashboard"
        Text = "Costume Dashboard"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblUser As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCart As Button
End Class
