<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.LUsername = New System.Windows.Forms.Label()
        Me.LPassword = New System.Windows.Forms.Label()
        Me.InPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_login = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2ColorTransition1 = New Guna.UI2.WinForms.Guna2ColorTransition(Me.components)
        Me.btn_cancle = New Guna.UI2.WinForms.Guna2Button()
        Me.InEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'LUsername
        '
        Me.LUsername.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LUsername.AutoSize = True
        Me.LUsername.Location = New System.Drawing.Point(27, 129)
        Me.LUsername.Name = "LUsername"
        Me.LUsername.Size = New System.Drawing.Size(55, 13)
        Me.LUsername.TabIndex = 2
        Me.LUsername.Text = "Username"
        '
        'LPassword
        '
        Me.LPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LPassword.AutoSize = True
        Me.LPassword.Location = New System.Drawing.Point(27, 190)
        Me.LPassword.Name = "LPassword"
        Me.LPassword.Size = New System.Drawing.Size(53, 13)
        Me.LPassword.TabIndex = 4
        Me.LPassword.Text = "Password"
        '
        'InPassword
        '
        Me.InPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.InPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.InPassword.DefaultText = ""
        Me.InPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.InPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.InPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.InPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.InPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.InPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.InPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.InPassword.Location = New System.Drawing.Point(27, 206)
        Me.InPassword.Name = "InPassword"
        Me.InPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.InPassword.PlaceholderText = "Password"
        Me.InPassword.SelectedText = ""
        Me.InPassword.Size = New System.Drawing.Size(570, 36)
        Me.InPassword.TabIndex = 3
        '
        'btn_login
        '
        Me.btn_login.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(447, 269)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(150, 38)
        Me.btn_login.TabIndex = 5
        Me.btn_login.Text = "Login"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 31)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Login"
        '
        'Guna2ColorTransition1
        '
        Me.Guna2ColorTransition1.ColorArray = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.Blue, System.Drawing.Color.Orange}
        '
        'btn_cancle
        '
        Me.btn_cancle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_cancle.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_cancle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_cancle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_cancle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_cancle.FillColor = System.Drawing.Color.Gray
        Me.btn_cancle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_cancle.ForeColor = System.Drawing.Color.White
        Me.btn_cancle.Location = New System.Drawing.Point(276, 267)
        Me.btn_cancle.Name = "btn_cancle"
        Me.btn_cancle.Size = New System.Drawing.Size(150, 38)
        Me.btn_cancle.TabIndex = 7
        Me.btn_cancle.Text = "Cancle"
        '
        'InEmail
        '
        Me.InEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.InEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.InEmail.DefaultText = ""
        Me.InEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.InEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.InEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.InEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.InEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.InEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.InEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.InEmail.Location = New System.Drawing.Point(27, 145)
        Me.InEmail.Name = "InEmail"
        Me.InEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.InEmail.PlaceholderText = "Email"
        Me.InEmail.SelectedText = ""
        Me.InEmail.Size = New System.Drawing.Size(570, 36)
        Me.InEmail.TabIndex = 9
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 341)
        Me.Controls.Add(Me.InEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cancle)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.LPassword)
        Me.Controls.Add(Me.InPassword)
        Me.Controls.Add(Me.LUsername)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(640, 380)
        Me.MinimumSize = New System.Drawing.Size(640, 380)
        Me.Name = "FormLogin"
        Me.Padding = New System.Windows.Forms.Padding(30, 10, 30, 10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Login"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents LUsername As Label
    Friend WithEvents LPassword As Label
    Friend WithEvents InPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2ColorTransition1 As Guna.UI2.WinForms.Guna2ColorTransition
    Friend WithEvents btn_cancle As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents InEmail As Guna.UI2.WinForms.Guna2TextBox
End Class
