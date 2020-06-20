Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports System.Text
Imports System.Net
Imports System.Collections.Generic

Module library
    Public removechar As Char() = "\".ToCharArray()
    Public sb As New System.Text.StringBuilder
    Public imgBytes As Byte() = Nothing
    Public stream As MemoryStream = Nothing
    Public img As Image = Nothing
    Public sqlcmd As New MySqlCommand
    Public sql As String
    Public arrImage() As Byte = Nothing
    Public proFileImg As Boolean

    '----------------email variables ----------------
    Public SendTo(1) As String
    Public FileAttach(10) As String
    Public strSubject As String
    Public strMessage As String

#Region "GET OS NAME"
    Dim Full_Os_Name As String = My.Computer.Info.OSFullName
    Public Function Get_os_name() As String
        Get_os_name = ""
        If Full_Os_Name.Contains("Windows 7") Then
            Get_os_name = "Windows 7"
        ElseIf Full_Os_Name.Contains("Windows Vista") Then
            Get_os_name = "Windows Vista"
        ElseIf Full_Os_Name.Contains("Windows XP") Then
            Get_os_name = "Windows XP"
        Else
            Get_os_name = Full_Os_Name.ToString()
        End If
        Return Get_os_name
    End Function
#End Region

    Public Function rchar(ByVal str As String)
        str = str.Replace("'", "''")
        str = str.Replace("\", "\\")
        Return str
    End Function
    Public Function Rowcount(ByVal tbl As String)
        Dim cnt As Integer = 0
        com.CommandText = "SELECT count(*) as cnt from " & tbl : rst = com.ExecuteReader()
        While rst.Read
            cnt = rst("cnt")
        End While
        rst.Close()
        Return cnt
    End Function
    Public Function qrysingledata(ByVal field As String, ByVal fqry As String, ByVal tblandqry As String)
        Dim def As String = ""
        com.CommandText = "select " & fqry & " from " & tblandqry : rst = com.ExecuteReader
        While rst.Read
            def = rst(field).ToString
        End While
        rst.Close()
        Return def
    End Function

    Public Function countqry(ByVal tbl As String, ByVal cond As String)
        Dim cnt As Integer = 0
        com.CommandText = "select count(*) as cnt from " & tbl & " where " & cond
        rst = com.ExecuteReader
        While rst.Read
            cnt = Val(rst("cnt").ToString)
        End While
        rst.Close()
        Return cnt
    End Function

    Public Function GetDateTimeID()
        com.CommandText = "SELECT date_format(current_timestamp,'%Y%m%d-%r') as currtime" : rst = com.ExecuteReader()
        Dim removechar As Char() = ":/AMPM ".ToCharArray()
        Dim sb As New System.Text.StringBuilder
        While rst.Read()
            Dim str As String = rst("currtime").ToString
            For Each ch As Char In str
                If Array.IndexOf(removechar, ch) = -1 Then
                    sb.Append(ch)
                End If
            Next
        End While
        rst.Close()
        Return sb.ToString
    End Function
   
    Public Function CenterDashColumns(ByVal grdView As DataGridView) As DataGridView
        For Each clm As DataGridViewColumn In grdView.Columns
            If clm.Visible = True Then
                Dim visibility As Boolean = False
                For Each row As DataGridViewRow In grdView.Rows
                    If row.Cells(clm.Index).Value.ToString() = "-" Then
                        grdView.Columns(clm.Index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        grdView.Columns(clm.Index).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Exit For
                    End If
                Next
            End If
        Next
        Return grdView
    End Function
    Public Function UpdateImage(ByVal qry As String, ByVal fld As String, ByVal tbl As String, ByVal picbox As System.Windows.Forms.PictureBox)
        arrImage = Nothing
        Try
            If Not picbox.Image Is Nothing Then
                Dim mstream As New System.IO.MemoryStream()
                picbox.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()
                mstream.Close()
            End If

            sql = "Update " & tbl & " set " & fld & " = @file where " & qry

            With sqlcmd
                .CommandText = sql
                .Connection = conn
                .Parameters.AddWithValue("@file", arrImage)
                .ExecuteNonQuery()
            End With
            sqlcmd.Parameters.Clear()

        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf, _
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
    Public Function ShowImage(ByVal fld As String, ByVal picbox As System.Windows.Forms.PictureBox)
        Try
            If rst(fld).ToString <> "" Then
                imgBytes = CType(rst(fld), Byte())
                stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                img = Image.FromStream(stream)
                picbox.Image = img
                proFileImg = True
            Else
                picbox.Image = Global.DocKeeper.My.Resources.Resources.blankimg
                proFileImg = False
            End If
        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function

  
    Public Function countrecord(ByVal tbl As String)
        Dim cnt As Integer = 0
        com.CommandText = "select count(*) as cnt from " & tbl & " "
        rst = com.ExecuteReader
        While rst.Read
            cnt = rst("cnt")
        End While
        rst.Close()
        Return cnt
    End Function

    Public Function GridColumnAlignment(ByVal grdView As DataGridView, ByVal column As Array, ByVal alignment As DataGridViewContentAlignment) As DataGridView
        '   Dim array() As String = {a}
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    grdView.Columns(i).DefaultCellStyle.Alignment = alignment
                    grdView.Columns(i).HeaderCell.Style.Alignment = alignment
                End If
            Next
        Next
        Return grdView
    End Function

    Public Function GridCurrencyColumn(ByVal grdView As DataGridView, ByVal column As Array) As DataGridView
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    ' grdView.Columns(i).ValueType = System.Type.GetType("System.Decimal")
                    grdView.Columns(i).ValueType = GetType(Decimal)
                    grdView.Columns(i).DefaultCellStyle.Format = "n2"
                    grdView.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    grdView.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

                End If
            Next
        Next
        Return grdView
    End Function
    Public Function GridHideColumn(ByVal grdView As DataGridView, ByVal column As Array) As DataGridView
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    grdView.Columns(i).Visible = False
                End If
            Next
        Next
        Return grdView
    End Function
    Public Sub GridColumnChoosed(ByVal grdView As DataGridView, ByVal file_dir As String)
        If System.IO.File.Exists(Application.StartupPath & "\" & file_dir) = True Then
            Dim sr As StreamReader = File.OpenText(Application.StartupPath & "\" & file_dir)
            Try
                Dim columnChoosed As String = sr.ReadLine()
                For Each col In grdView.Columns
                    col.visible = False
                Next
                For Each strresult In DecryptTripleDES(columnChoosed).Split(New Char() {","c})
                    grdView.Columns(strresult).Visible = True
                Next
                sr.Close()
            Catch errMS As Exception
                MessageBox.Show("Message: Invalid column choosed format! Please update your column" & vbCrLf, _
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sr.Close()
            End Try
        End If

    End Sub
   Public Function LoadToComboBox(ByVal query As String, ByVal fields As String, ByVal id As String, ByVal cb As Windows.Forms.ComboBox)
        cb.Items.Clear()
        com.CommandText = query : rst = com.ExecuteReader
        While rst.Read
            If rst(fields).ToString <> "" Then
                cb.Items.Add(New ComboBoxItem(rst(fields).ToString, rst(id.ToString)))
            End If
        End While
        rst.Close()
        Return 0
    End Function
    Public Function CC(ByVal m As String)
        Return Val(m.Replace(",", ""))
    End Function
    Public Function CheckSelectedRow(ByVal value As String) As Boolean
        Try
            If value = "" Then
                MessageBox.Show("There is no item selected! make sure, the selection is on the list", globalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                CheckSelectedRow = False
            Else
                CheckSelectedRow = True
            End If
        Catch errMS As Exception
            MessageBox.Show("There is no item selected! make sure, the selection is on the list", globalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            CheckSelectedRow = False
        End Try
    End Function

    'Public Function qrysingledata(ByVal field As String, ByVal fqry As String, ByVal addwhere As String, ByVal tbl As String)
    '    Dim def As String = ""
    '    Try
    '        If countrecord(tbl) = 0 Then
    '            def = ""
    '        Else
    '            com.CommandText = "select " & fqry & " from " & tbl & " " & addwhere : rst = com.ExecuteReader
    '            While rst.Read
    '                def = rst(field).ToString
    '            End While
    '            rst.Close()
    '        End If
    '    Catch errMYSQL As MySqlException
    '        MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf _
    '                         & "Details:" & errMYSQL.StackTrace, _
    '                         "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '    Catch errMS As Exception
    '        MessageBox.Show("Message:" & errMS.Message & vbCrLf _
    '                         & "Details:" & errMS.StackTrace, _
    '                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    '    Return def
    'End Function

    Public Function checkAttachment(ByVal dir As String) As Boolean
        Dim fs1 As FileStream
        Try
            If dir <> "" Then
                If System.IO.File.Exists(dir) = True Then
                    fs1 = New FileStream(dir, FileMode.OpenOrCreate, FileAccess.Read)
                    Dim iFileSize As UInt32
                    iFileSize = fs1.Length
                    'MsgBox(iFileSize & " Bytes" & Environment.NewLine & (iFileSize / 1024) & " KB" & Environment.NewLine & (iFileSize / 1024) / 1024 & " MB")
                    If iFileSize > GlobalAllowableAttachSize Then
                        Return False
                    End If
                End If
            End If
        Catch errMS As Exception
            MessageBox.Show("Module:" & "Image Attachment" & vbCrLf _
                               & "Message:" & errMS.Message, vbCrLf _
                               & "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function

    Public Function GridColumAutonWidth(ByVal grdView As DataGridView, ByVal column As Array) As DataGridView
        For Each valueArr As String In column
            For i = 0 To grdView.ColumnCount - 1
                If valueArr = grdView.Columns(i).Name Then
                    grdView.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                End If
            Next
        Next
        Return grdView
    End Function

    Public Function InputNumberOnly(ByVal textbox As System.Windows.Forms.TextBox, e As KeyPressEventArgs)
        Dim keyChar = e.KeyChar
        If Char.IsControl(keyChar) Then
        ElseIf Char.IsDigit(keyChar) OrElse keyChar = "."c Then
            Dim text = textbox.Text
            Dim selectionStart = textbox.SelectionStart
            Dim selectionLength = textbox.SelectionLength
            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 16 Then
                'Reject an integer that is longer than 16 digits.
                e.Handled = True
            End If
        Else
            'Reject all other characters.
            e.Handled = True
        End If
    End Function
    Public Function RemoveEmptyColumns(ByVal grdView As DataGridView) As DataGridView
        For Each clm As DataGridViewColumn In grdView.Columns
            Dim visibility As Boolean = False
            For Each row As DataGridViewRow In grdView.Rows
                If row.Cells(clm.Index).Value.ToString() <> String.Empty Or Val(row.Cells(clm.Index).Value.ToString()) <> 0 Then
                    visibility = True
                    Exit For
                End If
            Next
            ' MsgBox(clm.Name)
            If clm.Name <> "id" And clm.Name <> "productid" Then
                grdView.Columns(clm.Name).Visible = visibility
            End If
        Next
        Return grdView
    End Function

    Public Function getControlNumber(ByVal year As String, ByVal table As String)
        Dim strng As Integer = 1 : Dim newNumber As String = "" : Dim NumberLen As Integer = 3
        com.CommandText = "select seriesno from " & table & " where date_format(datesaved,'%Y')='" & year & "' order by seriesno desc limit 1" : rst = com.ExecuteReader()
        While rst.Read
            'NumberLen = rst("seriesno").ToString.Length
            strng = Val(rst("seriesno").ToString) + 1
        End While
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 10 Then
                newNumber = "0000000000" & strng
            ElseIf a = 9 Then
                newNumber = "000000000" & strng
            ElseIf a = 8 Then
                newNumber = "00000000" & strng
            ElseIf a = 7 Then
                newNumber = "0000000" & strng
            ElseIf a = 6 Then
                newNumber = "000000" & strng
            ElseIf a = 5 Then
                newNumber = "00000" & strng
            ElseIf a = 4 Then
                newNumber = "0000" & strng
            ElseIf a = 3 Then
                newNumber = "000" & strng
            ElseIf a = 2 Then
                newNumber = "00" & strng
            ElseIf a = 1 Then
                newNumber = "0" & strng
            Else
                newNumber = strng
            End If
        Else
            newNumber = strng
        End If
        Return newNumber
    End Function

     
End Module
