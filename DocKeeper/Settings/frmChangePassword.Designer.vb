<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangePassword))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtCurrentPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVerifyPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ckEnableEmailNotification = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(176, 157)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(200, 30)
        Me.cmdset.TabIndex = 3
        Me.cmdset.Text = "Confirm Password"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtPosition
        '
        Me.txtPosition.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPosition.ForeColor = System.Drawing.Color.Black
        Me.txtPosition.Location = New System.Drawing.Point(177, 40)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(198, 22)
        Me.txtPosition.TabIndex = 100
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(122, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 357
        Me.Label3.Text = "Position"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(88, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 366
        Me.Label4.Text = "New Password"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(177, 15)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(198, 22)
        Me.txtName.TabIndex = 99
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(85, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 15)
        Me.Label7.TabIndex = 368
        Me.Label7.Text = "Account Name"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNewPassword.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNewPassword.Location = New System.Drawing.Point(177, 112)
        Me.txtNewPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtNewPassword.ReadOnly = True
        Me.txtNewPassword.Size = New System.Drawing.Size(198, 20)
        Me.txtNewPassword.TabIndex = 1
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCurrentPassword.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCurrentPassword.Location = New System.Drawing.Point(177, 89)
        Me.txtCurrentPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtCurrentPassword.ReadOnly = True
        Me.txtCurrentPassword.Size = New System.Drawing.Size(198, 20)
        Me.txtCurrentPassword.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(72, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 370
        Me.Label1.Text = "Current Password"
        '
        'txtVerifyPassword
        '
        Me.txtVerifyPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtVerifyPassword.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtVerifyPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtVerifyPassword.Location = New System.Drawing.Point(177, 135)
        Me.txtVerifyPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVerifyPassword.Name = "txtVerifyPassword"
        Me.txtVerifyPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtVerifyPassword.ReadOnly = True
        Me.txtVerifyPassword.Size = New System.Drawing.Size(198, 20)
        Me.txtVerifyPassword.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(82, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 372
        Me.Label2.Text = "Verify Password"
        '
        'ckEnableEmailNotification
        '
        Me.ckEnableEmailNotification.AutoSize = True
        Me.ckEnableEmailNotification.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckEnableEmailNotification.ForeColor = System.Drawing.Color.Black
        Me.ckEnableEmailNotification.Location = New System.Drawing.Point(177, 69)
        Me.ckEnableEmailNotification.Name = "ckEnableEmailNotification"
        Me.ckEnableEmailNotification.Size = New System.Drawing.Size(120, 19)
        Me.ckEnableEmailNotification.TabIndex = 374
        Me.ckEnableEmailNotification.Text = "Change Password"
        Me.ckEnableEmailNotification.UseVisualStyleBackColor = True
        '
        'frmChangePassword
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(388, 195)
        Me.Controls.Add(Me.txtVerifyPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCurrentPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdset)
        Me.Controls.Add(Me.ckEnableEmailNotification)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User Account Info."
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrentPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtVerifyPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ckEnableEmailNotification As System.Windows.Forms.CheckBox
End Class
