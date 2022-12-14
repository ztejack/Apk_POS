<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataPelanggan
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TXT1 = New System.Windows.Forms.Label()
        Me.txtkode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn = New Guna.UI2.WinForms.Guna2Button()
        Me.dvgPelanggan = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Perusahaan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Satker = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnama = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.dvgPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXT1
        '
        Me.TXT1.AutoSize = True
        Me.TXT1.BackColor = System.Drawing.Color.Transparent
        Me.TXT1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT1.Location = New System.Drawing.Point(2, 30)
        Me.TXT1.Name = "TXT1"
        Me.TXT1.Size = New System.Drawing.Size(130, 20)
        Me.TXT1.TabIndex = 0
        Me.TXT1.Text = "Kode Pelanggan"
        '
        'txtkode
        '
        Me.txtkode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtkode.DefaultText = ""
        Me.txtkode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtkode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtkode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtkode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtkode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtkode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtkode.ForeColor = System.Drawing.Color.Black
        Me.txtkode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtkode.Location = New System.Drawing.Point(6, 53)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtkode.PlaceholderText = ""
        Me.txtkode.SelectedText = ""
        Me.txtkode.Size = New System.Drawing.Size(632, 36)
        Me.txtkode.TabIndex = 3
        '
        'btn
        '
        Me.btn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn.FillColor = System.Drawing.Color.MediumBlue
        Me.btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn.ForeColor = System.Drawing.Color.White
        Me.btn.Location = New System.Drawing.Point(1136, 104)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(157, 42)
        Me.btn.TabIndex = 2
        Me.btn.Text = "Cari"
        '
        'dvgPelanggan
        '
        Me.dvgPelanggan.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dvgPelanggan.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dvgPelanggan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dvgPelanggan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgPelanggan.BackgroundColor = System.Drawing.Color.White
        Me.dvgPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dvgPelanggan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dvgPelanggan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgPelanggan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dvgPelanggan.ColumnHeadersHeight = 21
        Me.dvgPelanggan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nama, Me.notel, Me.Email, Me.Perusahaan, Me.Satker})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dvgPelanggan.DefaultCellStyle = DataGridViewCellStyle3
        Me.dvgPelanggan.EnableHeadersVisualStyles = False
        Me.dvgPelanggan.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dvgPelanggan.Location = New System.Drawing.Point(6, 163)
        Me.dvgPelanggan.Name = "dvgPelanggan"
        Me.dvgPelanggan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgPelanggan.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dvgPelanggan.RowHeadersVisible = False
        Me.dvgPelanggan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgPelanggan.Size = New System.Drawing.Size(1287, 470)
        Me.dvgPelanggan.TabIndex = 4
        Me.dvgPelanggan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dvgPelanggan.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dvgPelanggan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dvgPelanggan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dvgPelanggan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dvgPelanggan.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dvgPelanggan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dvgPelanggan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Blue
        Me.dvgPelanggan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dvgPelanggan.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dvgPelanggan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dvgPelanggan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dvgPelanggan.ThemeStyle.HeaderStyle.Height = 21
        Me.dvgPelanggan.ThemeStyle.ReadOnly = False
        Me.dvgPelanggan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dvgPelanggan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dvgPelanggan.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dvgPelanggan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dvgPelanggan.ThemeStyle.RowsStyle.Height = 22
        Me.dvgPelanggan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dvgPelanggan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'Nama
        '
        Me.Nama.HeaderText = "Nama"
        Me.Nama.Name = "Nama"
        '
        'notel
        '
        Me.notel.HeaderText = "Nomor Telephone"
        Me.notel.Name = "notel"
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        '
        'Perusahaan
        '
        Me.Perusahaan.HeaderText = "Perusahaan"
        Me.Perusahaan.Name = "Perusahaan"
        '
        'Satker
        '
        Me.Satker.HeaderText = "Satuan Kerja"
        Me.Satker.Name = "Satker"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtnama)
        Me.GroupBox1.Controls.Add(Me.dvgPelanggan)
        Me.GroupBox1.Controls.Add(Me.TXT1)
        Me.GroupBox1.Controls.Add(Me.btn)
        Me.GroupBox1.Controls.Add(Me.txtkode)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1299, 639)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Pelanggan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(651, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nama Pelanggan"
        '
        'txtnama
        '
        Me.txtnama.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnama.DefaultText = ""
        Me.txtnama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtnama.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtnama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnama.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtnama.ForeColor = System.Drawing.Color.Black
        Me.txtnama.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnama.Location = New System.Drawing.Point(655, 53)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnama.PlaceholderText = ""
        Me.txtnama.SelectedText = ""
        Me.txtnama.Size = New System.Drawing.Size(638, 36)
        Me.txtnama.TabIndex = 5
        '
        'DataPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1323, 663)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 217)
        Me.Name = "DataPelanggan"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Pelanggan"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dvgPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TXT1 As Label
    Friend WithEvents txtkode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dvgPelanggan As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents notel As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Perusahaan As DataGridViewTextBoxColumn
    Friend WithEvents Satker As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnama As Guna.UI2.WinForms.Guna2TextBox
End Class
