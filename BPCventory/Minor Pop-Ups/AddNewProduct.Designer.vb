<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNewProduct))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AddProdBttn = New System.Windows.Forms.Button()
        Me.ProductsName = New System.Windows.Forms.TextBox()
        Me.PartNumber = New System.Windows.Forms.TextBox()
        Me.Quantity = New System.Windows.Forms.TextBox()
        Me.BuyingPrice = New System.Windows.Forms.TextBox()
        Me.SellingPrice = New System.Windows.Forms.TextBox()
        Me.CancelBttn = New System.Windows.Forms.Button()
        Me.ClearAllBttn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ProductSize = New System.Windows.Forms.TextBox()
        Me.UnitLength = New System.Windows.Forms.TextBox()
        Me.ProductDimension = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(950, 446)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'AddProdBttn
        '
        Me.AddProdBttn.BackColor = System.Drawing.Color.IndianRed
        Me.AddProdBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddProdBttn.Location = New System.Drawing.Point(26, 376)
        Me.AddProdBttn.Name = "AddProdBttn"
        Me.AddProdBttn.Size = New System.Drawing.Size(130, 45)
        Me.AddProdBttn.TabIndex = 1
        Me.AddProdBttn.Text = "Add Product"
        Me.ToolTip1.SetToolTip(Me.AddProdBttn, "Add Product ")
        Me.AddProdBttn.UseVisualStyleBackColor = False
        '
        'ProductsName
        '
        Me.ProductsName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProductsName.ForeColor = System.Drawing.Color.Gray
        Me.ProductsName.Location = New System.Drawing.Point(88, 103)
        Me.ProductsName.Name = "ProductsName"
        Me.ProductsName.Size = New System.Drawing.Size(837, 15)
        Me.ProductsName.TabIndex = 2
        Me.ProductsName.Text = "Enter Product Name Here"
        Me.ToolTip1.SetToolTip(Me.ProductsName, "Enter product name here")
        '
        'PartNumber
        '
        Me.PartNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PartNumber.ForeColor = System.Drawing.Color.Gray
        Me.PartNumber.Location = New System.Drawing.Point(26, 158)
        Me.PartNumber.Name = "PartNumber"
        Me.PartNumber.Size = New System.Drawing.Size(303, 15)
        Me.PartNumber.TabIndex = 3
        Me.PartNumber.Text = "Part Number"
        Me.ToolTip1.SetToolTip(Me.PartNumber, "Product description")
        '
        'Quantity
        '
        Me.Quantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Quantity.ForeColor = System.Drawing.Color.Gray
        Me.Quantity.Location = New System.Drawing.Point(520, 158)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(241, 15)
        Me.Quantity.TabIndex = 4
        Me.Quantity.Text = "Quantity"
        Me.ToolTip1.SetToolTip(Me.Quantity, "Enter Quantity")
        '
        'BuyingPrice
        '
        Me.BuyingPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BuyingPrice.ForeColor = System.Drawing.Color.Gray
        Me.BuyingPrice.Location = New System.Drawing.Point(520, 233)
        Me.BuyingPrice.Name = "BuyingPrice"
        Me.BuyingPrice.Size = New System.Drawing.Size(241, 15)
        Me.BuyingPrice.TabIndex = 5
        Me.BuyingPrice.Text = "Buying Price"
        Me.ToolTip1.SetToolTip(Me.BuyingPrice, "Enter buying price")
        '
        'SellingPrice
        '
        Me.SellingPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SellingPrice.ForeColor = System.Drawing.Color.Gray
        Me.SellingPrice.Location = New System.Drawing.Point(520, 315)
        Me.SellingPrice.Name = "SellingPrice"
        Me.SellingPrice.Size = New System.Drawing.Size(216, 15)
        Me.SellingPrice.TabIndex = 6
        Me.SellingPrice.Text = "Selling Price"
        Me.ToolTip1.SetToolTip(Me.SellingPrice, "Enter selling price")
        '
        'CancelBttn
        '
        Me.CancelBttn.BackColor = System.Drawing.Color.Gold
        Me.CancelBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.CancelBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBttn.Location = New System.Drawing.Point(808, 6)
        Me.CancelBttn.Name = "CancelBttn"
        Me.CancelBttn.Size = New System.Drawing.Size(130, 45)
        Me.CancelBttn.TabIndex = 7
        Me.CancelBttn.Text = "Cancel"
        Me.ToolTip1.SetToolTip(Me.CancelBttn, "Cancel input data")
        Me.CancelBttn.UseVisualStyleBackColor = False
        '
        'ClearAllBttn
        '
        Me.ClearAllBttn.BackColor = System.Drawing.Color.DarkGray
        Me.ClearAllBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.ClearAllBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearAllBttn.Location = New System.Drawing.Point(784, 393)
        Me.ClearAllBttn.Name = "ClearAllBttn"
        Me.ClearAllBttn.Size = New System.Drawing.Size(141, 28)
        Me.ClearAllBttn.TabIndex = 8
        Me.ClearAllBttn.Text = "Clear All"
        Me.ToolTip1.SetToolTip(Me.ClearAllBttn, "Clear all data input")
        Me.ClearAllBttn.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Tips and Guide"
        '
        'ProductSize
        '
        Me.ProductSize.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProductSize.ForeColor = System.Drawing.Color.Gray
        Me.ProductSize.Location = New System.Drawing.Point(26, 215)
        Me.ProductSize.Name = "ProductSize"
        Me.ProductSize.Size = New System.Drawing.Size(183, 15)
        Me.ProductSize.TabIndex = 9
        Me.ProductSize.Text = "Size"
        Me.ToolTip1.SetToolTip(Me.ProductSize, "Product description")
        '
        'UnitLength
        '
        Me.UnitLength.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UnitLength.ForeColor = System.Drawing.Color.Gray
        Me.UnitLength.Location = New System.Drawing.Point(26, 272)
        Me.UnitLength.Name = "UnitLength"
        Me.UnitLength.Size = New System.Drawing.Size(183, 15)
        Me.UnitLength.TabIndex = 10
        Me.UnitLength.Text = "Unit Length"
        Me.ToolTip1.SetToolTip(Me.UnitLength, "Unit Length")
        '
        'ProductDimension
        '
        Me.ProductDimension.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProductDimension.ForeColor = System.Drawing.Color.Gray
        Me.ProductDimension.Location = New System.Drawing.Point(26, 324)
        Me.ProductDimension.Name = "ProductDimension"
        Me.ProductDimension.Size = New System.Drawing.Size(183, 15)
        Me.ProductDimension.TabIndex = 11
        Me.ProductDimension.Text = "Dimensions"
        Me.ToolTip1.SetToolTip(Me.ProductDimension, "Unit Length")
        '
        'AddNewProduct
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(950, 446)
        Me.Controls.Add(Me.ProductDimension)
        Me.Controls.Add(Me.UnitLength)
        Me.Controls.Add(Me.ProductSize)
        Me.Controls.Add(Me.ClearAllBttn)
        Me.Controls.Add(Me.CancelBttn)
        Me.Controls.Add(Me.SellingPrice)
        Me.Controls.Add(Me.BuyingPrice)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.PartNumber)
        Me.Controls.Add(Me.ProductsName)
        Me.Controls.Add(Me.AddProdBttn)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddNewProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddNewProduct"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AddProdBttn As Button
    Friend WithEvents ProductsName As TextBox
    Friend WithEvents PartNumber As TextBox
    Friend WithEvents Quantity As TextBox
    Friend WithEvents BuyingPrice As TextBox
    Friend WithEvents SellingPrice As TextBox
    Friend WithEvents CancelBttn As Button
    Friend WithEvents ClearAllBttn As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ProductSize As TextBox
    Friend WithEvents UnitLength As TextBox
    Friend WithEvents ProductDimension As TextBox
End Class
