Imports MySql.Data.MySqlClient

Public Class ScanQR
    Dim connToAcc As New accountsConn
    Dim cmd As New MySqlCommand

    Private Sub ScanQR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        QRCodeTxt.Focus()
    End Sub

    '--------------------- TEXTBOX CAPTURING THE QRCODE TEXT CHANGING -----------------------------

    Private Sub QRCodeTxt_KeyUp(sender As Object, e As KeyEventArgs) Handles QRCodeTxt.KeyUp
        If QRCodeTxt.Text.Length >= 20 Then
            cmd = New MySqlCommand($"Select privileges,lastname,firstname FROM users WHERE unique_ID = '" & QRCodeTxt.Text & "'", connToAcc.openAccDB)
            Try
                Login.TryingLogin(cmd)
                Hide()
            Catch ex As Exception
                MessageBox.Show("Invalid Unique ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Hide()
                Login.Show()
            End Try
            QRCodeTxt.Clear()
            connToAcc.closeAccDB()
        End If
    End Sub


    '------------------ TEXTBOX FOCUSING And CAPTURING ALL QRCODE -------------------------

    Private Sub ScanQR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If Me.QRCodeTxt.Focused = False Then
            QRCodeTxt.Focus()
            QRCodeTxt.Text = e.KeyChar.ToString
            QRCodeTxt.SelectionStart = QRCodeTxt.Text.Length
            e.Handled = True
        End If
    End Sub
    '---------------------------------------------------------------------------------------------

    Private Sub ScanQR_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.Close()
    End Sub
End Class