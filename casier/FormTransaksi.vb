Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Public Class FormTransaksi
    'produks & transaksi'
    Dim kodeT As Integer
    Dim kodeB, namaB As String
    Dim hargaB, total, totalB, dibayar, kembalian, Qty, stokB, bayar As Long
    Dim tgl As Date

    Dim metodbyr, idtagihan As Long

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog


    'users'
    Dim idpel, nama, username As String

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
                txtnamapelanggan.Text = nama
                rdDB.Close()

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

    Sub simpandata()
        tgl = Format(Now, "yyyy/MM/dd HH:mm:ss")
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
        'MessageBox.Show("idpelanggan : '" & idpel & "'" & vbCrLf & "' metode byr : '" & metodbyr & "'" & vbCrLf & "' id tagihan : '" & idtagihan & "'", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        'Try
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

        'Catch ex As Exception
        'MessageBox.Show("transaksi Gagal", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End Try
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
        'Dim dibayar As Long = txtbayar.Text

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

    Private Sub txtnamapelanggan_TextChanged(sender As Object, e As EventArgs) Handles txtnamapelanggan.TextChanged

    End Sub

    Private Sub txthargaB_TextChanged(sender As Object, e As EventArgs) Handles txthargaB.TextChanged

    End Sub

    Private Sub txtkembalian_TextChanged(sender As Object, e As EventArgs) Handles txtkembalian.TextChanged

    End Sub

    Private Sub IdTransaksi_TextChanged(sender As Object, e As EventArgs) Handles IdTransaksi.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txttotalB_TextChanged(sender As Object, e As EventArgs) Handles txttotalB.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtnamaB_TextChanged(sender As Object, e As EventArgs) Handles txtnamaB.TextChanged

    End Sub

    Private Sub txtkodeB_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txttgltransaksi_ValueChanged(sender As Object, e As EventArgs) Handles txttgltransaksi.ValueChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btncancle_Click(sender As Object, e As EventArgs) Handles btncancle.Click
        reset()
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub txttotalbyr_TextChanged(sender As Object, e As EventArgs) Handles txttotalbyr.TextChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Guna2ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Guna2ContextMenuStrip1.Opening

    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Segoi UI", 10, FontStyle.Regular)
        Dim f10b As New Font("Segoi UI", 10, FontStyle.Bold)
        Dim f14 As New Font("Segoi UI", 14, FontStyle.Bold)
        Dim f8 As New Font("Segoi UI", 8, FontStyle.Regular)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "-------------------------------------------------------------"

        e.Graphics.DrawString("Nama Toko", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("Jl. Soekarno Hatta KM. 15, Tarahan, Lampung", f10, Brushes.Black, centermargin, 25, tengah)
        e.Graphics.DrawString("HP: 085669920357", f10, Brushes.Black, centermargin, 40, tengah)

        e.Graphics.DrawString("Nama Pelanggan :", f10, Brushes.Black, 0, 60)
        e.Graphics.DrawString("Tomi Andreansyah", f10, Brushes.Black, 62, 60)

        e.Graphics.DrawString(garis, f10b, Brushes.Black, centermargin, 40, tengah)
    End Sub

End Class