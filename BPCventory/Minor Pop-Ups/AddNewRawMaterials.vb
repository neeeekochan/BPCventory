Imports MySql.Data.MySqlClient

Public Class AddNewRawMaterials
    Dim connToAcc As New accountsConn
    Dim cmd As New MySqlCommand
    Dim dtable As New DataTable()
    Dim da As MySqlDataAdapter
    Dim reader As MySqlDataReader
    Public MaterialIDval, CompanyNameval As String
    Dim expectedInt, instockInt As Integer
    Public opt As Integer

    Dim smssender As New TextMessage

#Region "ADD NEW RAW MATERIAL --- ADD AND EDIT"
    Private Sub AddNewRawMaterials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '// COMBOBOX OF SUPPLIER
            cmd = New MySqlCommand($"SELECT supplier_id, company_name FROM supplier ORDER BY supplier_id ASC", connToAcc.openAccDB)
            reader = cmd.ExecuteReader
            While reader.Read
                SupNameIDCB.Items.Add(String.Format("{0}-{1}", reader(0), reader(1)))
                SupplierName.Items.Add(String.Format("{0}-{1}", reader(0), reader(1)))
                ORDSuppCB.Items.Add(String.Format("{0}-{1}", reader(0), reader(1)))

            End While
            reader.Close()
            connToAcc.closeAccDB()

            '// COMBOBOX OF MATERIAL ID AVAILABLE
            cmd = New MySqlCommand($"SELECT material_id, material_name FROM materials ORDER BY material_id ASC", connToAcc.openAccDB)
            reader = cmd.ExecuteReader
            While reader.Read
                MatIDCB.Items.Add(String.Format("{0}-{1}", reader(0), reader(1)))
                ORDMatNameCB.Items.Add(String.Format("{0}-{1}", reader(0), reader(1)))
            End While
            reader.Close()
            connToAcc.closeAccDB()

        Catch ex As Exception
            connToAcc.closeAccDB()
            MsgBox("Error sa Load")
        End Try


    End Sub

    Function Overwrite()
        '-------------------- PRESET DESCRIPTION ------------------------------
        MaterialName.Text = "Material Name"
        AverageCost.Text = "Average Cost of Material"
        InStock.Text = "Quantity in Stock"
        SupplierName.Text = "Supplier of Materials"

        For Each fcolor In {MaterialName, AverageCost, InStock}
            fcolor.ForeColor = Color.Gray
        Next

        SupplierName.Enabled = True
        InStock.Enabled = True
        Label1.Visible = False
        '------------------------------------------------------

        Return 0
    End Function

    Function AddNewRawMaterial(cmd As MySqlCommand)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Data Inputted Successfully.")
            ModifyAffiliates.ResetModif()
            Mainsystem.Show()
            Mainsystem.Load_Records()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            connToAcc.closeAccDB()
        End Try
        Return 0
    End Function

    Private Sub CancelBttn_Click(sender As Object, e As EventArgs) Handles CancelBttn.Click
        Mainsystem.Opacity = 1
        Mainsystem.Enabled = True
        Close()
        Mainsystem.Load_Records()
    End Sub

    Private Sub ClearAllBttn_Click(sender As Object, e As EventArgs) Handles ClearAllBttn.Click
        MessageBox.Show("All Fields Cleared", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Overwrite()
    End Sub

    '//
    '//
    '//
    '//

#Region "TEXTBOX DESC, APPEARANCE, DISAPPEARANCE"
    '--------------------- TEXTBOX DESCRIPTION APPEARANCE AND DISAPPEARANCE --------------------

    Private Sub MaterialName_MouseClick(sender As Object, e As MouseEventArgs) Handles MaterialName.MouseClick
        If MaterialName.Text = "Material Name" Then
            MaterialName.Clear()
            MaterialName.ForeColor = Color.Black
        End If
    End Sub

    Private Sub MaterialName_Leave(sender As Object, e As EventArgs) Handles MaterialName.Leave
        If MaterialName.Text = "" Then
            MaterialName.Text = "Material Name"
            MaterialName.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub AverageCost_MouseClick(sender As Object, e As MouseEventArgs) Handles AverageCost.MouseClick
        If AverageCost.Text = "Average Cost of Material" Then
            AverageCost.Clear()
            AverageCost.ForeColor = Color.Black
        End If
    End Sub

    Private Sub AverageCost_Leave(sender As Object, e As EventArgs) Handles AverageCost.Leave
        If AverageCost.Text = "" Then
            AverageCost.Text = "Average Cost of Material"
            AverageCost.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub InStock_MouseClick(sender As Object, e As MouseEventArgs) Handles InStock.MouseClick
        If InStock.Text = "Quantity in Stock" Then
            InStock.Clear()
            InStock.ForeColor = Color.Black
        End If
    End Sub

    Private Sub InStock_Leave(sender As Object, e As EventArgs) Handles InStock.Leave
        If InStock.Text = "" Then
            InStock.Text = "Quantity in Stock"
            InStock.ForeColor = Color.Gray
        End If
    End Sub


    Private Sub SupplierName_MouseClick(sender As Object, e As MouseEventArgs) Handles SupplierName.MouseClick
        If SupplierName.Text = "Supplier of Materials" Then
            SupplierName.ForeColor = Color.Black
        End If
    End Sub

    Private Sub SupplierName_Leave(sender As Object, e As EventArgs) Handles SupplierName.Leave
        If SupplierName.Text = "" Then
            SupplierName.Text = "Supplier of Materials"
            SupplierName.ForeColor = Color.Gray
        End If
    End Sub

#End Region

    '//ADDING NEW RAW MATERIALS TO INVENTORY --------- 
    Private Sub AddNewMtrlBttn_Click(sender As Object, e As EventArgs) Handles AddNewMtrlBttn.Click
        Try
            If MaterialName.Text = "Material Name" Or AverageCost.Text = "Average Cost of Material" Or InStock.Text = "Quantity in Stock" Or
                SupplierName.Text = "" Then
                MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If opt = 1 Then
                    cmd = New MySqlCommand($"INSERT INTO materials ( material_name, average_cost, in_stock, supplier_id)
                                            VALUES ('" & MaterialName.Text & "', '" & AverageCost.Text & "', '" & InStock.Text & "',
                                            (SELECT supplier_id FROM supplier WHERE company_name = '" & CompanyNameval & "'))", connToAcc.openAccDB)

                    AddNewRawMaterial(cmd)

                ElseIf opt = 2 Then
                    cmd = New MySqlCommand($"UPDATE materials SET material_name = '" & MaterialName.Text & "', average_cost = '" & AverageCost.Text & "',
                                                                in_stock = '" & InStock.Text & "',
                                                                supplier_id = (SELECT supplier_id FROM supplier WHERE company_name = '" & CompanyNameval & "')
                                                                WHERE material_id = '" & MaterialIDval & "'", connToAcc.openAccDB)

                    AddNewRawMaterial(cmd)
                End If
            End If
        Catch ex As Exception
            connToAcc.closeAccDB()
            MsgBox("Error sa Button Add")
        End Try
    End Sub

    Private Sub SupplierName_TextChanged(sender As Object, e As EventArgs) Handles SupplierName.TextChanged
        Try
            Dim names() As String = SupplierName.Text.ToString.Split(New Char() {"-"c})
            CompanyNameval = names(1)
        Catch ex As Exception
            Try
                Dim names() As String = SupplierName.SelectedIndex.ToString.Split(New Char() {"-"c})
                CompanyNameval = names(1)
            Catch ex1 As Exception
                Exit Sub
            End Try
        End Try
    End Sub
    '----------------------------------------------------------------------------
    '----------------------------------------------------------------------------
#End Region

#Region "ADD TO STOCK IN RAW MATERIALS"
    Private Sub M_IDKeyUpIndexChanged(ByVal CBbox As Double)
        Try
            cmd = New MySqlCommand($"SELECT materials.material_id, materials.material_name, materials.average_cost,
                                    materials.in_stock, expected,
                                    supplier.supplier_id, supplier.company_name
                                    FROM materials
                                    INNER JOIN supplier ON materials.supplier_id = supplier.supplier_id
                                    WHERE materials.material_id = '" & CBbox & "'", connToAcc.openAccDB)
            da = New MySqlDataAdapter(cmd)

            Dim dtable As New DataTable
            dtable.Clear()
            da.Fill(dtable)
            connToAcc.closeAccDB()

            If dtable.Rows.Count > 0 Then
                '/// FOR ADDING TO STOCK ----------------------------
                MatIDCB.Text = String.Format("{0}-{1}", dtable.Rows(0).Item("material_id"), dtable.Rows(0).Item("material_name"))
                MatNameTB.Text = dtable.Rows(0).Item("material_name")
                ExpectedTB.Text = dtable.Rows(0).Item("expected")
                AverageCostTB.Text = dtable.Rows(0).Item("average_cost")
                InStockTB.Text = dtable.Rows(0).Item("in_stock")
                SupNameIDCB.Text = (String.Format("{0}-{1}", dtable.Rows(0).Item("supplier_id"), dtable.Rows(0).Item("company_name")))

                MaterialIDval = dtable.Rows(0).Item("material_id")
                CompanyNameval = dtable.Rows(0).Item("company_name")

                opt = 2
                SupNameIDCB.Enabled = False
                AddToQuantityNUD.Value = 0
                '///-----------------------------------------------------------------
                '
                '
                '
                '// FOR PERFORMING ORDER TO SUPPLIER --------------------------------

                ORDMatNameCB.Text = String.Format("{0}-{1}", dtable.Rows(0).Item("material_id"), dtable.Rows(0).Item("material_name"))
                ORDSuppCB.Text = (String.Format("{0}-{1}", dtable.Rows(0).Item("supplier_id"), dtable.Rows(0).Item("company_name")))
                ORDPriceTB.Text = dtable.Rows(0).Item("average_cost")

                '//------------------------------------------------------------------------
            ElseIf dtable.Rows.Count = 0 Then

                opt = 1
                SupNameIDCB.Enabled = True

            End If

            connToAcc.closeAccDB()
        Catch ex As Exception
            MessageBox.Show("Choose from all the given Material ID's, or leave blank. (New Material ID's are auto-generated.)", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connToAcc.closeAccDB()
        End Try

    End Sub

    Private Sub MatIDCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MatIDCB.SelectedIndexChanged
        M_IDKeyUpIndexChanged(Val(MatIDCB.SelectedItem))
        connToAcc.closeAccDB()
    End Sub

    Private Sub ADDTOSTOCKBTTN_Click(sender As Object, e As EventArgs) Handles ADDTOSTOCKBTTN.Click
        '// ADDING QUANTITY INTO INSTOCK.TEXT -----------------------
        Try
            InStockTB.Text += AddToQuantityNUD.Value
            ExpectedTB.Text -= AddToQuantityNUD.Value

            If ExpectedTB.Text < 0 Then
                MessageBox.Show("Insufficient Expected Materials", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                M_IDKeyUpIndexChanged(Val(MatIDCB.SelectedItem))
                Exit Sub
            End If
        Catch ex As Exception
            connToAcc.closeAccDB()
            MsgBox(ex.Message)
        End Try

        '// ---------------------------------------------------------
        '
        '
        '
        cmd = New MySqlCommand($"UPDATE materials SET in_stock = '" & InStockTB.Text & "', expected = '" & ExpectedTB.Text & "'
                                            WHERE material_id = '" & MaterialIDval & "'", connToAcc.openAccDB)

        AddNewRawMaterial(cmd)

    End Sub

    Private Sub BarcodeTB_KeyUp(sender As Object, e As KeyEventArgs) Handles BarcodeTB.KeyUp
        Dim allowed As String = ("1234567890")

        For Each c As Char In BarcodeTB.Text
            If allowed.Contains(c) = False Then
                BarcodeTB.Text = BarcodeTB.Text.Remove(BarcodeTB.SelectionStart - 1, 1)
                BarcodeTB.Select(BarcodeTB.Text.Count, 0)
            End If
        Next

        If BarcodeTB.TextLength = 5 Then
            For Each item In MatIDCB.Items
                If BarcodeTB.Text = Val(item).ToString Then
                    MatIDCB.Text = item
                    AddToQuantityNUD.Value += 1
                End If
            Next

            BarcodeTB.Clear()
        End If
    End Sub

    Private Sub AddToQuantityNUD_Leave(sender As Object, e As EventArgs) Handles AddToQuantityNUD.Leave
        BarcodeTB.Clear()
    End Sub

    Private Sub CancelBttn1_Click(sender As Object, e As EventArgs) Handles CancelBttn1.Click
        CancelBttn.PerformClick()
    End Sub

#End Region

    Private Sub CancelBttn2_Click(sender As Object, e As EventArgs) Handles CancelBttn2.Click
        CancelBttn.PerformClick()
    End Sub

    Private Sub ORDMatNameCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ORDMatNameCB.SelectedIndexChanged
        M_IDKeyUpIndexChanged(Val(ORDMatNameCB.SelectedItem))
        connToAcc.closeAccDB()
    End Sub

    Private Sub ORDQtyTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ORDQtyTB.KeyPress
        Mainsystem.AsciiCheck(e, "numbers")
    End Sub

    Private Sub OrderLogsBttn_Click(sender As Object, e As EventArgs) Handles OrderLogsBttn.Click
        Dim DTB As New DataTable
        Try
            '// LOADING OF DGV OF PRINTING IN ORDERING FORM -------------------------------------------------------
            cmd = New MySqlCommand($"SELECT ord.order_id, u.username, ord.date, s.company_name, m.material_id, m.material_name, ord.quantity, m.average_cost, ord.total
                                    FROM orderrecord ord
                                    INNER JOIN supplier s ON ord.supplier_id = s.supplier_id
                                    INNER JOIN materials m ON ord.material_id = m.material_id
				                    INNER JOIN users u ON ord.user_id = u.user_id", connToAcc.openAccDB)
            Using da = New MySqlDataAdapter(cmd)
                DTB.Clear()
                da.Fill(DTB)
            End Using
            OrderDGV.DataSource = DTB
            connToAcc.closeAccDB()

            OrderDGV.Columns(0).HeaderText = "Order ID"
            OrderDGV.Columns(1).HeaderText = "User"
            OrderDGV.Columns(2).HeaderText = "Date"
            OrderDGV.Columns(3).HeaderText = "Supplier Company"
            OrderDGV.Columns(4).HeaderText = "Material ID"
            OrderDGV.Columns(5).HeaderText = "Material Name"
            OrderDGV.Columns(6).HeaderText = "Quantity"
            OrderDGV.Columns(7).HeaderText = "Average Cost"
            OrderDGV.Columns(8).HeaderText = "Total"
        Catch ex As Exception
            MsgBox(ex.Message)
            connToAcc.closeAccDB()
        End Try

        '// FOR PRINTING
        Dim sys As New Mainsystem()
        sys.GRepBttnChecker = "Order Materials"

        sys.PrintPreviewDialog1.Document = sys.PrintDocument1
        sys.PrintDocument1.DefaultPageSettings.Landscape = True
        sys.PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        sys.PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub ORDQtyTB_KeyUp(sender As Object, e As KeyEventArgs) Handles ORDQtyTB.KeyUp
        If ORDQtyTB.Text = "" Then
            ORDQtyTB.Text = 0
        ElseIf ORDQtyTB.Text.Length > 0 Then
            ORDTotalTB.Text = Convert.ToDouble(ORDQtyTB.Text) * Convert.ToDouble(ORDPriceTB.Text)
        End If
    End Sub

    Private Sub InStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InStock.KeyPress
        Mainsystem.AsciiCheck(e, "numbers")
    End Sub

    Private Sub AverageCost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AverageCost.KeyPress
        Mainsystem.AsciiCheck(e, "numbers")
    End Sub

    Dim orderID As Integer = 0
    Private Sub OrderMaterialsBttn_Click(sender As Object, e As EventArgs) Handles OrderMaterialsBttn.Click
        Dim mname = "", sname = "", contno = "", qty = ""

        If ORDSuppCB.SelectedItem Is Nothing Or ORDMatNameCB.SelectedItem Is Nothing Or ORDQtyTB.Text = "" Or ORDPriceTB.Text = "" Or ORDTotalTB.Text = "" Then
            MessageBox.Show("There is no selected item to order from the supplier.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
            cmd = New MySqlCommand($"UPDATE materials SET expected = expected + '" & ORDQtyTB.Text & "'
                                            WHERE material_id = '" & MaterialIDval & "'", connToAcc.openAccDB)
                cmd.ExecuteNonQuery()
                connToAcc.closeAccDB()

            cmd = New MySqlCommand($"INSERT INTO orderrecord (user_id, material_id, supplier_id, quantity, total)
                                        VALUES('" & Login.userID & "', '" & MaterialIDval & "', '" & Val(ORDSuppCB.Text) & "',
                                            '" & ORDQtyTB.Text & "', '" & ORDTotalTB.Text & "'); SELECT @@IDENTITY AS ordID", connToAcc.openAccDB)

            AddNewRawMaterial(cmd)

            Using reader = cmd.ExecuteReader()
                If reader.Read Then
                    orderID = reader.Item("ordID")
                End If
            End Using
            reader.Close()
            connToAcc.closeAccDB()

            '/// SENDING TO SUPPLIER ORDERED MATERIALS ------------------------------
            Try
            cmd = New MySqlCommand("SELECT m.material_name, s.company_name, s.contact_no, ord.quantity
                                            FROM orderrecord ord
                                            INNER JOIN materials m ON m.material_id = ord.material_id
                                            INNER JOIN supplier s ON s.supplier_id = ord.supplier_id
                                            WHERE order_id = '" & orderID & "'", connToAcc.openAccDB)

            Using reader = cmd.ExecuteReader()
                If reader.Read Then
                    mname = reader.Item("material_name")
                    sname = reader.Item("company_name")
                    contno = reader.Item("contact_no")
                    qty = reader.Item("quantity")
                End If
            End Using
            reader.Close()

            Dim msg = "BPC would like to order: " & vbNewLine &
                    mname & " -- " & "Qty: " & qty & vbNewLine &
                    "Thankyou!"

            smssender.SendSMS(msg, contno,)
            MsgBox(msg & vbNewLine & vbNewLine & "Message sent.")

            connToAcc.closeAccDB()
            Catch ex As Exception
                    MsgBox(ex.Message)
                    connToAcc.closeAccDB()
            End Try
                '/// --------------------------------------------------------------------

            Catch ex As Exception
                MessageBox.Show("Error proceeding with purchase from the supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                reader.Close()
                connToAcc.closeAccDB()
            End Try
        End If
    End Sub
End Class



