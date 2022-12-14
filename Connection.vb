Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient.MySqlConnection
Imports System.Data

Module Connection
    '-- MySQL Connection
    Public connDB As New MySql.Data.MySqlClient.MySqlConnection
    Public comDB As New MySql.Data.MySqlClient.MySqlCommand
    Public rdDB As MySql.Data.MySqlClient.MySqlDataReader
    Public adDB As MySql.Data.MySqlClient.MysqlDataAdapter
    Public myError As MySql.Data.MySqlClient.MySqlError

    Public SQL As String

    Public Sub conecDB()
        'This is the connection for your MS SQL Server
        'Dim strServer As String = "alfian-pc"    'This is the server IP/Server name.  If server is intalled on your local machine, your IP should be 127.0.0.1 or you may use localhost
        Dim strServer As String = "localhost"
        Dim strDbase As String = "pkl_koperasi"   'Database name
        Dim strUser As String = "root"                'Database user
        Dim strPass As String = ""     'Database password

        'MySQL Connection String
        If connDB.State <> ConnectionState.Open Then connDB.ConnectionString = "server=" & strServer.Trim & ";database=" & strDbase.Trim & ";user=" & strUser.Trim & ";password=" & strPass
        If connDB.State <> ConnectionState.Open Then connDB.Open()
    End Sub

    'Close the connection from database
    Public Sub closeDB()
        If connDB.State <> ConnectionState.Closed Then connDB.Close()
    End Sub

    'Initialize the sql command object
    Public Sub initCMD()
        With comDB
            .Connection = connDB
            .CommandType = CommandType.Text
            .CommandTimeout = 0
        End With
    End Sub

End Module
