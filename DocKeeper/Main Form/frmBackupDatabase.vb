Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports System.Security
Imports System.IO

Public Class frmBackupDatabase
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmBackupDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtKey.Text = "Dockeeper " & GetDateTimeID() & ".zip"
    End Sub

    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        Dim StructureLocation As String = Application.StartupPath.ToString & "\Transaction\"
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Zip File (*.zip)|*.zip"
        saveFileDialog1.FileName = txtKey.Text
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim MyInput As String = txtKey.Text
            Dim process As System.Diagnostics.Process
            Dim processStartInfo As System.Diagnostics.ProcessStartInfo
            processStartInfo = New System.Diagnostics.ProcessStartInfo
            processStartInfo.FileName = "cmd.exe"

            processStartInfo.Arguments = "/C mysqldump --no-data --opt --host " & sqlserver & " --password=" & sqlpass & " --user=" & sqluser & " --database " & sqldatabase & " -r  """ & StructureLocation & "database.sql" & """"
            processStartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
            processStartInfo.UseShellExecute = True
            process = System.Diagnostics.Process.Start(processStartInfo)
            process.WaitForExit()
            If process.HasExited Then
                Dim copy_location As String = System.IO.Path.GetTempPath() & "Coffeecup"
                If (Not System.IO.Directory.Exists(copy_location)) Then
                    System.IO.Directory.CreateDirectory(copy_location)
                End If

                Dim sourceDirectoryInfo As New System.IO.DirectoryInfo(GlobalDatabaseLocation)
                For Each fileSystemInfo In sourceDirectoryInfo.GetFileSystemInfos
                    Dim destinationFileName As String = System.IO.Path.Combine(copy_location, fileSystemInfo.Name)
                    If fileSystemInfo.Name <> "Thumbs.db" Then
                        System.IO.File.Copy(fileSystemInfo.FullName, destinationFileName, True)
                    End If
                Next

                Dim BackupDirectoryInfo As New System.IO.DirectoryInfo(copy_location)
                For Each fileSystemInfo In BackupDirectoryInfo.GetFileSystemInfos
                    Dim destinationFileName As String = System.IO.Path.Combine(copy_location, fileSystemInfo.Name)
                    If fileSystemInfo.Name <> "Thumbs.db" Then
                        UploadBackupToZip(saveFileDialog1.FileName, fileSystemInfo.FullName)
                    End If
                Next
                UploadBackupToZip(saveFileDialog1.FileName, StructureLocation & "database.sql")
                MessageBox.Show("Database " & txtKey.Text & " Successfully Backed up!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If
        Try

        Catch errMS As Exception
            MessageBox.Show("Form:" & Me.Name & vbCrLf _
                         & "Message:" & errMS.Message & vbCrLf _
                         & "Details:" & errMS.StackTrace, _
                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
