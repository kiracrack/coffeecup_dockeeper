Imports System.IO
Imports Shell32
Imports MySql.Data.MySqlClient

Module FileExtractor
    Dim detailsFile As StreamWriter = Nothing
    Public Function ExtractSpecificZipFile(ByVal UpdateFileName As String, ByVal version As String) As Boolean
        Dim Download_location As String = Application.StartupPath.ToString & "\UpdateVersion\" & UpdateFileName
        Dim Extract_location As String = System.IO.Path.GetTempPath() & "\CoffeecupUpdate"
        Try
            'If (System.IO.Directory.Exists(Extract_location)) Then
            '    My.Computer.FileSystem.DeleteDirectory(Extract_location, FileIO.DeleteDirectoryOption.DeleteAllContents)
            'End If

            Dim unzip As New ICSharpCode.SharpZipLib.Zip.FastZip
            unzip.ExtractZip(Download_location, Extract_location, Nothing)


            If System.IO.File.Exists(System.IO.Path.GetTempPath() & "\CoffeecupUpdater.bat") = True Then
                System.IO.File.Delete(System.IO.Path.GetTempPath() & "\CoffeecupUpdater.bat")
            End If
            Dim xstring As String = ""
            Dim addtimeout As String = "" : Dim xcopy As String = ""
            If Get_os_name() <> "Windows XP" Then
                addtimeout = "timeout 5" & Environment.NewLine
                xcopy = "xcopy /s """ & Extract_location & "\*.*"" """ & Application.StartupPath.ToString & "\"" /b/v/y/r/j"
            Else
                addtimeout = "ping -w 5000 -n 1 1.1.1.1" & Environment.NewLine
                xcopy = "xcopy /s """ & Extract_location & "\*.*"" """ & Application.StartupPath.ToString & "\"" /v/y/r"
            End If
            detailsFile = New StreamWriter(System.IO.Path.GetTempPath() & "\CoffeecupUpdater.bat", True)
            xstring = "@echo off" & Environment.NewLine _
                    + "color c" & Environment.NewLine _
                    + "@echo Updating Coffeecup Client v" & version & " in 5 seconds.." & Environment.NewLine _
                    + addtimeout _
                    + xcopy & Environment.NewLine _
                    + "echo msgbox ""Your system successfully updated! To view update features, please login your account and goto menu > About Coffeecup Client > View Complete Details"" > %tmp%\tmp.vbs" & Environment.NewLine _
                    + "cscript /nologo %tmp%\tmp.vbs" & Environment.NewLine _
                    + "del %tmp%\tmp.vbs"
            detailsFile.WriteLine(xstring)
            detailsFile.Close()

            Process.Start(System.IO.Path.GetTempPath() & "\CoffeecupUpdater.bat")
            End
            Return (True)
        Catch ex As Exception
            MessageBox.Show("Message:" & ex.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rst.Close()
            Return False
        End Try

    End Function

    Public Function ExtractBlobFiles(ByVal refno As String)
        Dim extract_location As String = Application.StartupPath.ToString & "\Extracted\"
        Dim myData As MySqlDataReader
        Dim rawData() As Byte
        Dim FileSize As UInt32
        Dim fs As FileStream
        Try
            If (System.IO.Directory.Exists(extract_location)) Then
                My.Computer.FileSystem.DeleteDirectory(extract_location, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            If (Not System.IO.Directory.Exists(extract_location)) Then
                System.IO.Directory.CreateDirectory(extract_location)
            End If

            For Each word In refno.Split(New Char() {","c})
                com.CommandText = "SELECT * FROM tblblobattachment where refnumber = '" & word & "'"
                myData = com.ExecuteReader
                While myData.Read
                    FileSize = myData.GetUInt32(myData.GetOrdinal("filesize"))
                    rawData = New Byte(FileSize) {}

                    myData.GetBytes(myData.GetOrdinal("attachment"), 0, rawData, 0, FileSize)

                    fs = New FileStream(Application.StartupPath.ToString & "\Extracted\" & myData("filename").ToString, FileMode.OpenOrCreate, FileAccess.Write)
                    fs.Write(rawData, 0, FileSize)
                    fs.Close()
                End While
                myData.Close()

            Next

            Process.Start("explorer.exe", extract_location)

        Catch ex As Exception
            myData.Close()
            MessageBox.Show("There was an error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return True
    End Function
End Module
