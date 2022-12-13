<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModifyProduction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifyProduction))
        Me.EditComponentsContent = New System.Windows.Forms.Panel()
        Me.EdtCmpntsSaveBttn = New System.Windows.Forms.Button()
        Me.CloseCompBttn = New System.Windows.Forms.Button()
        Me.ComponentsDGV = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CompMatNameCB = New System.Windows.Forms.ComboBox()
        Me.CompProdNameCB = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProductionLogContent = New System.Windows.Forms.Panel()
        Me.ResetBttn = New System.Windows.Forms.Button()
        Me.SearchByDateBttn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CloseCompBttn1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProductionLogDGV = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddtoNewProduceContent = New System.Windows.Forms.Panel()
        Me.AddToProductionBttn = New System.Windows.Forms.Button()
        Me.AddToProductionCloseBttn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProdDeadlineADP = New System.Windows.Forms.DateTimePicker()
        Me.qtyANP = New System.Windows.Forms.TextBox()
        Me.ProdNameANP = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProductionIDanp = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.EditComponentsContent.SuspendLayout()
        CType(Me.ComponentsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductionLogContent.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ProductionLogDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddtoNewProduceContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'EditComponentsContent
        '
        Me.EditComponentsContent.Controls.Add(Me.EdtCmpntsSaveBttn)
        Me.EditComponentsContent.Controls.Add(Me.CloseCompBttn)
        Me.EditComponentsContent.Controls.Add(Me.ComponentsDGV)
        Me.EditComponentsContent.Controls.Add(Me.CompMatNameCB)
        Me.EditComponentsContent.Controls.Add(Me.CompProdNameCB)
        Me.EditComponentsContent.Controls.Add(Me.PictureBox1)
        Me.EditComponentsContent.Location = New System.Drawing.Point(10, 10)
        Me.EditComponentsContent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EditComponentsContent.Name = "EditComponentsContent"
        Me.EditComponentsContent.Size = New System.Drawing.Size(730, 490)
        Me.EditComponentsContent.TabIndex = 0
        '
        'EdtCmpntsSaveBttn
        '
        Me.EdtCmpntsSaveBttn.BackColor = System.Drawing.Color.Gold
        Me.EdtCmpntsSaveBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.EdtCmpntsSaveBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EdtCmpntsSaveBttn.Location = New System.Drawing.Point(497, 148)
        Me.EdtCmpntsSaveBttn.Margin = New System.Windows.Forms.Padding(4)
        Me.EdtCmpntsSaveBttn.Name = "EdtCmpntsSaveBttn"
        Me.EdtCmpntsSaveBttn.Size = New System.Drawing.Size(79, 42)
        Me.EdtCmpntsSaveBttn.TabIndex = 39
        Me.EdtCmpntsSaveBttn.Text = "SAVE"
        Me.EdtCmpntsSaveBttn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EdtCmpntsSaveBttn.UseVisualStyleBackColor = False
        '
        'CloseCompBttn
        '
        Me.CloseCompBttn.BackColor = System.Drawing.Color.Gold
        Me.CloseCompBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.CloseCompBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseCompBttn.Location = New System.Drawing.Point(584, 148)
        Me.CloseCompBttn.Margin = New System.Windows.Forms.Padding(4)
        Me.CloseCompBttn.Name = "CloseCompBttn"
        Me.CloseCompBttn.Size = New System.Drawing.Size(79, 42)
        Me.CloseCompBttn.TabIndex = 38
        Me.CloseCompBttn.Text = "CLOSE"
        Me.CloseCompBttn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CloseCompBttn.UseVisualStyleBackColor = False
        '
        'ComponentsDGV
        '
        Me.ComponentsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ComponentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ComponentsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column2, Me.Column8})
        Me.ComponentsDGV.Location = New System.Drawing.Point(50, 212)
        Me.ComponentsDGV.Margin = New System.Windows.Forms.Padding(4)
        Me.ComponentsDGV.Name = "ComponentsDGV"
        Me.ComponentsDGV.RowHeadersVisible = False
        Me.ComponentsDGV.Size = New System.Drawing.Size(613, 231)
        Me.ComponentsDGV.TabIndex = 3
        '
        'Column3
        '
        Me.Column3.HeaderText = "Component #"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Materials Needed"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Quantity"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 90
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "Delete"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 55
        '
        'CompMatNameCB
        '
        Me.CompMatNameCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CompMatNameCB.ForeColor = System.Drawing.Color.Gray
        Me.CompMatNameCB.FormattingEnabled = True
        Me.CompMatNameCB.Location = New System.Drawing.Point(224, 158)
        Me.CompMatNameCB.Margin = New System.Windows.Forms.Padding(4)
        Me.CompMatNameCB.Name = "CompMatNameCB"
        Me.CompMatNameCB.Size = New System.Drawing.Size(256, 24)
        Me.CompMatNameCB.TabIndex = 2
        Me.CompMatNameCB.Text = "Components of the Product chosen"
        '
        'CompProdNameCB
        '
        Me.CompProdNameCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CompProdNameCB.ForeColor = System.Drawing.Color.Gray
        Me.CompProdNameCB.FormattingEnabled = True
        Me.CompProdNameCB.Location = New System.Drawing.Point(224, 107)
        Me.CompProdNameCB.Margin = New System.Windows.Forms.Padding(4)
        Me.CompProdNameCB.Name = "CompProdNameCB"
        Me.CompProdNameCB.Size = New System.Drawing.Size(256, 24)
        Me.CompProdNameCB.TabIndex = 1
        Me.CompProdNameCB.Text = "Choose Product Name here"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(722, 482)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ProductionLogContent
        '
        Me.ProductionLogContent.BackColor = System.Drawing.Color.Snow
        Me.ProductionLogContent.Controls.Add(Me.ResetBttn)
        Me.ProductionLogContent.Controls.Add(Me.SearchByDateBttn)
        Me.ProductionLogContent.Controls.Add(Me.Label2)
        Me.ProductionLogContent.Controls.Add(Me.Label1)
        Me.ProductionLogContent.Controls.Add(Me.DateTimePicker2)
        Me.ProductionLogContent.Controls.Add(Me.DateTimePicker1)
        Me.ProductionLogContent.Controls.Add(Me.CloseCompBttn1)
        Me.ProductionLogContent.Controls.Add(Me.Panel1)
        Me.ProductionLogContent.Location = New System.Drawing.Point(10, 10)
        Me.ProductionLogContent.Name = "ProductionLogContent"
        Me.ProductionLogContent.Size = New System.Drawing.Size(730, 490)
        Me.ProductionLogContent.TabIndex = 39
        '
        'ResetBttn
        '
        Me.ResetBttn.BackColor = System.Drawing.Color.Gold
        Me.ResetBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.ResetBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBttn.Location = New System.Drawing.Point(431, 27)
        Me.ResetBttn.Margin = New System.Windows.Forms.Padding(0)
        Me.ResetBttn.Name = "ResetBttn"
        Me.ResetBttn.Size = New System.Drawing.Size(61, 28)
        Me.ResetBttn.TabIndex = 45
        Me.ResetBttn.Text = "Reset"
        Me.ResetBttn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ResetBttn.UseVisualStyleBackColor = False
        '
        'SearchByDateBttn
        '
        Me.SearchByDateBttn.BackColor = System.Drawing.Color.Gold
        Me.SearchByDateBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.SearchByDateBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchByDateBttn.Location = New System.Drawing.Point(364, 27)
        Me.SearchByDateBttn.Margin = New System.Windows.Forms.Padding(0)
        Me.SearchByDateBttn.Name = "SearchByDateBttn"
        Me.SearchByDateBttn.Size = New System.Drawing.Size(49, 28)
        Me.SearchByDateBttn.TabIndex = 44
        Me.SearchByDateBttn.Text = "Go"
        Me.SearchByDateBttn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SearchByDateBttn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(333, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 17)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "TO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SEARCH FROM"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(127, 39)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker2.TabIndex = 42
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(127, 11)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 41
        '
        'CloseCompBttn1
        '
        Me.CloseCompBttn1.BackColor = System.Drawing.Color.Gold
        Me.CloseCompBttn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.CloseCompBttn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseCompBttn1.Location = New System.Drawing.Point(636, 13)
        Me.CloseCompBttn1.Margin = New System.Windows.Forms.Padding(4)
        Me.CloseCompBttn1.Name = "CloseCompBttn1"
        Me.CloseCompBttn1.Size = New System.Drawing.Size(79, 42)
        Me.CloseCompBttn1.TabIndex = 39
        Me.CloseCompBttn1.Text = "CLOSE"
        Me.CloseCompBttn1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CloseCompBttn1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.ProductionLogDGV)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(17, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(698, 402)
        Me.Panel1.TabIndex = 40
        '
        'ProductionLogDGV
        '
        Me.ProductionLogDGV.AllowUserToAddRows = False
        Me.ProductionLogDGV.AllowUserToDeleteRows = False
        Me.ProductionLogDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductionLogDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.ProductionLogDGV.Location = New System.Drawing.Point(3, 32)
        Me.ProductionLogDGV.Name = "ProductionLogDGV"
        Me.ProductionLogDGV.RowHeadersVisible = False
        Me.ProductionLogDGV.RowTemplate.Height = 24
        Me.ProductionLogDGV.Size = New System.Drawing.Size(692, 355)
        Me.ProductionLogDGV.TabIndex = 0
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Log ID"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 78
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Production ID"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Date / Time"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Quantity"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 90
        '
        'AddtoNewProduceContent
        '
        Me.AddtoNewProduceContent.BackColor = System.Drawing.Color.Snow
        Me.AddtoNewProduceContent.Controls.Add(Me.AddToProductionBttn)
        Me.AddtoNewProduceContent.Controls.Add(Me.AddToProductionCloseBttn)
        Me.AddtoNewProduceContent.Controls.Add(Me.Label8)
        Me.AddtoNewProduceContent.Controls.Add(Me.Label7)
        Me.AddtoNewProduceContent.Controls.Add(Me.Label6)
        Me.AddtoNewProduceContent.Controls.Add(Me.Label5)
        Me.AddtoNewProduceContent.Controls.Add(Me.Label4)
        Me.AddtoNewProduceContent.Controls.Add(Me.ProdDeadlineADP)
        Me.AddtoNewProduceContent.Controls.Add(Me.qtyANP)
        Me.AddtoNewProduceContent.Controls.Add(Me.ProdNameANP)
        Me.AddtoNewProduceContent.Controls.Add(Me.Label3)
        Me.AddtoNewProduceContent.Controls.Add(Me.ProductionIDanp)
        Me.AddtoNewProduceContent.Location = New System.Drawing.Point(10, 10)
        Me.AddtoNewProduceContent.Name = "AddtoNewProduceContent"
        Me.AddtoNewProduceContent.Size = New System.Drawing.Size(730, 490)
        Me.AddtoNewProduceContent.TabIndex = 39
        '
        'AddToProductionBttn
        '
        Me.AddToProductionBttn.BackColor = System.Drawing.Color.Gold
        Me.AddToProductionBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.AddToProductionBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddToProductionBttn.Location = New System.Drawing.Point(338, 425)
        Me.AddToProductionBttn.Margin = New System.Windows.Forms.Padding(4)
        Me.AddToProductionBttn.Name = "AddToProductionBttn"
        Me.AddToProductionBttn.Size = New System.Drawing.Size(142, 37)
        Me.AddToProductionBttn.TabIndex = 40
        Me.AddToProductionBttn.Text = "ADD"
        Me.AddToProductionBttn.UseVisualStyleBackColor = False
        '
        'AddToProductionCloseBttn
        '
        Me.AddToProductionCloseBttn.BackColor = System.Drawing.Color.Gold
        Me.AddToProductionCloseBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.AddToProductionCloseBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddToProductionCloseBttn.Location = New System.Drawing.Point(505, 425)
        Me.AddToProductionCloseBttn.Margin = New System.Windows.Forms.Padding(4)
        Me.AddToProductionCloseBttn.Name = "AddToProductionCloseBttn"
        Me.AddToProductionCloseBttn.Size = New System.Drawing.Size(142, 37)
        Me.AddToProductionCloseBttn.TabIndex = 39
        Me.AddToProductionCloseBttn.Text = "CLOSE"
        Me.AddToProductionCloseBttn.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Gold
        Me.Label8.Font = New System.Drawing.Font("Roboto", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(58, 338)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(5)
        Me.Label8.Size = New System.Drawing.Size(162, 27)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Deadline of Production:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Gold
        Me.Label7.Font = New System.Drawing.Font("Roboto", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(58, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(5)
        Me.Label7.Size = New System.Drawing.Size(75, 27)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Quantity:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Gold
        Me.Label6.Font = New System.Drawing.Font("Roboto", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(58, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(5)
        Me.Label6.Size = New System.Drawing.Size(111, 27)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Product Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Production ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Roboto Medium", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(5, 5, 400, 5)
        Me.Label4.Size = New System.Drawing.Size(635, 33)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Add New to Production"
        '
        'ProdDeadlineADP
        '
        Me.ProdDeadlineADP.Location = New System.Drawing.Point(61, 381)
        Me.ProdDeadlineADP.Name = "ProdDeadlineADP"
        Me.ProdDeadlineADP.Size = New System.Drawing.Size(285, 22)
        Me.ProdDeadlineADP.TabIndex = 4
        '
        'qtyANP
        '
        Me.qtyANP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.qtyANP.Location = New System.Drawing.Point(61, 278)
        Me.qtyANP.Name = "qtyANP"
        Me.qtyANP.Size = New System.Drawing.Size(104, 22)
        Me.qtyANP.TabIndex = 3
        '
        'ProdNameANP
        '
        Me.ProdNameANP.FormattingEnabled = True
        Me.ProdNameANP.Location = New System.Drawing.Point(61, 181)
        Me.ProdNameANP.Name = "ProdNameANP"
        Me.ProdNameANP.Size = New System.Drawing.Size(340, 24)
        Me.ProdNameANP.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(558, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "---------------------------------------------------------------------------------" &
    "-----------------------------"
        '
        'ProductionIDanp
        '
        Me.ProductionIDanp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductionIDanp.Location = New System.Drawing.Point(127, 65)
        Me.ProductionIDanp.Name = "ProductionIDanp"
        Me.ProductionIDanp.ReadOnly = True
        Me.ProductionIDanp.Size = New System.Drawing.Size(190, 22)
        Me.ProductionIDanp.TabIndex = 0
        '
        'ModifyProduction
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(750, 512)
        Me.Controls.Add(Me.AddtoNewProduceContent)
        Me.Controls.Add(Me.EditComponentsContent)
        Me.Controls.Add(Me.ProductionLogContent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ModifyProduction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModifyProduction"
        Me.EditComponentsContent.ResumeLayout(False)
        CType(Me.ComponentsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductionLogContent.ResumeLayout(False)
        Me.ProductionLogContent.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ProductionLogDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddtoNewProduceContent.ResumeLayout(False)
        Me.AddtoNewProduceContent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EditComponentsContent As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComponentsDGV As DataGridView
    Friend WithEvents CompMatNameCB As ComboBox
    Friend WithEvents CompProdNameCB As ComboBox
    Friend WithEvents CloseCompBttn As Button
    Friend WithEvents ProductionLogContent As Panel
    Friend WithEvents CloseCompBttn1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProductionLogDGV As DataGridView
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents SearchByDateBttn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents AddtoNewProduceContent As Panel
    Friend WithEvents ProdNameANP As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ProductionIDanp As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ProdDeadlineADP As DateTimePicker
    Friend WithEvents qtyANP As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents AddToProductionCloseBttn As Button
    Friend WithEvents AddToProductionBttn As Button
    Friend WithEvents EdtCmpntsSaveBttn As Button
    Friend WithEvents ResetBttn As Button
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewButtonColumn
End Class
