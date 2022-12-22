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
        Me.OTPPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.SendOTPBttn = New System.Windows.Forms.Button()
        Me.CancelOTPBttn = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OTPPanel.SuspendLayout()
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
        'OTPPanel
        '
        Me.OTPPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OTPPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.OTPPanel.Controls.Add(Me.Label1)
        Me.OTPPanel.Controls.Add(Me.MaskedTextBox1)
        Me.OTPPanel.Controls.Add(Me.SendOTPBttn)
        Me.OTPPanel.Controls.Add(Me.CancelOTPBttn)
        Me.OTPPanel.Controls.Add(Me.LinkLabel1)
        Me.OTPPanel.Controls.Add(Me.Label2)
        Me.OTPPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.OTPPanel.Location = New System.Drawing.Point(268, 188)
        Me.OTPPanel.Margin = New System.Windows.Forms.Padding(7)
        Me.OTPPanel.Name = "OTPPanel"
        Me.OTPPanel.Padding = New System.Windows.Forms.Padding(4)
        Me.OTPPanel.Size = New System.Drawing.Size(484, 265)
        Me.OTPPanel.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SandyBrown
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5)
        Me.Label1.Size = New System.Drawing.Size(466, 90)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A One-Time-Password (OTP) has been sent to the phone number you have registered i" &
    "n the system corresponding to your account. Please input the OTP to proceed with" &
    " logging in."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.MaskedTextBox1.Location = New System.Drawing.Point(9, 99)
        Me.MaskedTextBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.MaskedTextBox1.Mask = "00-00-00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(462, 30)
        Me.MaskedTextBox1.TabIndex = 1
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'SendOTPBttn
        '
        Me.SendOTPBttn.BackColor = System.Drawing.Color.Gold
        Me.SendOTPBttn.Location = New System.Drawing.Point(7, 137)
        Me.SendOTPBttn.Name = "SendOTPBttn"
        Me.SendOTPBttn.Size = New System.Drawing.Size(91, 35)
        Me.SendOTPBttn.TabIndex = 2
        Me.SendOTPBttn.Text = "Submit"
        Me.SendOTPBttn.UseVisualStyleBackColor = False
        '
        'CancelOTPBttn
        '
        Me.CancelOTPBttn.BackColor = System.Drawing.Color.Gold
        Me.CancelOTPBttn.Location = New System.Drawing.Point(7, 178)
        Me.CancelOTPBttn.Name = "CancelOTPBttn"
        Me.CancelOTPBttn.Size = New System.Drawing.Size(91, 35)
        Me.CancelOTPBttn.TabIndex = 5
        Me.CancelOTPBttn.Text = "Cancel"
        Me.CancelOTPBttn.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(7, 216)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(65, 17)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Resend?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'Login
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1020, 640)
        Me.Controls.Add(Me.OTPPanel)
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
        Me.OTPPanel.ResumeLayout(False)
        Me.OTPPanel.PerformLayout()
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
    Friend WithEvents OTPPanel As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents SendOTPBttn As Button
    Friend WithEvents CancelOTPBttn As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
End Class
