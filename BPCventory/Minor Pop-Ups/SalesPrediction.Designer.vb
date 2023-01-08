<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesPrediction
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Date_1 = New System.Windows.Forms.Label()
        Me.Date_2 = New System.Windows.Forms.Label()
        Me.Date_3 = New System.Windows.Forms.Label()
        Me.Sales_3 = New System.Windows.Forms.Label()
        Me.Sales_2 = New System.Windows.Forms.Label()
        Me.Sales_1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.HighestSellingDG = New System.Windows.Forms.DataGridView()
        Me.LeastSellingDG = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HighestSellingDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeastSellingDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Date_1
        '
        Me.Date_1.AutoSize = True
        Me.Date_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_1.Location = New System.Drawing.Point(770, 96)
        Me.Date_1.Name = "Date_1"
        Me.Date_1.Size = New System.Drawing.Size(68, 20)
        Me.Date_1.TabIndex = 0
        Me.Date_1.Text = "DATE 1"
        '
        'Date_2
        '
        Me.Date_2.AutoSize = True
        Me.Date_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_2.Location = New System.Drawing.Point(770, 176)
        Me.Date_2.Name = "Date_2"
        Me.Date_2.Size = New System.Drawing.Size(68, 20)
        Me.Date_2.TabIndex = 1
        Me.Date_2.Text = "DATE 2"
        '
        'Date_3
        '
        Me.Date_3.AutoSize = True
        Me.Date_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_3.Location = New System.Drawing.Point(770, 263)
        Me.Date_3.Name = "Date_3"
        Me.Date_3.Size = New System.Drawing.Size(68, 20)
        Me.Date_3.TabIndex = 2
        Me.Date_3.Text = "DATE 3"
        '
        'Sales_3
        '
        Me.Sales_3.AutoSize = True
        Me.Sales_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sales_3.Location = New System.Drawing.Point(767, 288)
        Me.Sales_3.Name = "Sales_3"
        Me.Sales_3.Size = New System.Drawing.Size(114, 36)
        Me.Sales_3.TabIndex = 5
        Me.Sales_3.Text = "Sales 3"
        '
        'Sales_2
        '
        Me.Sales_2.AutoSize = True
        Me.Sales_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sales_2.Location = New System.Drawing.Point(767, 201)
        Me.Sales_2.Name = "Sales_2"
        Me.Sales_2.Size = New System.Drawing.Size(114, 36)
        Me.Sales_2.TabIndex = 4
        Me.Sales_2.Text = "Sales 2"
        '
        'Sales_1
        '
        Me.Sales_1.AutoSize = True
        Me.Sales_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sales_1.Location = New System.Drawing.Point(767, 121)
        Me.Sales_1.Name = "Sales_1"
        Me.Sales_1.Size = New System.Drawing.Size(114, 36)
        Me.Sales_1.TabIndex = 3
        Me.Sales_1.Text = "Sales 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkOrange
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5, 5, 10, 5)
        Me.Label1.Size = New System.Drawing.Size(400, 49)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "SALES FORECASTING"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(41, 96)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Prediction"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(708, 228)
        Me.Chart1.TabIndex = 7
        Me.Chart1.Text = "Chart1"
        '
        'HighestSellingDG
        '
        Me.HighestSellingDG.AllowUserToAddRows = False
        Me.HighestSellingDG.AllowUserToResizeRows = False
        Me.HighestSellingDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HighestSellingDG.Location = New System.Drawing.Point(41, 381)
        Me.HighestSellingDG.Name = "HighestSellingDG"
        Me.HighestSellingDG.RowHeadersVisible = False
        Me.HighestSellingDG.RowTemplate.Height = 24
        Me.HighestSellingDG.Size = New System.Drawing.Size(931, 179)
        Me.HighestSellingDG.TabIndex = 8
        '
        'LeastSellingDG
        '
        Me.LeastSellingDG.AllowUserToAddRows = False
        Me.LeastSellingDG.AllowUserToResizeRows = False
        Me.LeastSellingDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LeastSellingDG.Location = New System.Drawing.Point(41, 631)
        Me.LeastSellingDG.Name = "LeastSellingDG"
        Me.LeastSellingDG.RowHeadersVisible = False
        Me.LeastSellingDG.RowTemplate.Height = 24
        Me.LeastSellingDG.Size = New System.Drawing.Size(931, 179)
        Me.LeastSellingDG.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Orange
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 350)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(259, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "HIGHEST SELLING PRODUCTS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkOrange
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 600)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "LEAST SELLING PRODUCTS"
        '
        'SalesPrediction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 843)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LeastSellingDG)
        Me.Controls.Add(Me.HighestSellingDG)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Sales_3)
        Me.Controls.Add(Me.Sales_2)
        Me.Controls.Add(Me.Sales_1)
        Me.Controls.Add(Me.Date_3)
        Me.Controls.Add(Me.Date_2)
        Me.Controls.Add(Me.Date_1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "SalesPrediction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SalesPrediction"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HighestSellingDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeastSellingDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Date_1 As Label
    Friend WithEvents Date_2 As Label
    Friend WithEvents Date_3 As Label
    Friend WithEvents Sales_3 As Label
    Friend WithEvents Sales_2 As Label
    Friend WithEvents Sales_1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents HighestSellingDG As DataGridView
    Friend WithEvents LeastSellingDG As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
