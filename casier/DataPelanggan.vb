Imports MySql.Data.MySqlClient

Public Class DataPelanggan
    Dim idpel, namepel, usernpel, phonepel, emailpel, levelpel, perusahaanpel, satkerpel, perusahaanID, satkerID As String

    Private Sub DataPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        Call movedatapelanggan()
    End Sub


    Private Sub movedatapelanggan()
        Try
            Call conecDB()
            Call initCMD()


            SQL = "SELECT * FROM users"
            With comDB
                .CommandText = SQL
                .ExecuteNonQuery()
            End With
            rdDB = comDB.ExecuteReader
            'comDB = New MySqlCommand(SQL, connDB)

            rdDB.Read()
            If rdDB.HasRows Then
                Me.Cursor = Cursors.WaitCursor
                Dim ds As New DataSet()
                Dim adDB = New MySqlDataAdapter(SQL, connDB)
                adDB.Fill(ds)
                Me.Cursor = Cursors.Default
                Call closeDB()

                If ds.Tables(0).Rows.Count > 0 Then
                    'idpel = rdDB.Item("id")



                    For Each dr As DataRow In ds.Tables(0).Rows
                        idpel = dr.Item("id")
                        namepel = dr.Item("name")
                        usernpel = dr.Item("username")
                        phonepel = dr.Item("phonenumber")
                        emailpel = dr.Item("email")
                        If dr.Item("level_id") = 1 Then
                            levelpel = "Admin"
                        ElseIf dr.Item("level_id") = 2 Then
                            levelpel = "Kasir"
                        Else
                            levelpel = "User"
                        End If
                        perusahaanID = dr.Item("perusahaan_id")
                        getperusahaan()
                        satkerID = dr.Item("satker_id")
                        getsatker()
                    Next
                Else
                    MessageBox.Show("Kosong Row Count")
                End If
                dvgPelanggan.DataSource = ds.Tables(0)
            Else
                MessageBox.Show("Kosong")
            End If

        Catch ex As Exception
        End Try

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
        perusahaanpel = rdDB.Item("nama_perusahaan")
        rdDB.Close()
    End Sub



    Sub getsatker()
        Call conecDB()
        Call initCMD()

        SQL = "SELECT * FROM satkers WHERE id = '" & satkerID & "'"
        With comDB
            .CommandText = SQL
            .ExecuteNonQuery()
        End With
        rdDB = comDB.ExecuteReader
        rdDB.Read()
        satkerpel = rdDB.Item("satker")
        rdDB.Close()
    End Sub

    Private Sub txt_ttlbyr_TextChanged(sender As Object, e As EventArgs)



    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Call movedatapelanggan()

    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_jml_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dvgPelanggan.CellContentClick

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

End Class