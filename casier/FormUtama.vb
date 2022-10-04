Public Class FormUtama
    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
    Sub Hiden()
        FormTransaksi.Hide()
        DataPelanggan.Hide()
        DataBarang.Hide()
        Me.Hide()
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        Hiden()
        FormTransaksi.TopLevel = False
        MenuUtama.Panel1.Controls.Add(FormTransaksi)
        FormTransaksi.Show()
    End Sub

    Private Sub btnDataPelanggan_Click(sender As Object, e As EventArgs) Handles btnDataPelanggan.Click
        Hiden()
        DataPelanggan.TopLevel = False
        MenuUtama.Panel1.Controls.Add(DataPelanggan)
        DataPelanggan.Show()
    End Sub

    Private Sub btnDataBarang_Click(sender As Object, e As EventArgs) Handles btnDataBarang.Click
        Hiden()
        DataBarang.TopLevel = False
        MenuUtama.Panel1.Controls.Add(DataBarang)
        DataBarang.Show()
    End Sub
End Class