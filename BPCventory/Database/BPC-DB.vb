Imports MySql.Data.MySqlClient

Public Class BPC_DB
    Public DBConn As New MySqlConnection("server=localhost;username=root;password=;database=dt")
    Public Function openDB()
        Try
            DBConn.open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return DBConn
    End Function

    Public Function closeDB()
        Try
            DBConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return DBConn
    End Function
End Class
