<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransaksi
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransaksi))
        Me.dvgtampil = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama_Barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ttl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtjumlahB = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnTambah = New Guna.UI2.WinForms.Guna2Button()
        Me.txttotalB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txthargaB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtnamaB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtkodeB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txttgltransaksi = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IdTransaksi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnBayar = New Guna.UI2.WinForms.Guna2Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtnamapelanggan = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtidpelanggan = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txttotalbyr = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbayar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtkembalian = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbxmetodebyr = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.btncancle = New Guna.UI2.WinForms.Guna2Button()
        Me.prnDocument = New System.Drawing.Printing.PrintDocument()
        Me.prnPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.prnDialog = New System.Windows.Forms.PrintDialog()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dvgtampil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtjumlahB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dvgtampil
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.dvgtampil.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dvgtampil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dvgtampil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgtampil.BackgroundColor = System.Drawing.Color.White
        Me.dvgtampil.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dvgtampil.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvgtampil.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dvgtampil.ColumnHeadersHeight = 4
        Me.dvgtampil.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kode, Me.Nama_Barang, Me.harga, Me.jumlah, Me.ttl})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dvgtampil.DefaultCellStyle = DataGridViewCellStyle8
        Me.dvgtampil.EnableHeadersVisualStyles = False
        Me.dvgtampil.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dvgtampil.Location = New System.Drawing.Point(13, 275)
        Me.dvgtampil.Name = "dvgtampil"
        Me.dvgtampil.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dvgtampil.RowHeadersVisible = False
        Me.dvgtampil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgtampil.Size = New System.Drawing.Size(1297, 211)
        Me.dvgtampil.TabIndex = 0
        Me.dvgtampil.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dvgtampil.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dvgtampil.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dvgtampil.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dvgtampil.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dvgtampil.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dvgtampil.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dvgtampil.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dvgtampil.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.dvgtampil.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dvgtampil.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dvgtampil.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dvgtampil.ThemeStyle.HeaderStyle.Height = 4
        Me.dvgtampil.ThemeStyle.ReadOnly = False
        Me.dvgtampil.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dvgtampil.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dvgtampil.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dvgtampil.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dvgtampil.ThemeStyle.RowsStyle.Height = 22
        Me.dvgtampil.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dvgtampil.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Kode
        '
        Me.Kode.HeaderText = "Kode"
        Me.Kode.Name = "Kode"
        '
        'Nama_Barang
        '
        Me.Nama_Barang.HeaderText = "Nama Barang"
        Me.Nama_Barang.Name = "Nama_Barang"
        '
        'harga
        '
        DataGridViewCellStyle7.Format = "Rp #,###"
        DataGridViewCellStyle7.NullValue = "0"
        Me.harga.DefaultCellStyle = DataGridViewCellStyle7
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        '
        'ttl
        '
        Me.ttl.HeaderText = "Total"
        Me.ttl.Name = "ttl"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(526, 551)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 30)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total Bayar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtjumlahB)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.BtnReset)
        Me.GroupBox1.Controls.Add(Me.BtnTambah)
        Me.GroupBox1.Controls.Add(Me.txttotalB)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txthargaB)
        Me.GroupBox1.Controls.Add(Me.txtnamaB)
        Me.GroupBox1.Controls.Add(Me.txtkodeB)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1297, 144)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Barang"
        '
        'txtjumlahB
        '
        Me.txtjumlahB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjumlahB.BackColor = System.Drawing.Color.Transparent
        Me.txtjumlahB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtjumlahB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtjumlahB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtjumlahB.Location = New System.Drawing.Point(1068, 37)
        Me.txtjumlahB.Margin = New System.Windows.Forms.Padding(2)
        Me.txtjumlahB.Name = "txtjumlahB"
        Me.txtjumlahB.Size = New System.Drawing.Size(223, 35)
        Me.txtjumlahB.TabIndex = 26
        Me.txtjumlahB.ThousandsSeparator = True
        Me.txtjumlahB.UpDownButtonBorderVisible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 17)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1065, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Jumlah"
        '
        'BtnReset
        '
        Me.BtnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnReset.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnReset.FillColor = System.Drawing.Color.MediumBlue
        Me.BtnReset.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.ForeColor = System.Drawing.Color.White
        Me.BtnReset.HoverState.FillColor = System.Drawing.Color.Navy
        Me.BtnReset.Location = New System.Drawing.Point(965, 101)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(145, 35)
        Me.BtnReset.TabIndex = 15
        Me.BtnReset.Text = "Reset"
        '
        'BtnTambah
        '
        Me.BtnTambah.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTambah.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnTambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnTambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnTambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnTambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnTambah.FillColor = System.Drawing.Color.MediumBlue
        Me.BtnTambah.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.ForeColor = System.Drawing.Color.White
        Me.BtnTambah.HoverState.FillColor = System.Drawing.Color.Navy
        Me.BtnTambah.Location = New System.Drawing.Point(1128, 101)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(163, 35)
        Me.BtnTambah.TabIndex = 16
        Me.BtnTambah.Text = "Tambah Produk"
        '
        'txttotalB
        '
        Me.txttotalB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttotalB.DefaultText = ""
        Me.txttotalB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txttotalB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txttotalB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttotalB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttotalB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttotalB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txttotalB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txttotalB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttotalB.Location = New System.Drawing.Point(6, 101)
        Me.txttotalB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttotalB.Name = "txttotalB"
        Me.txttotalB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttotalB.PlaceholderText = ""
        Me.txttotalB.ReadOnly = True
        Me.txttotalB.SelectedText = ""
        Me.txttotalB.Size = New System.Drawing.Size(327, 35)
        Me.txttotalB.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(729, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(360, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nama Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Kode Barang"
        '
        'txthargaB
        '
        Me.txthargaB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txthargaB.DefaultText = ""
        Me.txthargaB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txthargaB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txthargaB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txthargaB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txthargaB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txthargaB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txthargaB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txthargaB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txthargaB.Location = New System.Drawing.Point(732, 37)
        Me.txthargaB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txthargaB.Name = "txthargaB"
        Me.txthargaB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txthargaB.PlaceholderText = ""
        Me.txthargaB.ReadOnly = True
        Me.txthargaB.SelectedText = ""
        Me.txthargaB.Size = New System.Drawing.Size(293, 35)
        Me.txthargaB.TabIndex = 15
        '
        'txtnamaB
        '
        Me.txtnamaB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnamaB.DefaultText = ""
        Me.txtnamaB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtnamaB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtnamaB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnamaB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnamaB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnamaB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtnamaB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtnamaB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnamaB.Location = New System.Drawing.Point(363, 37)
        Me.txtnamaB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnamaB.Name = "txtnamaB"
        Me.txtnamaB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnamaB.PlaceholderText = ""
        Me.txtnamaB.ReadOnly = True
        Me.txtnamaB.SelectedText = ""
        Me.txtnamaB.Size = New System.Drawing.Size(341, 35)
        Me.txtnamaB.TabIndex = 14
        '
        'txtkodeB
        '
        Me.txtkodeB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtkodeB.DefaultText = ""
        Me.txtkodeB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtkodeB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtkodeB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtkodeB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtkodeB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtkodeB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtkodeB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtkodeB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtkodeB.Location = New System.Drawing.Point(6, 37)
        Me.txtkodeB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtkodeB.Name = "txtkodeB"
        Me.txtkodeB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtkodeB.PlaceholderText = ""
        Me.txtkodeB.SelectedText = ""
        Me.txtkodeB.Size = New System.Drawing.Size(327, 35)
        Me.txtkodeB.TabIndex = 13
        '
        'txttgltransaksi
        '
        Me.txttgltransaksi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttgltransaksi.BackColor = System.Drawing.Color.Transparent
        Me.txttgltransaksi.Checked = True
        Me.txttgltransaksi.Enabled = False
        Me.txttgltransaksi.FillColor = System.Drawing.Color.White
        Me.txttgltransaksi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttgltransaksi.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.txttgltransaksi.Location = New System.Drawing.Point(1068, 34)
        Me.txttgltransaksi.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txttgltransaksi.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txttgltransaksi.Name = "txttgltransaksi"
        Me.txttgltransaksi.Size = New System.Drawing.Size(223, 26)
        Me.txttgltransaksi.TabIndex = 23
        Me.txttgltransaksi.Value = New Date(2022, 9, 24, 17, 24, 57, 0)
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1065, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 17)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Tanggal Transaksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Kode Transaksi"
        '
        'IdTransaksi
        '
        Me.IdTransaksi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IdTransaksi.DefaultText = ""
        Me.IdTransaksi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.IdTransaksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.IdTransaksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IdTransaksi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.IdTransaksi.Enabled = False
        Me.IdTransaksi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IdTransaksi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTransaksi.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IdTransaksi.Location = New System.Drawing.Point(6, 34)
        Me.IdTransaksi.Name = "IdTransaksi"
        Me.IdTransaksi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.IdTransaksi.PlaceholderText = ""
        Me.IdTransaksi.ReadOnly = True
        Me.IdTransaksi.SelectedText = ""
        Me.IdTransaksi.Size = New System.Drawing.Size(327, 26)
        Me.IdTransaksi.TabIndex = 11
        '
        'BtnBayar
        '
        Me.BtnBayar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBayar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnBayar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnBayar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnBayar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnBayar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnBayar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnBayar.FillColor = System.Drawing.Color.MediumBlue
        Me.BtnBayar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBayar.ForeColor = System.Drawing.Color.White
        Me.BtnBayar.HoverState.FillColor = System.Drawing.Color.Navy
        Me.BtnBayar.Location = New System.Drawing.Point(1063, 584)
        Me.BtnBayar.Name = "BtnBayar"
        Me.BtnBayar.Size = New System.Drawing.Size(241, 60)
        Me.BtnBayar.TabIndex = 17
        Me.BtnBayar.Text = "Bayar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 36)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Transaksi"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtnamapelanggan)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtidpelanggan)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.IdTransaksi)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txttgltransaksi)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1297, 67)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaksi"
        '
        'txtnamapelanggan
        '
        Me.txtnamapelanggan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnamapelanggan.DefaultText = ""
        Me.txtnamapelanggan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtnamapelanggan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtnamapelanggan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnamapelanggan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnamapelanggan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnamapelanggan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamapelanggan.ForeColor = System.Drawing.Color.Black
        Me.txtnamapelanggan.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnamapelanggan.Location = New System.Drawing.Point(732, 35)
        Me.txtnamapelanggan.Name = "txtnamapelanggan"
        Me.txtnamapelanggan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnamapelanggan.PlaceholderText = ""
        Me.txtnamapelanggan.ReadOnly = True
        Me.txtnamapelanggan.SelectedText = ""
        Me.txtnamapelanggan.Size = New System.Drawing.Size(293, 26)
        Me.txtnamapelanggan.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(729, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 17)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Nama Pelanggan"
        '
        'txtidpelanggan
        '
        Me.txtidpelanggan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtidpelanggan.DefaultText = ""
        Me.txtidpelanggan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtidpelanggan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtidpelanggan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtidpelanggan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtidpelanggan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtidpelanggan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidpelanggan.ForeColor = System.Drawing.Color.Black
        Me.txtidpelanggan.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtidpelanggan.Location = New System.Drawing.Point(363, 35)
        Me.txtidpelanggan.Name = "txtidpelanggan"
        Me.txtidpelanggan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtidpelanggan.PlaceholderText = ""
        Me.txtidpelanggan.SelectedText = ""
        Me.txtidpelanggan.Size = New System.Drawing.Size(341, 26)
        Me.txtidpelanggan.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(360, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 17)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "ID Pelanggan"
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(259, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 30)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Dibayar"
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(259, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 30)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Kembalian"
        '
        'txttotalbyr
        '
        Me.txttotalbyr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txttotalbyr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttotalbyr.DefaultText = ""
        Me.txttotalbyr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txttotalbyr.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txttotalbyr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttotalbyr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttotalbyr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttotalbyr.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalbyr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txttotalbyr.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttotalbyr.Location = New System.Drawing.Point(531, 584)
        Me.txttotalbyr.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txttotalbyr.Name = "txttotalbyr"
        Me.txttotalbyr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttotalbyr.PlaceholderText = ""
        Me.txttotalbyr.ReadOnly = True
        Me.txttotalbyr.SelectedText = ""
        Me.txttotalbyr.Size = New System.Drawing.Size(507, 60)
        Me.txttotalbyr.TabIndex = 26
        '
        'txtbayar
        '
        Me.txtbayar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtbayar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbayar.DefaultText = ""
        Me.txtbayar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbayar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbayar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbayar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbayar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbayar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbayar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtbayar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbayar.Location = New System.Drawing.Point(260, 47)
        Me.txtbayar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbayar.PlaceholderText = ""
        Me.txtbayar.SelectedText = ""
        Me.txtbayar.Size = New System.Drawing.Size(235, 36)
        Me.txtbayar.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtbayar.TabIndex = 31
        '
        'txtkembalian
        '
        Me.txtkembalian.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtkembalian.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtkembalian.DefaultText = ""
        Me.txtkembalian.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtkembalian.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtkembalian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtkembalian.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtkembalian.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtkembalian.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkembalian.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtkembalian.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtkembalian.Location = New System.Drawing.Point(260, 113)
        Me.txtkembalian.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtkembalian.Name = "txtkembalian"
        Me.txtkembalian.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtkembalian.PlaceholderText = ""
        Me.txtkembalian.ReadOnly = True
        Me.txtkembalian.SelectedText = ""
        Me.txtkembalian.Size = New System.Drawing.Size(235, 38)
        Me.txtkembalian.TabIndex = 32
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.cbxmetodebyr)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtkembalian)
        Me.GroupBox3.Controls.Add(Me.txtbayar)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 492)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(508, 158)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pembayaran"
        '
        'cbxmetodebyr
        '
        Me.cbxmetodebyr.BackColor = System.Drawing.Color.Transparent
        Me.cbxmetodebyr.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxmetodebyr.DisplayMember = "Tunai"
        Me.cbxmetodebyr.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxmetodebyr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxmetodebyr.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxmetodebyr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxmetodebyr.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxmetodebyr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbxmetodebyr.ItemHeight = 30
        Me.cbxmetodebyr.Items.AddRange(New Object() {"Tunai", "Hutang"})
        Me.cbxmetodebyr.Location = New System.Drawing.Point(6, 47)
        Me.cbxmetodebyr.Name = "cbxmetodebyr"
        Me.cbxmetodebyr.Size = New System.Drawing.Size(235, 36)
        Me.cbxmetodebyr.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbxmetodebyr.TabIndex = 34
        Me.cbxmetodebyr.ValueMember = "Tunai,Kredit"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(149, 30)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Metode Bayar"
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btncancle
        '
        Me.btncancle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancle.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btncancle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancle.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btncancle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btncancle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btncancle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btncancle.FillColor = System.Drawing.Color.SlateGray
        Me.btncancle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancle.ForeColor = System.Drawing.Color.White
        Me.btncancle.HoverState.FillColor = System.Drawing.Color.Navy
        Me.btncancle.Location = New System.Drawing.Point(1063, 515)
        Me.btncancle.Name = "btncancle"
        Me.btncancle.Size = New System.Drawing.Size(241, 60)
        Me.btncancle.TabIndex = 34
        Me.btncancle.Text = "Batal"
        '
        'prnPreview
        '
        Me.prnPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.prnPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.prnPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.prnPreview.Enabled = True
        Me.prnPreview.Icon = CType(resources.GetObject("prnPreview.Icon"), System.Drawing.Icon)
        Me.prnPreview.Name = "prnPreview"
        Me.prnPreview.Visible = False
        '
        'prnDialog
        '
        Me.prnDialog.UseEXDialog = True
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(814, 506)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(180, 45)
        Me.Guna2Button1.TabIndex = 35
        Me.Guna2Button1.Text = "Guna2Button1"
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CancelButton = Me.btncancle
        Me.ClientSize = New System.Drawing.Size(1323, 663)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.btncancle)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txttotalbyr)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnBayar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dvgtampil)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormTransaksi"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dvgtampil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtjumlahB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dvgtampil As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txttotalB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txttgltransaksi As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txthargaB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtnamaB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtkodeB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents IdTransaksi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnTambah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnBayar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txttotalbyr As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbayar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtkembalian As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtjumlahB As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Kode As DataGridViewTextBoxColumn
    Friend WithEvents Nama_Barang As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents ttl As DataGridViewTextBoxColumn
    Friend WithEvents txtnamapelanggan As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtidpelanggan As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbxmetodebyr As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents btncancle As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents prnDocument As Printing.PrintDocument
    Friend WithEvents prnPreview As PrintPreviewDialog
    Friend WithEvents prnDialog As PrintDialog
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
