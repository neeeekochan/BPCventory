<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddNewRawMaterials
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNewRawMaterials))
        Me.Tips = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SupplierName = New System.Windows.Forms.ComboBox()
        Me.InStock = New System.Windows.Forms.TextBox()
        Me.AverageCost = New System.Windows.Forms.TextBox()
        Me.MaterialName = New System.Windows.Forms.TextBox()
        Me.ClearAllBttn = New System.Windows.Forms.Button()
        Me.CancelBttn = New System.Windows.Forms.Button()
        Me.AddNewMtrlBttn = New System.Windows.Forms.Button()
        Me.ADDTOSTOCKBTTN = New System.Windows.Forms.Button()
        Me.CancelBttn1 = New System.Windows.Forms.Button()
        Me.CancelBttn2 = New System.Windows.Forms.Button()
        Me.OrderMaterialsBttn = New System.Windows.Forms.Button()
        Me.OrderLogsBttn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ADDEDITRAWMATERIALPANEL = New System.Windows.Forms.Panel()
        Me.ADDINSTOCKPANEL = New System.Windows.Forms.Panel()
        Me.AddToQuantityNUD = New System.Windows.Forms.NumericUpDown()
        Me.BarcodeTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AverageCostTB = New System.Windows.Forms.TextBox()
        Me.InStockTB = New System.Windows.Forms.TextBox()
        Me.ExpectedTB = New System.Windows.Forms.TextBox()
        Me.MatNameTB = New System.Windows.Forms.TextBox()
        Me.MatIDCB = New System.Windows.Forms.ComboBox()
        Me.SupNameIDCB = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ORDERFORMPANEL = New System.Windows.Forms.Panel()
        Me.ORDTotalTB = New System.Windows.Forms.TextBox()
        Me.ORDPriceTB = New System.Windows.Forms.TextBox()
        Me.ORDQtyTB = New System.Windows.Forms.TextBox()
        Me.ORDMatNameCB = New System.Windows.Forms.ComboBox()
        Me.ORDSuppCB = New System.Windows.Forms.ComboBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.OrderDGV = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ADDEDITRAWMATERIALPANEL.SuspendLayout()
        Me.ADDINSTOCKPANEL.SuspendLayout()
        CType(Me.AddToQuantityNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ORDERFORMPANEL.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tips
        '
        Me.Tips.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Tips.ToolTipTitle = "Raw Materials Tips"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlText
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(950, 502)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.Tips.SetToolTip(Me.PictureBox1, "Quantity in Stcck")
        '
        'SupplierName
        '
        Me.SupplierName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SupplierName.ForeColor = System.Drawing.Color.Gray
        Me.SupplierName.IntegralHeight = False
        Me.SupplierName.ItemHeight = 16
        Me.SupplierName.Location = New System.Drawing.Point(272, 125)
        Me.SupplierName.MaxDropDownItems = 10
        Me.SupplierName.Name = "SupplierName"
        Me.SupplierName.Size = New System.Drawing.Size(342, 24)
        Me.SupplierName.TabIndex = 20
        Me.SupplierName.Text = "Supplier of Materials"
        Me.Tips.SetToolTip(Me.SupplierName, "Supplier of the materials")
        '
        'InStock
        '
        Me.InStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InStock.ForeColor = System.Drawing.Color.Gray
        Me.InStock.Location = New System.Drawing.Point(272, 249)
        Me.InStock.Name = "InStock"
        Me.InStock.Size = New System.Drawing.Size(169, 15)
        Me.InStock.TabIndex = 15
        Me.InStock.Text = "Quantity in Stock"
        Me.Tips.SetToolTip(Me.InStock, "Amount of quantity in stock.")
        '
        'AverageCost
        '
        Me.AverageCost.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AverageCost.ForeColor = System.Drawing.Color.Gray
        Me.AverageCost.Location = New System.Drawing.Point(272, 308)
        Me.AverageCost.Name = "AverageCost"
        Me.AverageCost.Size = New System.Drawing.Size(169, 15)
        Me.AverageCost.TabIndex = 14
        Me.AverageCost.Text = "Average Cost of Material"
        Me.Tips.SetToolTip(Me.AverageCost, "Average cost of the Material.")
        '
        'MaterialName
        '
        Me.MaterialName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialName.ForeColor = System.Drawing.Color.Gray
        Me.MaterialName.Location = New System.Drawing.Point(272, 190)
        Me.MaterialName.Name = "MaterialName"
        Me.MaterialName.Size = New System.Drawing.Size(342, 15)
        Me.MaterialName.TabIndex = 13
        Me.MaterialName.Text = "Material Name"
        Me.Tips.SetToolTip(Me.MaterialName, "Material Name")
        '
        'ClearAllBttn
        '
        Me.ClearAllBttn.BackColor = System.Drawing.Color.DarkGray
        Me.ClearAllBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.ClearAllBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearAllBttn.Location = New System.Drawing.Point(798, 451)
        Me.ClearAllBttn.Name = "ClearAllBttn"
        Me.ClearAllBttn.Size = New System.Drawing.Size(141, 28)
        Me.ClearAllBttn.TabIndex = 11
        Me.ClearAllBttn.Text = "Clear All"
        Me.Tips.SetToolTip(Me.ClearAllBttn, "Clear all fields.")
        Me.ClearAllBttn.UseVisualStyleBackColor = False
        '
        'CancelBttn
        '
        Me.CancelBttn.BackColor = System.Drawing.Color.Gold
        Me.CancelBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.CancelBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBttn.Location = New System.Drawing.Point(809, 12)
        Me.CancelBttn.Name = "CancelBttn"
        Me.CancelBttn.Size = New System.Drawing.Size(130, 45)
        Me.CancelBttn.TabIndex = 10
        Me.CancelBttn.Text = "Cancel"
        Me.Tips.SetToolTip(Me.CancelBttn, "Cancel adding raw materials.")
        Me.CancelBttn.UseVisualStyleBackColor = False
        '
        'AddNewMtrlBttn
        '
        Me.AddNewMtrlBttn.BackColor = System.Drawing.Color.IndianRed
        Me.AddNewMtrlBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddNewMtrlBttn.Location = New System.Drawing.Point(12, 443)
        Me.AddNewMtrlBttn.Name = "AddNewMtrlBttn"
        Me.AddNewMtrlBttn.Size = New System.Drawing.Size(130, 45)
        Me.AddNewMtrlBttn.TabIndex = 9
        Me.AddNewMtrlBttn.Text = "Add Raw Materials"
        Me.Tips.SetToolTip(Me.AddNewMtrlBttn, "Add quantities to new or existing materials.")
        Me.AddNewMtrlBttn.UseVisualStyleBackColor = False
        '
        'ADDTOSTOCKBTTN
        '
        Me.ADDTOSTOCKBTTN.BackColor = System.Drawing.Color.IndianRed
        Me.ADDTOSTOCKBTTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ADDTOSTOCKBTTN.Location = New System.Drawing.Point(780, 434)
        Me.ADDTOSTOCKBTTN.Name = "ADDTOSTOCKBTTN"
        Me.ADDTOSTOCKBTTN.Size = New System.Drawing.Size(130, 45)
        Me.ADDTOSTOCKBTTN.TabIndex = 10
        Me.ADDTOSTOCKBTTN.Text = "ADD TO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "STOCK" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Tips.SetToolTip(Me.ADDTOSTOCKBTTN, "Add quantities to new or existing materials.")
        Me.ADDTOSTOCKBTTN.UseVisualStyleBackColor = False
        '
        'CancelBttn1
        '
        Me.CancelBttn1.BackColor = System.Drawing.Color.Gold
        Me.CancelBttn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.CancelBttn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBttn1.Location = New System.Drawing.Point(798, 12)
        Me.CancelBttn1.Name = "CancelBttn1"
        Me.CancelBttn1.Size = New System.Drawing.Size(130, 45)
        Me.CancelBttn1.TabIndex = 14
        Me.CancelBttn1.Text = "Cancel"
        Me.Tips.SetToolTip(Me.CancelBttn1, "Cancel adding raw materials.")
        Me.CancelBttn1.UseVisualStyleBackColor = False
        '
        'CancelBttn2
        '
        Me.CancelBttn2.BackColor = System.Drawing.Color.Gold
        Me.CancelBttn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.CancelBttn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBttn2.Location = New System.Drawing.Point(808, 12)
        Me.CancelBttn2.Name = "CancelBttn2"
        Me.CancelBttn2.Size = New System.Drawing.Size(130, 45)
        Me.CancelBttn2.TabIndex = 11
        Me.CancelBttn2.Text = "Cancel"
        Me.Tips.SetToolTip(Me.CancelBttn2, "Cancel adding raw materials.")
        Me.CancelBttn2.UseVisualStyleBackColor = False
        '
        'OrderMaterialsBttn
        '
        Me.OrderMaterialsBttn.BackColor = System.Drawing.Color.IndianRed
        Me.OrderMaterialsBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OrderMaterialsBttn.Location = New System.Drawing.Point(299, 405)
        Me.OrderMaterialsBttn.Name = "OrderMaterialsBttn"
        Me.OrderMaterialsBttn.Size = New System.Drawing.Size(119, 45)
        Me.OrderMaterialsBttn.TabIndex = 12
        Me.OrderMaterialsBttn.Text = "ORDER"
        Me.Tips.SetToolTip(Me.OrderMaterialsBttn, "Add quantities to new or existing materials.")
        Me.OrderMaterialsBttn.UseVisualStyleBackColor = False
        '
        'OrderLogsBttn
        '
        Me.OrderLogsBttn.BackColor = System.Drawing.Color.Gold
        Me.OrderLogsBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.OrderLogsBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OrderLogsBttn.Location = New System.Drawing.Point(831, 443)
        Me.OrderLogsBttn.Name = "OrderLogsBttn"
        Me.OrderLogsBttn.Size = New System.Drawing.Size(107, 45)
        Me.OrderLogsBttn.TabIndex = 13
        Me.OrderLogsBttn.Text = "PRINT"
        Me.Tips.SetToolTip(Me.OrderLogsBttn, "Cancel adding raw materials.")
        Me.OrderLogsBttn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(28, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 37)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "EDIT RAW MATERIAL"
        Me.Label1.Visible = False
        '
        'ADDEDITRAWMATERIALPANEL
        '
        Me.ADDEDITRAWMATERIALPANEL.Controls.Add(Me.AddNewMtrlBttn)
        Me.ADDEDITRAWMATERIALPANEL.Controls.Add(Me.CancelBttn)
        Me.ADDEDITRAWMATERIALPANEL.Controls.Add(Me.ClearAllBttn)
        Me.ADDEDITRAWMATERIALPANEL.Controls.Add(Me.MaterialName)
        Me.ADDEDITRAWMATERIALPANEL.Controls.Add(Me.AverageCost)
        Me.ADDEDITRAWMATERIALPANEL.Controls.Add(Me.InStock)
        Me.ADDEDITRAWMATERIALPANEL.Controls.Add(Me.SupplierName)
        Me.ADDEDITRAWMATERIALPANEL.Controls.Add(Me.Label1)
        Me.ADDEDITRAWMATERIALPANEL.Controls.Add(Me.PictureBox1)
        Me.ADDEDITRAWMATERIALPANEL.Location = New System.Drawing.Point(0, 0)
        Me.ADDEDITRAWMATERIALPANEL.Name = "ADDEDITRAWMATERIALPANEL"
        Me.ADDEDITRAWMATERIALPANEL.Size = New System.Drawing.Size(950, 502)
        Me.ADDEDITRAWMATERIALPANEL.TabIndex = 23
        '
        'ADDINSTOCKPANEL
        '
        Me.ADDINSTOCKPANEL.Controls.Add(Me.CancelBttn1)
        Me.ADDINSTOCKPANEL.Controls.Add(Me.AddToQuantityNUD)
        Me.ADDINSTOCKPANEL.Controls.Add(Me.BarcodeTB)
        Me.ADDINSTOCKPANEL.Controls.Add(Me.Label2)
        Me.ADDINSTOCKPANEL.Controls.Add(Me.ADDTOSTOCKBTTN)
        Me.ADDINSTOCKPANEL.Controls.Add(Me.AverageCostTB)
        Me.ADDINSTOCKPANEL.Controls.Add(Me.InStockTB)
        Me.ADDINSTOCKPANEL.Controls.Add(Me.ExpectedTB)
        Me.ADDINSTOCKPANEL.Controls.Add(Me.MatNameTB)
        Me.ADDINSTOCKPANEL.Controls.Add(Me.MatIDCB)
        Me.ADDINSTOCKPANEL.Controls.Add(Me.SupNameIDCB)
        Me.ADDINSTOCKPANEL.Controls.Add(Me.PictureBox2)
        Me.ADDINSTOCKPANEL.Location = New System.Drawing.Point(0, 0)
        Me.ADDINSTOCKPANEL.Name = "ADDINSTOCKPANEL"
        Me.ADDINSTOCKPANEL.Size = New System.Drawing.Size(950, 501)
        Me.ADDINSTOCKPANEL.TabIndex = 23
        '
        'AddToQuantityNUD
        '
        Me.AddToQuantityNUD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AddToQuantityNUD.Location = New System.Drawing.Point(520, 319)
        Me.AddToQuantityNUD.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.AddToQuantityNUD.Name = "AddToQuantityNUD"
        Me.AddToQuantityNUD.Size = New System.Drawing.Size(194, 18)
        Me.AddToQuantityNUD.TabIndex = 13
        '
        'BarcodeTB
        '
        Me.BarcodeTB.Location = New System.Drawing.Point(710, 207)
        Me.BarcodeTB.Name = "BarcodeTB"
        Me.BarcodeTB.Size = New System.Drawing.Size(167, 22)
        Me.BarcodeTB.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(710, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Enter Barcode (SKU):"
        '
        'AverageCostTB
        '
        Me.AverageCostTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AverageCostTB.Location = New System.Drawing.Point(299, 368)
        Me.AverageCostTB.Name = "AverageCostTB"
        Me.AverageCostTB.ReadOnly = True
        Me.AverageCostTB.Size = New System.Drawing.Size(123, 15)
        Me.AverageCostTB.TabIndex = 6
        '
        'InStockTB
        '
        Me.InStockTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InStockTB.Location = New System.Drawing.Point(299, 319)
        Me.InStockTB.Name = "InStockTB"
        Me.InStockTB.ReadOnly = True
        Me.InStockTB.Size = New System.Drawing.Size(123, 15)
        Me.InStockTB.TabIndex = 5
        '
        'ExpectedTB
        '
        Me.ExpectedTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ExpectedTB.Location = New System.Drawing.Point(299, 270)
        Me.ExpectedTB.Name = "ExpectedTB"
        Me.ExpectedTB.ReadOnly = True
        Me.ExpectedTB.Size = New System.Drawing.Size(123, 15)
        Me.ExpectedTB.TabIndex = 4
        '
        'MatNameTB
        '
        Me.MatNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MatNameTB.Location = New System.Drawing.Point(354, 224)
        Me.MatNameTB.Name = "MatNameTB"
        Me.MatNameTB.ReadOnly = True
        Me.MatNameTB.Size = New System.Drawing.Size(286, 15)
        Me.MatNameTB.TabIndex = 3
        '
        'MatIDCB
        '
        Me.MatIDCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MatIDCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MatIDCB.FormattingEnabled = True
        Me.MatIDCB.Location = New System.Drawing.Point(299, 169)
        Me.MatIDCB.Name = "MatIDCB"
        Me.MatIDCB.Size = New System.Drawing.Size(341, 24)
        Me.MatIDCB.TabIndex = 2
        '
        'SupNameIDCB
        '
        Me.SupNameIDCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SupNameIDCB.Enabled = False
        Me.SupNameIDCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SupNameIDCB.FormattingEnabled = True
        Me.SupNameIDCB.Location = New System.Drawing.Point(299, 118)
        Me.SupNameIDCB.Name = "SupNameIDCB"
        Me.SupNameIDCB.Size = New System.Drawing.Size(341, 24)
        Me.SupNameIDCB.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(950, 501)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'ORDERFORMPANEL
        '
        Me.ORDERFORMPANEL.Controls.Add(Me.OrderLogsBttn)
        Me.ORDERFORMPANEL.Controls.Add(Me.OrderMaterialsBttn)
        Me.ORDERFORMPANEL.Controls.Add(Me.CancelBttn2)
        Me.ORDERFORMPANEL.Controls.Add(Me.ORDTotalTB)
        Me.ORDERFORMPANEL.Controls.Add(Me.ORDPriceTB)
        Me.ORDERFORMPANEL.Controls.Add(Me.ORDQtyTB)
        Me.ORDERFORMPANEL.Controls.Add(Me.ORDMatNameCB)
        Me.ORDERFORMPANEL.Controls.Add(Me.ORDSuppCB)
        Me.ORDERFORMPANEL.Controls.Add(Me.PictureBox3)
        Me.ORDERFORMPANEL.Controls.Add(Me.OrderDGV)
        Me.ORDERFORMPANEL.Location = New System.Drawing.Point(0, 0)
        Me.ORDERFORMPANEL.Name = "ORDERFORMPANEL"
        Me.ORDERFORMPANEL.Size = New System.Drawing.Size(950, 502)
        Me.ORDERFORMPANEL.TabIndex = 15
        '
        'ORDTotalTB
        '
        Me.ORDTotalTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ORDTotalTB.Location = New System.Drawing.Point(308, 358)
        Me.ORDTotalTB.Name = "ORDTotalTB"
        Me.ORDTotalTB.ReadOnly = True
        Me.ORDTotalTB.Size = New System.Drawing.Size(176, 15)
        Me.ORDTotalTB.TabIndex = 5
        '
        'ORDPriceTB
        '
        Me.ORDPriceTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ORDPriceTB.Location = New System.Drawing.Point(308, 293)
        Me.ORDPriceTB.Name = "ORDPriceTB"
        Me.ORDPriceTB.ReadOnly = True
        Me.ORDPriceTB.Size = New System.Drawing.Size(176, 15)
        Me.ORDPriceTB.TabIndex = 4
        '
        'ORDQtyTB
        '
        Me.ORDQtyTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ORDQtyTB.Location = New System.Drawing.Point(308, 235)
        Me.ORDQtyTB.Name = "ORDQtyTB"
        Me.ORDQtyTB.Size = New System.Drawing.Size(176, 15)
        Me.ORDQtyTB.TabIndex = 3
        '
        'ORDMatNameCB
        '
        Me.ORDMatNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ORDMatNameCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ORDMatNameCB.FormattingEnabled = True
        Me.ORDMatNameCB.Location = New System.Drawing.Point(308, 172)
        Me.ORDMatNameCB.Name = "ORDMatNameCB"
        Me.ORDMatNameCB.Size = New System.Drawing.Size(281, 24)
        Me.ORDMatNameCB.TabIndex = 2
        '
        'ORDSuppCB
        '
        Me.ORDSuppCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ORDSuppCB.Enabled = False
        Me.ORDSuppCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ORDSuppCB.FormattingEnabled = True
        Me.ORDSuppCB.Location = New System.Drawing.Point(311, 109)
        Me.ORDSuppCB.Name = "ORDSuppCB"
        Me.ORDSuppCB.Size = New System.Drawing.Size(281, 24)
        Me.ORDSuppCB.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(950, 502)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'OrderDGV
        '
        Me.OrderDGV.AllowUserToAddRows = False
        Me.OrderDGV.AllowUserToDeleteRows = False
        Me.OrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderDGV.Location = New System.Drawing.Point(520, 224)
        Me.OrderDGV.Name = "OrderDGV"
        Me.OrderDGV.RowHeadersVisible = False
        Me.OrderDGV.RowTemplate.Height = 24
        Me.OrderDGV.Size = New System.Drawing.Size(408, 150)
        Me.OrderDGV.TabIndex = 14
        '
        'AddNewRawMaterials
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Tomato
        Me.ClientSize = New System.Drawing.Size(950, 502)
        Me.Controls.Add(Me.ADDINSTOCKPANEL)
        Me.Controls.Add(Me.ADDEDITRAWMATERIALPANEL)
        Me.Controls.Add(Me.ORDERFORMPANEL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddNewRawMaterials"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddNewRawMaterials"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ADDEDITRAWMATERIALPANEL.ResumeLayout(False)
        Me.ADDEDITRAWMATERIALPANEL.PerformLayout()
        Me.ADDINSTOCKPANEL.ResumeLayout(False)
        Me.ADDINSTOCKPANEL.PerformLayout()
        CType(Me.AddToQuantityNUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ORDERFORMPANEL.ResumeLayout(False)
        Me.ORDERFORMPANEL.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tips As ToolTip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SupplierName As ComboBox
    Friend WithEvents InStock As TextBox
    Friend WithEvents AverageCost As TextBox
    Friend WithEvents MaterialName As TextBox
    Friend WithEvents ClearAllBttn As Button
    Friend WithEvents CancelBttn As Button
    Friend WithEvents AddNewMtrlBttn As Button
    Friend WithEvents ADDEDITRAWMATERIALPANEL As Panel
    Friend WithEvents ADDINSTOCKPANEL As Panel
    Friend WithEvents ADDTOSTOCKBTTN As Button
    Friend WithEvents AverageCostTB As TextBox
    Friend WithEvents InStockTB As TextBox
    Friend WithEvents ExpectedTB As TextBox
    Friend WithEvents MatNameTB As TextBox
    Friend WithEvents MatIDCB As ComboBox
    Friend WithEvents SupNameIDCB As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BarcodeTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents AddToQuantityNUD As NumericUpDown
    Friend WithEvents CancelBttn1 As Button
    Friend WithEvents ORDERFORMPANEL As Panel
    Friend WithEvents ORDTotalTB As TextBox
    Friend WithEvents ORDPriceTB As TextBox
    Friend WithEvents ORDQtyTB As TextBox
    Friend WithEvents ORDMatNameCB As ComboBox
    Friend WithEvents ORDSuppCB As ComboBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents CancelBttn2 As Button
    Friend WithEvents OrderMaterialsBttn As Button
    Friend WithEvents OrderLogsBttn As Button
    Friend WithEvents OrderDGV As DataGridView
End Class
