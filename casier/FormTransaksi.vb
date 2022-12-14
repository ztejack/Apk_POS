Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Public Class FormTransaksi
    'produks & transaksi'
    Dim kodeB, namaB As String
    Dim hargaB, total, totalB, dibayar, kembalian, Qty, stokB, bayar As Long
    Dim tgl As Date

    Dim metodbyr, idtagihan As Long

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog

    ' for Report:
    Private CurrentY As Integer
    Private CurrentX As Integer
    Private leftMargin As Integer
    Private rightMargin As Integer
    Private topMargin As Integer
    Private bottomMargin As Integer
    Private InvoiceWidth As Integer
    Private InvoiceHeight As Integer
    Private ReadInvoice As Boolean
    Private AmountPosition As Integer


    ' for Invoice Head:
    Private InvTitle As String
    Private InvSubTitle1 As String
    Private InvSubTitle2 As String
    Private InvSubTitle3 As String
    Private InvImage As String

    ' Font and Color:------------------
    ' Title Font
    Private InvTitleFont As Font = New Font("Segoi UI", 24, FontStyle.Regular)
    ' Title Font height
    Private InvTitleHeight As Integer
    ' SubTitle Font
    Private InvSubTitleFont As Font = New Font("Segoi UI", 14, FontStyle.Regular)
    ' Invoice Font Bold
    Private InvoiceFontB14 As Font = New Font("Segoi UI", 14, FontStyle.Bold)
    ' SubTitle Font height
    Private InvSubTitleHeight As Integer
    ' Invoice Font
    Private InvoiceFont As Font = New Font("Segoi UI", 12, FontStyle.Regular)
    ' Invoice Font Bold
    Private InvoiceFontB As Font = New Font("Segoi UI", 12, FontStyle.Bold)
    ' Invoice Font height
    Private InvoiceFontHeight As Integer
    ' Blue Color
    Private BlueBrush As SolidBrush = New SolidBrush(Color.Blue)
    ' Red Color
    Private RedBrush As SolidBrush = New SolidBrush(Color.Red)
    ' Black Color
    Private BlackBrush As SolidBrush = New SolidBrush(Color.Black)

    Public Sub New()
        MyBase.New()

        InitializeComponent()

        Me.prnDialog = New System.Windows.Forms.PrintDialog
        Me.prnPreview = New System.Windows.Forms.PrintPreviewDialog
        Me.prnDocument = New System.Drawing.Printing.PrintDocument
        ' The Event of 'PrintPage'
        AddHandler prnDocument.PrintPage, AddressOf prnDocument_PrintPage
    End Sub

    'users'
    Dim idpel, nama, username, perusahaanID, perusahaanName As String


    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles Me.Load
        desaindgv()
        cbxmetodebyr.SelectedItem = "Tunai"
        txttgltransaksi.Value = DateTime.Now
    End Sub

    Private Sub dvgtampil_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgtampil.CellContentClick

    End Sub

    Private Sub txtbayar_TextChanged(sender As Object, e As EventArgs) Handles txtbayar.TextChanged
        If (cbxmetodebyr.Text = "Tunai") Then

            'Dim f As Long
            If txtbayar.Text = "" Or Not IsNumeric(txtbayar.Text) Then
                Exit Sub
            End If
            bayar = txtbayar.Text
            txtbayar.Text = Format(bayar, "##,###")
            txtbayar.SelectionStart = Len(txtbayar.Text)

            Dim hitung As Long = 0
            For baris As Long = 0 To dvgtampil.RowCount - 1
                hitung = hitung + dvgtampil.Rows(baris).Cells(4).Value
            Next
            Dim byr As Long
            Try
                byr = txtbayar.Text
                kembalian = byr - hitung
            Catch ex As Exception
                kembalian = 0
            End Try
            If (kembalian > 0) Then
                txtkembalian.Text = "Rp. " + Format(kembalian, "##,###")
            Else
                txtkembalian.Text = 0
            End If
        End If
    End Sub

    Private Sub txtkodeB_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtkodeB.KeyPress
        If (e.KeyChar = Chr(13)) Then
            If (txtidpelanggan.Text = "") Then
                txtidpelanggan.Text = "4"
            End If
            If txtkodeB.Text IsNot "" Then
                Call conecDB()
                Call initCMD()

                SQL = "SELECT * FROM produks WHERE kodePrd ='" & txtkodeB.Text & "'"
                With comDB
                    .CommandText = SQL
                    .ExecuteNonQuery()
                End With
                rdDB = comDB.ExecuteReader
                rdDB.Read()

                If rdDB.HasRows Then
                    kodeB = rdDB.Item("kodePrd")
                    namaB = rdDB.Item("namaPrd")
                    hargaB = rdDB.Item("price")
                    stokB = rdDB.Item("stok")
                    txtnamaB.Text = namaB
                    txthargaB.Text = "Rp. " + Format(hargaB, "##,##")
                    txtjumlahB.Focus()
                    rdDB.Close()

                Else
                    MessageBox.Show("Produk dengan kode barang '" & txtkodeB.Text & "' tidak ditemukan", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtkodeB.Text = ""
                    txtkodeB.Focus()
                    rdDB.Close()


                End If

            Else
                MessageBox.Show("Isi Kode barang terlebih dahulu", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        End If

    End Sub
    Sub reset()
        txtjumlahB.Value = 0
        txtkodeB.Text = ""
        txtnamaB.Text = ""
        txthargaB.Text = ""
        txttotalB.Text = ""
        cbxmetodebyr.ValueMember = 1
        txtbayar.Text = 0
        txtkembalian.Text = 0
        txttotalbyr.Text = 0
        txtidpelanggan.Text = ""
        txtnamapelanggan.Text = ""
        IdTransaksi.Text = ""
    End Sub
    Sub resetbrg()
        txtjumlahB.Value = 0
        txtkodeB.Text = ""
        txtnamaB.Text = ""
        txthargaB.Text = ""
        txttotalB.Text = ""
    End Sub
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        resetbrg()
    End Sub

    Sub delrow()
        If dvgtampil.CurrentRow.Index <> dvgtampil.NewRowIndex Then
            dvgtampil.Rows.RemoveAt(dvgtampil.CurrentRow.Index)
        End If
    End Sub

    Private Sub BtnBayar_Click(sender As Object, e As EventArgs) Handles BtnBayar.Click

        If (IdTransaksi.Text IsNot "") Then
            If (txtbayar.Text IsNot "") Then
                If (cbxmetodebyr.Text = "Tunai") Then
                    Dim hitung As Long = 0
                    For baris As Long = 0 To dvgtampil.RowCount - 1
                        hitung = hitung + dvgtampil.Rows(baris).Cells(4).Value
                    Next

                    Dim kurang As Long = hitung - bayar

                    If (txtkembalian.Text = "0") Then
                        MessageBox.Show("Jumlah bayar kurang" & " Rp." & Format(kurang, "##,###") & "", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
                simpandata()
                PPD.Document = PD
                PPD.ShowDialog()
                'PD.Print()

            ElseIf (cbxmetodebyr.Text IsNot "Hutang") Then
                MessageBox.Show("Mohon Isi jumlah pembayaran terlebih dahulu", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtbayar.Focus()
            End If
        Else
            MessageBox.Show("Pembayaran Transaksi gagal, belum ada produk yang ditambahkan", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtkodeB.Focus()
        End If


    End Sub

    Private Sub cbxmetodebyr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxmetodebyr.SelectedIndexChanged
        If (cbxmetodebyr.Text = "Hutang") Then
            metodbyr = 1
            txtbayar.Enabled = False
            txtbayar.Text = 0
            txtkembalian.Enabled = False
            txtkembalian.Text = 0
        ElseIf (cbxmetodebyr.Text = "Tunai") Then
            metodbyr = 0
            txtbayar.Enabled = True
            txtkembalian.Enabled = True
        End If
    End Sub


    Private Sub txtidpelanggan_TextChanged(sender As Object, e As EventArgs) Handles txtidpelanggan.TextChanged
        If txtidpelanggan.Text IsNot "" Then
            Call conecDB()
            Call initCMD()

            SQL = "SELECT * FROM users WHERE id ='" & txtidpelanggan.Text & "'"
            With comDB
                .CommandText = SQL
                .ExecuteNonQuery()
            End With
            rdDB = comDB.ExecuteReader
            rdDB.Read()

            If rdDB.HasRows Then
                idpel = rdDB.Item("id")
                nama = rdDB.Item("name")
                username = rdDB.Item("username")
                perusahaanID = rdDB.Item("perusahaan_id")
                txtnamapelanggan.Text = nama

                rdDB.Close()
                getperusahaan()
            Else
                MessageBox.Show("Data pelanggan dengan ID '" & txtidpelanggan.Text & "' tidak ditemukan", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtidpelanggan.Text = ""
                txtnamapelanggan.Text = ""

                txtidpelanggan.Focus()
                rdDB.Close()

            End If
        Else
            txtnamapelanggan.Text = ""
        End If

    End Sub

    Sub getperusahaan()
        Call conecDB()
        Call initCMD()

        SQL = "SELECT * FROM perusahaans WHERE id = '" & perusahaanID & "'"
        With comDB
            .CommandText = SQL
            .ExecuteNonQuery()
        End With
        rdDB = comDB.ExecuteReader
        rdDB.Read()
        perusahaanName = rdDB.Item("nama_perusahaan")
        rdDB.Close()
    End Sub

    Sub simpandata()
        tgl = Format(txttgltransaksi.Value, "yyyy/MM/dd HH:mm:ss")
        idpel = txtidpelanggan.Text
        Dim idTRANS As String = ""
        Dim idsementara As String = ""
        Dim idTAG As String = ""

        Dim hitung As Long = 0
        For baris As Long = 0 To dvgtampil.RowCount - 1
            hitung = hitung + dvgtampil.Rows(baris).Cells(4).Value
        Next


        If (metodbyr = 1) Then
            idTAG = 1
        Else
            Dim id1 As String = ""
            Call conecDB()
            Call initCMD()
            Dim statustag As Long = 0

            SQL = "SELECT * FROM tagihans ORDER BY id DESC LIMIT 1"
            With comDB
                .CommandText = SQL
                .ExecuteNonQuery()
            End With
            rdDB = comDB.ExecuteReader
            rdDB.Read()

            If rdDB.HasRows Then
                id1 = rdDB.Item("id")
                idTAG = Val(id1) + 1
            End If
            rdDB.Close()

            'Try
            Call conecDB()
            Call initCMD()

            SQL1 = "INSERT INTO tagihans VALUES (@id,@user_id ,@status , @total, @created_at, @updated_at)"
            With comDB
                .CommandText = SQL1
                .Parameters.Add("id", MySqlDbType.Int64).Value = idTAG
                .Parameters.Add("user_id", MySqlDbType.String).Value = idpel
                .Parameters.Add("status", MySqlDbType.String).Value = statustag
                .Parameters.Add("total", MySqlDbType.Int64).Value = hitung
                .Parameters.Add("created_at", MySqlDbType.DateTime).Value = tgl
                .Parameters.Add("updated_at", MySqlDbType.DateTime).Value = tgl
                .ExecuteNonQuery()
            End With
            rdDB.Close()
            'Catch ex As Exception
            'MessageBox.Show("Gagal Menambah Tagihan", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            'End Try

        End If
        Call conecDB()
        Call initCMD()

        SQL = "SELECT * FROM transaksis ORDER BY id DESC LIMIT 1"
        With comDB
            .CommandText = SQL
            .ExecuteNonQuery()
        End With
        rdDB = comDB.ExecuteReader
        rdDB.Read()

        If rdDB.HasRows Then
            idsementara = rdDB.Item("id")
            idTRANS = Val(idsementara) + 1
        End If
        rdDB.Close()

        Call conecDB()
        Call initCMD()
        SQL = "INSERT INTO transaksis VALUES (@idt, @id_pelanggan, @metode_Byr, @id_tagihan, @total_Byr, @created_atT, @updated_atT)"
        With comDB
            .CommandText = SQL
            .Parameters.Add("idt", MySqlDbType.Int64).Value = idTRANS
            .Parameters.Add("id_pelanggan", MySqlDbType.Int64).Value = idpel
            .Parameters.Add("metode_Byr", MySqlDbType.Int64).Value = metodbyr
            .Parameters.Add("id_tagihan", MySqlDbType.Int64).Value = idTAG
            .Parameters.Add("total_Byr", MySqlDbType.Int64).Value = hitung
            .Parameters.Add("created_atT", MySqlDbType.DateTime).Value = tgl
            .Parameters.Add("updated_atT", MySqlDbType.DateTime).Value = tgl
            .ExecuteNonQuery()

            MessageBox.Show("Transaksi Berhasil", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            reset()
        End With
        rdDB.Close()

    End Sub
    Sub movedata()

        dvgtampil.AllowUserToAddRows = True
        dvgtampil.RowCount = dvgtampil.RowCount + 1

        dvgtampil(0, dvgtampil.RowCount - 2).Value = kodeB
        dvgtampil(1, dvgtampil.RowCount - 2).Value = namaB
        dvgtampil(2, dvgtampil.RowCount - 2).Value = hargaB
        dvgtampil(3, dvgtampil.RowCount - 2).Value = Qty
        dvgtampil(4, dvgtampil.RowCount - 2).Value = totalB

        dvgtampil.AllowUserToAddRows = False
        dvgtampil.ReadOnly = True

        Dim b_atasjumlah As Long
        For barisatas As Long = 0 To dvgtampil.RowCount - 1
            For barisbawah As Long = barisatas + 1 To dvgtampil.RowCount - 1
                b_atasjumlah = dvgtampil.Rows(barisatas).Cells(3).Value

                If dvgtampil.Rows(barisbawah).Cells(0).Value = dvgtampil.Rows(barisatas).Cells(0).Value Then
                    Dim totjumlah As Long
                    totjumlah = b_atasjumlah + dvgtampil.Rows(barisbawah).Cells(3).Value
                    If totjumlah > stokB Then
                        MessageBox.Show("Jumlah lebih besar dari stok yang ada" & vbCrLf _
                                & "Stok hanya " & stokB, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        dvgtampil.Rows(barisatas).Cells(3).Value = stokB
                        dvgtampil.Rows(barisatas).Cells(2).Value = dvgtampil.Rows(barisbawah).Cells(2).Value
                        dvgtampil.Rows(barisatas).Cells(4).Value = (dvgtampil.Rows(barisatas).Cells(2).Value * dvgtampil.Rows(barisatas).Cells(3).Value)
                        dvgtampil.CurrentCell = dvgtampil.Rows(barisbawah).Cells(3)
                        delrow()
                    Else
                        dvgtampil.Rows(barisatas).Cells(3).Value = b_atasjumlah + dvgtampil.Rows(barisbawah).Cells(3).Value
                        dvgtampil.Rows(barisatas).Cells(2).Value = dvgtampil.Rows(barisbawah).Cells(2).Value
                        dvgtampil.Rows(barisatas).Cells(4).Value = (dvgtampil.Rows(barisatas).Cells(2).Value * dvgtampil.Rows(barisatas).Cells(3).Value)
                        dvgtampil.CurrentCell = dvgtampil.Rows(barisbawah).Cells(3)
                        delrow()
                    End If
                End If
            Next
        Next
        hitungtotal()

    End Sub
    Sub desaindgv()
        Me.dvgtampil.Columns(0).HeaderText = "KODE"
        Me.dvgtampil.Columns(1).HeaderText = "NAMA BARANG"
        Me.dvgtampil.Columns(2).HeaderText = "HARGA"
        Me.dvgtampil.Columns(3).HeaderText = "JUMLAH"
        Me.dvgtampil.Columns(4).HeaderText = "TOTAL"

        Dim lebar As Long
        lebar = 0
        lebar = dvgtampil.Width
        lebar = lebar - 800

        Me.dvgtampil.Columns(0).Width = 200
        Me.dvgtampil.Columns(1).Width = lebar
        Me.dvgtampil.Columns(2).Width = 130
        Me.dvgtampil.Columns(3).Width = 120
        Me.dvgtampil.Columns(4).Width = 120

        'TINGGI HEADER'
        Me.dvgtampil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dvgtampil.ColumnHeadersHeight = 25

        'POSISI HEADER' 
        Me.dvgtampil.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dvgtampil.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dvgtampil.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dvgtampil.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dvgtampil.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        'Me.dvgtampil.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)'

        Me.dvgtampil.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dvgtampil.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dvgtampil.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dvgtampil.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dvgtampil.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        Me.dvgtampil.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Me.dvgtampil.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
        Me.dvgtampil.EnableHeadersVisualStyles = False

        Me.dvgtampil.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(200, 203, 204)
        Me.dvgtampil.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(244, 244, 244)

        'Me.dvgtampil.Columns(0).Visible = False
        Me.dvgtampil.Columns(2).DefaultCellStyle.Format = "Rp #,###"
        Me.dvgtampil.Columns(4).DefaultCellStyle.Format = "Rp #,###"

    End Sub

    Sub hitungtotal()
        Dim hitung As Long = 0
        For baris As Long = 0 To dvgtampil.RowCount - 1
            hitung = hitung + dvgtampil.Rows(baris).Cells(4).Value
        Next

        txttotalbyr.Text = "Rp. " + Format(hitung, "##,###")

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        DisplayInvoice()
    End Sub

    Private Sub txtjumlahB_ValueChanged(sender As Object, e As EventArgs) Handles txtjumlahB.ValueChanged

        If txtkodeB.Text IsNot "" Then
            If txtjumlahB.Value <= stokB Then

                Qty = txtjumlahB.Value
                totalB = hargaB * Qty
                txttotalB.Text = "Rp. " + Format(totalB, "##,###")

            Else
                txtjumlahB.Value = 0
                MessageBox.Show("Jumlah melebihi stok yang ada. '" & vbCrLf & "' Stok hanya : '" & stokB & "'", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtjumlahB.Focus()
            End If

        ElseIf txtjumlahB.Value > 0 Then
            txtjumlahB.Value = 0
        Else
            MessageBox.Show("Isi Kode barang terlebih dahulu", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtkodeB.Text = ""
        End If

    End Sub

    Private Sub TransaksiId()
        Dim strSementara As String = ""
        Dim strIsi As String = ""
        Call conecDB()
        Call initCMD()

        SQL = "SELECT * FROM transaksis ORDER BY id DESC LIMIT 1"
        With comDB
            .CommandText = SQL
            .ExecuteNonQuery()
        End With
        rdDB = comDB.ExecuteReader
        rdDB.Read()

        If rdDB.HasRows Then
            strSementara = rdDB.Item("id")
            strIsi = Val(strSementara) + 1
            IdTransaksi.Text = "#" & strIsi & ""
        End If

        rdDB.Close()
    End Sub


    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If IdTransaksi.Text IsNot "" Then
            movedata()
            txtjumlahB.Value = 0
            txtkodeB.Text = ""
            txtnamaB.Text = ""
            txthargaB.Text = ""
            txttotalB.Text = ""
        Else
            TransaksiId()
            movedata()
            txtjumlahB.Value = 0
            txtkodeB.Text = ""
            txtnamaB.Text = ""
            txthargaB.Text = ""
            txttotalB.Text = ""
        End If

    End Sub


    Private Sub txtbayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbayar.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub btncancle_Click(sender As Object, e As EventArgs) Handles btncancle.Click
        reset()
    End Sub


    'Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
    'Dim pagesetup As New PageSettings
    '   pagesetup.PaperSize = New PaperSize("Custom", 250, 500)
    '  PD.DefaultPageSettings = pagesetup
    'End Sub


    Private Sub ReadInvoiceHead()
        'Titles and Image of invoice:
        InvTitle = "KOPKARBARA"
        InvSubTitle1 = "Jl. Soekarno Hatta KM. 15, Tarahan"
        InvSubTitle2 = "Srengsem, Kec. Panjang, Kota Bandar Lampung, Lampung"
        InvSubTitle3 = "Phone 2233445566"
        InvImage = Application.StartupPath & "\Resources\" + "logo bukitasam@3x.png"
    End Sub

    Private Sub SetInvoiceHead(ByVal g As Graphics)
        ReadInvoiceHead()

        CurrentY = topMargin
        CurrentX = leftMargin
        Dim ImageHeight As Integer = 0

        ' Draw Invoice image:
        If (System.IO.File.Exists(InvImage)) Then
            Dim oInvImage As Bitmap = New Bitmap(InvImage)
            ' Set Image Left to center Image:
            Dim xImage As Integer = CurrentX + (InvoiceWidth - oInvImage.Width) / 2
            ImageHeight = oInvImage.Height ' Get Image Height
            g.DrawImage(oInvImage, xImage, CurrentY)
        End If

        InvTitleHeight = Convert.ToInt32(InvTitleFont.GetHeight(g))
        InvSubTitleHeight = Convert.ToInt32(InvSubTitleFont.GetHeight(g))
        ' Get Titles Length:
        Dim lenInvTitle As Integer = Convert.ToInt32(g.MeasureString(InvTitle, InvTitleFont).Width)
        Dim lenInvSubTitle1 As Integer = Convert.ToInt32(g.MeasureString(InvSubTitle1, InvSubTitleFont).Width)
        Dim lenInvSubTitle2 As Integer = Convert.ToInt32(g.MeasureString(InvSubTitle2, InvSubTitleFont).Width)
        Dim lenInvSubTitle3 As Integer = Convert.ToInt32(g.MeasureString(InvSubTitle3, InvSubTitleFont).Width)
        ' Set Titles Left:
        Dim xInvTitle As Integer = CurrentX + (InvoiceWidth - lenInvTitle) / 2
        Dim xInvSubTitle1 As Integer = CurrentX + (InvoiceWidth - lenInvSubTitle1) / 2
        Dim xInvSubTitle2 As Integer = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2
        Dim xInvSubTitle3 As Integer = CurrentX + (InvoiceWidth - lenInvSubTitle3) / 2

        ' Draw Invoice Head:
        If (InvTitle <> "") Then
            CurrentY = CurrentY + ImageHeight
            g.DrawString(InvTitle, InvTitleFont, BlueBrush, xInvTitle, CurrentY)
        End If
        If (InvSubTitle1 <> "") Then
            CurrentY = CurrentY + InvTitleHeight
            g.DrawString(InvSubTitle1, InvSubTitleFont, BlueBrush, xInvSubTitle1, CurrentY)
        End If
        If (InvSubTitle2 <> "") Then
            CurrentY = CurrentY + InvSubTitleHeight
            g.DrawString(InvSubTitle2, InvSubTitleFont, BlueBrush, xInvSubTitle2, CurrentY)
        End If
        If (InvSubTitle3 <> "") Then
            CurrentY = CurrentY + InvSubTitleHeight
            g.DrawString(InvSubTitle3, InvSubTitleFont, BlueBrush, xInvSubTitle3, CurrentY)
        End If

        ' Draw line:
        CurrentY = CurrentY + InvSubTitleHeight + 8
        g.DrawLine(New Pen(Brushes.Black, 2), CurrentX, CurrentY, rightMargin, CurrentY)
    End Sub

    Private Sub SetOrderData(ByVal g As Graphics)
        ' Set Company Name, City, Salesperson, Order ID and Order Date
        Dim FieldValue As String = ""
        InvoiceFontHeight = Convert.ToInt32(InvoiceFont.GetHeight(g))

        ' Set Nama Pelanggan
        CurrentX = leftMargin
        CurrentY = CurrentY + 8
        FieldValue = "Nama Pelanggan: " & txtnamapelanggan.Text
        g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY)
        ' Set Perusahaan
        CurrentX = leftMargin
        CurrentY = CurrentY + InvoiceFontHeight

        FieldValue = "Perusahaan: " & perusahaanName
        g.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY)

        ' Set Order ID:
        AmountPosition = CurrentX + Convert.ToInt32(g.MeasureString(FieldValue, InvoiceFont).Width) + 350
        Dim xOrderid As Integer = AmountPosition - Convert.ToInt32(g.MeasureString("Sub Total", InvoiceFont).Width)
        CurrentY = CurrentY - InvoiceFontHeight
        FieldValue = "Order ID: " & IdTransaksi.Text
        g.DrawString(FieldValue, InvoiceFont, BlackBrush, xOrderid, CurrentY)
        ' Set Order Date:
        Dim xDateorder As Integer = AmountPosition - Convert.ToInt32(g.MeasureString("Sub Total", InvoiceFont).Width)
        CurrentY = CurrentY + InvoiceFontHeight

        FieldValue = "Order Date: " & Format(txttgltransaksi.Value, "yyyy/MM/dd")
        g.DrawString(FieldValue, InvoiceFont, BlackBrush, xDateorder, CurrentY)

        ' Draw line:
        CurrentY = CurrentY + InvoiceFontHeight + 8
        g.DrawLine(New Pen(Brushes.Black), leftMargin, CurrentY, rightMargin, CurrentY)
    End Sub

    Private Sub SetInvoiceData(ByVal g As Graphics, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        ' Set Invoice Table:
        Dim FieldValue As String = ""
        Dim CurrentRecord = 0
        Dim RecordsPerPage = 20
        Dim Amount As Decimal = 0
        Dim StopReading As Boolean = False

        InvoiceFontHeight = Convert.ToInt32(InvoiceFont.GetHeight(g))

        ' Set Table Head:
        Dim xProductID As Integer = leftMargin
        CurrentY = CurrentY + InvoiceFontHeight

        Dim xProductName As Integer = leftMargin
        g.DrawString("Nama Barang", InvoiceFont, BlueBrush, xProductName, CurrentY)

        Dim xUnitPrice As Integer = rightMargin - 350
        g.DrawString("Harga", InvoiceFont, BlueBrush, xUnitPrice, CurrentY)

        Dim xQuantity As Integer = xUnitPrice + Convert.ToInt32(g.MeasureString("Jumlah", InvoiceFont).Width) + 80
        g.DrawString("Jumlah", InvoiceFont, BlueBrush, xQuantity, CurrentY)

        Dim xTotal As Integer = xQuantity + Convert.ToInt32(g.MeasureString("Total", InvoiceFont).Width) + 50
        g.DrawString("Total", InvoiceFont, BlueBrush, xTotal, CurrentY)

        AmountPosition = xTotal + Convert.ToInt32(g.MeasureString("Discount", InvoiceFont).Width) - 80

        ' Set Invoice Table:
        CurrentY = CurrentY + InvoiceFontHeight + 8

        'Pull data grid view data
        Dim valor As Integer
        valor = dvgtampil.RowCount
        valor = valor - 1
        For indice As Integer = 0 To valor
            FieldValue = dvgtampil.Rows(indice).Cells(1).Value.ToString
            ' if Length of (Product Name) > 20, Draw 20 character only
            If (FieldValue.Length > 20) Then
                FieldValue = FieldValue.Remove(20, FieldValue.Length - 20)
            End If
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, xProductName, CurrentY)

            'FieldValue = String.Format("{0:0.00}", rdDB("UnitPrice"))
            FieldValue = "Rp. " + Format(dvgtampil.Rows(indice).Cells(2).Value, "##,###")
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, xUnitPrice, CurrentY)

            'FieldValue = rdDB("Quantity").ToString()
            FieldValue = dvgtampil.Rows(indice).Cells(3).Value.ToString
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, xQuantity, CurrentY)

            FieldValue = "Rp. " + Format(dvgtampil.Rows(indice).Cells(4).Value, "##,###")
            g.DrawString(FieldValue, InvoiceFont, BlackBrush, xTotal, CurrentY)


            CurrentY = CurrentY + InvoiceFontHeight



            CurrentRecord += 1

        Next

        If (CurrentRecord < RecordsPerPage) Then
            e.HasMorePages = False
        Else
            e.HasMorePages = True
        End If
        SetInvoiceTotal(g)


        g.Dispose()
    End Sub

    Private Sub SetInvoiceTotal(ByVal g As Graphics)
        ' Set Invoice Total:
        ' Draw line:
        CurrentY = CurrentY + 16
        g.DrawLine(New Pen(Brushes.Black), leftMargin, CurrentY, rightMargin, CurrentY)
        ' Get Right Edge of Invoice:
        Dim xRightEdg As Integer = AmountPosition + Convert.ToInt32(g.MeasureString("Extended Price", InvoiceFont).Width)

        ' Write Sub Total:
        Dim xTotal As Integer = AmountPosition - Convert.ToInt32(g.MeasureString("Sub Total", InvoiceFontB14).Width) - 10
        CurrentY = CurrentY + 14
        g.DrawString("Total Bayar", InvoiceFontB14, RedBrush, xTotal, CurrentY)
        'Dim TotalValue As String = String.Format("{0:0.00}", SubTotal)
        Dim TotalValue As String = txttotalbyr.Text
        Dim xTotalValue As Integer = xRightEdg - Convert.ToInt32(g.MeasureString(TotalValue, InvoiceFontB14).Width)
        g.DrawString(TotalValue, InvoiceFontB14, BlackBrush, xTotalValue, CurrentY)

        CurrentY = CurrentY + InvoiceFontHeight + 10
        g.DrawString("Metode Pembayaran", InvoiceFontB14, RedBrush, xTotal, CurrentY)
        Dim MetodeBayar As String = cbxmetodebyr.Text
        g.DrawString(MetodeBayar, InvoiceFontB14, BlackBrush, xTotalValue, CurrentY)

        If MetodeBayar = "Tunai" Then
            CurrentY = CurrentY + InvoiceFontHeight + 10

            g.DrawString("Tunai", InvoiceFontB14, RedBrush, xTotal, CurrentY)
            Dim Tunai As String = "Rp. " + txtbayar.Text
            g.DrawString(Tunai, InvoiceFontB14, BlackBrush, xTotalValue, CurrentY)
            CurrentY = CurrentY + InvoiceFontHeight + 10

            g.DrawString("Kembalian", InvoiceFontB14, RedBrush, xTotal, CurrentY)
            Dim Kembalian As String = txtkembalian.Text
            g.DrawString(Kembalian, InvoiceFontB14, BlackBrush, xTotalValue, CurrentY)
        End If

    End Sub

    Private Sub DisplayInvoice()
        prnPreview.Document = Me.prnDocument
        Try
            prnPreview.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub ReadInvoiceData()
        Call conecDB()
        Call initCMD()

        SQL = "SELECT * FROM detail_transaksis WHERE id_Transaksi ='" & IdTransaksi.Text & "'"
        With comDB
            .CommandText = SQL
            .ExecuteNonQuery()
        End With
        rdDB = comDB.ExecuteReader
        rdDB.Read()
    End Sub

    Private Sub prnDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        leftMargin = Convert.ToInt32(e.MarginBounds.Left)
        rightMargin = Convert.ToInt32(e.MarginBounds.Right)
        topMargin = Convert.ToInt32(e.MarginBounds.Top)
        bottomMargin = Convert.ToInt32(e.MarginBounds.Bottom)
        InvoiceWidth = Convert.ToInt32(e.MarginBounds.Width)
        InvoiceHeight = Convert.ToInt32(e.MarginBounds.Height)

        ' If (Not ReadInvoice) Then ReadInvoiceData()

        SetInvoiceHead(e.Graphics) ' Draw Invoice Head
        SetOrderData(e.Graphics) ' Draw Order Data
        SetInvoiceData(e.Graphics, e) ' Draw Invoice Data

        ReadInvoice = True
    End Sub
End Class