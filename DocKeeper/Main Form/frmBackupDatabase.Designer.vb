<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackupDatabase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackupDatabase))
        Me.cms_em = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.cms_em.SuspendLayout()
        Me.SuspendLayout()
        '
        'cms_em
        '
        Me.cms_em.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteCategoryToolStripMenuItem})
        Me.cms_em.Name = "ContextMenuStrip1"
        Me.cms_em.Size = New System.Drawing.Size(129, 26)
        '
        'DeleteCategoryToolStripMenuItem
        '
        Me.DeleteCategoryToolStripMenuItem.Image = Global.DocKeeper.My.Resources.Resources.inbox__minus
        Me.DeleteCategoryToolStripMenuItem.Name = "DeleteCategoryToolStripMenuItem"
        Me.DeleteCategoryToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.DeleteCategoryToolStripMenuItem.Text = "Delete File"
        '
        'cmdset
        '
        Me.cmdset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdset.Location = New System.Drawing.Point(122, 69)
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
        Me.Label1.Size = New System.Drawing.Size(421, 15)
        Me.Label1.TabIndex = 376
        Me.Label1.Text = "Please select file location to make database backup (Prefer External Hard Drive)"
        '
        'txtKey
        '
        Me.txtKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKey.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtKey.Location = New System.Drawing.Point(93, 40)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.ReadOnly = True
        Me.txtKey.Size = New System.Drawing.Size(260, 23)
        Me.txtKey.TabIndex = 377
        Me.txtKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmBackupDatabase
        '
        Me.AcceptButton = Me.cmdset
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 117)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBackupDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Backup"
        Me.cms_em.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cms_em As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdset As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKey As System.Windows.Forms.TextBox

End Class
