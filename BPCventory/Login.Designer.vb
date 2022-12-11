<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.LogoutBttn = New System.Windows.Forms.Label()
        Me.LoginBttn = New System.Windows.Forms.Button()
        Me.ShowPass = New System.Windows.Forms.CheckBox()
        Me.textpassword = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.textusername = New System.Windows.Forms.TextBox()
        Me.AutologinBttn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoutBttn
        '
        Me.LogoutBttn.AutoSize = True
        Me.LogoutBttn.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutBttn.Location = New System.Drawing.Point(985, 9)
        Me.LogoutBttn.Name = "LogoutBttn"
        Me.LogoutBttn.Size = New System.Drawing.Size(23, 24)
        Me.LogoutBttn.TabIndex = 10
        Me.LogoutBttn.Text = "X"
        '
        'LoginBttn
        '
        Me.LoginBttn.BackColor = System.Drawing.Color.Gold
        Me.LoginBttn.FlatAppearance.BorderSize = 0
        Me.LoginBttn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.LoginBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.LoginBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginBttn.Font = New System.Drawing.Font("Roboto", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBttn.Location = New System.Drawing.Point(809, 451)
        Me.LoginBttn.Name = "LoginBttn"
        Me.LoginBttn.Size = New System.Drawing.Size(100, 48)
        Me.LoginBttn.TabIndex = 5
        Me.LoginBttn.Text = "Login"
        Me.LoginBttn.UseVisualStyleBackColor = False
        '
        'ShowPass
        '
        Me.ShowPass.AutoSize = True
        Me.ShowPass.Font = New System.Drawing.Font("Roboto", 8.0!)
        Me.ShowPass.Location = New System.Drawing.Point(525, 536)
        Me.ShowPass.Name = "ShowPass"
        Me.ShowPass.Size = New System.Drawing.Size(131, 21)
        Me.ShowPass.TabIndex = 4
        Me.ShowPass.Text = "Show Password"
        Me.ShowPass.UseVisualStyleBackColor = True
        '
        'textpassword
        '
        Me.textpassword.BackColor = System.Drawing.Color.DarkOrange
        Me.textpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textpassword.Font = New System.Drawing.Font("Roboto Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textpassword.ForeColor = System.Drawing.Color.White
        Me.textpassword.Location = New System.Drawing.Point(504, 494)
        Me.textpassword.Name = "textpassword"
        Me.textpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textpassword.Size = New System.Drawing.Size(277, 21)
        Me.textpassword.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1020, 640)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'textusername
        '
        Me.textusername.BackColor = System.Drawing.Color.DarkOrange
        Me.textusername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textusername.Font = New System.Drawing.Font("Roboto Medium", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textusername.ForeColor = System.Drawing.Color.White
        Me.textusername.Location = New System.Drawing.Point(504, 441)
        Me.textusername.Name = "textusername"
        Me.textusername.Size = New System.Drawing.Size(277, 21)
        Me.textusername.TabIndex = 2
        '
        'AutologinBttn
        '
        Me.AutologinBttn.BackColor = System.Drawing.Color.Tomato
        Me.AutologinBttn.FlatAppearance.BorderSize = 0
        Me.AutologinBttn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.AutologinBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.AutologinBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AutologinBttn.Font = New System.Drawing.Font("Roboto", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutologinBttn.Location = New System.Drawing.Point(809, 521)
        Me.AutologinBttn.Name = "AutologinBttn"
        Me.AutologinBttn.Size = New System.Drawing.Size(100, 48)
        Me.AutologinBttn.TabIndex = 12
        Me.AutologinBttn.Text = "Auto - Login"
        Me.AutologinBttn.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1020, 640)
        Me.Controls.Add(Me.AutologinBttn)
        Me.Controls.Add(Me.LoginBttn)
        Me.Controls.Add(Me.LogoutBttn)
        Me.Controls.Add(Me.textusername)
        Me.Controls.Add(Me.textpassword)
        Me.Controls.Add(Me.ShowPass)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoginBttn As Button
    Friend WithEvents ShowPass As CheckBox
    Friend WithEvents textpassword As TextBox
    Friend WithEvents LogoutBttn As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents textusername As TextBox
    Friend WithEvents AutologinBttn As Button
End Class
