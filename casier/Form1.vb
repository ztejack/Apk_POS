Public Class FormUtama
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Hiden()
        Form4.TopLevel = False
        Panel1.Controls.Add(Form4)
        Form4.Show()
    End Sub
    Sub Hiden()
        Form2.Hide()
        Form3.Hide()
        Form4.Hide()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Hiden()
        Form2.TopLevel = False
        Panel1.Controls.Add(Form2)
        Form2.Show()
    End Sub

    Private Sub DataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem.Click
        Hiden()
        Form3.TopLevel = False
        Panel1.Controls.Add(Form3)
        Form3.Show()
    End Sub
End Class