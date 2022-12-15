Imports MySql.Data.MySqlClient

Public Class AddNewRawMaterials
    Dim connToAcc As New accountsConn
    Dim cmd As New MySqlCommand
    Dim dtable As New DataTable()
    Dim da As MySqlDataAdapter
    Dim reader As MySqlDataReader
    Dim opt = 0
    Dim MaterialIDval, CompanyNameval As String
    Dim expectedInt, instockInt As Integer

    Private Sub AddNewRawMaterials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '// COMBOBOX OF SUPPLIER
            cmd = New MySqlCommand($"SELECT supplier_id, company_name FROM supplier ORDER BY supplier_id ASC", connToAcc.openAccDB)
            reader = cmd.ExecuteReader
            While reader.Read
                SupplierName.Items.Add(String.Format("{0}-{1}", reader(0), reader(1)))
            End While
            reader.Close()
            connToAcc.closeAccDB()

            '// COMBOBOX OF MATERIAL ID AVAILABLE
            cmd = New MySqlCommand($"SELECT material_id, material_name FROM materials ORDER BY material_id ASC", connToAcc.openAccDB)
            reader = cmd.ExecuteReader
            While reader.Read
                MaterialID.Items.Add(String.Format("{0}-{1}", reader(0), reader(1)))
            End While
            reader.Close()
            connToAcc.closeAccDB()

        Catch ex As Exception
            MsgBox("Error sa Load")
        End Try

        TextBox1.Focus()
    End Sub

    Function Overwrite()
        '-------------------- PRESET DESCRIPTION ------------------------------
        MaterialID.Text = "Material ID"
        MaterialName.Text = "Material Name"
        AverageCost.Text = "Average Cost of Material"
        InStock.Text = "Quantity in Stock"
        Expected.Text = "Expected to Arrive"
        Committed.Text = "Committed to Production"
        Missing.Text = "Missing Materials"
        SupplierName.Text = "Supplier of Materials"

        For Each fcolor In {MaterialID, MaterialName, AverageCost, InStock, Expected, Committed, Missing}
            fcolor.ForeColor = Color.Gray
        Next

        SupplierName.Enabled = True
        LabelQty.Visible = False
        ExpectedNUD.Visible = False
        '------------------------------------------------------

        Return 0
    End Function

    Private Sub M_IDKeyUpIndexChanged()
        If MaterialID.Text = "" Then
            Overwrite()
            PictureBox1.Focus()
            Exit Sub
        Else
            Try
                cmd = New MySqlCommand($"SELECT materials.material_id, materials.material_name, materials.average_cost,
                                    materials.in_stock, materials.expected, materials.committed, materials.missing,
                                    supplier.supplier_id, supplier.company_name
                                    FROM materials
                                    INNER JOIN supplier ON materials.supplier_id = supplier.supplier_id
                                    WHERE materials.material_id = '" & MaterialID.Text & "'", connToAcc.openAccDB)
                da = New MySqlDataAdapter(cmd)

                dtable.Clear()
                da.Fill(dtable)

                If dtable.Rows.Count > 0 Then
                    MaterialName.Text = dtable.Rows(0).Item("material_name")

                    AverageCost.Text = dtable.Rows(0).Item("average_cost")
                    InStock.Text = dtable.Rows(0).Item("in_stock")
                    Expected.Text = dtable.Rows(0).Item("expected")
                    Committed.Text = dtable.Rows(0).Item("committed")
                    Missing.Text = dtable.Rows(0).Item("missing")
                    SupplierName.Text = (String.Format("{0}-{1}", dtable.Rows(0).Item("supplier_id"), dtable.Rows(0).Item("company_name")))

                    '//EXPECTED AND INSTOCK IS PUT INTO VAR AS INT --------------------------

                    expectedInt = Convert.ToInt32(Expected.Text)
                    instockInt = Convert.ToInt32(InStock.Text)

                    '// ------------------------------------------
                    MaterialIDval = dtable.Rows(0).Item("material_id")
                    CompanyNameval = dtable.Rows(0).Item("company_name")
                    AddToQuantityNUD.Value = 0

                    opt = 2
                    SupplierName.Enabled = False
                    'ExpectedNUD.Visible = True
                    'LabelQty.Visible = True
                    AddToQuantityNUD.Enabled = True

                    For Each fcolor In {MaterialName, AverageCost, InStock, Expected, Committed, Missing, SupplierName}
                        fcolor.ForeColor = Color.Black
                    Next

                ElseIf dtable.Rows.Count = 0 Then
                    '// PRESET EXCLUDING THE MATERIAL ID

                    MaterialName.Text = "Material Name"
                    AverageCost.Text = "Average Cost of Material"
                    InStock.Text = "0"
                    Expected.Text = "0"
                    Committed.Text = "0"
                    Missing.Text = "0"
                    SupplierName.Text = "Supplier of Materials"
                    AddToQuantityNUD.Value = 0

                    opt = 1
                    SupplierName.Enabled = True
                    'ExpectedNUD.Visible = True
                    'LabelQty.Visible = True
                    AddToQuantityNUD.Enabled = True

                    For Each fcolor In {MaterialName, AverageCost, InStock, Expected, Committed, Missing, SupplierName}
                        fcolor.ForeColor = Color.Gray
                    Next

                End If

                connToAcc.closeAccDB()
            Catch ex As Exception
                MsgBox("Error sa MID")
                connToAcc.closeAccDB()
            End Try
        End If

    End Sub

    Function AddNewRawMaterial(cmd As MySqlCommand)
        Try
            If MaterialID.Text = "Material ID" Or MaterialName.Text = "Material Name" Or AverageCost.Text = "Average Cost of Material" Or InStock.Text = "Quantity in Stock" Or
                Expected.Text = "Expected to Arrive" Or Committed.Text = "Committed to Production" Or Missing.Text = "Missing Materials" Or SupplierName.Text = "" Then
                MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Data Inputted Successfully.")
                ModifyAffiliates.ResetModif()
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

    Private Sub CancelBttn_Click(sender As Object, e As EventArgs) Handles CancelBttn.Click
        Mainsystem.Opacity = 1
        Mainsystem.Enabled = True
        Close()
        Overwrite()
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

    Private Sub MaterialID_MouseClick(sender As Object, e As MouseEventArgs) Handles MaterialID.MouseClick
        If MaterialID.Text = "Material ID" Then
            MaterialID.ForeColor = Color.Black
        End If
    End Sub

    Private Sub MaterialID_Leave(sender As Object, e As EventArgs) Handles MaterialID.Leave
        If MaterialID.Text = "" Then
            MaterialID.Text = "Material ID"
            MaterialID.ForeColor = Color.Gray
        End If
    End Sub

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

    Private Sub Expected_MouseClick(sender As Object, e As MouseEventArgs) Handles Expected.MouseClick
        If Expected.Text = "Expected to Arrive" Then
            Expected.Clear()
            Expected.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Expected_Leave(sender As Object, e As EventArgs) Handles Expected.Leave
        If Expected.Text = "" Then
            Expected.Text = "Expected to Arrive"
            Expected.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Committed_MouseClick(sender As Object, e As MouseEventArgs) Handles Committed.MouseClick
        If Committed.Text = "Committed to Production" Then
            Committed.Clear()
            Committed.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Committed_Leave(sender As Object, e As EventArgs) Handles Committed.Leave
        If Committed.Text = "" Then
            Committed.Text = "Committed to Production"
            Committed.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Missing_MouseClick(sender As Object, e As MouseEventArgs) Handles Missing.MouseClick
        If Missing.Text = "Missing Materials" Then
            Missing.Clear()
            Missing.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Missing_Leave(sender As Object, e As EventArgs) Handles Missing.Leave
        If Missing.Text = "" Then
            Missing.Text = "Missing Materials"
            Missing.ForeColor = Color.Gray
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

    '//ADDING NEW RAW MATERIALS TO INVENTORY --------- REGARDLESS IF EXISTING OR NOT
    Private Sub AddNewMtrlBttn_Click(sender As Object, e As EventArgs) Handles AddNewMtrlBttn.Click
        Try
            If MaterialID.Text = "Material ID" Or MaterialName.Text = "Material Name" Or AverageCost.Text = "Average Cost of Material" Or InStock.Text = "Quantity in Stock" Or
                Expected.Text = "Expected to Arrive" Or Committed.Text = "Committed to Production" Or Missing.Text = "Missing Materials" Or SupplierName.Text = "" Then
                MessageBox.Show("All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If opt = 1 Then

                    '// ADDING QUANTITY INTO EXPECTED.TEXT ----------------------

                    expectedInt += ExpectedNUD.Value
                    Expected.Text = expectedInt

                    '// ---------------------------------------------------------

                    cmd = New MySqlCommand($"INSERT INTO materials (material_id, material_name, average_cost, in_stock, expected, committed, missing, supplier_id)
                                            VALUES ('" & MaterialIDval & "', '" & MaterialName.Text & "', '" & AverageCost.Text & "', '" & InStock.Text & "',
                                            '" & Expected.Text & "', '" & Committed.Text & "', '" & Missing.Text & "',
                                            (SELECT supplier_id FROM supplier WHERE company_name = '" & CompanyNameval & "'))", connToAcc.openAccDB)

                ElseIf opt = 2 Then
                    '// ADDING QUANTITY INTO EXPECTED.TEXT ----------------------

                    expectedInt += ExpectedNUD.Value
                    Expected.Text = expectedInt

                    '// ---------------------------------------------------------
                    '
                    '
                    '// ADDING QUANTITY INTO INSTOCK.TEXT -----------------------
                    Try
                        instockInt += AddToQuantityNUD.Value
                        InStock.Text = instockInt
                        Expected.Text -= AddToQuantityNUD.Value

                        If Expected.Text < 0 Then
                            MessageBox.Show("Insufficient Expected Materials", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Overwrite()
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    'instockInt += AddToQuantityNUD.Value
                    'InStock.Text = instockInt
                    'Expected.Text -= AddToQuantityNUD.Value

                    '// ---------------------------------------------------------
                    '
                    '
                    '
                    cmd = New MySqlCommand($"UPDATE materials SET material_name = '" & MaterialName.Text & "', average_cost = '" & AverageCost.Text & "',
                                            in_stock = '" & InStock.Text & "', expected = '" & Expected.Text & "', committed = '" & Committed.Text & "',
                                            missing = '" & Missing.Text & "', supplier_id = (SELECT supplier_id FROM supplier WHERE company_name = '" & CompanyNameval & "')
                                            WHERE material_id = '" & MaterialIDval & "'", connToAcc.openAccDB)
                End If

                AddNewRawMaterial(cmd)
            End If
        Catch ex As Exception
            MsgBox("Error sa Button Add/Update")
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

    '//DETERMINING WHETHER THE PRODUCT IS EXISTING OR NOT
    Private Sub MaterialID_KeyUp(sender As Object, e As KeyEventArgs) Handles MaterialID.KeyUp
        M_IDKeyUpIndexChanged()
    End Sub

    Private Sub MaterialID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MaterialID.SelectedIndexChanged
        M_IDKeyUpIndexChanged()
    End Sub

    Private Sub MaterialID_textChanged(sender As Object, e As EventArgs) Handles MaterialID.TextChanged
        M_IDKeyUpIndexChanged()
    End Sub

    Private Sub MaterialID_TextUpdate(sender As Object, e As EventArgs) Handles MaterialID.TextUpdate
        M_IDKeyUpIndexChanged()
    End Sub

    Private Sub InStock_TextChanged(sender As Object, e As EventArgs) Handles InStock.TextChanged

    End Sub

    '// --- ADDING TO THE CURRENT STOCK ON HAND
    Private Sub AddToQuantityNumericUpDown_Click(sender As Object, e As EventArgs) Handles AddToQuantityNUD.Click
        TextBox1.Focus()
    End Sub

    Private Sub Textbox1_KeyUp(sender As Object, e As EventArgs) Handles TextBox1.KeyUp
        Dim allowed As String = ("123456789")
        For Each c As Char In TextBox1.Text
            If allowed.Contains(c) = False Then
                TextBox1.Text = TextBox1.Text.Remove(TextBox1.SelectionStart - 1, 1)
                TextBox1.Select(TextBox1.Text.Count, 0)
            End If
        Next
        If TextBox1.Text.Length = 6 Then
            If MaterialIDval = TextBox1.Text Then
                AddToQuantityNUD.Value += 1
                TextBox1.Clear()
            Else
                MaterialID.Text = TextBox1.Text
                AddToQuantityNUD.Value = 0
            End If
        End If
    End Sub

    '----------------------------------------------------------------------------
    '----------------------------------------------------------------------------
End Class