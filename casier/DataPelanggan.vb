Public Class DataPelanggan
    Private Sub FormStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
    End Sub

    Private Sub txt_ttlbyr_TextChanged(sender As Object, e As EventArgs) Handles txt_ttlbyr.TextChanged



    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click

        Dim jml = txt_jml.Text
        Dim hrgbrg = txt_hrg.Text
        txt_ttlbyr.Text = jml * hrgbrg
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txt_jml_TextChanged(sender As Object, e As EventArgs) Handles txt_jml.TextChanged

    End Sub
End Class