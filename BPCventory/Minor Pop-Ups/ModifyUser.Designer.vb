<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifyUser))
        Me.BG = New System.Windows.Forms.Panel()
        Me.textpriv = New System.Windows.Forms.ComboBox()
        Me.ModifLabel = New System.Windows.Forms.Label()
        Me.ShowPass = New System.Windows.Forms.CheckBox()
        Me.UpdateBttn = New System.Windows.Forms.Button()
        Me.AddUserBttn = New System.Windows.Forms.Button()
        Me.textlname = New System.Windows.Forms.TextBox()
        Me.textpass2 = New System.Windows.Forms.TextBox()
        Me.textage = New System.Windows.Forms.TextBox()
        Me.textemail = New System.Windows.Forms.TextBox()
        Me.textMN = New System.Windows.Forms.TextBox()
        Me.textpass1 = New System.Windows.Forms.TextBox()
        Me.textuname = New System.Windows.Forms.TextBox()
        Me.textfname = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ClearAllBttn = New System.Windows.Forms.Button()
        Me.CancelBttn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BG.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BG
        '
        Me.BG.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BG.Controls.Add(Me.textpriv)
        Me.BG.Controls.Add(Me.ModifLabel)
        Me.BG.Controls.Add(Me.ShowPass)
        Me.BG.Controls.Add(Me.UpdateBttn)
        Me.BG.Controls.Add(Me.AddUserBttn)
        Me.BG.Controls.Add(Me.textlname)
        Me.BG.Controls.Add(Me.textpass2)
        Me.BG.Controls.Add(Me.textage)
        Me.BG.Controls.Add(Me.textemail)
        Me.BG.Controls.Add(Me.textMN)
        Me.BG.Controls.Add(Me.textpass1)
        Me.BG.Controls.Add(Me.textuname)
        Me.BG.Controls.Add(Me.textfname)
        Me.BG.Controls.Add(Me.PictureBox1)
        Me.BG.Location = New System.Drawing.Point(12, 12)
        Me.BG.Name = "BG"
        Me.BG.Size = New System.Drawing.Size(560, 560)
        Me.BG.TabIndex = 0
        '
        'textpriv
        '
        Me.textpriv.BackColor = System.Drawing.Color.Gold
        Me.textpriv.FormattingEnabled = True
        Me.textpriv.Items.AddRange(New Object() {"ADMINISTRATOR", "USER", "OWNER"})
        Me.textpriv.Location = New System.Drawing.Point(140, 522)
        Me.textpriv.Name = "textpriv"
        Me.textpriv.Size = New System.Drawing.Size(273, 24)
        Me.textpriv.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.textpriv, "Choose Access Level")
        '
        'ModifLabel
        '
        Me.ModifLabel.AutoSize = True
        Me.ModifLabel.BackColor = System.Drawing.Color.DarkOrange
        Me.ModifLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModifLabel.ForeColor = System.Drawing.Color.White
        Me.ModifLabel.Location = New System.Drawing.Point(80, 28)
        Me.ModifLabel.Name = "ModifLabel"
        Me.ModifLabel.Size = New System.Drawing.Size(230, 23)
        Me.ModifLabel.TabIndex = 14
        Me.ModifLabel.Text = "MODIFY EXISTING USER"
        Me.ModifLabel.Visible = False
        '
        'ShowPass
        '
        Me.ShowPass.AutoSize = True
        Me.ShowPass.Location = New System.Drawing.Point(231, 300)
        Me.ShowPass.Name = "ShowPass"
        Me.ShowPass.Size = New System.Drawing.Size(129, 21)
        Me.ShowPass.TabIndex = 13
        Me.ShowPass.Text = "Show Password"
        Me.ShowPass.UseVisualStyleBackColor = True
        '
        'UpdateBttn
        '
        Me.UpdateBttn.BackColor = System.Drawing.Color.Gold
        Me.UpdateBttn.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.UpdateBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.UpdateBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.UpdateBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateBttn.Location = New System.Drawing.Point(430, 19)
        Me.UpdateBttn.Name = "UpdateBttn"
        Me.UpdateBttn.Size = New System.Drawing.Size(118, 44)
        Me.UpdateBttn.TabIndex = 12
        Me.UpdateBttn.Text = "Save"
        Me.ToolTip1.SetToolTip(Me.UpdateBttn, "Save all data Input")
        Me.UpdateBttn.UseVisualStyleBackColor = False
        '
        'AddUserBttn
        '
        Me.AddUserBttn.BackColor = System.Drawing.Color.Gold
        Me.AddUserBttn.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.AddUserBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.AddUserBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.AddUserBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddUserBttn.Location = New System.Drawing.Point(430, 19)
        Me.AddUserBttn.Name = "AddUserBttn"
        Me.AddUserBttn.Size = New System.Drawing.Size(118, 44)
        Me.AddUserBttn.TabIndex = 10
        Me.AddUserBttn.Text = "Add User"
        Me.AddUserBttn.UseVisualStyleBackColor = False
        '
        'textlname
        '
        Me.textlname.BackColor = System.Drawing.Color.Gold
        Me.textlname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textlname.Location = New System.Drawing.Point(304, 122)
        Me.textlname.Name = "textlname"
        Me.textlname.Size = New System.Drawing.Size(232, 15)
        Me.textlname.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.textlname, "Enter Last Name")
        '
        'textpass2
        '
        Me.textpass2.BackColor = System.Drawing.Color.Gold
        Me.textpass2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textpass2.Location = New System.Drawing.Point(304, 266)
        Me.textpass2.Name = "textpass2"
        Me.textpass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textpass2.Size = New System.Drawing.Size(232, 15)
        Me.textpass2.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.textpass2, "Re-enter your password here")
        '
        'textage
        '
        Me.textage.BackColor = System.Drawing.Color.Gold
        Me.textage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textage.Location = New System.Drawing.Point(14, 336)
        Me.textage.Name = "textage"
        Me.textage.Size = New System.Drawing.Size(126, 15)
        Me.textage.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.textage, "Enter your Age here")
        '
        'textemail
        '
        Me.textemail.BackColor = System.Drawing.Color.Gold
        Me.textemail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textemail.Location = New System.Drawing.Point(14, 411)
        Me.textemail.Name = "textemail"
        Me.textemail.Size = New System.Drawing.Size(451, 15)
        Me.textemail.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.textemail, "Enter Email")
        '
        'textMN
        '
        Me.textMN.BackColor = System.Drawing.Color.Gold
        Me.textMN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textMN.Location = New System.Drawing.Point(14, 483)
        Me.textMN.Name = "textMN"
        Me.textMN.Size = New System.Drawing.Size(270, 15)
        Me.textMN.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.textMN, "Enter mobile number here")
        '
        'textpass1
        '
        Me.textpass1.BackColor = System.Drawing.Color.Gold
        Me.textpass1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textpass1.Location = New System.Drawing.Point(14, 266)
        Me.textpass1.Name = "textpass1"
        Me.textpass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textpass1.Size = New System.Drawing.Size(270, 15)
        Me.textpass1.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.textpass1, "Enter Password")
        '
        'textuname
        '
        Me.textuname.BackColor = System.Drawing.Color.Gold
        Me.textuname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textuname.Location = New System.Drawing.Point(14, 194)
        Me.textuname.Name = "textuname"
        Me.textuname.Size = New System.Drawing.Size(270, 15)
        Me.textuname.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.textuname, "Enter Username")
        '
        'textfname
        '
        Me.textfname.BackColor = System.Drawing.Color.Gold
        Me.textfname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textfname.Location = New System.Drawing.Point(14, 122)
        Me.textfname.Name = "textfname"
        Me.textfname.Size = New System.Drawing.Size(270, 15)
        Me.textfname.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.textfname, "Enter First Name Here")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gold
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(560, 560)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ClearAllBttn
        '
        Me.ClearAllBttn.BackColor = System.Drawing.Color.DarkGray
        Me.ClearAllBttn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.ClearAllBttn.FlatAppearance.BorderSize = 0
        Me.ClearAllBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.ClearAllBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.ClearAllBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearAllBttn.Location = New System.Drawing.Point(442, 587)
        Me.ClearAllBttn.Name = "ClearAllBttn"
        Me.ClearAllBttn.Size = New System.Drawing.Size(118, 44)
        Me.ClearAllBttn.TabIndex = 9
        Me.ClearAllBttn.Text = "Clear All"
        Me.ToolTip1.SetToolTip(Me.ClearAllBttn, "Clear All Data")
        Me.ClearAllBttn.UseVisualStyleBackColor = False
        '
        'CancelBttn
        '
        Me.CancelBttn.BackColor = System.Drawing.Color.DarkGray
        Me.CancelBttn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.CancelBttn.FlatAppearance.BorderSize = 0
        Me.CancelBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.CancelBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.CancelBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelBttn.Location = New System.Drawing.Point(12, 587)
        Me.CancelBttn.Name = "CancelBttn"
        Me.CancelBttn.Size = New System.Drawing.Size(118, 44)
        Me.CancelBttn.TabIndex = 10
        Me.CancelBttn.Text = "<< Cancel"
        Me.ToolTip1.SetToolTip(Me.CancelBttn, "Cancel Data Input")
        Me.CancelBttn.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Tips and Guide"
        '
        'ModifyUser
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(582, 653)
        Me.Controls.Add(Me.CancelBttn)
        Me.Controls.Add(Me.ClearAllBttn)
        Me.Controls.Add(Me.BG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModifyUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModifyUser"
        Me.BG.ResumeLayout(False)
        Me.BG.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BG As Panel
    Friend WithEvents AddUserBttn As Button
    Friend WithEvents textlname As TextBox
    Friend WithEvents textpass2 As TextBox
    Friend WithEvents textage As TextBox
    Friend WithEvents textemail As TextBox
    Friend WithEvents textMN As TextBox
    Friend WithEvents textpass1 As TextBox
    Friend WithEvents textuname As TextBox
    Friend WithEvents textfname As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ClearAllBttn As Button
    Friend WithEvents CancelBttn As Button
    Friend WithEvents UpdateBttn As Button
    Friend WithEvents ShowPass As CheckBox
    Friend WithEvents ModifLabel As Label
    Friend WithEvents textpriv As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
