﻿Imports System.Text
Imports MySql.Data.MySqlClient

Public Class ModifySales
    Dim connToAcc As New accountsConn
    Dim cmd As New MySqlCommand
    Dim dtable As New DataTable()
    Dim da As MySqlDataAdapter
    Dim reader As MySqlDataReader
    Dim SmsSender As New TextMessage

    Dim custName, prod_id, options, prod_name, saleID As String
    Dim custID, saleprice, rownum As Integer


    Private Sub ModifySales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProdNameCB.Focus()
        '//////////
        '/// LOAD CUSTNAMECB - CUSTOMER NAMES
        '//////////
        cmd = New MySqlCommand($"SELECT customer_id, company_name FROM customer", connToAcc.openAccDB)
        reader = cmd.ExecuteReader()

        While reader.Read
            CustNameCB.Items.Add(String.Format("{0}-{1}", reader(0), reader(1)))
        End While
        reader.Close()
        connToAcc.closeAccDB()

        cmd = New MySqlCommand($"SELECT product_id, product_name, sale_price FROM products", connToAcc.openAccDB)
        reader = cmd.ExecuteReader()

        While reader.Read
            ProdNameCB.Items.Add(String.Format("{0}-{1}", reader(0), reader(1)))
        End While
        reader.Close()
        connToAcc.closeAccDB()
    End Sub

    Private Sub ModifySales_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Close()
    End Sub

    Private Sub AddSaleCloseBttn_Click(sender As Object, e As EventArgs) Handles AddSaleCloseBttn.Click
        Mainsystem.Show()
        Me.Close()
    End Sub

    Private Sub AddSaleDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles AddSaleDGV.CellClick
        '//DELETING RECORDS
        Dim customerDelete As String = AddSaleDGV.Columns(e.ColumnIndex).HeaderText
        If customerDelete = "DEL" Then
            If MsgBox("Delete this record?", vbYesNo + vbQuestion) = vbYes Then
                AddSaleDGV.Rows.RemoveAt(AddSaleDGV.CurrentRow.Index)
            End If
        End If

        If AddSaleDGV.Rows.Count = 0 Then
            CustNameCB.Enabled = True
            ProdQtyTB.Clear()
            TotalTB.Clear()
        End If
    End Sub

    Private Sub AddSalesBttn_Click(sender As Object, e As EventArgs) Handles AddSalesBttn.Click
        If CustNameCB.Text = "" Or ProdNameCB.Text = "" Or ProdQtyTB.Text = "" Or TotalTB.Text = "" Then
            MessageBox.Show("All fields are required!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If options = "EXISTING" Then
                AddSaleDGV.Rows(rownum).Cells(1).Value = ProdQtyTB.Text
                AddSaleDGV.Rows(rownum).Cells(2).Value = TotalTB.Text
            Else
                AddSaleDGV.Rows.Add(Convert.ToString(ProdNameCB.Text), Convert.ToString(ProdQtyTB.Text), Convert.ToString(TotalTB.Text), "Delete")
                For Each TB In {ProdQtyTB, TotalTB}
                    TB.Clear()
                Next

                CustNameCB.Enabled = False
            End If
            ProdQtyTB.Enabled = False
        End If
    End Sub

    Private Sub CustNameCB_TextChanged(sender As Object, e As EventArgs) Handles CustNameCB.TextChanged
        Dim names() As String = CustNameCB.Text.ToString.Split(New Char() {"-"c})
        custID = names(0)
        custName = names(1)
    End Sub

    Private Sub Prodnamechanged()
        ProdQtyTB.Enabled = True
        '/////clearing values in qty and total first off
        ProdQtyTB.Clear()
        TotalTB.Clear()
        '/////////

        Dim names() As String = ProdNameCB.Text.ToString.Split(New Char() {"-"c})
        prod_id = names(0)
        prod_name = names(1)

        For i As Integer = 0 To AddSaleDGV.Rows.Count - 1
            If ProdNameCB.Text = AddSaleDGV.Rows(i).Cells(0).Value Then
                ProdQtyTB.Text = AddSaleDGV.Rows(i).Cells(1).Value
                TotalTB.Text = AddSaleDGV.Rows(i).Cells(2).Value
                options = "EXISTING"
                rownum = i
                'RichTextBox1.AppendText("EXISTING" & vbNewLine)
            Else
                options = "Not"
                'RichTextBox1.AppendText("NOT" & vbNewLine)
            End If
        Next

        cmd = New MySqlCommand($"SELECT sale_price FROM products WHERE product_id = '" & prod_id & "'", connToAcc.openAccDB)
        Using reader = cmd.ExecuteReader()
            If reader.Read Then
                saleprice = reader(0)
            End If
        End Using
        connToAcc.closeAccDB()
    End Sub

    Private Sub ProdNameCB_KeyUp(sender As Object, e As KeyEventArgs) Handles ProdNameCB.KeyUp
        Dim allowed As String = ("1234567890")

        For Each c As Char In ProdNameCB.Text
            If allowed.Contains(c) = False Then
                ProdNameCB.Text = ProdNameCB.Text.Remove(ProdNameCB.SelectionStart - 1, 1)
                ProdNameCB.Select(ProdNameCB.Text.Count, 0)
            End If
        Next

        If ProdNameCB.Text.Length = 5 Then
            For Each item In ProdNameCB.Items
                If ProdNameCB.Text = Val(item).ToString Then
                    ProdNameCB.ResetText()
                    ProdNameCB.Text = item
                    Prodnamechanged()
                    Label5.Focus()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub ProdNameCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProdNameCB.SelectedIndexChanged
        Prodnamechanged()
    End Sub

    Private Sub ProdQtyTB_KeyUp(sender As Object, e As KeyEventArgs) Handles ProdQtyTB.KeyUp
        If ProdQtyTB.Text = "" Then
            ProdQtyTB.Text = 0
        Else
            Try
                TotalTB.Text = Convert.ToInt32(ProdQtyTB.Text) * saleprice
            Catch ex As Exception
                ProdQtyTB.Text = ""
            End Try
        End If
    End Sub


    '////////
    '//FINALIZING THE PURCHASE
    '///////

    Public purchasemsgnotif = ""
    Dim totalspent As Integer

    Private Sub DoneSaleBttn_Click(sender As Object, e As EventArgs) Handles DoneSalesBttn.Click
        If AddSaleDGV.Rows.Count <= 0 Then
            MessageBox.Show("There are no inputted purchases.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProdQtyTB.Clear()
            TotalTB.Clear()

        ElseIf AddSaleDGV.Rows.Count > 0 Then
            DialogResult = MessageBox.Show("Save Changes?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DialogResult.Yes Then

                Try
                    '////////////////////////////////////////
                    '///// INPUTTING IN SALES -- CATCHING THE SALES ID
                    cmd = New MySqlCommand($"INSERT INTO sales ( user_id, customer_id)
                                            VALUES ( '" & Login.userID & "', '" & custID & "'); select @@identity as ID;", connToAcc.openAccDB)

                    Using reader = cmd.ExecuteReader()
                        If reader.Read Then
                            saleID = reader.Item("ID")
                        End If
                    End Using
                    connToAcc.closeAccDB()

                    '// SMS NOTIF TO OWNER -----------------------------------------------------
                    purchasemsgnotif = "OPERATED BY: " + Login.lastname + vbCrLf +
                        "SALE ID: " + saleID + vbCrLf +
                        "Customer '" + custName + "' ordered: " + vbCrLf

                Catch ex As Exception
                    MsgBox(ex.Message)
                    connToAcc.closeAccDB()
                End Try

                Try
                    '////////////////////////////////////////
                    '////// INPUTTING IN SALES REPORT --- UPDATING PRODUCTS
                    Dim strbuilder As New System.Text.StringBuilder()
                    For i As Integer = 0 To AddSaleDGV.Rows.Count - 1

                        Dim names() As String = AddSaleDGV.Rows(i).Cells(0).Value.ToString.Split(New Char() {"-"c})
                        prod_id = names(0)
                        prod_name = names(1)

                        '///// APPENDING PURCHASE TO TXT MSG ---------------------------------------
                        'purchasemsgnotif = purchasemsgnotif & prod_name & " qty: " & AddSaleDGV.Rows(i).Cells(1).Value & "x  ---" & AddSaleDGV.Rows(i).Cells(2).Value & vbCrLf
                        strbuilder.Append(prod_name & " qty: " & AddSaleDGV.Rows(i).Cells(1).Value & "x ₱" & AddSaleDGV.Rows(i).Cells(2).Value & vbNewLine)
                        '---------------------------------------------------------------------------
                        totalspent += AddSaleDGV.Rows(i).Cells(2).Value

                        cmd = New MySqlCommand($"INSERT INTO sales_details(sales_id, product_id, sale_quantity, total)
                                                VALUES('" & saleID & "', '" & prod_id & "', '" & AddSaleDGV.Rows(i).Cells(1).Value & "', '" & AddSaleDGV.Rows(i).Cells(2).Value & "'); select @@identity as SID;", connToAcc.openAccDB)
                        cmd.ExecuteNonQuery()
                        connToAcc.closeAccDB()

                        cmd = New MySqlCommand($"UPDATE products p
                                            INNER JOIN sales_details s
                                            ON p.product_id = s.product_id
                                            SET p.in_stock = p.in_stock - s.sale_quantity  WHERE s.sales_id = '" & saleID & "' AND p.product_id = '" & prod_id & "'", connToAcc.openAccDB)
                        cmd.ExecuteNonQuery()
                        connToAcc.closeAccDB()

                    Next
                    purchasemsgnotif = purchasemsgnotif & strbuilder.ToString & "End of transaction."


                    MessageBox.Show("Purchase Inserted.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MsgBox(purchasemsgnotif)
                    SmsSender.SendSMS(purchasemsgnotif, Login.mobilenum, )

                    Mainsystem.Load_Records()
                    Mainsystem.Show()
                    Me.Close()

                Catch ex As Exception
                    MessageBox.Show("Insufficient resources. Refer to the Products window to verify amount of available stocks of desired product.", "Unable to proceed with purchase", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    connToAcc.closeAccDB()
                End Try

            ElseIf DialogResult = vbNo Then
                Mainsystem.Show()
                Me.Close()
            End If
        End If
    End Sub


    '// ASCI CHECKS ///////////////////////
    Private Sub ProdQtyTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProdQtyTB.KeyPress
        Mainsystem.AsciiCheck(e, "numbers")
    End Sub
End Class