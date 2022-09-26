Imports MySql.Data.MySqlClient
Public Class FormTransaksi
    'produks & transaksi'
    Dim kodeT As Integer
    Dim kodeB, namaB As String
    Dim hargaB, total, totalB, diabayar, kembalian, Qty, stokB As Long
    Dim tgl As Date

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

        Dim f As Long
        If txtbayar.Text = "" Or Not IsNumeric(txtbayar.Text) Then
            Exit Sub
        End If
        f = txtbayar.Text
        txtbayar.Text = Format(f, "##,###")
        txtbayar.SelectionStart = Len(txtbayar.Text)

        Dim hitung As Long = 0
        For baris As Long = 0 To dvgtampil.RowCount - 1
            hitung = hitung + dvgtampil.Rows(baris).Cells(4).Value
        Next

        kembalian = txtbayar.Text - hitung
        If (kembalian > 0) Then
            txtkembalian.Text = "Rp. " + Format(kembalian, "##,###")
        Else
            txtkembalian.Text = 0
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

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        txtjumlahB.Value = 0
        txtkodeB.Text = ""
        txtnamaB.Text = ""
        txthargaB.Text = ""
        txttotalB.Text = ""
    End Sub

    Sub delrow()
        If dvgtampil.CurrentRow.Index <> dvgtampil.NewRowIndex Then
            dvgtampil.Rows.RemoveAt(dvgtampil.CurrentRow.Index)
        End If
    End Sub

    Private Sub BtnBayar_Click(sender As Object, e As EventArgs) Handles BtnBayar.Click

    End Sub

    Private Sub txtnamapelanggan_TextChanged(sender As Object, e As EventArgs) Handles txtnamapelanggan.TextChanged

    End Sub

    Private Sub txthargaB_TextChanged(sender As Object, e As EventArgs) Handles txthargaB.TextChanged

    End Sub

    Private Sub txtkembalian_TextChanged(sender As Object, e As EventArgs) Handles txtkembalian.TextChanged

    End Sub

    Private Sub IdTransaksi_TextChanged(sender As Object, e As EventArgs) Handles IdTransaksi.TextChanged

    End Sub


    Private Sub txtkodeB_TextChanged(sender As Object, e As EventArgs) Handles txtkodeB.TextChanged, txtkodeB.KeyPress


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

    Sub movedata()

        dvgtampil.AllowUserToAddRows = True
        dvgtampil.RowCount = dvgtampil.RowCount + 1

        dvgtampil(0, dvgtampil.RowCount - 2).Value = kodeB
        dvgtampil(1, dvgtampil.RowCount - 2).Value = namaB
        dvgtampil(2, dvgtampil.RowCount - 2).Value = hargaB
        dvgtampil(3, dvgtampil.RowCount - 2).Value = Qty
        dvgtampil(4, dvgtampil.RowCount - 2).Value = totalB

        dvgtampil.AllowUserToAddRows = False

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
End Class