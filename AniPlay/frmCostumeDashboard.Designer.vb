﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        btnCart = New Button()
        btnAll = New Button()
        btnWomen = New Button()
        btnMen = New Button()
        btnAccessories = New Button()
        Label1 = New Label()
        Panel1.SuspendLayout()
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
        ' frmCostumeDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1264, 681)
        Controls.Add(Label1)
        Controls.Add(btnAccessories)
        Controls.Add(btnMen)
        Controls.Add(btnWomen)
        Controls.Add(btnAll)
        Controls.Add(btnCart)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(lblUser)
        Name = "frmCostumeDashboard"
        StartPosition = FormStartPosition.CenterParent
        Text = "Costume Dashboard"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUser As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCart As Button
    Friend WithEvents btnAll As Button
    Friend WithEvents btnWomen As Button
    Friend WithEvents btnMen As Button
    Friend WithEvents btnAccessories As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
End Class
