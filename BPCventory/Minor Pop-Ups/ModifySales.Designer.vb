<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModifySales
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProdNameCB = New System.Windows.Forms.ComboBox()
        Me.CustNameCB = New System.Windows.Forms.ComboBox()
        Me.AddSaleDGV = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AddSaleCloseBttn = New System.Windows.Forms.Button()
        Me.DoneSalesBttn = New System.Windows.Forms.Button()
        Me.AddSalesBttn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TotalTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProdQtyTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.AddSaleDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.ProdNameCB)
        Me.Panel1.Controls.Add(Me.CustNameCB)
        Me.Panel1.Controls.Add(Me.AddSaleDGV)
        Me.Panel1.Controls.Add(Me.AddSaleCloseBttn)
        Me.Panel1.Controls.Add(Me.DoneSalesBttn)
        Me.Panel1.Controls.Add(Me.AddSalesBttn)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TotalTB)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ProdQtyTB)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(755, 281)
        Me.Panel1.TabIndex = 0
        '
        'ProdNameCB
        '
        Me.ProdNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProdNameCB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ProdNameCB.FormattingEnabled = True
        Me.ProdNameCB.Location = New System.Drawing.Point(31, 107)
        Me.ProdNameCB.Name = "ProdNameCB"
        Me.ProdNameCB.Size = New System.Drawing.Size(216, 24)
        Me.ProdNameCB.TabIndex = 33
        '
        'CustNameCB
        '
        Me.CustNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CustNameCB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CustNameCB.FormattingEnabled = True
        Me.CustNameCB.Location = New System.Drawing.Point(31, 44)
        Me.CustNameCB.Name = "CustNameCB"
        Me.CustNameCB.Size = New System.Drawing.Size(216, 24)
        Me.CustNameCB.TabIndex = 32
        '
        'AddSaleDGV
        '
        Me.AddSaleDGV.AllowUserToAddRows = False
        Me.AddSaleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AddSaleDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.AddSaleDGV.Location = New System.Drawing.Point(321, 14)
        Me.AddSaleDGV.Name = "AddSaleDGV"
        Me.AddSaleDGV.RowHeadersVisible = False
        Me.AddSaleDGV.RowTemplate.Height = 24
        Me.AddSaleDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AddSaleDGV.Size = New System.Drawing.Size(417, 150)
        Me.AddSaleDGV.TabIndex = 31
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Product Name"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Quantity"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 90
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Total"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 69
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "DEL"
        Me.Column4.Name = "Column4"
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column4.Width = 64
        '
        'AddSaleCloseBttn
        '
        Me.AddSaleCloseBttn.BackColor = System.Drawing.Color.Tomato
        Me.AddSaleCloseBttn.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.AddSaleCloseBttn.FlatAppearance.BorderSize = 2
        Me.AddSaleCloseBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.AddSaleCloseBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddSaleCloseBttn.Location = New System.Drawing.Point(591, 228)
        Me.AddSaleCloseBttn.Name = "AddSaleCloseBttn"
        Me.AddSaleCloseBttn.Size = New System.Drawing.Size(120, 45)
        Me.AddSaleCloseBttn.TabIndex = 30
        Me.AddSaleCloseBttn.Text = "CANCEL"
        Me.AddSaleCloseBttn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddSaleCloseBttn.UseVisualStyleBackColor = False
        '
        'DoneSalesBttn
        '
        Me.DoneSalesBttn.BackColor = System.Drawing.Color.Gold
        Me.DoneSalesBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.DoneSalesBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DoneSalesBttn.Location = New System.Drawing.Point(591, 177)
        Me.DoneSalesBttn.Name = "DoneSalesBttn"
        Me.DoneSalesBttn.Size = New System.Drawing.Size(120, 45)
        Me.DoneSalesBttn.TabIndex = 28
        Me.DoneSalesBttn.Text = "DONE"
        Me.DoneSalesBttn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DoneSalesBttn.UseVisualStyleBackColor = False
        '
        'AddSalesBttn
        '
        Me.AddSalesBttn.BackColor = System.Drawing.Color.Gold
        Me.AddSalesBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.AddSalesBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddSalesBttn.Location = New System.Drawing.Point(408, 177)
        Me.AddSalesBttn.Name = "AddSalesBttn"
        Me.AddSalesBttn.Size = New System.Drawing.Size(120, 45)
        Me.AddSalesBttn.TabIndex = 27
        Me.AddSalesBttn.Text = "ADD SALE"
        Me.AddSalesBttn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddSalesBttn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.NavajoWhite
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(5, 5, 210, 5)
        Me.Label4.Size = New System.Drawing.Size(265, 27)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total:"
        '
        'TotalTB
        '
        Me.TotalTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalTB.Location = New System.Drawing.Point(31, 245)
        Me.TotalTB.Name = "TotalTB"
        Me.TotalTB.ReadOnly = True
        Me.TotalTB.Size = New System.Drawing.Size(109, 22)
        Me.TotalTB.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(5, 5, 190, 5)
        Me.Label3.Size = New System.Drawing.Size(269, 27)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Quantity:"
        '
        'ProdQtyTB
        '
        Me.ProdQtyTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProdQtyTB.Location = New System.Drawing.Point(31, 177)
        Me.ProdQtyTB.Name = "ProdQtyTB"
        Me.ProdQtyTB.Size = New System.Drawing.Size(109, 22)
        Me.ProdQtyTB.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.ProdQtyTB, "Choose any product again after adding a sale.")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5, 5, 150, 5)
        Me.Label2.Size = New System.Drawing.Size(270, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Product Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5, 5, 140, 5)
        Me.Label1.Size = New System.Drawing.Size(272, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(275, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(241, 29)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "----  ADD SALE  -----"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Add Sale -- Tips"
        '
        'ModifySales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(779, 316)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModifySales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddNewSales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AddSaleDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ProdQtyTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TotalTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DoneSalesBttn As Button
    Friend WithEvents AddSalesBttn As Button
    Friend WithEvents AddSaleCloseBttn As Button
    Friend WithEvents AddSaleDGV As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewButtonColumn
    Friend WithEvents CustNameCB As ComboBox
    Friend WithEvents ProdNameCB As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class
