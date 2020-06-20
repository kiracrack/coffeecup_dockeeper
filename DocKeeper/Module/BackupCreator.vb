Imports System.IO.Packaging

Module BackupCreator
    Public Sub UploadBackupToZip(ByVal zipLocation As String, ByVal fileToAdd As String)
        If zipLocation = "" Then
            MessageBox.Show("Archived location not available!", "Error Uploading", _
              MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Using zip As Package = System.IO.Packaging.Package.Open(zipLocation, FileMode.OpenOrCreate)
            Dim destFilename As String = ".\" & rchar(Path.GetFileName(fileToAdd))
            Dim uri As Uri = PackUriHelper.CreatePartUri(New Uri(destFilename, UriKind.Relative))
            If zip.PartExists(uri) Then
                zip.DeletePart(uri)
            End If
            Dim part As PackagePart = zip.CreatePart(uri, "", CompressionOption.Normal)
            Using fileStream As New FileStream(fileToAdd, FileMode.Open, FileAccess.Read)
                Using dest As Stream = part.GetStream()
                    CopyStream(fileStream, dest)
                End Using
            End Using
        End Using
    End Sub
End Module
