Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Data
Imports System.Management
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Data.OleDb

Module ConectionSetup
    Public provider As Globalization.CultureInfo = Globalization.CultureInfo.InvariantCulture
    Public li As String = Environment.NewLine
    Public Em As DataGridView

    Public GlobalSmtpHost As String
    Public GlobalSmtpPort As String
    Public GlobalSSLEnable As Boolean
    Public GlobalServerMail As String
    Public GlobalTargetMail As String
    Public GlobalServerPassword As String
    
    Public FileProperties As FileVersionInfo = FileVersionInfo.GetVersionInfo(Application.ExecutablePath)
    Public fversion As String = FileProperties.FileVersion.ToString.Remove(FileProperties.FileVersion.ToString.Length - 2, 2)
    Public dversion As Date = Date.ParseExact(fversion, "yy.M.d", provider)
    Public GlobalApplicationName As String = "Coffeecup Client"
    Public formclose As Boolean
    Public conn As New MySqlConnection
    Public msda As MySqlDataAdapter
    Public msda2 As MySqlDataAdapter
    Public dst As New DataSet
    Public dst2 As New DataSet
    Public com As New MySqlCommand
    Public rst As MySqlDataReader

    Public file_Attachment As String = Application.StartupPath.ToString & "\Resources\Attachment\"
    Public file_conn As String = Application.StartupPath.ToString & "\" & My.Application.Info.AssemblyName & ".conn"
     
    Public sqlserver As String
    Public sqlport As String
    Public sqluser As String
    Public sqlpass As String
    Public sqldatabase As String

    Public connclient As New MySqlConnection 'for MySQLDatabase Connection
    Public msdaclient As MySqlDataAdapter 'is use to update the dataset and datasource
    Public dstclient As New DataSet 'miniature of your table - cache table to client
    Public comclient As New MySqlCommand
    Public rstclient As MySqlDataReader
    Public ConnectedServer As Boolean = False

    Public clientserver As String
    Public clientport As String
    Public clientuser As String
    Public clientpass As String
    Public clientdatabase As String

    Public Function OpenMysqlConnection() As Boolean
        Dim strSetup As String = ""
        Dim sr As StreamReader = File.OpenText(file_conn)
        Dim br As String = sr.ReadLine() : sr.Close()
        strSetup = DecryptTripleDES(br) : Dim cnt As Integer = 0
        For Each word In strSetup.Split(New Char() {","c})
            If cnt = 0 Then
                sqlserver = word
            ElseIf cnt = 1 Then
                sqlport = word
            ElseIf cnt = 2 Then
                sqluser = word
            ElseIf cnt = 3 Then
                sqlpass = word
            ElseIf cnt = 4 Then
                sqldatabase = word
            End If
            cnt = cnt + 1
        Next
        Try
            conn.Close()
            conn = New MySql.Data.MySqlClient.MySqlConnection
            conn.ConnectionString = "server=" & sqlserver & "; Port=" & sqlport & "; user id=" & sqluser & "; password=" & sqlpass & "; database=" & sqldatabase & "; Connection Timeout=6000000 ; Allow Zero Datetime=True"
            conn.Open()
            com.Connection = conn
            com.CommandTimeout = 6000000
            com.CommandText = "set global max_allowed_packet=999999999;" : com.ExecuteNonQuery()
        Catch errMYSQL As MySqlException
            globallogin = False
            Return False
        End Try
        Return True
    End Function

    Public Function CheckConnectionServer() As Boolean
        Try
            conn.Close()
            conn = New MySql.Data.MySqlClient.MySqlConnection
            conn.ConnectionString = "server=" & sqlserver & "; Port=" & sqlport & "; user id=" & sqluser & "; password=" & sqlpass & "; database=" & sqldatabase & "; Connection Timeout=6000000 ; Allow Zero Datetime=True"
            conn.Open()
            com.Connection = conn
            com.CommandTimeout = 6000000
        Catch errMYSQL As MySqlException
            'MessageBox.Show("Can't connect database server on '" & sqlserver & "'", _
            '              "Connection Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function

    Public Function OpenClientServer() As Boolean
        Try
            connclient.Close()
            connclient = New MySql.Data.MySqlClient.MySqlConnection
            connclient.ConnectionString = "server=" & clientserver & "; Port=" & clientport & "; user id=" & clientuser & "; password=" & clientpass & "; database=" & clientdatabase & "; Connection Timeout=10; allow user variables=true"
            connclient.Open()
            comclient.Connection = connclient
            comclient.CommandTimeout = 6000000
            OpenClientServer = True

        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            OpenClientServer = False
            Return False
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            OpenClientServer = False
            Return False
        End Try
    End Function

    Public Class ComboBoxItem
        Private displayValue As String
        Private m_hiddenValue As String

        Public Sub New(ByVal d As String, ByVal h As String)
            displayValue = d
            m_hiddenValue = h
        End Sub

        Public ReadOnly Property HiddenValue() As String
            Get
                Return m_hiddenValue
            End Get
        End Property

        Public Overrides Function ToString() As String
            Return displayValue
        End Function
    End Class

    Public Function getGlobalTrnid(ByVal init As String, ByVal endid As String)
        Dim finalstr As String = Now.ToString("yyyyMMddhhmmss")

        finalstr = init & "-" & finalstr & "-" & endid
        Return finalstr
    End Function
    Public Function getGlobalRequestid(ByVal init As String, ByVal endid As String)
        Dim strs As Date
        Dim finalstr As String = ""

        com.CommandText = "select current_timestamp as trnid"
        rst = com.ExecuteReader
        While rst.Read
            strs = rst("trnid").ToString
            finalstr = strs.ToString("yyyy-MM-dd")
        End While
        rst.Close()
        finalstr = init & "-" & finalstr.Replace("-", "") & "-" & endid
        Return finalstr
    End Function

    'Public Function SendAttachment(ByVal refno As String, ByVal fileList() As String) As Boolean
    '    Dim FileSize As UInt32
    '    Dim rawData() As Byte
    '    Dim fs As FileStream

    '    Try
    '        For Each strfile As String In fileList
    '            If Not strfile = "" Then
    '                com = Nothing : rawData = Nothing : FileSize = Nothing
    '                fs = New FileStream(strfile, FileMode.Open, FileAccess.Read)
    '                FileSize = fs.Length

    '                rawData = New Byte(FileSize) {}
    '                fs.Read(rawData, 0, FileSize)
    '                fs.Close()
    '                com = New MySqlCommand : com.Connection = conn
    '                com.CommandText = "DELETE FROM tblblobattachment where refnumber='" & refno & "';" : com.ExecuteNonQuery()
    '                com.CommandText = "INSERT INTO tblblobattachment (refnumber,filename,extension,attachment,filesize,datesaved) " _
    '                    + " VALUES('" & refno & "','" & rchar(Path.GetFileName(strfile)) & "','" & Path.GetExtension(strfile) & "',?File,?FileSize,current_timestamp)"
    '                com.Parameters.Add("?File", rawData)
    '                com.Parameters.Add("?FileSize", FileSize)
    '                com.ExecuteNonQuery()
    '            End If
    '        Next
    '    Catch ex As Exception
    '        MessageBox.Show("Connection error during uploading attachment. click ok to retry upload.", "Error Uploading", _
    '            MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False
    '    End Try
    '    Return True
    'End Function
 
End Module
