Imports MySql.Data.MySqlClient

Public Class Login
    Dim connToAcc As New accountsConn
    Dim cmd As New MySqlCommand
    Dim dtable As New DataTable()
    Dim da As MySqlDataAdapter
    Dim reader As MySqlDataReader
    Dim SmsSender As New TextMessage
    Public lastname = "", firstname = "", privileges = "", userID = "", mobilenum = "", OTP = "", otpmsg = ""

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OTPPanel.SendToBack()
    End Sub

    Public Function TryingLogin(cmd As MySqlCommand)
        Try
            da = New MySqlDataAdapter(cmd)

            dtable.Clear()
            da.Fill(dtable)

            If dtable.Rows.Count > 0 Then

                '// WILL BE READING FOR MATCHING INFO
                Using reader = cmd.ExecuteReader
                    While reader.Read
                        userID = reader("user_id").ToString
                        lastname = reader("lastname").ToString
                        firstname = reader("firstname").ToString
                        privileges = reader("privileges").ToString
                        mobilenum = reader("mobile_number").ToString
                    End While
                End Using

                '// SENDING OTP TO THE MOBILE NUMBER
                OTPPanel.BringToFront()
                MaskedTextBox1.Focus()
                OTP = Mainsystem.RandGen(1234567890, 6)

                otpmsg = OTP & " is your authentication code. For your protection, do not share this code with anyone."

                Try
                    SmsSender.SendSMS(otpmsg, mobilenum, )
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            ElseIf dtable.Rows.Count < 1 Then
                MessageBox.Show("Incorrect username or password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            connToAcc.closeAccDB()
            MessageBox.Show("Incorrect username or password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MsgBox(ex.Message)
        End Try

        Return 0
    End Function

    Private Sub SendOTPBttn_Click(sender As Object, e As EventArgs) Handles SendOTPBttn.Click
        '// VERIFYING OTP
        If MaskedTextBox1.Text = OTP Then
            MessageBox.Show("Login Confirmed. Logging in...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Mainsystem.Show()
            OTPPanel.SendToBack()
            MaskedTextBox1.ResetText()
            Hide()
        Else
            MessageBox.Show("Incorrect inputted OTP. Try again later.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MaskedTextBox1.Clear()
        End If
    End Sub

    Private Sub CancelOTPBttn_Click(sender As Object, e As EventArgs) Handles CancelOTPBttn.Click
        OTPPanel.SendToBack()
        MaskedTextBox1.Clear()
    End Sub

    '///////////////////////////////
    '/////RESENDING OTP
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        OTP = Mainsystem.RandGen(1234567890, 6)
    End Sub

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
            cmd = New MySqlCommand($"Select user_id, username,password,privileges,lastname,firstname,mobile_number FROM users WHERE username= '{textusername.Text}' AND password= '{textpassword.Text}'", connToAcc.openAccDB)
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
