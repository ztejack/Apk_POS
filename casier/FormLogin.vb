Imports Guna.UI2.WinForms

Public Class FormLogin
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If ValidasiEntry() = True Then
            InEmail.Select()
            Exit Sub
        End If

        Call conecDB()      'Open the connection to database
        Call initCMD()      'Initialize the sqlclient command object
        Call CekUser()
    End Sub

    Private Sub btn_cancle_Click(sender As Object, e As EventArgs) Handles btn_cancle.Click
        Me.Close()
    End Sub
    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InPassword.Text = ""
        InEmail.Text = ""
        InEmail.Select()
    End Sub

    Private Function ValidasiEntry() As Boolean
        'Make sure that all fields have values
        If Me.InEmail.Text.Trim = "" Or
            Me.InPassword.Text.Trim = "" Then
            MsgBox("Username & Password Harus Diisi!", MsgBoxStyle.Exclamation, "Insufficient Data")
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        If ValidasiEntry() = True Then
            InEmail.Select()
            Exit Sub
        End If

        Call conecDB()      'Open the connection to database
        Call initCMD()      'Initialize the sqlclient command object
        Call CekUser()
    End Sub

    'Load data user
    Private Sub CekUser()
        Try
            SQL = "SELECT * FROM users WHERE email ='" & Me.InEmail.Text & "'"
            '"AND password ='" & getMD5Hash(InPassword.Text) & "'"

            With comDB
                .CommandText = SQL
                .ExecuteNonQuery()
            End With
            rdDB = comDB.ExecuteReader
            rdDB.Read()
            If InEmail.Text = "" Or InPassword.Text = "" Then
                MsgBox("Harap Isi Email dan Password anda", MsgBoxStyle.Exclamation, "Information")


            ElseIf rdDB.HasRows = True Then
                If rdDB("level_id").ToString = "0" Then
                    Me.Hide()
                    MenuUtama.Show()

                    'FormStatus.Show()
                    'FormStatus.TXT1.Text = rdDB!name.ToString.Trim
                    'Dim password = BCrypt.Net.BCrypt.HashPassword("value")
                    'FormStatus.TXT2.Text = getMD5Hash(InPassword.Text)
                    'FormStatus.txt_nmbrg.Text = getMD5Hash(InPassword.Text)
                ElseIf rdDB("level_id").ToString = "1" Then
                    Me.Hide()
                    MenuUtama.Show()

                    'FormStatus.Show()
                    'FormStatus.TXT1.Text = rdDB!name.ToString.Trim
                    'Dim password = BCrypt.Net.BCrypt.HashPassword("value")
                    'FormStatus.TXT2.Text = getMD5Hash(InPassword.Text)
                    'FormStatus.txt_nmbrg.Text = getMD5Hash(InPassword.Text)
                Else
                    MsgBox("Email '" & InEmail.Text & "' tidak memiliki akses", MsgBoxStyle.Exclamation, "Information")
                    InEmail.Text = ""
                    InPassword.Text = ""
                    InEmail.Select()
                End If

            Else
                MsgBox("Email '" & InEmail.Text & "' tidak terdaftar", MsgBoxStyle.Exclamation, "Information")
                InEmail.Text = ""
                InPassword.Text = ""
                'InEmail.Select()
            End If
            rdDB.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LoadData(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles InPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            ProcessTabKey(True) 'Move to next text box
        End If
    End Sub

    Private Sub InEmail_TextChanged(sender As Object, e As EventArgs) Handles InEmail.TextChanged

    End Sub
End Class
