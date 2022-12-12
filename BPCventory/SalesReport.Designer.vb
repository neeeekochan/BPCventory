<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesReport))
        Me.LogoutBttn = New System.Windows.Forms.Button()
        Me.BGPanel = New System.Windows.Forms.Panel()
        Me.WelcomeLabel = New System.Windows.Forms.Label()
        Me.user_icon = New System.Windows.Forms.PictureBox()
        Me.BGPanel.SuspendLayout()
        CType(Me.user_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoutBttn
        '
        Me.LogoutBttn.BackColor = System.Drawing.Color.Gold
        Me.LogoutBttn.FlatAppearance.BorderSize = 0
        Me.LogoutBttn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.LogoutBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.LogoutBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutBttn.Font = New System.Drawing.Font("Roboto", 7.8!)
        Me.LogoutBttn.Location = New System.Drawing.Point(1071, 569)
        Me.LogoutBttn.Name = "LogoutBttn"
        Me.LogoutBttn.Size = New System.Drawing.Size(99, 42)
        Me.LogoutBttn.TabIndex = 0
        Me.LogoutBttn.Text = "Log out"
        Me.LogoutBttn.UseVisualStyleBackColor = False
        '
        'BGPanel
        '
        Me.BGPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.BGPanel.Controls.Add(Me.WelcomeLabel)
        Me.BGPanel.Controls.Add(Me.user_icon)
        Me.BGPanel.Location = New System.Drawing.Point(0, -2)
        Me.BGPanel.Name = "BGPanel"
        Me.BGPanel.Size = New System.Drawing.Size(1180, 80)
        Me.BGPanel.TabIndex = 1
        '
        'WelcomeLabel
        '
        Me.WelcomeLabel.AutoSize = True
        Me.WelcomeLabel.Location = New System.Drawing.Point(100, 30)
        Me.WelcomeLabel.Name = "WelcomeLabel"
        Me.WelcomeLabel.Size = New System.Drawing.Size(43, 17)
        Me.WelcomeLabel.TabIndex = 4
        Me.WelcomeLabel.Text = "Label"
        Me.WelcomeLabel.Visible = False
        '
        'user_icon
        '
        Me.user_icon.Image = CType(resources.GetObject("user_icon.Image"), System.Drawing.Image)
        Me.user_icon.InitialImage = Nothing
        Me.user_icon.Location = New System.Drawing.Point(12, 6)
        Me.user_icon.Margin = New System.Windows.Forms.Padding(0)
        Me.user_icon.Name = "user_icon"
        Me.user_icon.Size = New System.Drawing.Size(70, 58)
        Me.user_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.user_icon.TabIndex = 2
        Me.user_icon.TabStop = False
        Me.user_icon.Visible = False
        '
        'SalesReport
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1180, 620)
        Me.Controls.Add(Me.LogoutBttn)
        Me.Controls.Add(Me.BGPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SalesReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SalesReport"
        Me.BGPanel.ResumeLayout(False)
        Me.BGPanel.PerformLayout()
        CType(Me.user_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogoutBttn As Button
    Friend WithEvents BGPanel As Panel
    Friend WithEvents user_icon As PictureBox
    Friend WithEvents WelcomeLabel As Label
End Class
