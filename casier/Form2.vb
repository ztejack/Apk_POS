Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TransaksiId()
        Dim strSementara As String = ""
        Dim strIsi As String = ""
        conecDB()

        Try
            SQL = "SELECT * FROM order by id desc"
            With comDB
                .CommandText = SQL
                .ExecuteNonQuery()
            End With
            rdDB = comDB.ExecuteReader
            rdDB.Read()

            If rdDB.Read Then
                strSementara = Mid(rdDB.Item("id"), 2, 2)
                strIsi = Val(strSementara) + 1
                IdTransaksi.Text = "P" + Mid("0", 1, 2 - strIsi.Length) & strIsi
            Else
                IdTransaksi.Text = "P01"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            SQL = "INSERT INTO order  orderkode ('" + IdTransaksi.Text() + "'"
            '"AND password ='" & getMD5Hash(InPassword.Text) & "'" 
            With comDB
                .CommandText = SQL
                .ExecuteNonQuery()
            End With
            rdDB = comDB.ExecuteReader
            rdDB.Read()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        closeDB()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles BtnReset.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub IdTransaksi_TextChanged(sender As Object, e As EventArgs) Handles IdTransaksi.TextChanged

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        TransaksiId()
    End Sub
End Class