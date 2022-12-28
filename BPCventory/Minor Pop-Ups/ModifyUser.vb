Imports MySql.Data.MySqlClient

Public Class ModifyUser
    Dim connToAcc As New accountsConn
    Dim cmd As New MySqlCommand
    Dim dtable As New DataTable()
    Dim da As MySqlDataAdapter
    Dim reader As MySqlDataReader

    Public Function ResetModif()
        Mainsystem.Opacity = 1
        Mainsystem.Enabled = True
        Mainsystem.EditUserMngmtBttn.Enabled = False
        Hide()
        Mainsystem.Focus()

        For Each txt In {textfname, textuname, textpass1, textMN, textemail, textage, textpass2, textlname}
            txt.Clear()
        Next
        Return 0
    End Function
    Private Sub CancelBttn_Click(sender As Object, e As EventArgs) Handles CancelBttn.Click
        ResetModif()
    End Sub

    Public Sub ClearAllBttn_Click(sender As Object, e As EventArgs) Handles ClearAllBttn.Click
        For Each txt In {textfname, textuname, textpass1, textMN, textemail, textage, textpass2, textlname}
            txt.Clear()
        Next
        MessageBox.Show("All fields cleared!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AddUserBttn_Click(sender As Object, e As EventArgs) Handles AddUserBttn.Click
        Try
            If textfname.Text = "" Or textuname.Text = "" Or textpass1.Text = "" Or textMN.Text = "" Or
                    textemail.Text = "" Or textage.Text = "" Or textpass2.Text = "" Or textlname.Text = "" Then
                MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If textpass1.Text = textpass2.Text Then
                    Dim textrandom = Mainsystem.RandGen()

                    cmd = New MySqlCommand($"INSERT INTO users
                    VALUES ('', '" & textfname.Text & "', '" & textlname.Text & "', '" & textuname.Text & "', '" & textpass1.Text & "',
                            '" & textage.Text & "', '" & textemail.Text & "', '" & textMN.Text & "', '" & textpriv.Text & "',
                            '" & textrandom & "')", connToAcc.openAccDB)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Inputted Successfully.")
                    MessageBox.Show("Copy and save your unique key(IMPORTANT)." & vbCrLf & textrandom, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    ResetModif()
                    Mainsystem.Show()
                    Mainsystem.Load_Records()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            connToAcc.closeAccDB()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub UpdateBttn_Click(sender As Object, e As EventArgs) Handles UpdateBttn.Click
        Try
            If textfname.Text = "" Or textuname.Text = "" Or textpass1.Text = "" Or textMN.Text = "" Or
                    textemail.Text = "" Or textage.Text = "" Or textpass2.Text = "" Or textlname.Text = "" Then
                MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf textMN.Text.Length > 12 And textMN.Text.Length < 10 Then
                MessageBox.Show("Invalid Mobile Number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If textpass1.Text = textpass2.Text Then
                    cmd = New MySqlCommand($"UPDATE users SET firstname = '" & textfname.Text & "', lastname = '" & textlname.Text & "',
                    password = '" & textpass1.Text & "', age = '" & textage.Text & "', email = '" & textemail.Text & "', mobile_number = '" & textMN.Text & "',
                    privileges = '" & textpriv.Text & "' WHERE user_id = '" & Mainsystem.user_id & "'", connToAcc.openAccDB)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Inputted Successfully.")
                    connToAcc.closeAccDB()
                    Mainsystem.Close()
                    Mainsystem.Show()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            connToAcc.closeAccDB()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPass.CheckedChanged
        If ShowPass.Checked = True Then
            textpass1.PasswordChar = ""
            textpass2.PasswordChar = ""
        ElseIf ShowPass.Checked = False Then
            textpass1.PasswordChar = "*"
            textpass2.PasswordChar = "*"
        End If
    End Sub


    '/////////// ASCII CHECKS //////////////
    Private Sub textMN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textMN.KeyPress
        Mainsystem.AsciiCheck(e, "numbers")
    End Sub

    Private Sub textage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textage.KeyPress
        Mainsystem.AsciiCheck(e, "numbers")
    End Sub

    Private Sub textfname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textfname.KeyPress
        Mainsystem.AsciiCheck(e, "texts")
    End Sub

    Private Sub textlname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textlname.KeyPress
        Mainsystem.AsciiCheck(e, "texts")
    End Sub
End Class