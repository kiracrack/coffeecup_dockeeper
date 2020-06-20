Imports System.Windows.Forms
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
 

Public Class MainForm
    Dim r As Rectangle = Screen.GetWorkingArea(Me)
    Private checkupdate As Boolean = True
    Dim bw As BackgroundWorker = New BackgroundWorker
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control) + Keys.F12 Then
            
        End If
        Return ProcessCmdKey
    End Function

#Region "Call Data Reload Function"
    Public Shared reloaddata As New MainForm()

    Public Sub New()
        reloaddata = Me
        InitializeComponent()
    End Sub
#End Region

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmUserlogoff.ShowDialog()
        If formclose = False Then
            e.Cancel = True
            Exit Sub
        End If
        For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
            If My.Application.OpenForms.Item(i) IsNot Me And My.Application.OpenForms.Item(i) IsNot frmLogin Then
                My.Application.OpenForms.Item(i).Close()
            End If
        Next i
        userexit()
        frmLogin.Show()
    End Sub

    Private Sub MDIMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        txtfullname.Text = globalfullname
        txtPosition.Text = globalposition
        txtDateLogin.Text = Format(Now, "MMMM dd, yyyy hh:mm:ss tt")
      
        PictureBox1.BackgroundImage = frmLogin.loadimage.Image
        LoadFormAreaSize()
        If globaladminuser = True Or LCase(globalusername) = "root" Then
            cmdUserLog.Visible = True
        Else
            cmdUserLog.Visible = False
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Public Sub LoadFormAreaSize()
        Me.Size = New Size(250, Screen.PrimaryScreen.WorkingArea.Height)
        Me.MaximumSize = New Size(254, Screen.PrimaryScreen.WorkingArea.Height)
        Me.MinimumSize = New Size(254, Screen.PrimaryScreen.WorkingArea.Height)
        Me.Location = New Point(r.Right - Me.Width, r.Bottom - Me.Height)
    End Sub
  
    Public Sub resizesignature()
        If loadimage.Image Is Nothing Then Exit Sub
        Dim Original As New Bitmap(loadimage.Image)
        loadimage.Image = Original

        Dim m As Int32 = PictureBox1.Width
        Dim n As Int32 = m * Original.Height / Original.Width

        Dim Thumb As New Bitmap(m, n, Original.PixelFormat)
        Thumb.SetResolution(Original.HorizontalResolution, Original.VerticalResolution)

        Dim g As Graphics = Graphics.FromImage(Thumb)
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High

        g.DrawImage(Original, New Rectangle(0, 0, m, n))
        loadimage.Image = Thumb

        loadimage.Image.Save(Application.StartupPath & "\logo.png")
        If MessageBox.Show("Please close your system to load your new logo! Are you sure you want to quit system?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            End
        End If

    End Sub

    Private Sub BrowsePictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrowsePictureToolStripMenuItem.Click
        ' (max size 163x163 png files)
        If MessageBox.Show("Please use PNG or GIF image file. (Max Resolution 163x163 Pixel size!). Are you sure you want to continue?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            Dim objOpenFileDialog As New OpenFileDialog
            'Set the Open dialog properties
            With objOpenFileDialog
                ' .Filter = "JPEG files (.jpg)|*.jpg , PNG files (.png)|*.png , GIF files (.gif)|*.gif"
                .Filter = "PNG files (*.png)|*.png|JPG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif"
                .FilterIndex = 1
                .Title = "Open File Dialog"
            End With

            'Show the Open dialog and if the user clicks the Open button,
            'load the file
            If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Dim allText As String
                Try
                    'Read the contents of the file
                    allText = My.Computer.FileSystem.GetParentPath(objOpenFileDialog.FileName)
                    loadimage.ImageLocation = objOpenFileDialog.FileName
                Catch fileException As Exception
                    Throw fileException
                End Try

            End If

            'Clean up
            objOpenFileDialog.Dispose()
            objOpenFileDialog = Nothing
        End If
    End Sub

    Private Sub loadimage_LoadCompleted1(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles loadimage.LoadCompleted
        resizesignature()
    End Sub

    Private Sub mainname_Click(sender As Object, e As EventArgs) Handles lblSystemName.Click
        frmSystemInfo.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
  
    Private Sub ConnectionSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectionSetupToolStripMenuItem.Click
        If LCase(globalusername) = "root" Then
            frmConnectionSetup.ShowDialog()
        Else
            MessageBox.Show("You are not allowed to enter this area!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
 
     
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        If frmSystemInfo.Visible = False Then
            frmSystemInfo.ShowDialog()
        Else
            frmSystemInfo.WindowState = FormWindowState.Normal
        End If
    End Sub

   
   
    Private Sub cmdPOS_Click(sender As Object, e As EventArgs) Handles cmdPOS.Click
        frmNewDocument.Show()
    End Sub

    Private Sub cmdPumpReading_Click(sender As Object, e As EventArgs) Handles cmdPumpReading.Click
        frmDocumentList.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.Close()
    End Sub

    Private Sub ChangeAccountPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeAccountPasswordToolStripMenuItem.Click
        If frmChangePassword.Visible = False Then
            frmChangePassword.ShowDialog()
        Else
            frmChangePassword.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdDownloadData_Click(sender As Object, e As EventArgs) Handles cmdDownloadData.Click
        If LCase(globalusername) = "root" Or globaladminuser = True Then
            If frmUserAccounts.Visible = False Then
                frmUserAccounts.Show()
            Else
                frmUserAccounts.WindowState = FormWindowState.Normal
            End If
        Else
            MessageBox.Show("You are not allowed to enter this area!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
      
    End Sub

    Private Sub ChangeLogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeLogoToolStripMenuItem.Click
        BrowsePictureToolStripMenuItem.PerformClick()
    End Sub

    Private Sub cmdChecktoCash_Click(sender As Object, e As EventArgs) Handles cmdChecktoCash.Click
        If LCase(globalusername) = "root" Or globaladminuser = True Then
            frmConfiguration.ShowDialog()
        Else
            MessageBox.Show("You are not allowed to enter this area!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cmdUserLog_Click(sender As Object, e As EventArgs) Handles cmdUserLog.Click
        frmUserLogSummary.Show()
    End Sub

    Private Sub AboutCoffeecupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutCoffeecupToolStripMenuItem.Click
        frmSystemInfo.ShowDialog(Me)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmSystemInfo.ShowDialog(Me)
    End Sub

    Private Sub cmdbackupDatabase_Click(sender As Object, e As EventArgs) Handles cmdbackupDatabase.Click
        frmBackupDatabase.ShowDialog(Me)
    End Sub
End Class
