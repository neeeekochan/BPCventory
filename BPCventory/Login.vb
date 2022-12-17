Imports MySql.Data.MySqlClient

Public Class Login
    Dim connToAcc As New accountsConn
    Dim cmd As New MySqlCommand
    Dim dtable As New DataTable()
    Dim da As MySqlDataAdapter
    Dim reader As MySqlDataReader
    Public lastname = "", firstname = "", privileges = "", userID = ""
    Public Function TryingLogin(cmd As MySqlCommand)
        Try
            da = New MySqlDataAdapter(cmd)

            dtable.Clear()
            da.Fill(dtable)
            reader = cmd.ExecuteReader

            While reader.Read
                userID = reader("user_id").ToString
                lastname = reader("lastname").ToString
                firstname = reader("firstname").ToString
                privileges = reader("privileges").ToString
            End While

            If dtable.Rows(0)("privileges") = "ADMINISTRATOR" Or dtable.Rows(0)("privileges") = "USER" Or dtable.Rows(0)("privileges") = "OWNER" Then
                MessageBox.Show("Login Confirmed. Logging in...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Mainsystem.Show()
                Hide()
            End If

        Catch ex As Exception
            connToAcc.closeAccDB()
            MessageBox.Show("Incorrect username or password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        Return 0
    End Function

    Private Sub ShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPass.CheckedChanged
        If ShowPass.Checked = True Then
            textpassword.PasswordChar = ""
        ElseIf ShowPass.Checked = False Then
            textpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub LogoutBttn_Click(sender As Object, e As EventArgs) Handles LogoutBttn.Click
        DialogResult = MessageBox.Show("Closing program, would you like to proceed?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If DialogResult = DialogResult.OK Then
            Application.Exit()
        End If
    End Sub

    Private Sub ShowPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ShowPass.KeyPress
        If Keys.Enter Then
            If ShowPass.Checked = True Then
                ShowPass.Checked = False
            ElseIf ShowPass.Checked = False Then
                ShowPass.Checked = True
            End If
        End If
    End Sub

    Private Sub SubmitBttn_Click(sender As Object, e As EventArgs) Handles LoginBttn.Click
        If textusername.Text = "" Or textpassword.Text = "" Then
            MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            cmd = New MySqlCommand($"Select user_id, username,password,privileges,lastname,firstname FROM users WHERE username= '{textusername.Text}' AND password= '{textpassword.Text}'", connToAcc.openAccDB)
            TryingLogin(cmd)
        End If

        connToAcc.closeAccDB()
        textusername.Clear()
        textpassword.Clear()
        ShowPass.Checked = False
    End Sub

    Private Sub AutologinBttn_Click(sender As Object, e As EventArgs) Handles AutologinBttn.Click
        ScanQR.Show()
    End Sub
End Class
