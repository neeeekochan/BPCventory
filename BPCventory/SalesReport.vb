Public Class SalesReport
    Private Sub LogoutBttn_Click(sender As Object, e As EventArgs) Handles LogoutBttn.Click
        DialogResult = MessageBox.Show("Logging out, proceed?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If DialogResult = DialogResult.OK Then
            Hide()
            Login.Show()
        End If
    End Sub

    Private Sub SalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WelcomeLabel.Text = "Welcome! " + Login.privileges + " " + Login.lastname + ", " + Login.firstname + "."
    End Sub
End Class