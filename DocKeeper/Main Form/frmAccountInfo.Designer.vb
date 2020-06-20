<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccountInfo))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtVerify = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AccountId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.ckadminuser = New System.Windows.Forms.CheckBox()
        Me.ckChange = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(120, 182)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(139, 30)
        Me.cmdset.TabIndex = 6
        Me.cmdset.Text = "Save User"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtPosition
        '
        Me.txtPosition.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPosition.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPosition.ForeColor = System.Drawing.Color.Black
        Me.txtPosition.Location = New System.Drawing.Point(121, 67)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(216, 22)
        Me.txtPosition.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(68, 70)
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
        Me.Label4.Location = New System.Drawing.Point(42, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 366
        Me.Label4.Text = "Set Password"
        '
        'txtFullname
        '
        Me.txtFullname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFullname.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtFullname.ForeColor = System.Drawing.Color.Black
        Me.txtFullname.Location = New System.Drawing.Point(121, 42)
        Me.txtFullname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(216, 22)
        Me.txtFullname.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(62, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 15)
        Me.Label7.TabIndex = 368
        Me.Label7.Text = "Fullname"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(121, 117)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(137, 20)
        Me.txtPassword.TabIndex = 3
        '
        'txtVerify
        '
        Me.txtVerify.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtVerify.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtVerify.Location = New System.Drawing.Point(121, 140)
        Me.txtVerify.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVerify.Name = "txtVerify"
        Me.txtVerify.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtVerify.ReadOnly = True
        Me.txtVerify.Size = New System.Drawing.Size(137, 20)
        Me.txtVerify.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(28, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 372
        Me.Label2.Text = "Verify Password"
        '
        'AccountId
        '
        Me.AccountId.BackColor = System.Drawing.Color.Yellow
        Me.AccountId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AccountId.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.AccountId.ForeColor = System.Drawing.Color.Black
        Me.AccountId.Location = New System.Drawing.Point(121, 17)
        Me.AccountId.Margin = New System.Windows.Forms.Padding(4)
        Me.AccountId.Name = "AccountId"
        Me.AccountId.ReadOnly = True
        Me.AccountId.Size = New System.Drawing.Size(97, 22)
        Me.AccountId.TabIndex = 415
        Me.AccountId.Text = "AUTO"
        Me.AccountId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(52, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 15)
        Me.Label8.TabIndex = 414
        Me.Label8.Text = "Account ID"
        '
        'txtUsername
        '
        Me.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(121, 92)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(137, 22)
        Me.txtUsername.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(58, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 417
        Me.Label5.Text = "Username"
        '
        'mode
        '
        Me.mode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.mode.ForeColor = System.Drawing.Color.Black
        Me.mode.Location = New System.Drawing.Point(456, 330)
        Me.mode.Margin = New System.Windows.Forms.Padding(4)
        Me.mode.Name = "mode"
        Me.mode.Size = New System.Drawing.Size(67, 22)
        Me.mode.TabIndex = 421
        Me.mode.Visible = False
        '
        'ckadminuser
        '
        Me.ckadminuser.AutoSize = True
        Me.ckadminuser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckadminuser.ForeColor = System.Drawing.Color.Black
        Me.ckadminuser.Location = New System.Drawing.Point(121, 163)
        Me.ckadminuser.Name = "ckadminuser"
        Me.ckadminuser.Size = New System.Drawing.Size(88, 19)
        Me.ckadminuser.TabIndex = 5
        Me.ckadminuser.Text = "Admin User"
        Me.ckadminuser.UseVisualStyleBackColor = True
        '
        'ckChange
        '
        Me.ckChange.AutoSize = True
        Me.ckChange.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckChange.ForeColor = System.Drawing.Color.Black
        Me.ckChange.Location = New System.Drawing.Point(262, 118)
        Me.ckChange.Name = "ckChange"
        Me.ckChange.Size = New System.Drawing.Size(67, 19)
        Me.ckChange.TabIndex = 422
        Me.ckChange.Text = "Change"
        Me.ckChange.UseVisualStyleBackColor = True
        '
        'frmAccountInfo
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(371, 228)
        Me.Controls.Add(Me.ckChange)
        Me.Controls.Add(Me.ckadminuser)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AccountId)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtVerify)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAccountInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFullname As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtVerify As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AccountId As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents ckadminuser As System.Windows.Forms.CheckBox
    Friend WithEvents ckChange As System.Windows.Forms.CheckBox
End Class
