Imports System.Text
Imports MySql.Data.MySqlClient

Public Class ModifySales
    Dim connToAcc As New accountsConn
    Dim cmd As New MySqlCommand
    Dim dtable As New DataTable()
    Dim da As MySqlDataAdapter
    Dim reader As MySqlDataReader

    Dim prod_id, options, prod_name, saleID As String
    Dim custID, saleprice, rownum As Integer


    Private Sub ModifySales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub AddSaleCloseBttn_Click(sender As Object, e As EventArgs) Handles AddSaleCloseBttn.Click
        Me.Close()
        Mainsystem.Show()
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
                'RichTextBox1.AppendText("EXISTING - ADDBTTN" & vbNewLine & "/////////////////" & vbNewLine)
            Else
                AddSaleDGV.Rows.Add(Convert.ToString(ProdNameCB.Text), Convert.ToString(ProdQtyTB.Text), Convert.ToString(TotalTB.Text), "Delete")
                'RichTextBox1.AppendText("NOT - ADDBTTN" & vbNewLine & "/////////////////" & vbNewLine)
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

    Private Sub ProdNameCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProdNameCB.SelectedIndexChanged
        Prodnamechanged()
    End Sub

    Private Sub ProdQtyTB_KeyUp(sender As Object, e As KeyEventArgs) Handles ProdQtyTB.KeyUp
        If ProdQtyTB.Text = "" Then
            ProdQtyTB.Text = 0
        Else
            TotalTB.Text = Convert.ToInt32(ProdQtyTB.Text) * saleprice
        End If
    End Sub


    '////////
    '//FINALIZING THE PURCHASE
    '///////
    Private Sub DoneSaleBttn_Click(sender As Object, e As EventArgs) Handles DoneSalesBttn.Click
        If AddSaleDGV.Rows.Count <= 0 Then
            MessageBox.Show("There are no inputted purchases.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ProdQtyTB.Clear()
            TotalTB.Clear()

        ElseIf AddSaleDGV.Rows.Count > 0 Then
            DialogResult = MessageBox.Show("Save Changes?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DialogResult.Yes Then
                'RichTextBox1.AppendText(Login.userID & vbNewLine)

                '////////////////////////////////////////
                '///// INPUTTING IN SALES -- CATCHING THE SALES ID
                Dim datetime As Date = DateTime.Now

                cmd = New MySqlCommand($"INSERT INTO sales ( user_id, customer_id)
                                            VALUES ( '" & Login.userID & "', '" & custID & "'); select @@identity as ID;", connToAcc.openAccDB)

                'cmd.Parameters.Add("@saledate", MySqlDbType.DateTime).Value = datetime

                Using reader = cmd.ExecuteReader()
                    If reader.Read Then
                        saleID = reader.Item("ID")
                    End If
                End Using
                connToAcc.closeAccDB()

                '////////////////////////////////////////
                '////// INPUTTING IN SALES REPORTcxc
                For i As Integer = 0 To AddSaleDGV.Rows.Count - 1

                    Dim names() As String = AddSaleDGV.Rows(i).Cells(0).Value.ToString.Split(New Char() {"-"c})
                    prod_id = names(0)
                    'RichTextBox1.AppendText("SALEID: " & saleID & vbNewLine & prod_id & vbNewLine & "QTY:" & AddSaleDGV.Rows(i).Cells(1).Value & vbNewLine & "Total:" & AddSaleDGV.Rows(i).Cells(2).Value & "////////////////" & vbNewLine)

                    cmd = New MySqlCommand($"INSERT INTO sales_details(sales_id, product_id, sale_quantity, total)
                                                VALUES('" & saleID & "', '" & prod_id & "', '" & AddSaleDGV.Rows(i).Cells(1).Value & "', '" & AddSaleDGV.Rows(i).Cells(2).Value & "')", connToAcc.openAccDB)

                    cmd.ExecuteNonQuery()
                    connToAcc.closeAccDB()
                Next
                MessageBox.Show("Purchase Inserted.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Mainsystem.Load_Records()
                Me.Close()
            End If
        End If
    End Sub
End Class