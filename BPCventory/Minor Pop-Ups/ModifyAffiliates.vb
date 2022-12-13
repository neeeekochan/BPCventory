Imports MySql.Data.MySqlClient

Public Class ModifyAffiliates
    Dim connToAcc As New accountsConn
    Dim cmd As New MySqlCommand
    Dim dtable As New DataTable()
    Dim da As MySqlDataAdapter
    Dim reader As MySqlDataReader

    Public Function ResetModif()
        Mainsystem.Opacity = 1
        Mainsystem.Enabled = True
        textaffiliateid.Enabled = True

        For Each bttn In {Mainsystem.EditCustomerBttn, Mainsystem.EditSupplierBttn}
            bttn.Enabled = False
        Next

        ClearAllBttn.Visible = False
        Hide()
        Mainsystem.Focus()

        For Each txt In {textaffiliateid, textcompanyname, textemail, textcontno}
            txt.Clear()
        Next

        For Each view In {AddNewCustLabel, ModifCustLabel, AddNewSuppLabel, ModifSuppLabel}
            view.Visible = False
        Next
        Return 0
    End Function

    Private Sub CancelBttn_Click(sender As Object, e As EventArgs) Handles CancelBttn.Click
        ResetModif()

        For Each label In {Label1, Label5}
            label.Visible = False
        Next
    End Sub

    Private Sub ClearAllBttn_Click(sender As Object, e As EventArgs) Handles ClearAllBttn.Click
        For Each txt In {textaffiliateid, textcompanyname, textemail, textcontno}
            txt.Clear()
        Next
        MessageBox.Show("All fields cleared!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    '*******************************************************************************************************************************
    '*******************************************************************************************************************************
    '*******************************************************************************************************************************
    '*******************************************************************************************************************************

    Function AddingToDBCustomerSupplier(cmd As MySqlCommand)
        Try
            If textaffiliateid.Text = "" Or textcompanyname.Text = "" Or textemail.Text = "" Or textcontno.Text = "" Then
                MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Data Inputted Successfully.")
                connToAcc.closeAccDB()
                ResetModif()
                Mainsystem.Show()
                Mainsystem.Load_Records()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            connToAcc.closeAccDB()
        End Try
        Return 0
    End Function

    Function UpdatingToDBCustomerSupplier(cmd As MySqlCommand)
        Try
            If textaffiliateid.Text = "" Or textcompanyname.Text = "" Or textemail.Text = "" Or textcontno.Text = "" Then
                MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Data Inputted Successfully.")
                ResetModif()
                Mainsystem.Show()
                Mainsystem.Load_Records()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return 0
    End Function

    '//FOR CUSTOMER ////
    Private Sub AddCustomerBttn_Click(sender As Object, e As EventArgs) Handles AddCustomerBttn.Click
        cmd = New MySqlCommand($"INSERT INTO customer
                VALUES ('" & textaffiliateid.Text & "', '" & textcompanyname.Text & "', '" & textemail.Text & "', '" & textcontno.Text & "')", connToAcc.openAccDB)

        AddingToDBCustomerSupplier(cmd)
    End Sub

    Private Sub UpdateCustomerBttn_Click(sender As Object, e As EventArgs) Handles UpdateCustomerBttn.Click
        cmd = New MySqlCommand($"UPDATE customer SET company_name = '" & textcompanyname.Text & "', email = '" & textemail.Text & "',
            contact_no = '" & textcontno.Text & "' WHERE customer_id = '" & textaffiliateid.Text & "'", connToAcc.openAccDB)

        UpdatingToDBCustomerSupplier(cmd)
    End Sub



    '//FOR SUPPLIER ////
    Private Sub AddSupplierBttn_Click(sender As Object, e As EventArgs) Handles AddSupplierBttn.Click
        cmd = New MySqlCommand($"INSERT INTO supplier
                VALUES ('" & textaffiliateid.Text & "', '" & textcompanyname.Text & "', '" & textemail.Text & "', '" & textcontno.Text & "')", connToAcc.openAccDB)

        AddingToDBCustomerSupplier(cmd)
    End Sub

    Private Sub UpdateSupplierBttn_Click(sender As Object, e As EventArgs) Handles UpdateSupplierBttn.Click
        cmd = New MySqlCommand($"UPDATE supplier SET company_name = '" & textcompanyname.Text & "', email = '" & textemail.Text & "',
            contact_no = '" & textcontno.Text & "' WHERE supplier_id = '" & textaffiliateid.Text & "'", connToAcc.openAccDB)

        UpdatingToDBCustomerSupplier(cmd)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class