<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyAffiliates
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifyAffiliates))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ModifCustLabel = New System.Windows.Forms.Label()
        Me.AddNewCustLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UpdateCustomerBttn = New System.Windows.Forms.Button()
        Me.CancelBttn = New System.Windows.Forms.Button()
        Me.ClearAllBttn = New System.Windows.Forms.Button()
        Me.textaffiliateid = New System.Windows.Forms.TextBox()
        Me.textcompanyname = New System.Windows.Forms.TextBox()
        Me.textemail = New System.Windows.Forms.TextBox()
        Me.textcontno = New System.Windows.Forms.TextBox()
        Me.AddCustomerBttn = New System.Windows.Forms.Button()
        Me.AddNewSuppLabel = New System.Windows.Forms.Label()
        Me.ModifSuppLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AddSupplierBttn = New System.Windows.Forms.Button()
        Me.UpdateSupplierBttn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(560, 558)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ModifCustLabel
        '
        Me.ModifCustLabel.AutoSize = True
        Me.ModifCustLabel.BackColor = System.Drawing.Color.DarkOrange
        Me.ModifCustLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModifCustLabel.ForeColor = System.Drawing.Color.White
        Me.ModifCustLabel.Location = New System.Drawing.Point(78, 26)
        Me.ModifCustLabel.Name = "ModifCustLabel"
        Me.ModifCustLabel.Size = New System.Drawing.Size(274, 23)
        Me.ModifCustLabel.TabIndex = 15
        Me.ModifCustLabel.Text = "MODIFY EXISTING CUSTOMER"
        Me.ModifCustLabel.Visible = False
        '
        'AddNewCustLabel
        '
        Me.AddNewCustLabel.AutoSize = True
        Me.AddNewCustLabel.BackColor = System.Drawing.Color.DarkOrange
        Me.AddNewCustLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewCustLabel.ForeColor = System.Drawing.Color.White
        Me.AddNewCustLabel.Location = New System.Drawing.Point(78, 26)
        Me.AddNewCustLabel.Name = "AddNewCustLabel"
        Me.AddNewCustLabel.Size = New System.Drawing.Size(186, 23)
        Me.AddNewCustLabel.TabIndex = 16
        Me.AddNewCustLabel.Text = "ADD NEW CUSTOMER"
        Me.AddNewCustLabel.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Customer ID"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 23)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Company Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 23)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 23)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Contact Number"
        '
        'UpdateCustomerBttn
        '
        Me.UpdateCustomerBttn.BackColor = System.Drawing.Color.Gold
        Me.UpdateCustomerBttn.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.UpdateCustomerBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.UpdateCustomerBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.UpdateCustomerBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateCustomerBttn.Location = New System.Drawing.Point(430, 18)
        Me.UpdateCustomerBttn.Name = "UpdateCustomerBttn"
        Me.UpdateCustomerBttn.Size = New System.Drawing.Size(118, 44)
        Me.UpdateCustomerBttn.TabIndex = 23
        Me.UpdateCustomerBttn.Text = "Save"
        Me.UpdateCustomerBttn.UseVisualStyleBackColor = False
        '
        'CancelBttn
        '
        Me.CancelBttn.BackColor = System.Drawing.Color.DarkGray
        Me.CancelBttn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.CancelBttn.FlatAppearance.BorderSize = 0
        Me.CancelBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.CancelBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.CancelBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBttn.Location = New System.Drawing.Point(8, 556)
        Me.CancelBttn.Name = "CancelBttn"
        Me.CancelBttn.Size = New System.Drawing.Size(118, 44)
        Me.CancelBttn.TabIndex = 22
        Me.CancelBttn.Text = "<< Cancel"
        Me.ToolTip1.SetToolTip(Me.CancelBttn, "Cancel input data")
        Me.CancelBttn.UseVisualStyleBackColor = False
        '
        'ClearAllBttn
        '
        Me.ClearAllBttn.BackColor = System.Drawing.Color.DarkGray
        Me.ClearAllBttn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.ClearAllBttn.FlatAppearance.BorderSize = 0
        Me.ClearAllBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.ClearAllBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.ClearAllBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearAllBttn.Location = New System.Drawing.Point(435, 556)
        Me.ClearAllBttn.Name = "ClearAllBttn"
        Me.ClearAllBttn.Size = New System.Drawing.Size(118, 44)
        Me.ClearAllBttn.TabIndex = 21
        Me.ClearAllBttn.Text = "Clear All"
        Me.ToolTip1.SetToolTip(Me.ClearAllBttn, "Clear all data input")
        Me.ClearAllBttn.UseVisualStyleBackColor = False
        Me.ClearAllBttn.Visible = False
        '
        'textaffiliateid
        '
        Me.textaffiliateid.BackColor = System.Drawing.Color.Gold
        Me.textaffiliateid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textaffiliateid.Location = New System.Drawing.Point(12, 123)
        Me.textaffiliateid.Name = "textaffiliateid"
        Me.textaffiliateid.Size = New System.Drawing.Size(274, 15)
        Me.textaffiliateid.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.textaffiliateid, "Enter Supplier ID")
        '
        'textcompanyname
        '
        Me.textcompanyname.BackColor = System.Drawing.Color.Gold
        Me.textcompanyname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textcompanyname.Location = New System.Drawing.Point(11, 192)
        Me.textcompanyname.Name = "textcompanyname"
        Me.textcompanyname.Size = New System.Drawing.Size(493, 15)
        Me.textcompanyname.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.textcompanyname, "Enter Company name")
        '
        'textemail
        '
        Me.textemail.BackColor = System.Drawing.Color.Gold
        Me.textemail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textemail.Location = New System.Drawing.Point(11, 265)
        Me.textemail.Name = "textemail"
        Me.textemail.Size = New System.Drawing.Size(346, 15)
        Me.textemail.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.textemail, "Enter email here")
        '
        'textcontno
        '
        Me.textcontno.BackColor = System.Drawing.Color.Gold
        Me.textcontno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textcontno.Location = New System.Drawing.Point(11, 336)
        Me.textcontno.Name = "textcontno"
        Me.textcontno.Size = New System.Drawing.Size(274, 15)
        Me.textcontno.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.textcontno, "Enter Contact Number")
        '
        'AddCustomerBttn
        '
        Me.AddCustomerBttn.BackColor = System.Drawing.Color.Gold
        Me.AddCustomerBttn.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.AddCustomerBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.AddCustomerBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.AddCustomerBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddCustomerBttn.Location = New System.Drawing.Point(430, 18)
        Me.AddCustomerBttn.Name = "AddCustomerBttn"
        Me.AddCustomerBttn.Size = New System.Drawing.Size(118, 44)
        Me.AddCustomerBttn.TabIndex = 28
        Me.AddCustomerBttn.Text = "Add Customer"
        Me.AddCustomerBttn.UseVisualStyleBackColor = False
        '
        'AddNewSuppLabel
        '
        Me.AddNewSuppLabel.AutoSize = True
        Me.AddNewSuppLabel.BackColor = System.Drawing.Color.DarkOrange
        Me.AddNewSuppLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewSuppLabel.ForeColor = System.Drawing.Color.White
        Me.AddNewSuppLabel.Location = New System.Drawing.Point(78, 26)
        Me.AddNewSuppLabel.Name = "AddNewSuppLabel"
        Me.AddNewSuppLabel.Size = New System.Drawing.Size(186, 23)
        Me.AddNewSuppLabel.TabIndex = 29
        Me.AddNewSuppLabel.Text = "ADD NEW SUPPLIER"
        Me.AddNewSuppLabel.Visible = False
        '
        'ModifSuppLabel
        '
        Me.ModifSuppLabel.AutoSize = True
        Me.ModifSuppLabel.BackColor = System.Drawing.Color.DarkOrange
        Me.ModifSuppLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModifSuppLabel.ForeColor = System.Drawing.Color.White
        Me.ModifSuppLabel.Location = New System.Drawing.Point(78, 26)
        Me.ModifSuppLabel.Name = "ModifSuppLabel"
        Me.ModifSuppLabel.Size = New System.Drawing.Size(274, 23)
        Me.ModifSuppLabel.TabIndex = 30
        Me.ModifSuppLabel.Text = "MODIFY EXISTING SUPPLIER"
        Me.ModifSuppLabel.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 23)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Supplier ID"
        Me.Label5.Visible = False
        '
        'AddSupplierBttn
        '
        Me.AddSupplierBttn.BackColor = System.Drawing.Color.Gold
        Me.AddSupplierBttn.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.AddSupplierBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.AddSupplierBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.AddSupplierBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddSupplierBttn.Location = New System.Drawing.Point(430, 15)
        Me.AddSupplierBttn.Name = "AddSupplierBttn"
        Me.AddSupplierBttn.Size = New System.Drawing.Size(118, 44)
        Me.AddSupplierBttn.TabIndex = 33
        Me.AddSupplierBttn.Text = "Add Supplier"
        Me.ToolTip1.SetToolTip(Me.AddSupplierBttn, "Add Supplier")
        Me.AddSupplierBttn.UseVisualStyleBackColor = False
        '
        'UpdateSupplierBttn
        '
        Me.UpdateSupplierBttn.BackColor = System.Drawing.Color.Gold
        Me.UpdateSupplierBttn.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.UpdateSupplierBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.UpdateSupplierBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.UpdateSupplierBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateSupplierBttn.Location = New System.Drawing.Point(430, 17)
        Me.UpdateSupplierBttn.Name = "UpdateSupplierBttn"
        Me.UpdateSupplierBttn.Size = New System.Drawing.Size(118, 44)
        Me.UpdateSupplierBttn.TabIndex = 32
        Me.UpdateSupplierBttn.Text = "Save"
        Me.UpdateSupplierBttn.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Tips and Guide"
        '
        'ModifyAffiliates
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(560, 609)
        Me.Controls.Add(Me.AddSupplierBttn)
        Me.Controls.Add(Me.UpdateSupplierBttn)
        Me.Controls.Add(Me.ModifSuppLabel)
        Me.Controls.Add(Me.AddNewSuppLabel)
        Me.Controls.Add(Me.ModifCustLabel)
        Me.Controls.Add(Me.AddNewCustLabel)
        Me.Controls.Add(Me.AddCustomerBttn)
        Me.Controls.Add(Me.textcontno)
        Me.Controls.Add(Me.textemail)
        Me.Controls.Add(Me.textcompanyname)
        Me.Controls.Add(Me.textaffiliateid)
        Me.Controls.Add(Me.UpdateCustomerBttn)
        Me.Controls.Add(Me.CancelBttn)
        Me.Controls.Add(Me.ClearAllBttn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModifyAffiliates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModifyAffiliates"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ModifCustLabel As Label
    Friend WithEvents AddNewCustLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents UpdateCustomerBttn As Button
    Friend WithEvents CancelBttn As Button
    Friend WithEvents ClearAllBttn As Button
    Friend WithEvents textaffiliateid As TextBox
    Friend WithEvents textcompanyname As TextBox
    Friend WithEvents textemail As TextBox
    Friend WithEvents textcontno As TextBox
    Friend WithEvents AddCustomerBttn As Button
    Friend WithEvents AddNewSuppLabel As Label
    Friend WithEvents ModifSuppLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents AddSupplierBttn As Button
    Friend WithEvents UpdateSupplierBttn As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
