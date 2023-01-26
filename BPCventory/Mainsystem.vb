Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Mainsystem
#Region "VARIABLE AND CLASS DECLARATIONS"
    Dim PRT As New PrinterClass
    Dim connToAcc As New accountsConn
    Dim cmd As New MySqlCommand
    Dim dtable As New DataTable()
    Dim da As MySqlDataAdapter
    Dim reader As MySqlDataReader
    Dim SmsSender As New TextMessage

    Dim count = 0, prodqty = 0, compqty = 0, counting = 0
    Dim datestart, dateend As Date
    Public user_id As Integer
    Public GRepBttnChecker As String
    Dim prod_id = ""
    Dim flag As Boolean = False, RMstockyes As Boolean = False, Pstockyes As Boolean = False


#End Region

    Public Sub AsciiCheck(ByVal e As KeyPressEventArgs, type As String)
        Select Case type
            Case "texts"
                If Asc(e.KeyChar) <> 8 Then
                    If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 122 Then
                        e.Handled = True
                    End If
                End If
            Case "numbers"
                If Asc(e.KeyChar) <> 8 Then
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                        e.Handled = True
                    End If
                End If
        End Select
    End Sub

    Function StockCheck(ByVal cmd As MySqlCommand, DGV As DataGridView)
        '// ------- IN STOCK, NOT ACTIVE, OUT OF STOCK // RAW MATERIALS // PRODUCTS ------------
        Try
            dtable.Clear()
            RawMaterialsDGV.Rows.Clear()
            ProductsDGV.Rows.Clear()

            reader = cmd.ExecuteReader
            If DGV.Name = "RawMaterialsDGV" Then
                While reader.Read
                    DGV.Rows.Add(reader.Item("material_id").ToString, reader.Item("material_name").ToString,
                                                   reader.Item("average_cost").ToString, reader.Item("in_stock").ToString,
                                                   reader.Item("expected").ToString, reader.Item("committed").ToString,
                                                   reader.Item("missing").ToString, reader.Item("company_name").ToString, "DELETE")
                End While
            ElseIf DGV.Name = "ProductsDGV" Then
                While reader.Read
                    DGV.Rows.Add(reader.Item("product_id").ToString, reader.Item("product_name").ToString, reader.Item("part_number").ToString,
                                                   reader.Item("product_size").ToString, reader.Item("unit_length").ToString,
                                                   reader.Item("product_dimension").ToString, reader.Item("sale_price").ToString,
                                                   reader.Item("average_cost").ToString, reader.Item("profit").ToString,
                                                   reader.Item("in_stock").ToString, reader.Item("expected").ToString,
                                                   reader.Item("ordered").ToString, "DELETE")
                End While
            End If
            reader.Close()
            connToAcc.closeAccDB()
        Catch ex As Exception
            connToAcc.closeAccDB()
            MsgBox(ex.Message)
        End Try
        Return 0
    End Function

    Public Sub ExeDGV(ByVal mysqlcomm As MySqlCommand, DGV As DataGridView)
        reader = mysqlcomm.ExecuteReader()
        While reader.Read
            DGV.Rows.Add(reader.Item(0).ToString, reader.Item(1).ToString)
        End While
        reader.Close()
        connToAcc.closeAccDB()

    End Sub

    Public Function ExeDashboard(ByVal sqlcomm As MySqlCommand)
        Dim returnval As Integer

        Using reader As MySqlDataReader = sqlcomm.ExecuteReader
            If reader.Read Then
                Try
                    returnval = reader.GetInt32(0).ToString
                Catch ex As Exception
                    returnval = 0
                End Try
            End If
        End Using

        connToAcc.closeAccDB()
        Return returnval
    End Function

    Public Sub Load_Records()
        '****************************** DISPLAYING DASHBOARD VALUES ***************************

        '//NUMBER OF USERS
        cmd = New MySqlCommand($"SELECT COUNT(*) FROM users", connToAcc.openAccDB)
        UsersAmount.Text = ExeDashboard(cmd)

        '//NUMBER OF VARIATIONS
        cmd = New MySqlCommand($"SELECT COUNT(*) FROM products", connToAcc.openAccDB)
        VariationsAmount.Text = ExeDashboard(cmd)

        '//NUMBER OF PRODUCTS
        cmd = New MySqlCommand($"SELECT COUNT(DISTINCT product_name) FROM products", connToAcc.openAccDB)
        ProductsAmount.Text = ExeDashboard(cmd)

        '//AMOUNT OF SALES (FOR THIS MONTH)
        cmd = New MySqlCommand($"SELECT SUM(sales_details.total) ALL_SALES
                                FROM sales_details
                                INNER JOIN sales
                                ON sales.sales_id = sales_details.sales_id
                                WHERE YEAR(sales.sales_date) = EXTRACT(YEAR FROM CURRENT_TIMESTAMP)
                                AND MONTH (sales.sales_date) = EXTRACT(MONTH FROM CURRENT_TIMESTAMP)", connToAcc.openAccDB)
        SalesAmount.Text = ExeDashboard(cmd)

        '///////////////////
        '-------------------
        '///////////////////

        '////////////////////////////////////////////
        '//HIGHEST SELLING PRODUCTS
        GetHighestSellingroducts()

        '////////////////////////////////////////////
        '//LATEST SALES
        Try
            LatestSalesDGV.Rows.Clear()
            cmd = New MySqlCommand($"SELECT DISTINCT p.product_name, SUM(s.sale_quantity)QTY FROM sales_details s
                                    INNER JOIN products p
                                    ON s.product_id = p.product_id
                                    GROUP BY p.product_name
                                    ORDER BY sale_details_id DESC LIMIT 0, 8", connToAcc.openAccDB)
            ExeDGV(cmd, LatestSalesDGV)
        Catch ex As Exception
            connToAcc.closeAccDB()
            MsgBox(ex.Message)
        End Try

        '////////////////////////////////////////////
        '//RECENTLY ADDED PRODUCTS
        Try
            RecentlyAddedDGV.Rows.Clear()
            cmd = New MySqlCommand($"SELECT product_id, product_name FROM products ORDER BY product_id DESC LIMIT 0,8", connToAcc.openAccDB)
            ExeDGV(cmd, RecentlyAddedDGV)
        Catch ex As Exception
            connToAcc.closeAccDB()
            MsgBox(ex.Message)
        End Try

        '////////////////////////////////////////////
        '//RECENTLY ADDED PRODUCTS
        Try
            CriticalLowStockDGV.Rows.Clear()
            cmd = New MySqlCommand($"SELECT * FROM materials WHERE in_stock < 100", connToAcc.openAccDB)
            ExeDGV(cmd, CriticalLowStockDGV)

            cmd = New MySqlCommand($"SELECT * FROM products WHERE in_stock < 50", connToAcc.openAccDB)
            ExeDGV(cmd, CriticalLowStockDGV)
        Catch ex As Exception

        End Try
        '*************************** END OF DISPLAYING DASHBOARD VALUES ************************




        '*****************************************************************************************
        '***************************LOAD ALL DATA*************************************************

        '/// ACCOUNT INFORMATION PAGE PANEL LOADING --------------------

        Try
            cmd = New MySqlCommand($"SELECT * FROM users where user_id = '" & Login.userID & "'", connToAcc.openAccDB())
            Using reader = cmd.ExecuteReader()
                While reader.Read
                    AccInf_name.Text = reader.Item("lastname").ToString & ", " & reader.Item("firstname").ToString
                    AccInf_username.Text = reader.Item("username")
                    AccInf_contno.Text = reader.Item("mobile_number")
                    AccInf_email.Text = reader.Item("email")
                    AccInf_priv.Text = reader.Item("privileges")
                End While
            End Using
            connToAcc.closeAccDB()
            reader.Close()

        Catch ex As Exception
            connToAcc.closeAccDB()
            MsgBox(ex.Message)
        End Try

        '---------------------------------------------------------------
        '________________________________________________________________________________________________________________
        '//USER MANAGEMENT
        For Each DGV In {UsersDGV, UserGrpDGV, CustomerDGV, SupplierDGV, RawMaterialsDGV, AllProductionsDGV, ProductsDGV, SalesDGV, AllSalesDGV}
            DGV.Rows.Clear()
        Next

        cmd = New MySqlCommand($"SELECT lastname,firstname,username,age,email,mobile_number FROM users", connToAcc.openAccDB)

        Using reader = cmd.ExecuteReader
            While reader.Read
                UsersDGV.Rows.Add(reader.Item("lastname").ToString, reader.Item("firstname").ToString, reader.Item("username").ToString,
                                  reader.Item("age").ToString, reader.Item("email").ToString, reader.Item("mobile_number").ToString, "DELETE")
            End While
        End Using
        reader.Close()
        connToAcc.closeAccDB()

        cmd = New MySqlCommand($"SELECT privileges, count(1) as total_count FROM users GROUP BY privileges", connToAcc.openAccDB)
        Using reader = cmd.ExecuteReader
            While reader.Read
                UserGrpDGV.Rows.Add(reader.Item("privileges").ToString, reader.Item("total_count").ToString)
            End While
        End Using
        reader.Close()
        connToAcc.closeAccDB()


        '________________________________________________________________________________________________________________
        '//AFFILIATES
        cmd = New MySqlCommand($"SELECT customer_id,company_name,email,contact_no FROM customer", connToAcc.openAccDB)

        Using reader = cmd.ExecuteReader
            While reader.Read
                CustomerDGV.Rows.Add(reader.Item("customer_id").ToString, reader.Item("company_name").ToString,
                                     reader.Item("email").ToString, reader.Item("contact_no").ToString, "DELETE")
            End While
        End Using
        reader.Close()
        connToAcc.closeAccDB()

        cmd = New MySqlCommand($"SELECT supplier_id,company_name,email,contact_no FROM supplier", connToAcc.openAccDB)
        Using reader = cmd.ExecuteReader
            While reader.Read
                SupplierDGV.Rows.Add(reader.Item("supplier_id").ToString, reader.Item("company_name").ToString,
                                     reader.Item("email").ToString, reader.Item("contact_no").ToString, "DELETE")
            End While
        End Using
        reader.Close()
        connToAcc.closeAccDB()


        Dim stockcheckstr As New System.Text.StringBuilder()
        stockcheckstr.Append("Items currently low on stocks. Please restock ASAP." & vbNewLine & vbNewLine)
        stockcheckstr.Append("RAW MATERIALS" & vbNewLine & vbNewLine)
        '________________________________________________________________________________________________________________
        '//RAW MATERIALS
        cmd = New MySqlCommand($"SELECT m.material_id, m.material_name, m.average_cost, m.in_stock, m.expected, m.committed, m.missing, s.company_name
                                 FROM materials m 
                                 INNER JOIN supplier s
                                 ON m.supplier_id = s.supplier_id", connToAcc.openAccDB)

        Using reader = cmd.ExecuteReader
            While reader.Read
                RawMaterialsDGV.Rows.Add(reader.Item("material_id").ToString, reader.Item("material_name").ToString,
                                         reader.Item("average_cost").ToString, reader.Item("in_stock").ToString,
                                         reader.Item("expected").ToString, reader.Item("committed").ToString,
                                         reader.Item("missing").ToString, reader.Item("company_name").ToString, "EDIT", "DELETE")

                Dim stockQ = reader.Item("in_stock").ToString
                If stockQ < 100 Then
                    stockcheckstr.Append(reader.Item("material_id").ToString & " -- " & reader.Item("material_name").ToString & " -- " & reader.Item("in_stock").ToString & vbNewLine)
                    RMstockyes = True
                End If
            End While
        End Using

        If RMstockyes = True Then
            Do While flag = False
                MessageBox.Show(stockcheckstr.ToString & vbNewLine & "End of List", "Stock Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
                flag = True

                DialogResult = MessageBox.Show("Do you want to order now?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DialogResult = vbYes Then
                    AddNewRawMaterials.Show()
                    AddNewRawMaterials.ORDERFORMPANEL.BringToFront()
                    AddNewRawMaterials.Refresh()


                ElseIf DialogResult = vbNo Then
                    Exit Do
                End If
            Loop
        End If

        reader.Close()
        connToAcc.closeAccDB()


        '________________________________________________________________________________________________________________
        '//PRODUCTION
        Try
            cmd = New MySqlCommand($"SELECT make.production_id, make.product_id, p.product_name, make.quantity, make.production_deadline, make.status
                                    FROM make 
                                    RIGHT JOIN products p
                                    ON make.product_id = p.product_id
                                    WHERE make.quantity > 0
                                    ORDER BY make.production_deadline ASC", connToAcc.openAccDB)

            Using reader = cmd.ExecuteReader()
                While reader.Read
                    AllProductionsDGV.Rows.Add(reader.Item("production_id").ToString, reader.Item("product_id").ToString, reader.Item("product_name").ToString,
                                               reader.Item("quantity").ToString, reader.Item("production_deadline").ToString, reader.Item("status").ToString, "COMPLETE")
                End While
            End Using
            reader.Close()
            connToAcc.closeAccDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            connToAcc.closeAccDB()
        End Try
        '---------------------------------------=--------------------------


        '________________________________________________________________________________________________________________
        '//PRODUCTS
        stockcheckstr.Append(vbNewLine & "PRODUCTS" & vbNewLine & vbNewLine)
        cmd = New MySqlCommand($"SELECT product_id,product_name,part_number,product_size,unit_length,
                                product_dimension,sale_price,average_cost,profit,in_stock,expected,
                                ordered FROM products", connToAcc.openAccDB)
        Using reader = cmd.ExecuteReader
            While reader.Read
                ProductsDGV.Rows.Add(reader.Item("product_id").ToString,
                                     reader.Item("product_name").ToString, reader.Item("part_number").ToString,
                                     reader.Item("product_size").ToString, reader.Item("unit_length").ToString,
                                     reader.Item("product_dimension").ToString, reader.Item("sale_price").ToString,
                                     reader.Item("average_cost").ToString, reader.Item("profit").ToString,
                                     reader.Item("in_stock").ToString,
                                     reader.Item("expected").ToString,
                                     reader.Item("ordered").ToString, "DELETE")

                Dim stockQ = reader.Item("in_stock").ToString
                If stockQ < 50 Then
                    stockcheckstr.Append(reader.Item("product_id").ToString & " -- " & reader.Item("product_name").ToString & " -- " & reader.Item("in_stock").ToString & vbNewLine)
                    Pstockyes = True
                End If
            End While
        End Using
        If Pstockyes = True Then
            MessageBox.Show(stockcheckstr.ToString & vbNewLine & "End of List", "Stock Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            flag = True

            DialogResult = MessageBox.Show("Do you want to order now?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DialogResult = vbYes Then
                ModifyProduction.Show()
                ModifyProduction.AddtoNewProduceContent.BringToFront()
                ModifyProduction.Refresh()


            ElseIf DialogResult = vbNo Then

            End If
        End If

        reader.Close()
        connToAcc.closeAccDB()


        '________________________________________________________________________________________________________________
        '//SALES
        cmd = New MySqlCommand($"SELECT sales_id, sales_date, u.lastname, u.firstname, c.company_name
                                FROM sales s
                                INNER JOIN users u
                                ON s.user_id = u.user_id
                                INNER JOIN customer c
                                ON s.customer_id = c.customer_id
                                ORDER BY sales_date DESC", connToAcc.openAccDB)
        Using reader = cmd.ExecuteReader
            While reader.Read
                SalesDGV.Rows.Add(reader.Item("sales_id").ToString, reader.Item("sales_date").ToString,
                                          reader.Item("lastname").ToString, reader.Item("firstname").ToString, reader.Item("company_name").ToString)
            End While
        End Using

        reader.Close()
        connToAcc.closeAccDB()

        '________________________________________________________________________________________________________________
        '//SALES DETAILS
        LoadingAllSales(DailySaleBttn)

        '***************************END OF LOAD ALL DATA******************************************
        '*****************************************************************************************
        '*****************************************************************************************
    End Sub

    Public Function RandGen(Optional ByVal validchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+", Optional ByVal strlngth As Integer = 20)

        Dim sb As New StringBuilder()
        Dim rand As New Random()
        For i As Integer = 1 To strlngth
            Dim idx As Integer = rand.Next(0, validchars.Length)
            Dim randomChar As Char = validchars(idx)
            sb.Append(randomChar)
        Next i

        Dim randomString = sb.ToString()

        Return randomString
    End Function

    Private Sub LogoutBttn_Click(sender As Object, e As EventArgs) Handles LogoutBttn.Click
        DialogResult = MessageBox.Show("Logging out, proceed?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If DialogResult = DialogResult.OK Then
            Close()
            Login.Show()
        End If
    End Sub

    Private Sub Mainsystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '***********************************************************************************************************************
        '***********************************************************************************************************************
        '********************************************* DETERMINING PRIVILEGES **************************************************
        '***********************************************************************************************************************

        user_icon.Focus()
        If Login.privileges = "ADMINISTRATOR" Or Login.privileges = "SUPER ADMIN" Then
            WelcomeLabel.Text = "Welcome! " + Login.privileges + " " + Login.lastname + ", " + Login.firstname + "."
        ElseIf Login.privileges = "USER" Then
            WelcomeLabel.Text = "Welcome! " + Login.privileges + " " + Login.lastname + ", " + Login.firstname + "."
            For Each pic In {UserMngmntBttn, AffliliatesBttn, RawMtrlsBttn, ProductionBttn, ProdBttn}
                pic.Visible = False
            Next
            For Each pan In {UserManagementContent, AffiliatesContent, RawMaterialsContent, ProductsContent}
                pan.Visible = False
            Next
            SalesBttn.Location = New Point(1, 230)
            SalesRepBttn.Location = New Point(1, 281)
        End If

        '**************************************** END OF DETERMINING PRIVILEGES *************************************************
        '************************************************************************************************************************

        ClockTimer.Enabled = True

        '*********************************** FRONTING DEFAULT PAGE **************************
        DashboardContent.BringToFront()
        SideBar.BringToFront()
        Load_Records()
    End Sub


#Region "DASHBOARD // NAVBAR // DATE-TIME // CLICK AND TICK"
    ' ----------------------- DATE AND TIME ----------------------
    Private Sub ClockTimer_Tick(sender As Object, e As EventArgs) Handles ClockTimer.Tick
        TimeLabel.Text = Format(Now, "MM - dd - yyyy    ||    hh:mm:ss")
    End Sub
    '---------------- END DATE AND TIME ---------------------------------
#End Region


#Region "SIDE PANEL"
    '******************************* TRANSITION IN SIDE PANEL **********************************
    ' OPENING PANEL ****************************
    Private Sub user_icon_Click(sender As Object, e As EventArgs) Handles user_icon.Click
        If AccInfoPanel.Visible = True Then
            AccInfoPanel.Visible = False
        ElseIf AccInfoPanel.Visible = False Then
            AccInfoPanel.Visible = True
        End If
    End Sub

    Private Sub user_icon_MouseHover(sender As Object, e As EventArgs) Handles user_icon.MouseHover
        user_icon.BackColor = Color.Gold
    End Sub

    Private Sub user_icon_MouseLeave(sender As Object, e As EventArgs) Handles user_icon.MouseLeave
        user_icon.BackColor = Color.DarkOrange
    End Sub
#End Region


#Region "SIDEBAR BUTTONS"
    ' ------------------------ SIDEBAR MOUSE HOVER AND LEAVE ----------------------------

    ' -------- HOVER -----------------
    Private Sub DashboardBttn_MouseHover(sender As Object, e As EventArgs) Handles DashboardBttn.MouseHover
        DashboardBttn.BackColor = Color.Gold
        DescLabel.Text = "Dashboard: Displays all the basic information and the overview of the whole status of the business."
    End Sub

    Private Sub DashboardBttn_MouseLeave(sender As Object, e As EventArgs) Handles DashboardBttn.MouseLeave
        DashboardBttn.BackColor = Color.DarkOrange
    End Sub

    '---------------------------------------------------------------------------
    '---------------------------------------------------------------------------

    Private Sub UserMngmntBttn_MouseHover(sender As Object, e As EventArgs) Handles UserMngmntBttn.MouseHover
        UserMngmntBttn.BackColor = Color.Gold
        DescLabel.Text = "User Management: Overview of all the users logged into the system as well as their access level.
                         (viewer: admin only)"
    End Sub

    Private Sub UserMngmntBttn_MouseLeave(sender As Object, e As EventArgs) Handles UserMngmntBttn.MouseLeave
        UserMngmntBttn.BackColor = Color.DarkOrange
    End Sub

    '---------------------------------------------------------------------------
    '---------------------------------------------------------------------------

    Private Sub AffliliatesBttn_MouseHover(sender As Object, e As EventArgs) Handles AffliliatesBttn.MouseHover
        AffliliatesBttn.BackColor = Color.Gold
        DescLabel.Text = "Affiliates: Contains information about the customers and suppliers, their contact information
                         and other basic information."
    End Sub

    Private Sub AffliliatesBttn_MouseLeave(sender As Object, e As EventArgs) Handles AffliliatesBttn.MouseLeave
        AffliliatesBttn.BackColor = Color.DarkOrange
    End Sub

    '---------------------------------------------------------------------------
    '---------------------------------------------------------------------------

    Private Sub RawMtrlsBttn_MouseHover(sender As Object, e As EventArgs) Handles RawMtrlsBttn.MouseHover
        RawMtrlsBttn.BackColor = Color.Gold
        DescLabel.Text = "Raw Materials: Items acquired by the business through our suppliers and are subject to fabrication
                         and reconfigurations."
    End Sub

    Private Sub RawMtrlsBttn_MouseLeave(sender As Object, e As EventArgs) Handles RawMtrlsBttn.MouseLeave
        RawMtrlsBttn.BackColor = Color.DarkOrange
    End Sub

    '---------------------------------------------------------------------------
    '---------------------------------------------------------------------------

    Private Sub ProductionBttn_MouseHover(sender As Object, e As EventArgs) Handles ProductionBttn.MouseHover
        ProductionBttn.BackColor = Color.Gold
        DescLabel.Text = "Production: Configures which materials are subject for the fabrication process, turning them
                          into the products of the business."
    End Sub

    Private Sub ProductionBttn_MouseLeave(sender As Object, e As EventArgs) Handles ProductionBttn.MouseLeave
        ProductionBttn.BackColor = Color.DarkOrange
    End Sub

    '---------------------------------------------------------------------------
    '---------------------------------------------------------------------------

    Private Sub ProdBttn_MouseHover(sender As Object, e As EventArgs) Handles ProdBttn.MouseHover
        ProdBttn.BackColor = Color.Gold
        DescLabel.Text = "Products: The business' finished products, ready for use and are distributed to all branches."
    End Sub

    Private Sub ProdBttn_MouseLeave(sender As Object, e As EventArgs) Handles ProdBttn.MouseLeave
        ProdBttn.BackColor = Color.DarkOrange
    End Sub

    '---------------------------------------------------------------------------
    '---------------------------------------------------------------------------

    Private Sub SalesBttn_MouseHover(sender As Object, e As EventArgs) Handles SalesBttn.MouseHover
        SalesBttn.BackColor = Color.Gold
        DescLabel.Text = "Sales: Records of the sales made by the business throughout the day."
    End Sub

    Private Sub SalesBttn_MouseLeave(sender As Object, e As EventArgs) Handles SalesBttn.MouseLeave
        SalesBttn.BackColor = Color.DarkOrange
    End Sub

    '---------------------------------------------------------------------------
    '---------------------------------------------------------------------------

    Private Sub SalesRepBttn_MouseHover(sender As Object, e As EventArgs) Handles SalesRepBttn.MouseHover
        SalesRepBttn.BackColor = Color.Gold
        DescLabel.Text = "Sales Report: Contains all the sales made, capable of generating reports for the day, a chosen
                          month, or a date range of choice. This also gives overview of the most or least bought items."
    End Sub

    Private Sub SalesRepBttn_MouseLeave(sender As Object, e As EventArgs) Handles SalesRepBttn.MouseLeave
        SalesRepBttn.BackColor = Color.DarkOrange

    End Sub

    '------------------- END OF SIDEBAR HOVER AND LEAVE -----------------------
    '---------------------------------------------------------------------------
    '---------------------------------------------------------------------------



    '--------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------
    '------------------------------------ SIDEBAR BUTTONS ---------------------------------------------------------------------

    Private Sub DashboardBttn_Click(sender As Object, e As EventArgs) Handles DashboardBttn.Click
        CategoryLabel.Text = "DASHBOARD"
        DashboardContent.BringToFront()
        SideBar.BringToFront()
    End Sub

    Private Sub UserMngmntBttn_Click(sender As Object, e As EventArgs) Handles UserMngmntBttn.Click
        If Login.privileges = "SUPER ADMIN" Then
            CategoryLabel.Text = "USER MANAGEMENT"
            UserManagementContent.BringToFront()
            SideBar.BringToFront()
        Else
            MessageBox.Show("'USER MANAGEMENT' is only accessible to the 'SUPER ADMIN'.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub AffliliatesBttn_Click(sender As Object, e As EventArgs) Handles AffliliatesBttn.Click
        CategoryLabel.Text = "AFFILIATES"
        AffiliatesContent.BringToFront()
        SideBar.BringToFront()
    End Sub

    Private Sub RawMtrlsBttn_Click(sender As Object, e As EventArgs) Handles RawMtrlsBttn.Click
        CategoryLabel.Text = "PURCHASE AND RAW MATERIALS"
        RawMaterialsContent.BringToFront()
        SideBar.BringToFront()
    End Sub

    Private Sub ProductionBttn_Click(sender As Object, e As EventArgs) Handles ProductionBttn.Click
        CategoryLabel.Text = "WORK-IN-PROGRESS"
        ProductionContent.BringToFront()
        SideBar.BringToFront()
    End Sub

    Private Sub ProdBttn_Click(sender As Object, e As EventArgs) Handles ProdBttn.Click
        CategoryLabel.Text = "PRODUCTS"
        ProductsContent.BringToFront()
        SideBar.BringToFront()
    End Sub

    Private Sub SalesBttn_Click(sender As Object, e As EventArgs) Handles SalesBttn.Click
        CategoryLabel.Text = "ORDER OF CUSTOMER"
        SalesContent.BringToFront()
        SideBar.BringToFront()
    End Sub

    Private Sub SalesRepBttn_Click(sender As Object, e As EventArgs) Handles SalesRepBttn.Click
        CategoryLabel.Text = "REPORTS"
        SalesReportContent.BringToFront()
        SideBar.BringToFront()
    End Sub

    '------------------------------------------- END OF SIDEBAR BUTTONS -------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------
#End Region


#Region "USER MANAGEMENT CONTENT"
    '***********************************************************************************************************************
    '***********************************************************************************************************************
    '*************************************** USER MANAGEMENT CONTENT *******************************************************
    '***********************************************************************************************************************

    Private Sub AddUserMngmntBttn_Click(sender As Object, e As EventArgs) Handles AddUserMngmntBttn.Click
        ModifyUser.ModifLabel.Visible = False
        For Each txt In {ModifyUser.textfname, ModifyUser.textuname, ModifyUser.textpass1, ModifyUser.textMN, ModifyUser.textemail, ModifyUser.textage, ModifyUser.textpass2, ModifyUser.textlname}
            txt.Clear()
        Next
        Me.Opacity = 0.75
        ModifyUser.Show()
        Me.Enabled = False
        EditUserMngmtBttn.Enabled = False
        ModifyUser.AddUserBttn.BringToFront()

    End Sub

    Private Sub EditUserMngmtBttn_Click(sender As Object, e As EventArgs) Handles EditUserMngmtBttn.Click
        ModifyUser.ModifLabel.Visible = True
        Try
            If IsNothing(UsersDGV.CurrentRow) Then
                MsgBox("No Rows Selected.", vbInformation)
            Else
                Me.Opacity = 0.75
                ModifyUser.Show()
                Me.Enabled = False
                ModifyUser.UpdateBttn.BringToFront()
            End If
        Catch ex As Exception
            connToAcc.closeAccDB()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub UsersDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersDGV.CellClick
        '//retrieving information
        Try
            EditUserMngmtBttn.Enabled = True
            cmd = New MySqlCommand($"SELECT * FROM users WHERE firstname='" & UsersDGV.CurrentRow.Cells(1).Value & "'", connToAcc.openAccDB)
            da = New MySqlDataAdapter(cmd)
            reader = cmd.ExecuteReader

            While reader.Read
                user_id = reader.GetInt32("user_id")
            End While
            reader.Close()

            dtable = New DataTable
            da.Fill(dtable)

            ModifyUser.textfname.Text = dtable.Rows(0).Item("firstname")
            ModifyUser.textlname.Text = dtable.Rows(0).Item("lastname")
            ModifyUser.textuname.Text = dtable.Rows(0).Item("username")
            ModifyUser.textpass1.Text = dtable.Rows(0).Item("password")
            ModifyUser.textage.Text = dtable.Rows(0).Item("age")
            ModifyUser.textemail.Text = dtable.Rows(0).Item("email")
            ModifyUser.textMN.Text = dtable.Rows(0).Item("mobile_number")
            ModifyUser.textpriv.Text = dtable.Rows(0).Item("privileges")

            connToAcc.closeAccDB()
        Catch ex As Exception
            connToAcc.closeAccDB()
            MsgBox(ex.Message)
        End Try

        '//DELETING RECORDS
        Dim userDelete As String = UsersDGV.Columns(e.ColumnIndex).HeaderText
        If userDelete = "Delete" Then
            If MsgBox("Delete this record?", vbYesNo + vbQuestion) = vbYes Then
                cmd = New MySqlCommand($"DELETE FROM users WHERE user_id = '" & user_id & "'", connToAcc.openAccDB)
                cmd.ExecuteNonQuery()
                connToAcc.closeAccDB()
                MsgBox("Record has been successfully deleted.", vbInformation)
                Load_Records()
                ModifyUser.ResetModif()
                UsersDGV.ClearSelection()
                EditUserMngmtBttn.Enabled = False
            End If
        End If
    End Sub

    Private Sub UsersDGV_MouseHover(sender As Object, e As EventArgs) Handles UsersDGV.MouseHover
        DescLabel.Text = "Data Editing: Click on any information above to enable editing."
    End Sub

    '_************************************* END OF USER MANAGEMENT CONTENT *************************************************
    '***********************************************************************************************************************
#End Region


#Region "AFFILIATES CONTENT"
    '***********************************************************************************************************************
    '***********************************************************************************************************************
    '****************************************** AFFILIATES CONTENT *********************************************************
    '***********************************************************************************************************************
    Function Cleanout()
        For Each txt In {ModifyAffiliates.textaffiliateid, ModifyAffiliates.textcompanyname, ModifyAffiliates.textemail, ModifyAffiliates.textcontno}
            txt.Clear()
        Next
        Return 0
    End Function

    '//FOR CUSTOMERS ////
    Private Sub AddNewCustomerBttn_Click(sender As Object, e As EventArgs) Handles AddNewCustomerBttn.Click
        ModifyAffiliates.ClearAllBttn.Visible = True
        ModifyAffiliates.Label1.Visible = True
        ModifyAffiliates.AddNewCustLabel.Visible = True

        Cleanout()
        Me.Opacity = 0.75
        ModifyAffiliates.Show()
        Me.Enabled = False
        ModifyAffiliates.AddCustomerBttn.BringToFront()
    End Sub

    Private Sub EditCustomerBttn_Click(sender As Object, e As EventArgs) Handles EditCustomerBttn.Click
        ModifyAffiliates.Label1.Visible = True
        ModifyAffiliates.ModifCustLabel.Visible = True

        Try
            If IsNothing(CustomerDGV.CurrentRow) Then
                MsgBox("No Rows Selected.", vbInformation)
            Else
                Me.Opacity = 0.75
                ModifyAffiliates.Show()
                Me.Enabled = False
                ModifyAffiliates.UpdateCustomerBttn.BringToFront()
                ModifyAffiliates.ClearAllBttn.Visible = False
                ModifyAffiliates.textaffiliateid.Enabled = False
            End If
        Catch ex As Exception
            connToAcc.closeAccDB()
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub CustomerDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerDGV.CellClick
        '//retrieving information
        Try
            EditCustomerBttn.Enabled = True
            cmd = New MySqlCommand($"SELECT * FROM customer WHERE customer_id='" & CustomerDGV.CurrentRow.Cells(0).Value & "'", connToAcc.openAccDB)
            da = New MySqlDataAdapter(cmd)

            dtable = New DataTable
            da.Fill(dtable)

            ModifyAffiliates.textaffiliateid.Text = dtable.Rows(0).Item("customer_id")
            ModifyAffiliates.textcompanyname.Text = dtable.Rows(0).Item("company_name")
            ModifyAffiliates.textemail.Text = dtable.Rows(0).Item("email")
            ModifyAffiliates.textcontno.Text = dtable.Rows(0).Item("contact_no")

            connToAcc.closeAccDB()
        Catch ex As Exception
            connToAcc.closeAccDB()
            MsgBox(ex.Message)
        End Try

        '//DELETING RECORDS
        Dim customerDelete As String = CustomerDGV.Columns(e.ColumnIndex).HeaderText
        If customerDelete = "Delete" Then
            If MsgBox("Delete this record?", vbYesNo + vbQuestion) = vbYes Then
                cmd = New MySqlCommand($"DELETE FROM customer WHERE customer_id = '" & dtable.Rows(0).Item("customer_id") & "'", connToAcc.openAccDB)
                cmd.ExecuteNonQuery()
                connToAcc.closeAccDB()
                MsgBox("Record has been successfully deleted.", vbInformation)
                Load_Records()
                ModifyAffiliates.ResetModif()
                CustomerDGV.ClearSelection()
                EditCustomerBttn.Enabled = False
            End If
        End If
    End Sub

    '************************************************************************************************************************************
    '************************************************************************************************************************************
    '//FOR SUPPLIERS
    Private Sub AddNewSupplierBttn_Click(sender As Object, e As EventArgs) Handles AddNewSupplierBttn.Click
        ModifyAffiliates.Label5.Visible = True
        ModifyAffiliates.AddNewSuppLabel.Visible = True
        ModifyAffiliates.ClearAllBttn.Visible = True

        Cleanout()
        Me.Opacity = 0.75
        ModifyAffiliates.Show()
        Me.Enabled = False
        ModifyAffiliates.AddSupplierBttn.BringToFront()
    End Sub


    Private Sub EditSupplierBttn_Click(sender As Object, e As EventArgs) Handles EditSupplierBttn.Click
        ModifyAffiliates.Label5.Visible = True
        ModifyAffiliates.ModifSuppLabel.Visible = True

        Try
            If IsNothing(SupplierDGV.CurrentRow) Then
                MsgBox("No Rows Selected.", vbInformation)
            Else
                Me.Opacity = 0.75
                ModifyAffiliates.Show()
                Me.Enabled = False
                ModifyAffiliates.UpdateSupplierBttn.BringToFront()
                ModifyAffiliates.ClearAllBttn.Visible = False
                ModifyAffiliates.textaffiliateid.Enabled = False
            End If
        Catch ex As Exception
            connToAcc.closeAccDB()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SupplierDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SupplierDGV.CellClick
        '//retrieving information
        Try
            EditSupplierBttn.Enabled = True
            cmd = New MySqlCommand($"SELECT * FROM supplier WHERE supplier_id='" & SupplierDGV.CurrentRow.Cells(0).Value & "'", connToAcc.openAccDB)
            da = New MySqlDataAdapter(cmd)

            dtable = New DataTable
            da.Fill(dtable)

            ModifyAffiliates.textaffiliateid.Text = dtable.Rows(0).Item("supplier_id")
            ModifyAffiliates.textcompanyname.Text = dtable.Rows(0).Item("company_name")
            ModifyAffiliates.textemail.Text = dtable.Rows(0).Item("email")
            ModifyAffiliates.textcontno.Text = dtable.Rows(0).Item("contact_no")

            connToAcc.closeAccDB()
        Catch ex As Exception
            connToAcc.closeAccDB()
            MsgBox(ex.Message)
        End Try

        '//DELETING RECORDS
        Dim supplierDelete As String = SupplierDGV.Columns(e.ColumnIndex).HeaderText
        If supplierDelete = "Delete" Then
            If MsgBox("Delete this record?", vbYesNo + vbQuestion) = vbYes Then
                cmd = New MySqlCommand($"DELETE FROM supplier WHERE supplier_id = '" & dtable.Rows(0).Item("supplier_id") & "'", connToAcc.openAccDB)
                cmd.ExecuteNonQuery()
                connToAcc.closeAccDB()
                MsgBox("Record has been successfully deleted.", vbInformation)
                Load_Records()
                ModifyAffiliates.ResetModif()
                SupplierDGV.ClearSelection()
                EditSupplierBttn.Enabled = False
            End If
        End If
    End Sub


    Private Sub CustomerDGV_MouseHover(sender As Object, e As EventArgs) Handles CustomerDGV.MouseHover
        DescLabel.Text = "Data Editing: Click on any information above to enable editing."
    End Sub

    '_*************************************** END OF AFFILIATES CONTENT ****************************************************
    '***********************************************************************************************************************
#End Region


#Region "RAW MATERIALS CONTENT"
    '***********************************************************************************************************************
    '***********************************************************************************************************************
    '*************************************** RAW MATERIALS CONTENT *********************************************************
    '***********************************************************************************************************************

    Private Sub AddNewRawMaterialsBttn_Click(sender As Object, e As EventArgs) Handles AddNewRawMaterialsBttn.Click
        Me.Opacity = 0.75
        AddNewRawMaterials.Show()
        AddNewRawMaterials.ADDEDITRAWMATERIALPANEL.BringToFront()
        Me.Enabled = False
        AddNewRawMaterials.opt = 1
    End Sub

    Private Sub ADDSTOCKBTTN_Click(sender As Object, e As EventArgs) Handles ADDSTOCKBTTN.Click
        Me.Opacity = 0.75
        AddNewRawMaterials.Show()
        AddNewRawMaterials.ADDINSTOCKPANEL.BringToFront()
        Me.Enabled = False
    End Sub

    Private Sub OrderFRMSupplierBttn_Click(sender As Object, e As EventArgs) Handles OrderFRMSupplierBttn.Click
        Me.Opacity = 0.75
        AddNewRawMaterials.Show()
        AddNewRawMaterials.ORDERFORMPANEL.BringToFront()
        Me.Enabled = False
    End Sub

    '// SEARCH DGV FOR ITEMS IN MATERIALS --------------------------
    Private Sub RawMSearchbox_KeyUp(sender As Object, e As KeyEventArgs) Handles RawMSearchbox.KeyUp
        Try
            If RawMSearchbox.Text = "" Then
                dtable.Clear()
                RawMaterialsSearchDGV.Rows.Clear()
            Else
                dtable.Clear()
                RawMaterialsSearchDGV.Rows.Clear()

                cmd = New MySqlCommand($"SELECT m.material_id, m.material_name, m.average_cost, m.in_stock, m.expected, m.committed, m.missing, s.company_name
                                     FROM materials m 
                                     INNER JOIN supplier s
                                     ON m.supplier_id = s.supplier_id
                                     WHERE m.material_id LIKE '" & RawMSearchbox.Text & "%' OR m.material_name LIKE '" & RawMSearchbox.Text & "%'", connToAcc.openAccDB)

                reader = cmd.ExecuteReader
                While reader.Read
                    RawMaterialsSearchDGV.Rows.Add(reader.Item("material_id").ToString, reader.Item("material_name").ToString,
                                               reader.Item("average_cost").ToString, reader.Item("in_stock").ToString,
                                               reader.Item("expected").ToString, reader.Item("committed").ToString,
                                               reader.Item("missing").ToString, reader.Item("company_name").ToString)
                End While
                reader.Close()
                connToAcc.closeAccDB()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            connToAcc.closeAccDB()
        End Try
    End Sub

    Private Sub ClearRawMSearchBoxBttn_Click(sender As Object, e As EventArgs) Handles ClearRawMSearchBoxBttn.Click
        RawMSearchbox.Clear()
        RawMaterialsSearchDGV.Rows.Clear()
    End Sub

    Private Sub RawMaterialsDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles RawMaterialsDGV.CellClick
        Dim rm As New AddNewRawMaterials
        rm.opt = 2
        '//DELETING RECORDS
        Try
            Dim RawMaterialsDelete As String = RawMaterialsDGV.Columns(e.ColumnIndex).HeaderText
            If RawMaterialsDelete = "Delete" Then
                If MsgBox("Delete this record?", vbYesNo + vbQuestion) = vbYes Then
                    cmd = New MySqlCommand($"DELETE FROM materials WHERE material_id = '" & RawMaterialsDGV.CurrentRow.Cells(0).Value & "'", connToAcc.openAccDB)
                    cmd.ExecuteNonQuery()
                    connToAcc.closeAccDB()
                    MsgBox("Record has been successfully deleted.", vbInformation)
                    Load_Records()
                    RawMaterialsDGV.ClearSelection()
                End If

            ElseIf RawMaterialsDelete = "Edit" Then
                '//retrieving information
                cmd = New MySqlCommand($"SELECT m.supplier_id, s.company_name, m.material_id, m.material_name, m.in_stock,
                                            m.average_cost FROM materials m
                                            INNER JOIN supplier s ON m.supplier_id = s.supplier_id
                                            WHERE material_id='" & RawMaterialsDGV.CurrentRow.Cells(0).Value & "'", connToAcc.openAccDB)
                    da = New MySqlDataAdapter(cmd)

                    dtable = New DataTable
                    da.Fill(dtable)


                rm.SupplierName.Text = String.Format("{0}-{1}", dtable.Rows(0).Item("supplier_id"), dtable.Rows(0).Item("company_name"))
                rm.MaterialName.Text = dtable.Rows(0).Item("material_name")
                rm.MaterialIDval = dtable.Rows(0).Item("material_id")
                rm.InStock.Text = dtable.Rows(0).Item("in_stock")
                rm.AverageCost.Text = dtable.Rows(0).Item("average_cost")

                connToAcc.closeAccDB()

                Me.Opacity = 0.75
                rm.Show()
                Me.Enabled = False

                For Each clr In {rm.SupplierName, rm.MaterialName, rm.InStock, rm.AverageCost}
                    clr.forecolor = Color.Black
                Next
                rm.SupplierName.Enabled = False
                rm.InStock.Enabled = False
                rm.Label1.Visible = True
                rm.AddNewMtrlBttn.Text = "Update"
                rm.ADDEDITRAWMATERIALPANEL.BringToFront()
                rm.ClearAllBttn.Visible = False
            End If

        Catch ex As Exception
            connToAcc.closeAccDB()
            MsgBox(ex.Message)
        End Try
    End Sub


    '//---- INSTOCK, NOT ACTIVE, OUT OF STOCK -----------
    Private Sub InStockRawBttn_Click(sender As Object, e As EventArgs) Handles InStockRawBttn.Click
        cmd = New MySqlCommand($"SELECT m.material_id, m.material_name, m.average_cost, m.in_stock, m.expected, m.committed, m.missing, s.company_name
                                     FROM materials m 
                                     INNER JOIN supplier s
                                     ON m.supplier_id = s.supplier_id
                                     WHERE m.in_stock > 0", connToAcc.openAccDB)
        StockCheck(cmd, RawMaterialsDGV)
    End Sub

    Private Sub NotActiveRawBttn_Click(sender As Object, e As EventArgs) Handles NotActiveRawBttn.Click
        cmd = New MySqlCommand($"SELECT m.material_id, m.material_name, m.average_cost, m.in_stock, m.expected, m.committed, m.missing, s.company_name
                                     FROM materials m 
                                     INNER JOIN supplier s
                                     ON m.supplier_id = s.supplier_id
                                     WHERE m.in_stock <= 0 AND m.expected <= 0 AND m.committed <= 0 AND m.missing <= 0", connToAcc.openAccDB)
        StockCheck(cmd, RawMaterialsDGV)
    End Sub

    Private Sub OutOfStockRawBttn_Click(sender As Object, e As EventArgs) Handles OutOfStockRawBttn.Click
        cmd = New MySqlCommand($"SELECT m.material_id, m.material_name, m.average_cost, m.in_stock, m.expected, m.committed, m.missing, s.company_name
                                     FROM materials m 
                                     INNER JOIN supplier s
                                     ON m.supplier_id = s.supplier_id
                                     WHERE m.in_stock <= 0 AND m.expected > 0", connToAcc.openAccDB)
        StockCheck(cmd, RawMaterialsDGV)
    End Sub

#Region "PRINTING GENERATE REPORTS"

    Private Sub GenRepRawBttn_Click(sender As Object, e As EventArgs) Handles GenRepRawBttn.Click
        GRepBttnChecker = "Raw Materials"

        PrintPreviewDialog1.Document = PrintDocument1
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        If GRepBttnChecker = "Raw Materials" Then
            PRT.Print(sender, e, RawMaterialsDGV)
        ElseIf GRepBttnChecker = "Products" Then
            PRT.Print(sender, e, ProductsDGV)
        ElseIf GRepBttnChecker = "Sales" Then
            PRT.Print(sender, e, SalesDGV)
        ElseIf GRepBttnChecker = "Order Materials" Then
            PRT.Print(sender, e, AddNewRawMaterials.OrderDGV)
        ElseIf GRepBttnChecker = "Production" Then
            PRT.Print(sender, e, AllProductionsDGV)
        ElseIf GRepBttnChecker = "Reports" Then
            e.HasMorePages = True
            PRT.Print(sender, e, AllSalesDGV)
        End If

    End Sub

#End Region

    '_************************************* END OF RAW MATERIALS CONTENT ***************************************************
    '***********************************************************************************************************************
#End Region


#Region "PRODUCTION CONTENT"

    '/// RENDERING PRODUCTION COMPLETE OR INCOMPLETE
    '///////////////
    Private Sub AllProductionsDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles AllProductionsDGV.CellClick
        Dim prod_id = AllProductionsDGV.CurrentRow.Cells(0).Value

        Dim statuscompletion As String = AllProductionsDGV.Columns(e.ColumnIndex).HeaderText
        If statuscompletion = "Finish Work-In-Progress" Then
            DialogResult = MessageBox.Show("Production will be marked as completed. Continue?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If DialogResult = vbYes Then
                Try
                    cmd = New MySqlCommand($"UPDATE materials mat
                                           INNER JOIN components comp
                                           on comp.material_id = mat.material_id
                                           INNER JOIN make
                                           ON make.production_id = comp.production_id
                                           SET mat.in_stock = mat.in_stock-(make.quantity*comp.quantity),
                                           mat.committed = mat.committed-(make.quantity*comp.quantity)
                                           WHERE make.production_id = '" & prod_id & "'", connToAcc.openAccDB)
                    cmd.ExecuteNonQuery()
                    connToAcc.closeAccDB()

                    Dim cmd1 = New MySqlCommand($"UPDATE products p
                                            INNER JOIN make m
                                            on m.product_id = p.product_id
                                            SET p.in_stock = p.in_stock + (SELECT m.quantity), p.expected = p.expected - (SELECT m.quantity)
                                            WHERE m.production_id = '" & prod_id & "'", connToAcc.openAccDB)
                    cmd1.ExecuteNonQuery()
                    connToAcc.closeAccDB()

                    Dim cmd2 = New MySqlCommand("INSERT INTO production_log (production_id, datetime, quantity)
                                           VALUES('" & prod_id & "', @datenow, '" & AllProductionsDGV.CurrentRow.Cells(3).Value & "')", connToAcc.openAccDB)
                    cmd2.Parameters.Add("@datenow", MySqlDbType.DateTime).Value = DateTime.Now

                    cmd2.ExecuteNonQuery()
                    connToAcc.closeAccDB()

                    Dim cmd3 = New MySqlCommand($"UPDATE make Set quantity = 0, production_deadline = @d1 WHERE production_id = '" & prod_id & "'", connToAcc.openAccDB)
                    cmd3.Parameters.Add("@d1", MySqlDbType.DateTime).Value = DateTime.Now

                    cmd3.ExecuteNonQuery()
                    connToAcc.closeAccDB()

                    MessageBox.Show("Data Update Success", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                Catch ex As Exception
                    MessageBox.Show("Insufficient Raw Materials!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    connToAcc.closeAccDB()
                    Exit Sub
                End Try

                Load_Records()

            ElseIf DialogResult = vbNo Then
                Exit Sub
            End If
        End If
    End Sub

    '///////////////////////////
    '/// EDIT COMPONENTS // ADD NEW TO PRODUCTION // PRODUCTION LOG
    '///////////////////////////

    Private Sub EditCompProdctnBttn_Click(sender As Object, e As EventArgs) Handles EditCompProdctnBttn.Click
        ModifyProduction.Show()
        ModifyProduction.EditComponentsContent.BringToFront()
    End Sub

    Private Sub AddToProduce_Click(sender As Object, e As EventArgs) Handles AddToProduce.Click
        ModifyProduction.Show()
        ModifyProduction.AddtoNewProduceContent.BringToFront()
    End Sub

    Private Sub PrdctnLogBttn_Click(sender As Object, e As EventArgs) Handles PrdctnLogBttn.Click
        ModifyProduction.Show()
        ModifyProduction.ProductionLogContent.BringToFront()
    End Sub

    Private Sub GenRepProductionBttn_Click(sender As Object, e As EventArgs) Handles GenRepProductionBttn.Click
        GRepBttnChecker = "Production"

        PrintPreviewDialog1.Document = PrintDocument1
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub
#End Region


#Region "PRODUCTS CONTENT"
    '***********************************************************************************************************************
    '***********************************************************************************************************************
    '*************************************** PRODUCTS CONTENT **************************************************************
    '***********************************************************************************************************************

    Private Sub AddNewProductBttn_Click(sender As Object, e As EventArgs) Handles AddNewProductBttn.Click
        AddNewProduct.Show()
    End Sub

    '// SEARCH DGV FOR ITEMS IN PRODUCTS --------------------------
    Private Sub ProdSearchbox_KeyUp(sender As Object, e As KeyEventArgs) Handles ProdSearchBox.KeyUp
        Try
            If ProdSearchBox.Text = "" Then
                dtable.Clear()
                ProductsSearchDGV.Rows.Clear()
            Else
                dtable.Clear()
                ProductsSearchDGV.Rows.Clear()

                cmd = New MySqlCommand($"SELECT product_id,product_name,part_number,product_size,unit_length,
                                    product_dimension,sale_price,average_cost,profit,in_stock,expected,
                                    ordered FROM products
                                    WHERE product_id LIKE '" & ProdSearchBox.Text & "%' OR product_name LIKE '" & ProdSearchBox.Text & "%'", connToAcc.openAccDB)

                reader = cmd.ExecuteReader
                While reader.Read
                    ProductsSearchDGV.Rows.Add(reader.Item("product_id").ToString, reader.Item("product_name").ToString,
                                               reader.Item("part_number").ToString, reader.Item("product_size").ToString,
                                               reader.Item("unit_length").ToString, reader.Item("product_dimension").ToString,
                                               reader.Item("sale_price").ToString, reader.Item("average_cost").ToString,
                                               reader.Item("profit").ToString, reader.Item("in_stock").ToString,
                                               reader.Item("expected").ToString, reader.Item("ordered").ToString)
                End While
                reader.Close()
                connToAcc.closeAccDB()
            End If

        Catch ex As Exception
            connToAcc.closeAccDB()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearProdSearchBoxBttn_Click(sender As Object, e As EventArgs) Handles ClearProdSearchBoxBttn.Click
        ProdSearchBox.Clear()
        ProductsSearchDGV.Rows.Clear()
    End Sub


    '//---- INSTOCK, NOT ACTIVE, OUT OF STOCK -----------
    Private Sub InStockProdBttn_Click(sender As Object, e As EventArgs) Handles InStockProdBttn.Click
        cmd = New MySqlCommand($"SELECT product_id,product_name,part_number,product_size,unit_length,
                                    product_dimension,sale_price,average_cost,profit,in_stock,expected,
                                    ordered FROM products
                                    WHERE in_stock > 0", connToAcc.openAccDB)
        StockCheck(cmd, ProductsDGV)
    End Sub

    Private Sub NotActiveProdBttn_Click(sender As Object, e As EventArgs) Handles NotActiveProdBttn.Click
        cmd = New MySqlCommand($"SELECT product_id,product_name,part_number,product_size,unit_length,
                                    product_dimension,sale_price,average_cost,profit,in_stock,expected,
                                    ordered FROM products
                                    WHERE in_stock <= 0 AND expected <= 0", connToAcc.openAccDB)
        StockCheck(cmd, ProductsDGV)
    End Sub

    Private Sub OutOfStockProdBttn_Click(sender As Object, e As EventArgs) Handles OutOfStockProdBttn.Click
        cmd = New MySqlCommand($"SELECT product_id,product_name,part_number,product_size,unit_length,
                                    product_dimension,sale_price,average_cost,profit,in_stock,expected,
                                    ordered FROM products
                                    WHERE in_stock <= 0 AND expected > 0", connToAcc.openAccDB)
        StockCheck(cmd, ProductsDGV)
    End Sub

    '////////////////////
    '/// PRINTING OF PRODUCTS DGV
    '////////////////////
    Private Sub GenRepProdBttn_Click(sender As Object, e As EventArgs) Handles GenRepProdBttn.Click
        GRepBttnChecker = "Products"

        PrintPreviewDialog1.Document = PrintDocument1
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub ProductsDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductsDGV.CellClick
        '//DELETING RECORDS
        Try
            Dim ProductsDelete As String = ProductsDGV.Columns(e.ColumnIndex).HeaderText
            If ProductsDelete = "Delete" Then
                If MsgBox("Delete this record?", vbYesNo + vbQuestion) = vbYes Then
                    cmd = New MySqlCommand($"DELETE FROM products WHERE products_id = '" & ProductsDGV.CurrentRow.Cells(0).Value & "'", connToAcc.openAccDB)
                    cmd.ExecuteNonQuery()
                    connToAcc.closeAccDB()
                    MsgBox("Record has been successfully deleted.", vbInformation)
                    Load_Records()
                    ProductsDGV.ClearSelection()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            connToAcc.closeAccDB()

        End Try

    End Sub

    '_************************************* END OF PRODUCTS CONTENT ********************************************************
    '***********************************************************************************************************************
#End Region


#Region "SALES CONTENT"
    '***********************************************************************************************************************
    '***********************************************************************************************************************
    '-------------------------------------------- SALES CONTENT ------------------------------------------------------------
    '***********************************************************************************************************************
    '***********************************************************************************************************************
    Private Sub GenRepSalesBttn_Click(sender As Object, e As EventArgs) Handles GenRepSalesBttn.Click
        GRepBttnChecker = "Sales"

        PrintPreviewDialog1.Document = PrintDocument1
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub ManageSalesBttn_Click(sender As Object, e As EventArgs) Handles ManageSalesBttn.Click
        ModifySales.Show()
    End Sub

    Private Sub SalesSearchbox_KeyUp(sender As Object, e As KeyEventArgs) Handles SalesSearchbox.KeyUp
        Try
            If SalesSearchbox.Text = "" Then
                dtable.Clear()
                SalesSearchDGV.Rows.Clear()
            Else
                dtable.Clear()
                SalesSearchDGV.Rows.Clear()

                cmd = New MySqlCommand($"SELECT sales_id, sales_date, u.lastname, c.company_name 
                                        FROM sales s
                                        INNER JOIN users u
                                        ON u.user_id = s.user_id
                                        INNER JOIN customer c
                                        ON s.customer_id = c.customer_id
                                        WHERE s.sales_id LIKE '" & SalesSearchbox.Text & "%' OR u.lastname LIKE '" & SalesSearchbox.Text & "%' OR c.company_name LIKE '" & SalesSearchbox.Text & "%'", connToAcc.openAccDB)

                reader = cmd.ExecuteReader
                While reader.Read
                    SalesSearchDGV.Rows.Add(reader.Item("sales_id").ToString, reader.Item("sales_date").ToString,
                                               reader.Item("lastname").ToString, reader.Item("company_name").ToString)
                End While
                reader.Close()
                connToAcc.closeAccDB()
            End If

        Catch ex As Exception
            connToAcc.closeAccDB()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClearSalesSearchBttn_Click(sender As Object, e As EventArgs) Handles ClearSalesSearchBttn.Click
        SalesSearchDGV.Rows.Clear()
        SalesSearchbox.Clear()
    End Sub
#End Region


#Region "SALES REPORT CONTENT"
    '***********************************************************************************************************************
    '***********************************************************************************************************************
    '------------------------------------- SALES REPORT CONTENT ------------------------------------------------------------
    '***********************************************************************************************************************
    '***********************************************************************************************************************
    Private Sub LoadingAllSales(ByVal btn As Button)
        Dim startdate As Date = Picker_StartDate.Value, enddate As Date = Picker_EndDate.Value
        AllSalesDGV.Rows.Clear()

        Try
            If btn Is DailySaleBttn Then
                cmd = New MySqlCommand($"SELECT SD.sale_details_id, s.sales_id, s.sales_date,
                                SD.product_id, SD.sale_quantity, SD.total
                                FROM sales s RIGHT JOIN sales_details SD ON s.sales_id = SD.sales_id
                                ORDER BY s.sales_date DESC", connToAcc.openAccDB)

            ElseIf btn Is MonthlySaleBttn Then
                cmd = New MySqlCommand($"SELECT SD.sale_details_id, s.sales_id, s.sales_date,
                                SD.product_id, SD.sale_quantity, SD.total
                                FROM sales s RIGHT JOIN sales_details SD ON s.sales_id = SD.sales_id
                                WHERE YEAR(s.sales_date) = EXTRACT(YEAR from CURRENT_TIMESTAMP)
                                AND MONTH(CURRENT_TIMESTAMP) = extract(MONTH FROM s.sales_date)
                                ORDER BY s.sales_date DESC", connToAcc.openAccDB)

            ElseIf btn Is SaleByDateRangeBttn Then
                cmd = New MySqlCommand($"SELECT SD.sale_details_id, s.sales_id, s.sales_date,
                                SD.product_id, SD.sale_quantity, SD.total
                                FROM sales s RIGHT JOIN sales_details SD ON s.sales_id = SD.sales_id
                                WHERE s.sales_date >= @picker1 
                                    AND s.sales_date <= @picker2
                                ORDER BY s.sales_date DESC", connToAcc.openAccDB)
                cmd.Parameters.AddWithValue("@picker1", startdate)
                cmd.Parameters.AddWithValue("@picker2", enddate.AddHours(22).AddMinutes(58).AddSeconds(59))
            End If

            Using reader = cmd.ExecuteReader
                While reader.Read
                    AllSalesDGV.Rows.Add(reader.Item("sale_details_id").ToString, reader.Item("sales_id").ToString,
                                           reader.Item("sales_date").ToString, reader.Item("product_id").ToString,
                                           reader.Item("sale_quantity").ToString, reader.Item("total").ToString)
                End While
            End Using
            reader.Close()
            connToAcc.closeAccDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            connToAcc.closeAccDB()
        End Try

    End Sub

    Private Sub SaleByDateRangeBttn_Click(sender As Object, e As EventArgs) Handles SaleByDateRangeBttn.Click
        DateRangeContent.Visible = True
        DateRangeContent.BringToFront()
        DateRangeContent.Focus()
    End Sub

    Private Sub DateRangeContent_Leave(sender As Object, e As EventArgs) Handles DateRangeContent.Leave
        DateRangeContent.Visible = False
        DateRangeContent.SendToBack()
    End Sub

    Private Sub DailySaleBttn_Click(sender As Object, e As EventArgs) Handles DailySaleBttn.Click
        LoadingAllSales(DailySaleBttn)
        HeaderSalesRep.Text = "Daily Reports"
    End Sub

    Private Sub SalesPredBttn_Click(sender As Object, e As EventArgs) Handles SalesPredBttn.Click
        Prediction.ShowDialog()
    End Sub

    Private Sub MonthlySaleBttn_Click(sender As Object, e As EventArgs) Handles MonthlySaleBttn.Click
        LoadingAllSales(MonthlySaleBttn)
        HeaderSalesRep.Text = "Monthly Reports"
    End Sub


    '****************************** DATE PICKER *************************************************
    Private Sub DateRangeBttn_Click(sender As Object, e As EventArgs) Handles DateRangeBttn.Click
        LoadingAllSales(SaleByDateRangeBttn)
        DateRangeContent.SendToBack()
    End Sub

    Private Sub GenRepSRBttn_Click(sender As Object, e As EventArgs) Handles GenRepSRBttn.Click
        GRepBttnChecker = "Reports"

        PrintPreviewDialog1.Document = PrintDocument1
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    '*********************************** END OF SALES REPORT CONTENT *******************************************************
    '***********************************************************************************************************************
    '***********************************************************************************************************************


#Region "FORECASTING"
    '***********************************************************************************************************************
    '***********************************************************************************************************************
    '---------------------------------------------- FORECASTING ------------------------------------------------------------
    '***********************************************************************************************************************
    '***********************************************************************************************************************
    Private Sub GetHighestSellingroducts()

        cmd = New MySqlCommand("SELECT P.product_id
	                   , P.product_name
	                FROM products P 
                    LEFT JOIN sales_details SD
    	                ON P.product_id = SD.product_id
                    GROUP BY product_id
                    ORDER BY SUM(SD.sale_quantity) DESC
                    LIMIT 5", connToAcc.openAccDB)

        Using da = New MySqlDataAdapter(cmd)
            dtable.Clear()
            da.Fill(dtable)
        End Using

        HighestSellingDGV.DataSource = dtable

        HighestSellingDGV.Columns(0).HeaderText = "Product ID"
        HighestSellingDGV.Columns(1).HeaderText = "Product Name"

        connToAcc.closeAccDB()

    End Sub

    '******************************************** END OF FORECASTING *******************************************************
    '***********************************************************************************************************************
    '***********************************************************************************************************************
#End Region
#End Region

End Class