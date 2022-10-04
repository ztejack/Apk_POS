<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnDataPelanggan = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDataBarang = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTransaksi = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDataPelanggan
        '
        Me.btnDataPelanggan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDataPelanggan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDataPelanggan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDataPelanggan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDataPelanggan.FillColor = System.Drawing.Color.MediumBlue
        Me.btnDataPelanggan.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnDataPelanggan.ForeColor = System.Drawing.Color.White
        Me.btnDataPelanggan.HoverState.FillColor = System.Drawing.Color.Navy
        Me.btnDataPelanggan.Location = New System.Drawing.Point(104, 281)
        Me.btnDataPelanggan.Name = "btnDataPelanggan"
        Me.btnDataPelanggan.Size = New System.Drawing.Size(249, 92)
        Me.btnDataPelanggan.TabIndex = 0
        Me.btnDataPelanggan.Text = "Data Pelanggan"
        '
        'btnDataBarang
        '
        Me.btnDataBarang.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDataBarang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDataBarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDataBarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDataBarang.FillColor = System.Drawing.Color.MediumBlue
        Me.btnDataBarang.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnDataBarang.ForeColor = System.Drawing.Color.White
        Me.btnDataBarang.HoverState.FillColor = System.Drawing.Color.Navy
        Me.btnDataBarang.Location = New System.Drawing.Point(359, 281)
        Me.btnDataBarang.Name = "btnDataBarang"
        Me.btnDataBarang.ShadowDecoration.Depth = 10
        Me.btnDataBarang.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnDataBarang.Size = New System.Drawing.Size(251, 92)
        Me.btnDataBarang.TabIndex = 1
        Me.btnDataBarang.Text = "Data Barang"
        '
        'btnTransaksi
        '
        Me.btnTransaksi.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTransaksi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTransaksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTransaksi.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTransaksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTransaksi.FillColor = System.Drawing.Color.Blue
        Me.btnTransaksi.FillColor2 = System.Drawing.Color.MediumSpringGreen
        Me.btnTransaksi.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnTransaksi.ForeColor = System.Drawing.Color.White
        Me.btnTransaksi.Location = New System.Drawing.Point(104, 388)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Size = New System.Drawing.Size(506, 78)
        Me.btnTransaksi.TabIndex = 2
        Me.btnTransaksi.Text = "Transaksi"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Guna2PictureBox2.Image = Global.casier.My.Resources.Resources.logo_bukitasam_3x
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(104, 37)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(506, 71)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 5
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2GroupBox1.BorderRadius = 50
        Me.Guna2GroupBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2GroupBox1.Controls.Add(Me.btnDataBarang)
        Me.Guna2GroupBox1.Controls.Add(Me.btnDataPelanggan)
        Me.Guna2GroupBox1.Controls.Add(Me.btnTransaksi)
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(167, 5)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(714, 538)
        Me.Guna2GroupBox1.TabIndex = 6
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(216, 155)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(279, 56)
        Me.Guna2HtmlLabel1.TabIndex = 6
        Me.Guna2HtmlLabel1.Text = "POS MARKERT"
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1043, 617)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDataPelanggan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDataBarang As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTransaksi As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
