Imports MySql.Data.MySqlClient

Public Class accountsConn
    'Public connToAcc As New MySqlConnection("server=db4free.net;port=3306;user id=nekochan;password=123456789;database=bpc_accounts;Connect Timeout=100000;pooling=true;")
    'Public connToAcc As New MySqlConnection("server=sql.freedb.tech;port=3306;uid=freedb_nekochan;password=yMddXcE$d5Z@EgQ;database=freedb_bpc_accounts;Connect Timeout=100000;pooling=true;")
    Public connToAcc As New MySqlConnection("server=localhost;uid=root;password=;database=dt; Convert Zero Datetime=true;")
    'Public connToAcc As New MySqlConnection("server=remotemysql.com;uid=q8cEGSgoR2;password=2DDeQFujAY;database=q8cEGSgoR2;Connect Timeout=10000;pooling=true;")
    Public Function openAccDB()
        Try
            connToAcc.Open()
        Catch ex As Exception
            MsgBox("Nakaopen") '//REMEMBER TO EDIT THESE!!!!
        End Try
        Return connToAcc
    End Function

    Public Function closeAccDB()
        Try
            connToAcc.Close()
        Catch ex As Exception
            MsgBox("Nakaclose") '//REMEMBER TO EDIT THESE!!!!
        End Try
        Return connToAcc
    End Function
End Class