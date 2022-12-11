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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ClearAllBttn = New System.Windows.Forms.Button()
        Me.CancelBttn = New System.Windows.Forms.Button()
        Me.AddNewMtrlBttn = New System.Windows.Forms.Button()
        Me.Expected = New System.Windows.Forms.TextBox()
        Me.InStock = New System.Windows.Forms.TextBox()
        Me.AverageCost = New System.Windows.Forms.TextBox()
        Me.MaterialName = New System.Windows.Forms.TextBox()
        Me.Committed = New System.Windows.Forms.TextBox()
        Me.Missing = New System.Windows.Forms.TextBox()
        Me.SupplierName = New System.Windows.Forms.ComboBox()
        Me.MaterialID = New System.Windows.Forms.ComboBox()
        Me.ExpectedNUD = New System.Windows.Forms.NumericUpDown()
        Me.Tips = New System.Windows.Forms.ToolTip(Me.components)
        Me.AddToQuantityNUD = New System.Windows.Forms.NumericUpDown()
        Me.LabelQty = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpectedNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddToQuantityNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlText
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(950, 550)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.Tips.SetToolTip(Me.PictureBox1, "Quantity in Stcck")
        '
        'ClearAllBttn
        '
        Me.ClearAllBttn.BackColor = System.Drawing.Color.DarkGray
        Me.ClearAllBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.ClearAllBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearAllBttn.Location = New System.Drawing.Point(797, 497)
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
        Me.AddNewMtrlBttn.Location = New System.Drawing.Point(12, 480)
        Me.AddNewMtrlBttn.Name = "AddNewMtrlBttn"
        Me.AddNewMtrlBttn.Size = New System.Drawing.Size(130, 45)
        Me.AddNewMtrlBttn.TabIndex = 9
        Me.AddNewMtrlBttn.Text = "Add Raw Materials"
        Me.Tips.SetToolTip(Me.AddNewMtrlBttn, "Add quantities to new or existing materials.")
        Me.AddNewMtrlBttn.UseVisualStyleBackColor = False
        '
        'Expected
        '
        Me.Expected.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Expected.Enabled = False
        Me.Expected.ForeColor = System.Drawing.Color.Gray
        Me.Expected.Location = New System.Drawing.Point(660, 228)
        Me.Expected.Name = "Expected"
        Me.Expected.Size = New System.Drawing.Size(269, 15)
        Me.Expected.TabIndex = 16
        Me.Expected.Text = "Expected to Arrive"
        Me.Tips.SetToolTip(Me.Expected, "Expected amount of materials to arrive.")
        '
        'InStock
        '
        Me.InStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InStock.Enabled = False
        Me.InStock.ForeColor = System.Drawing.Color.Gray
        Me.InStock.Location = New System.Drawing.Point(390, 227)
        Me.InStock.Name = "InStock"
        Me.InStock.Size = New System.Drawing.Size(239, 15)
        Me.InStock.TabIndex = 15
        Me.InStock.Text = "Quantity in Stock"
        Me.Tips.SetToolTip(Me.InStock, "Amount of quantity in stock.")
        '
        'AverageCost
        '
        Me.AverageCost.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AverageCost.ForeColor = System.Drawing.Color.Gray
        Me.AverageCost.Location = New System.Drawing.Point(79, 224)
        Me.AverageCost.Name = "AverageCost"
        Me.AverageCost.Size = New System.Drawing.Size(241, 15)
        Me.AverageCost.TabIndex = 14
        Me.AverageCost.Text = "Average Cost of Material"
        Me.Tips.SetToolTip(Me.AverageCost, "Average cost of the Material.")
        '
        'MaterialName
        '
        Me.MaterialName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialName.ForeColor = System.Drawing.Color.Gray
        Me.MaterialName.Location = New System.Drawing.Point(79, 166)
        Me.MaterialName.Name = "MaterialName"
        Me.MaterialName.Size = New System.Drawing.Size(496, 15)
        Me.MaterialName.TabIndex = 13
        Me.MaterialName.Text = "Material Name"
        Me.Tips.SetToolTip(Me.MaterialName, "Material Name")
        '
        'Committed
        '
        Me.Committed.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Committed.Enabled = False
        Me.Committed.ForeColor = System.Drawing.Color.Gray
        Me.Committed.Location = New System.Drawing.Point(22, 291)
        Me.Committed.Name = "Committed"
        Me.Committed.Size = New System.Drawing.Size(269, 15)
        Me.Committed.TabIndex = 17
        Me.Committed.Text = "Committed to Production"
        Me.Tips.SetToolTip(Me.Committed, "Will be committed to the production soon.")
        '
        'Missing
        '
        Me.Missing.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Missing.Enabled = False
        Me.Missing.ForeColor = System.Drawing.Color.Gray
        Me.Missing.Location = New System.Drawing.Point(24, 349)
        Me.Missing.Name = "Missing"
        Me.Missing.Size = New System.Drawing.Size(269, 15)
        Me.Missing.TabIndex = 18
        Me.Missing.Text = "Missing Materials"
        Me.Tips.SetToolTip(Me.Missing, "Material lacking that is already committed to production.")
        '
        'SupplierName
        '
        Me.SupplierName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SupplierName.ForeColor = System.Drawing.Color.Gray
        Me.SupplierName.IntegralHeight = False
        Me.SupplierName.ItemHeight = 16
        Me.SupplierName.Location = New System.Drawing.Point(347, 345)
        Me.SupplierName.MaxDropDownItems = 10
        Me.SupplierName.Name = "SupplierName"
        Me.SupplierName.Size = New System.Drawing.Size(440, 24)
        Me.SupplierName.TabIndex = 20
        Me.SupplierName.Text = "Supplier of Materials"
        Me.Tips.SetToolTip(Me.SupplierName, "Supplier of the materials")
        '
        'MaterialID
        '
        Me.MaterialID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaterialID.ForeColor = System.Drawing.Color.Gray
        Me.MaterialID.FormattingEnabled = True
        Me.MaterialID.Location = New System.Drawing.Point(21, 98)
        Me.MaterialID.Name = "MaterialID"
        Me.MaterialID.Size = New System.Drawing.Size(370, 24)
        Me.MaterialID.TabIndex = 23
        Me.MaterialID.Text = "Material ID"
        Me.Tips.SetToolTip(Me.MaterialID, "Raw Material Unique ID/Barcode")
        '
        'ExpectedNUD
        '
        Me.ExpectedNUD.Location = New System.Drawing.Point(742, 266)
        Me.ExpectedNUD.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.ExpectedNUD.Name = "ExpectedNUD"
        Me.ExpectedNUD.Size = New System.Drawing.Size(120, 22)
        Me.ExpectedNUD.TabIndex = 24
        Me.Tips.SetToolTip(Me.ExpectedNUD, "Add Quantity of the Expected Amount of Materials arriving.")
        Me.ExpectedNUD.Visible = False
        '
        'Tips
        '
        Me.Tips.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Tips.ToolTipTitle = "Raw Materials Tips"
        '
        'AddToQuantityNUD
        '
        Me.AddToQuantityNUD.Location = New System.Drawing.Point(390, 264)
        Me.AddToQuantityNUD.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.AddToQuantityNUD.Name = "AddToQuantityNUD"
        Me.AddToQuantityNUD.ReadOnly = True
        Me.AddToQuantityNUD.Size = New System.Drawing.Size(88, 22)
        Me.AddToQuantityNUD.TabIndex = 26
        Me.Tips.SetToolTip(Me.AddToQuantityNUD, "Click to Add Quantity to the Current Stock")
        '
        'LabelQty
        '
        Me.LabelQty.AutoSize = True
        Me.LabelQty.BackColor = System.Drawing.Color.White
        Me.LabelQty.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQty.Location = New System.Drawing.Point(670, 268)
        Me.LabelQty.Name = "LabelQty"
        Me.LabelQty.Size = New System.Drawing.Size(64, 18)
        Me.LabelQty.TabIndex = 25
        Me.LabelQty.Text = "Add Qty:"
        Me.LabelQty.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(403, 263)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(52, 22)
        Me.TextBox1.TabIndex = 28
        '
        'AddNewRawMaterials
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Tomato
        Me.ClientSize = New System.Drawing.Size(950, 550)
        Me.Controls.Add(Me.AddToQuantityNUD)
        Me.Controls.Add(Me.LabelQty)
        Me.Controls.Add(Me.ExpectedNUD)
        Me.Controls.Add(Me.MaterialID)
        Me.Controls.Add(Me.SupplierName)
        Me.Controls.Add(Me.Missing)
        Me.Controls.Add(Me.Committed)
        Me.Controls.Add(Me.Expected)
        Me.Controls.Add(Me.InStock)
        Me.Controls.Add(Me.AverageCost)
        Me.Controls.Add(Me.MaterialName)
        Me.Controls.Add(Me.ClearAllBttn)
        Me.Controls.Add(Me.CancelBttn)
        Me.Controls.Add(Me.AddNewMtrlBttn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddNewRawMaterials"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddNewRawMaterials"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpectedNUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddToQuantityNUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ClearAllBttn As Button
    Friend WithEvents CancelBttn As Button
    Friend WithEvents AddNewMtrlBttn As Button
    Friend WithEvents Expected As TextBox
    Friend WithEvents InStock As TextBox
    Friend WithEvents AverageCost As TextBox
    Friend WithEvents MaterialName As TextBox
    Friend WithEvents Committed As TextBox
    Friend WithEvents Missing As TextBox
    Friend WithEvents SupplierName As ComboBox
    Friend WithEvents MaterialID As ComboBox
    Friend WithEvents Tips As ToolTip
    Friend WithEvents ExpectedNUD As NumericUpDown
    Friend WithEvents LabelQty As Label
    Friend WithEvents AddToQuantityNUD As NumericUpDown
    Friend WithEvents TextBox1 As TextBox
End Class
