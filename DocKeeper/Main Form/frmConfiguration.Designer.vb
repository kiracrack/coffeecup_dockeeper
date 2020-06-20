<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguration))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txtFileMB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFileKB = New System.Windows.Forms.TextBox()
        Me.txtFileDirectory = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtorgname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtorgaddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtorgoffice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtorgtelephone = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(224, 295)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(161, 30)
        Me.cmdset.TabIndex = 6
        Me.cmdset.Text = "Save Configuration"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtFileMB
        '
        Me.txtFileMB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFileMB.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtFileMB.ForeColor = System.Drawing.Color.Black
        Me.txtFileMB.Location = New System.Drawing.Point(15, 221)
        Me.txtFileMB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFileMB.Name = "txtFileMB"
        Me.txtFileMB.Size = New System.Drawing.Size(91, 22)
        Me.txtFileMB.TabIndex = 4
        Me.txtFileMB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(12, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 15)
        Me.Label7.TabIndex = 368
        Me.Label7.Text = "Allowable file uploading size"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(110, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 15)
        Me.Label1.TabIndex = 369
        Me.Label1.Text = "MB"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(233, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 15)
        Me.Label2.TabIndex = 371
        Me.Label2.Text = "KB"
        '
        'txtFileKB
        '
        Me.txtFileKB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFileKB.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtFileKB.ForeColor = System.Drawing.Color.Black
        Me.txtFileKB.Location = New System.Drawing.Point(138, 221)
        Me.txtFileKB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFileKB.Name = "txtFileKB"
        Me.txtFileKB.ReadOnly = True
        Me.txtFileKB.Size = New System.Drawing.Size(91, 22)
        Me.txtFileKB.TabIndex = 370
        Me.txtFileKB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFileDirectory
        '
        Me.txtFileDirectory.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtFileDirectory.ForeColor = System.Drawing.Color.Black
        Me.txtFileDirectory.Location = New System.Drawing.Point(15, 266)
        Me.txtFileDirectory.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFileDirectory.Name = "txtFileDirectory"
        Me.txtFileDirectory.Size = New System.Drawing.Size(370, 22)
        Me.txtFileDirectory.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(12, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(371, 15)
        Me.Label3.TabIndex = 373
        Me.Label3.Text = "File archieved directory (please put backslash[\] on the last character)"
        '
        'txtorgname
        '
        Me.txtorgname.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtorgname.ForeColor = System.Drawing.Color.Black
        Me.txtorgname.Location = New System.Drawing.Point(15, 28)
        Me.txtorgname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtorgname.Name = "txtorgname"
        Me.txtorgname.Size = New System.Drawing.Size(370, 22)
        Me.txtorgname.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 15)
        Me.Label4.TabIndex = 375
        Me.Label4.Text = "Organization Name"
        '
        'txtorgaddress
        '
        Me.txtorgaddress.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtorgaddress.ForeColor = System.Drawing.Color.Black
        Me.txtorgaddress.Location = New System.Drawing.Point(15, 119)
        Me.txtorgaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtorgaddress.Multiline = True
        Me.txtorgaddress.Name = "txtorgaddress"
        Me.txtorgaddress.Size = New System.Drawing.Size(370, 45)
        Me.txtorgaddress.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(12, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 15)
        Me.Label5.TabIndex = 377
        Me.Label5.Text = "Complete Address"
        '
        'txtorgoffice
        '
        Me.txtorgoffice.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtorgoffice.ForeColor = System.Drawing.Color.Black
        Me.txtorgoffice.Location = New System.Drawing.Point(15, 73)
        Me.txtorgoffice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtorgoffice.Name = "txtorgoffice"
        Me.txtorgoffice.Size = New System.Drawing.Size(214, 22)
        Me.txtorgoffice.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(12, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 15)
        Me.Label6.TabIndex = 379
        Me.Label6.Text = "Office Name"
        '
        'txtorgtelephone
        '
        Me.txtorgtelephone.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtorgtelephone.ForeColor = System.Drawing.Color.Black
        Me.txtorgtelephone.Location = New System.Drawing.Point(236, 73)
        Me.txtorgtelephone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtorgtelephone.Name = "txtorgtelephone"
        Me.txtorgtelephone.Size = New System.Drawing.Size(149, 22)
        Me.txtorgtelephone.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(233, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 15)
        Me.Label8.TabIndex = 381
        Me.Label8.Text = "Telephone Number"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(15, 171)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(156, 17)
        Me.CheckBox1.TabIndex = 382
        Me.CheckBox1.Text = "Center Header Alignment"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frmConfiguration
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(400, 340)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtorgtelephone)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtorgoffice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtorgaddress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtorgname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFileDirectory)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFileKB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFileMB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConfiguration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents txtFileMB As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFileKB As System.Windows.Forms.TextBox
    Friend WithEvents txtFileDirectory As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtorgname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtorgaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtorgoffice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtorgtelephone As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
