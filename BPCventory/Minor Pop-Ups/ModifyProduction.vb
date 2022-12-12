Imports MySql.Data.MySqlClient

Public Class ModifyProduction
    Dim connToAcc As New accountsConn
    Dim cmd As New MySqlCommand
    Dim dtable As New DataTable()
    Dim da As MySqlDataAdapter
    Dim reader As MySqlDataReader

    Dim prodName, prodID As String
    Dim rowcountofDGV, initRC As Integer

#Region "LOADING"
    Private Sub LoadLogs()
        ProductionLogDGV.Rows.Clear()
        Try
            cmd = New MySqlCommand($"SELECT log_id, production_id, datetime, quantity FROM production_log", connToAcc.openAccDB)
            reader = cmd.ExecuteReader()
            While reader.Read
                ProductionLogDGV.Rows.Add(reader.Item("log_id").ToString, reader.Item("production_id").ToString,
                                          reader.Item("datetime").ToString, reader.Item("quantity").ToString)
            End While
            reader.Close()
            connToAcc.closeAccDB()
        Catch ex As Exception
            MsgBox(ex.Message)
            connToAcc.closeAccDB()
        End Try
    End Sub

    Private Sub LoadProd()
        '/////////////////////////////////////
        '/// TRY FOR EDIT COMPONENTS
        '/////////////////////////////////////
        Try
            cmd = New MySqlCommand($"SELECT DISTINCT p.product_id, p.product_name 
                                FROM components comp
                                LEFT JOIN make m
                                ON comp.production_id = m.production_id
                                RIGHT JOIN products p
                                ON m.product_id = p.product_id", connToAcc.openAccDB)
            reader = cmd.ExecuteReader()
            While reader.Read
                CompProdNameCB.Items.Add(String.Format("{0}-{1}", reader(0), reader(1)))
            End While
            reader.Close()
            connToAcc.closeAccDB()
        Catch ex As Exception
            MsgBox(ex.Message)
            connToAcc.closeAccDB()
        End Try

        '/////////////////////////////////////
        '/// TRY FOR LOAD PRODUCTION_LOG
        '/////////////////////////////////////
        LoadLogs()



        '/////////////////////////////////////
        '/// TRY FOR LOAD ADD TO NEW PRODUCTION
        '/////////////////////////////////////
        Try
            cmd = New MySqlCommand($"SELECT make.production_id, products.product_name, make.quantity, make.production_deadline, make.status
                                FROM make 
                                INNER JOIN products
                                on make.product_id = products.product_id
                                ORDER BY make.product_id ASC", connToAcc.openAccDB)
            reader = cmd.ExecuteReader
            While reader.Read
                ProdNameANP.Items.Add(String.Format("{0}-{1}", reader(0), reader(1)))
            End While
            reader.Close()
            connToAcc.closeAccDB()
        Catch ex As Exception
            MsgBox(ex.Message)
            connToAcc.closeAccDB()
        End Try
    End Sub

    Private Sub ModifyProduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProd()
    End Sub
#End Region

#Region "EDIT COMPONENTS"
    Private Sub CloseCompBttn_Click(sender As Object, e As EventArgs) Handles CloseCompBttn.Click
        Me.Close()
        Mainsystem.Show()
    End Sub

    '/////////////
    '// COMPONENT PRODUCT NAME VALUE CHANGED
    '/////////////
    Private Sub ProductNameChanged()
        Try
            CompProdNameCB.ForeColor = Color.Black
            CompMatNameCB.ForeColor = Color.Black

            Dim names() As String = CompProdNameCB.Text.ToString.Split(New Char() {"-"c})
            prodName = names(1)
            prodID = names(0)
        Catch ex As Exception
            Dim names() As String = CompProdNameCB.Text.ToString.Split(New Char() {"-"c})
            prodName = names(0)
        End Try

        cmd = New MySqlCommand($"SELECT comp.component_id, mat.material_name, comp.quantity
                               FROM components comp
                               INNER JOIN materials mat
                               ON mat.material_id = comp.material_id
                               INNER JOIN make m
                               ON m.production_id = comp.production_id
                               WHERE m.product_id = '" & prodID & "'", connToAcc.openAccDB)
        da = New MySqlDataAdapter(cmd)

        dtable.Rows.Clear()
        ComponentsDGV.Rows.Clear()
        CompMatNameCB.Items.Clear()

        reader = cmd.ExecuteReader()
        While reader.Read
            ComponentsDGV.Rows.Add(reader.Item("component_id").ToString, reader.Item("material_name").ToString, reader.Item("quantity").ToString, "DELETE")
            CompMatNameCB.Items.Add(String.Format("{0}-{1}", reader(0), reader(1)))
        End While

        reader.Close()
        connToAcc.closeAccDB()
    End Sub

    Private Sub CompProdNameCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CompProdNameCB.SelectedIndexChanged
        ProductNameChanged()
    End Sub

    Private Sub CompProdNameCB_TextChanged(sender As Object, e As EventArgs) Handles CompProdNameCB.TextChanged
        ProductNameChanged()
    End Sub

    Private Sub CompProdNameCB_TextUpdate(sender As Object, e As EventArgs) Handles CompProdNameCB.TextUpdate
        ProductNameChanged()
    End Sub

    '/////////////
    '// EDITING THE COMPONENTS
    '/////////////
    Private Sub EdtCmpntsSaveBttn_Click(sender As Object, e As EventArgs) Handles EdtCmpntsSaveBttn.Click
        Try
            DialogResult = MessageBox.Show("Do you want to proceed with these changes?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            If DialogResult = DialogResult.Yes Then

                For i As Integer = 0 To ComponentsDGV.Rows.Count - 2
                    cmd = New MySqlCommand($"SELECT * FROM components WHERE component_id = 
                            '" & ComponentsDGV.Rows(i).Cells(0).Value & "'", connToAcc.openAccDB)
                    da = New MySqlDataAdapter(cmd)
                    dtable.Clear()
                    da.Fill(dtable)

                    If dtable.Rows.Count > 0 Then
                        connToAcc.closeAccDB()
                        cmd = New MySqlCommand($"UPDATE components comp
                                        INNER JOIN materials mat
                                        ON mat.material_id = comp.material_id
                                        INNER JOIN make m
                                        ON m.production_id = comp.production_id
                                        INNER JOIN products pro
                                        ON pro.product_id = m.product_id
                                        SET comp.material_id = (SELECT material_id FROM materials WHERE material_name = '" & ComponentsDGV.Rows(i).Cells(1).Value & "'),
                                            comp.quantity = '" & ComponentsDGV.Rows(i).Cells(2).Value & "'
                                        WHERE pro.product_name = '" & prodName & "'
                                        AND comp.component_id = '" & ComponentsDGV.Rows(i).Cells(0).Value & "'", connToAcc.openAccDB)
                        cmd.ExecuteNonQuery()
                        connToAcc.closeAccDB()

                    ElseIf dtable.Rows.Count < 1 Then
                        connToAcc.closeAccDB()
                        cmd = New MySqlCommand($"INSERT INTO components (production_id, material_id, quantity)
                                            VALUES (
                                                    (SELECT m.production_id FROM make m
                                                    INNER JOIN products p
                                                    ON m.product_id = p.product_id
                                                    WHERE p.product_name = '" & prodName & "'), 
                                                    (SELECT material_id FROM materials
                                                    WHERE material_name = '" & ComponentsDGV.Rows(i).Cells(1).Value & "'), '" & ComponentsDGV.Rows(i).Cells(2).Value & "')", connToAcc.openAccDB)

                        cmd.ExecuteNonQuery()
                        connToAcc.closeAccDB()

                    End If
                Next
                MessageBox.Show("Components successfully modified.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            ProductNameChanged()
        Catch ex As Exception
            MessageBox.Show("Incorrect input. The component doesn't exist or values inputted in the wrong column.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            connToAcc.closeAccDB()
            ProductNameChanged()
        End Try
    End Sub

    Private Sub ComponentsDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ComponentsDGV.CellClick
        '//DELETING RECORDS
        Dim userDelete As String = ComponentsDGV.Columns(e.ColumnIndex).HeaderText
        If userDelete = "Delete" Then
            If MsgBox("Delete this record?", vbYesNo + vbQuestion) = vbYes Then
                cmd = New MySqlCommand($"DELETE FROM components WHERE component_id = '" & ComponentsDGV.CurrentRow.Cells(0).Value & "'", connToAcc.openAccDB)
                cmd.ExecuteNonQuery()
                connToAcc.closeAccDB()
                MsgBox("Record has been successfully deleted.", vbInformation)
                ProductNameChanged()
            End If
        End If
    End Sub
#End Region

#Region "PRODUCTION LOG"
    Private Sub CloseCompBttn1_Click(sender As Object, e As EventArgs) Handles CloseCompBttn1.Click
        Me.Close()
        Mainsystem.Show()
    End Sub

    Private Sub SearchByDateBttn_Click(sender As Object, e As EventArgs) Handles SearchByDateBttn.Click
        Try
            ProductionLogDGV.Rows.Clear()

            cmd = New MySqlCommand($"SELECT log_id, production_id, datetime, quantity FROM production_log
                                    WHERE datetime BETWEEN @d1 AND @d2", connToAcc.openAccDB)

            cmd.Parameters.Add("@d1", MySqlDbType.DateTime).Value = DateTimePicker1.Value
            cmd.Parameters.Add("d2", MySqlDbType.DateTime).Value = DateTimePicker2.Value

            reader = cmd.ExecuteReader()
            While reader.Read
                ProductionLogDGV.Rows.Add(reader.Item("log_id").ToString, reader.Item("production_id").ToString,
                                          reader.Item("datetime").ToString, reader.Item("quantity").ToString)
            End While
            reader.Close()
            connToAcc.closeAccDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            connToAcc.closeAccDB()
        End Try
    End Sub

    Private Sub ResetBttn_Click(sender As Object, e As EventArgs) Handles ResetBttn.Click
        LoadLogs()
    End Sub
#End Region

#Region "ADD TO NEW PRODUCTION"

    Private Sub ProdNameANP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProdNameANP.SelectedIndexChanged
        ProdNameANP_Changed()
    End Sub

    Private Sub ProdNameANP_TextChanged(sender As Object, e As EventArgs) Handles ProdNameANP.TextChanged
        ProdNameANP_Changed()
    End Sub

    Private Sub ProdNameANP_TextUpdate(sender As Object, e As EventArgs) Handles ProdNameANP.TextUpdate
        ProdNameANP_Changed()
    End Sub

    Private Sub AddToProductionCloseBttn_Click(sender As Object, e As EventArgs) Handles AddToProductionCloseBttn.Click
        Me.Close()
        Mainsystem.Show()
    End Sub

    Private Sub ProdNameANP_Changed()
        'Try
        cmd = New MySqlCommand($"SELECT m.production_id, p.product_name, m.quantity, m.production_deadline
                                FROM make m
                                INNER JOIN products p
                                on m.product_id = p.product_id
                                WHERE m.production_id =  '" & ProdNameANP.Text & "'", connToAcc.openAccDB)
        reader = cmd.ExecuteReader()

        While reader.Read
            ProductionIDanp.Text = reader.Item("production_id")
            qtyANP.Text = reader.Item("quantity")
            ProdDeadlineADP.Value = reader.GetDateTime(reader.GetOrdinal("production_deadline"))
        End While
        reader.Close()
        connToAcc.closeAccDB()
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'connToAcc.closeAccDB()
        'End Try
    End Sub

    Private Sub AddToProductionBttn_Click(sender As Object, e As EventArgs) Handles AddToProductionBttn.Click
        Try
            cmd = New MySqlCommand($"Update make Set quantity = '" & qtyANP.Text & "',
                            production_deadline = @setdate
                            WHERE production_id = '" & ProductionIDanp.Text & "'", connToAcc.openAccDB)
            cmd.Parameters.Add("@setdate", MySqlDbType.Date).Value = ProdDeadlineADP.Value
            cmd.ExecuteNonQuery()
            connToAcc.closeAccDB()
            LoadProd()
            MessageBox.Show("Adding Materials to Production Success.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
            connToAcc.closeAccDB()
        End Try

    End Sub
#End Region
End Class