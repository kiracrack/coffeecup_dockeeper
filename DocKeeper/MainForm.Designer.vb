<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.se1 = New System.Windows.Forms.ToolStripSeparator()
        Me.se2 = New System.Windows.Forms.ToolStripSeparator()
        Me.se4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.cmdPOS = New System.Windows.Forms.ToolStripButton()
        Me.linePOS = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPumpReading = New System.Windows.Forms.ToolStripButton()
        Me.linePumpReading = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdDownloadData = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdbackupDatabase = New System.Windows.Forms.ToolStripButton()
        Me.lineCheckToCash = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdChecktoCash = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtfullname = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.contextLogo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BrowsePictureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.lblSystemName = New System.Windows.Forms.Label()
        Me.txtDateLogin = New System.Windows.Forms.Label()
        Me.loadimage = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdUserLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeAccountPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeLogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectionSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutCoffeecupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contextLogo.SuspendLayout()
        CType(Me.loadimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'se1
        '
        Me.se1.Name = "se1"
        Me.se1.Size = New System.Drawing.Size(196, 6)
        '
        'se2
        '
        Me.se2.Name = "se2"
        Me.se2.Size = New System.Drawing.Size(196, 6)
        '
        'se4
        '
        Me.se4.Name = "se4"
        Me.se4.Size = New System.Drawing.Size(196, 6)
        '
        'ToolStrip
        '
        Me.ToolStrip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip.AutoSize = False
        Me.ToolStrip.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ToolStrip.CanOverflow = False
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.GripMargin = New System.Windows.Forms.Padding(0)
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPOS, Me.linePOS, Me.cmdPumpReading, Me.linePumpReading, Me.cmdDownloadData, Me.ToolStripSeparator3, Me.cmdbackupDatabase, Me.lineCheckToCash, Me.cmdChecktoCash, Me.ToolStripSeparator2, Me.ToolStripButton3})
        Me.ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Padding = New System.Windows.Forms.Padding(20, 240, 20, 0)
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip.Size = New System.Drawing.Size(237, 709)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'cmdPOS
        '
        Me.cmdPOS.ForeColor = System.Drawing.Color.DarkGray
        Me.cmdPOS.Image = Global.DocKeeper.My.Resources.Resources.cmdNewRequest
        Me.cmdPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdPOS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPOS.Name = "cmdPOS"
        Me.cmdPOS.Size = New System.Drawing.Size(196, 36)
        Me.cmdPOS.Text = "New Document"
        Me.cmdPOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPOS.ToolTipText = "Point of Sale"
        '
        'linePOS
        '
        Me.linePOS.Name = "linePOS"
        Me.linePOS.Size = New System.Drawing.Size(196, 6)
        '
        'cmdPumpReading
        '
        Me.cmdPumpReading.ForeColor = System.Drawing.Color.DarkGray
        Me.cmdPumpReading.Image = Global.DocKeeper.My.Resources.Resources.cmdSummaryOfExpenses
        Me.cmdPumpReading.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPumpReading.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdPumpReading.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPumpReading.Name = "cmdPumpReading"
        Me.cmdPumpReading.Size = New System.Drawing.Size(196, 36)
        Me.cmdPumpReading.Text = "Document Summary"
        Me.cmdPumpReading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'linePumpReading
        '
        Me.linePumpReading.Name = "linePumpReading"
        Me.linePumpReading.Size = New System.Drawing.Size(196, 6)
        '
        'cmdDownloadData
        '
        Me.cmdDownloadData.ForeColor = System.Drawing.Color.DarkGray
        Me.cmdDownloadData.Image = Global.DocKeeper.My.Resources.Resources.cmdUserAccountManagement
        Me.cmdDownloadData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDownloadData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdDownloadData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDownloadData.Name = "cmdDownloadData"
        Me.cmdDownloadData.Size = New System.Drawing.Size(196, 36)
        Me.cmdDownloadData.Text = "User Accounts"
        Me.cmdDownloadData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(196, 6)
        '
        'cmdbackupDatabase
        '
        Me.cmdbackupDatabase.ForeColor = System.Drawing.Color.DarkGray
        Me.cmdbackupDatabase.Image = Global.DocKeeper.My.Resources.Resources.database
        Me.cmdbackupDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdbackupDatabase.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdbackupDatabase.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdbackupDatabase.Name = "cmdbackupDatabase"
        Me.cmdbackupDatabase.Size = New System.Drawing.Size(196, 36)
        Me.cmdbackupDatabase.Text = "Backup Database"
        Me.cmdbackupDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lineCheckToCash
        '
        Me.lineCheckToCash.Name = "lineCheckToCash"
        Me.lineCheckToCash.Size = New System.Drawing.Size(196, 6)
        '
        'cmdChecktoCash
        '
        Me.cmdChecktoCash.ForeColor = System.Drawing.Color.DarkGray
        Me.cmdChecktoCash.Image = Global.DocKeeper.My.Resources.Resources.cmdGeneralSettings
        Me.cmdChecktoCash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdChecktoCash.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdChecktoCash.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdChecktoCash.Name = "cmdChecktoCash"
        Me.cmdChecktoCash.Size = New System.Drawing.Size(196, 36)
        Me.cmdChecktoCash.Text = " Configurations"
        Me.cmdChecktoCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(196, 6)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.DarkGray
        Me.ToolStripButton3.Image = Global.DocKeeper.My.Resources.Resources.cmdExitAll
        Me.ToolStripButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(196, 36)
        Me.ToolStripButton3.Text = "Exit Account"
        Me.ToolStripButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(196, 6)
        '
        'txtfullname
        '
        Me.txtfullname.BackColor = System.Drawing.Color.Transparent
        Me.txtfullname.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtfullname.ForeColor = System.Drawing.Color.White
        Me.txtfullname.Location = New System.Drawing.Point(7, 199)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(222, 19)
        Me.txtfullname.TabIndex = 334
        Me.txtfullname.Text = "WINTER BUGAHOD"
        Me.txtfullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPosition
        '
        Me.txtPosition.BackColor = System.Drawing.Color.Transparent
        Me.txtPosition.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.txtPosition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPosition.Location = New System.Drawing.Point(12, 218)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(212, 15)
        Me.txtPosition.TabIndex = 339
        Me.txtPosition.Text = "Administrator"
        Me.txtPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.ContextMenuStrip = Me.contextLogo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(238, 165)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'contextLogo
        '
        Me.contextLogo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BrowsePictureToolStripMenuItem})
        Me.contextLogo.Name = "ContextMenuStrip1"
        Me.contextLogo.Size = New System.Drawing.Size(146, 26)
        '
        'BrowsePictureToolStripMenuItem
        '
        Me.BrowsePictureToolStripMenuItem.Image = Global.DocKeeper.My.Resources.Resources.images_flickr
        Me.BrowsePictureToolStripMenuItem.Name = "BrowsePictureToolStripMenuItem"
        Me.BrowsePictureToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.BrowsePictureToolStripMenuItem.Text = "Change Logo"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(196, 52)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'lblSystemName
        '
        Me.lblSystemName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSystemName.BackColor = System.Drawing.Color.Transparent
        Me.lblSystemName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSystemName.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemName.ForeColor = System.Drawing.Color.White
        Me.lblSystemName.Location = New System.Drawing.Point(11, 675)
        Me.lblSystemName.Name = "lblSystemName"
        Me.lblSystemName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblSystemName.Size = New System.Drawing.Size(213, 13)
        Me.lblSystemName.TabIndex = 342
        Me.lblSystemName.Text = "Coffeecup DocKeeper"
        Me.lblSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDateLogin
        '
        Me.txtDateLogin.BackColor = System.Drawing.Color.Transparent
        Me.txtDateLogin.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.txtDateLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDateLogin.Location = New System.Drawing.Point(12, 233)
        Me.txtDateLogin.Name = "txtDateLogin"
        Me.txtDateLogin.Size = New System.Drawing.Size(212, 15)
        Me.txtDateLogin.TabIndex = 345
        Me.txtDateLogin.Text = "July 10, 2013 11:34:32 PM"
        Me.txtDateLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'loadimage
        '
        Me.loadimage.BackColor = System.Drawing.Color.Transparent
        Me.loadimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.loadimage.Location = New System.Drawing.Point(219, 239)
        Me.loadimage.Name = "loadimage"
        Me.loadimage.Size = New System.Drawing.Size(2, 2)
        Me.loadimage.TabIndex = 349
        Me.loadimage.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(238, 24)
        Me.MenuStrip1.TabIndex = 351
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdUserLog, Me.ChangeAccountPasswordToolStripMenuItem, Me.toolStripSeparator, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'cmdUserLog
        '
        Me.cmdUserLog.Image = Global.DocKeeper.My.Resources.Resources.book_open_list1
        Me.cmdUserLog.Name = "cmdUserLog"
        Me.cmdUserLog.Size = New System.Drawing.Size(216, 22)
        Me.cmdUserLog.Text = "User Log Summary"
        '
        'ChangeAccountPasswordToolStripMenuItem
        '
        Me.ChangeAccountPasswordToolStripMenuItem.Image = Global.DocKeeper.My.Resources.Resources.kgpg_term
        Me.ChangeAccountPasswordToolStripMenuItem.Name = "ChangeAccountPasswordToolStripMenuItem"
        Me.ChangeAccountPasswordToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ChangeAccountPasswordToolStripMenuItem.Text = "Change Account Password"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(213, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit..."
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeLogoToolStripMenuItem, Me.ConnectionSetupToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'ChangeLogoToolStripMenuItem
        '
        Me.ChangeLogoToolStripMenuItem.Image = Global.DocKeeper.My.Resources.Resources.images_flickr
        Me.ChangeLogoToolStripMenuItem.Name = "ChangeLogoToolStripMenuItem"
        Me.ChangeLogoToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ChangeLogoToolStripMenuItem.Text = "Change Logo"
        '
        'ConnectionSetupToolStripMenuItem
        '
        Me.ConnectionSetupToolStripMenuItem.Image = Global.DocKeeper.My.Resources.Resources.network_receive_21
        Me.ConnectionSetupToolStripMenuItem.Name = "ConnectionSetupToolStripMenuItem"
        Me.ConnectionSetupToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ConnectionSetupToolStripMenuItem.Text = "Connection Setup"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutCoffeecupToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutCoffeecupToolStripMenuItem
        '
        Me.AboutCoffeecupToolStripMenuItem.Image = Global.DocKeeper.My.Resources.Resources.information
        Me.AboutCoffeecupToolStripMenuItem.Name = "AboutCoffeecupToolStripMenuItem"
        Me.AboutCoffeecupToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AboutCoffeecupToolStripMenuItem.Text = "About DocKeeper"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(-3, 700)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(240, 17)
        Me.LinkLabel1.TabIndex = 353
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Win e-Soft Technologies"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(11, 682)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(213, 24)
        Me.Label1.TabIndex = 354
        Me.Label1.Text = "File Keeping and Tracking System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.DocKeeper.My.Resources.Resources.bg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(238, 733)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblSystemName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.loadimage)
        Me.Controls.Add(Me.txtDateLogin)
        Me.Controls.Add(Me.txtfullname)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "DocKeeper"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contextLogo.ResumeLayout(False)
        CType(Me.loadimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Public WithEvents se1 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents se2 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents se4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtfullname As System.Windows.Forms.Label
    Friend WithEvents txtPosition As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDownloadData As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblSystemName As System.Windows.Forms.Label
    Friend WithEvents txtDateLogin As System.Windows.Forms.Label
    Friend WithEvents contextLogo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BrowsePictureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents loadimage As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectionSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutCoffeecupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ChangeAccountPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents linePumpReading As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents cmdPOS As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPumpReading As System.Windows.Forms.ToolStripButton
    Friend WithEvents linePOS As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdChecktoCash As System.Windows.Forms.ToolStripButton
    Friend WithEvents lineCheckToCash As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ChangeLogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdUserLog As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdbackupDatabase As System.Windows.Forms.ToolStripButton

End Class
