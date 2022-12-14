Public Class MenuUtama
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Hiden()
        FormTransaksi.TopLevel = False
        Panel1.Controls.Add(FormTransaksi)
        FormTransaksi.Show()
    End Sub

    Sub Hiden()
        FormTransaksi.Hide()
        DataBarang.Hide()
        DataPelanggan.Hide()
        FormUtama.Hide()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click

    End Sub

    Private Sub DataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem.Click
        Hiden()
        DataBarang.TopLevel = False
        Panel1.Controls.Add(DataBarang)
        DataBarang.Show()
    End Sub

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormUtama.TopLevel = False
        Panel1.Controls.Add(FormUtama)
        FormUtama.Show()
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataUserToolStripMenuItem.Click
        Hiden()
        DataPelanggan.TopLevel = False
        Panel1.Controls.Add(DataPelanggan)
        DataPelanggan.Show()
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Hiden()
        FormUtama.TopLevel = False
        Panel1.Controls.Add(FormUtama)
        FormUtama.Show()
    End Sub
End Class