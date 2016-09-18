Imports System.Configuration
Imports MySql.Data.MySqlClient

Module MySqlDatabase

    Class Database
        Dim ConnectionString As String
        Dim conn As MySqlConnection
        Dim cmd As MySqlCommand

        Sub New()
            ConnectionString = ConfigurationManager.ConnectionStrings("MysqlConnection").ConnectionString
        End Sub

        Function GetDataReader(sql As String) As MySqlDataReader
            conn = New MySqlConnection(ConnectionString)
            cmd = New MySqlCommand(sql, conn)
            conn.Open()
            Return cmd.ExecuteReader(CommandBehavior.CloseConnection)
        End Function

        Function GetDataScalar(sql As String) As Integer
            Dim r As Integer
            conn = New MySqlConnection(ConnectionString)
            cmd = New MySqlCommand(sql, conn)
            conn.Open()
            r = cmd.ExecuteScalar()
            conn.Close()
            Return r
        End Function

        Sub DeleteData(sql As String)
            'Dim r As Integer
            conn = New MySqlConnection(ConnectionString)
            cmd = New MySqlCommand(sql, conn)
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Sub

    End Class

End Module
