<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirmPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfirmPassword))
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtVerifyPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.refcode = New System.Windows.Forms.TextBox()
        Me.DeleteCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteCategoryToolStripMenuItem})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(129, 26)
        '
        'txtVerifyPassword
        '
        Me.txtVerifyPassword.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtVerifyPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtVerifyPassword.Location = New System.Drawing.Point(220, 35)
        Me.txtVerifyPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVerifyPassword.Name = "txtVerifyPassword"
        Me.txtVerifyPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtVerifyPassword.Size = New System.Drawing.Size(198, 20)
        Me.txtVerifyPassword.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(128, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 375
        Me.Label2.Text = "Enter Password"
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(219, 57)
        Me.cmdset.Name = "cmdset"
        Me.cmdset.Size = New System.Drawing.Size(200, 30)
        Me.cmdset.TabIndex = 374
        Me.cmdset.Text = "Confirm"
        Me.cmdset.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 15)
        Me.Label1.TabIndex = 376
        Me.Label1.Text = "This document is password protected. Please enter the document password."
        '
        'refcode
        '
        Me.refcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.refcode.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.refcode.ForeColor = System.Drawing.Color.Black
        Me.refcode.Location = New System.Drawing.Point(27, 66)
        Me.refcode.Margin = New System.Windows.Forms.Padding(4)
        Me.refcode.Name = "refcode"
        Me.refcode.Size = New System.Drawing.Size(78, 22)
        Me.refcode.TabIndex = 377
        Me.refcode.Visible = False
        '
        'DeleteCategoryToolStripMenuItem
        '
        Me.DeleteCategoryToolStripMenuItem.Image = Global.DocKeeper.My.Resources.Resources.inbox__minus
        Me.DeleteCategoryToolStripMenuItem.Name = "DeleteCategoryToolStripMenuItem"
        Me.DeleteCategoryToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.DeleteCategoryToolStripMenuItem.Text = "Delete File"
        '
        'frmConfirmPassword
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 99)
        Me.Controls.Add(Me.refcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtVerifyPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConfirmPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Document File Protected"
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtVerifyPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents refcode As System.Windows.Forms.TextBox

End Class
