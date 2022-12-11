Imports MySql.Data.MySqlClient

Public Class accountsConn
    Public connToAcc As New MySqlConnection("server=localhost;username=root;password=;database=BPC_accounts")
    Public Function openAccDB()
        Try
            connToAcc.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return connToAcc
    End Function

    Public Function closeAccDB()
        Try
            connToAcc.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return connToAcc
    End Function
End Class