<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewDocument
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewDocument))
        Me.cmdset = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDocumentTitle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtVerifyPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ckPasswordProtect = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.txtCategory = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.refcode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtReferenceNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdAttachment = New System.Windows.Forms.Button()
        Me.ckQuotation = New System.Windows.Forms.CheckBox()
        Me.txtDocDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.catid = New System.Windows.Forms.TextBox()
        Me.mode = New System.Windows.Forms.TextBox()
        Me.txtAttachedCount = New System.Windows.Forms.LinkLabel()
        Me.seriesno = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(176, 400)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(200, 30)
        Me.cmdset.TabIndex = 9
        Me.cmdset.Text = "Save Document"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDescription.ForeColor = System.Drawing.Color.Black
        Me.txtDescription.Location = New System.Drawing.Point(177, 88)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(440, 100)
        Me.txtDescription.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(105, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 357
        Me.Label3.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(94, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 366
        Me.Label4.Text = "Set Password"
        '
        'txtDocumentTitle
        '
        Me.txtDocumentTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDocumentTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDocumentTitle.ForeColor = System.Drawing.Color.Black
        Me.txtDocumentTitle.Location = New System.Drawing.Point(177, 63)
        Me.txtDocumentTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDocumentTitle.Name = "txtDocumentTitle"
        Me.txtDocumentTitle.Size = New System.Drawing.Size(345, 22)
        Me.txtDocumentTitle.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(83, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 15)
        Me.Label7.TabIndex = 368
        Me.Label7.Text = "Document Title"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNewPassword.Location = New System.Drawing.Point(177, 354)
        Me.txtNewPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtNewPassword.ReadOnly = True
        Me.txtNewPassword.Size = New System.Drawing.Size(198, 20)
        Me.txtNewPassword.TabIndex = 7
        '
        'txtVerifyPassword
        '
        Me.txtVerifyPassword.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtVerifyPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtVerifyPassword.Location = New System.Drawing.Point(177, 377)
        Me.txtVerifyPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVerifyPassword.Name = "txtVerifyPassword"
        Me.txtVerifyPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtVerifyPassword.ReadOnly = True
        Me.txtVerifyPassword.Size = New System.Drawing.Size(198, 20)
        Me.txtVerifyPassword.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(80, 379)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 372
        Me.Label2.Text = "Verify Password"
        '
        'ckPasswordProtect
        '
        Me.ckPasswordProtect.AutoSize = True
        Me.ckPasswordProtect.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckPasswordProtect.ForeColor = System.Drawing.Color.Black
        Me.ckPasswordProtect.Location = New System.Drawing.Point(177, 333)
        Me.ckPasswordProtect.Name = "ckPasswordProtect"
        Me.ckPasswordProtect.Size = New System.Drawing.Size(130, 19)
        Me.ckPasswordProtect.TabIndex = 6
        Me.ckPasswordProtect.Text = "Password Protected"
        Me.ckPasswordProtect.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(629, 25)
        Me.ToolStrip1.TabIndex = 409
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.Image = Global.DocKeeper.My.Resources.Resources.cross1
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripSplitButton1.Text = "Close Window"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.DocKeeper.My.Resources.Resources.notebook__plus
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripButton1.Text = "Document Category"
        '
        'txtCategory
        '
        Me.txtCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtCategory.DropDownHeight = 200
        Me.txtCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCategory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCategory.FormattingEnabled = True
        Me.txtCategory.IntegralHeight = False
        Me.txtCategory.ItemHeight = 15
        Me.txtCategory.Location = New System.Drawing.Point(177, 191)
        Me.txtCategory.MaxDropDownItems = 20
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(346, 23)
        Me.txtCategory.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(116, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 411
        Me.Label1.Text = "Category"
        '
        'refcode
        '
        Me.refcode.BackColor = System.Drawing.Color.Yellow
        Me.refcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.refcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.refcode.ForeColor = System.Drawing.Color.Black
        Me.refcode.Location = New System.Drawing.Point(177, 38)
        Me.refcode.Margin = New System.Windows.Forms.Padding(4)
        Me.refcode.Name = "refcode"
        Me.refcode.ReadOnly = True
        Me.refcode.Size = New System.Drawing.Size(142, 22)
        Me.refcode.TabIndex = 415
        Me.refcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(71, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 15)
        Me.Label8.TabIndex = 414
        Me.Label8.Text = "Registration Code"
        '
        'txtReferenceNumber
        '
        Me.txtReferenceNumber.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtReferenceNumber.ForeColor = System.Drawing.Color.Black
        Me.txtReferenceNumber.Location = New System.Drawing.Point(177, 217)
        Me.txtReferenceNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReferenceNumber.Name = "txtReferenceNumber"
        Me.txtReferenceNumber.Size = New System.Drawing.Size(197, 22)
        Me.txtReferenceNumber.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(65, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 15)
        Me.Label5.TabIndex = 417
        Me.Label5.Text = "Reference Number"
        '
        'cmdAttachment
        '
        Me.cmdAttachment.Enabled = False
        Me.cmdAttachment.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdAttachment.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAttachment.Location = New System.Drawing.Point(177, 293)
        Me.cmdAttachment.Name = "cmdAttachment"
        Me.cmdAttachment.Size = New System.Drawing.Size(73, 30)
        Me.cmdAttachment.TabIndex = 5
        Me.cmdAttachment.Text = "Add Files"
        Me.cmdAttachment.UseCompatibleTextRendering = True
        '
        'ckQuotation
        '
        Me.ckQuotation.AutoSize = True
        Me.ckQuotation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ckQuotation.ForeColor = System.Drawing.Color.Black
        Me.ckQuotation.Location = New System.Drawing.Point(177, 273)
        Me.ckQuotation.Name = "ckQuotation"
        Me.ckQuotation.Size = New System.Drawing.Size(173, 19)
        Me.ckQuotation.TabIndex = 4
        Me.ckQuotation.Text = "Add Attachment Document"
        Me.ckQuotation.UseVisualStyleBackColor = True
        '
        'txtDocDate
        '
        Me.txtDocDate.CustomFormat = "MMMM dd, yyyy"
        Me.txtDocDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDocDate.Location = New System.Drawing.Point(177, 242)
        Me.txtDocDate.Name = "txtDocDate"
        Me.txtDocDate.Size = New System.Drawing.Size(197, 23)
        Me.txtDocDate.TabIndex = 418
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(82, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 15)
        Me.Label6.TabIndex = 419
        Me.Label6.Text = "Document Date"
        '
        'catid
        '
        Me.catid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.catid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.catid.ForeColor = System.Drawing.Color.Black
        Me.catid.Location = New System.Drawing.Point(530, 192)
        Me.catid.Margin = New System.Windows.Forms.Padding(4)
        Me.catid.Name = "catid"
        Me.catid.Size = New System.Drawing.Size(67, 22)
        Me.catid.TabIndex = 420
        Me.catid.Visible = False
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
        'txtAttachedCount
        '
        Me.txtAttachedCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAttachedCount.BackColor = System.Drawing.Color.Transparent
        Me.txtAttachedCount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAttachedCount.Location = New System.Drawing.Point(251, 297)
        Me.txtAttachedCount.Name = "txtAttachedCount"
        Me.txtAttachedCount.Size = New System.Drawing.Size(142, 22)
        Me.txtAttachedCount.TabIndex = 422
        Me.txtAttachedCount.TabStop = True
        Me.txtAttachedCount.Text = "0 Attached Files"
        Me.txtAttachedCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'seriesno
        '
        Me.seriesno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.seriesno.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.seriesno.ForeColor = System.Drawing.Color.Black
        Me.seriesno.Location = New System.Drawing.Point(379, 38)
        Me.seriesno.Margin = New System.Windows.Forms.Padding(4)
        Me.seriesno.Name = "seriesno"
        Me.seriesno.Size = New System.Drawing.Size(52, 22)
        Me.seriesno.TabIndex = 423
        Me.seriesno.Visible = False
        '
        'frmNewDocument
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(629, 441)
        Me.Controls.Add(Me.seriesno)
        Me.Controls.Add(Me.txtAttachedCount)
        Me.Controls.Add(Me.mode)
        Me.Controls.Add(Me.catid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDocDate)
        Me.Controls.Add(Me.cmdAttachment)
        Me.Controls.Add(Me.ckQuotation)
        Me.Controls.Add(Me.txtReferenceNumber)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.refcode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtVerifyPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.txtDocumentTitle)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdset)
        Me.Controls.Add(Me.ckPasswordProtect)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmNewDocument"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Document Information"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDocumentTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtVerifyPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ckPasswordProtect As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents refcode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtReferenceNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdAttachment As System.Windows.Forms.Button
    Friend WithEvents ckQuotation As System.Windows.Forms.CheckBox
    Friend WithEvents txtDocDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents catid As System.Windows.Forms.TextBox
    Friend WithEvents mode As System.Windows.Forms.TextBox
    Friend WithEvents txtAttachedCount As System.Windows.Forms.LinkLabel
    Friend WithEvents seriesno As System.Windows.Forms.TextBox
End Class
