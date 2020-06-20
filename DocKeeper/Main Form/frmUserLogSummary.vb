Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing

Public Class frmUserLogSummary

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowDocumentList()
    End Sub
    Private Sub cmdlogin_Click(sender As Object, e As EventArgs) Handles cmdlogin.Click
        ShowDocumentList()
    End Sub
    Public Sub ShowDocumentList()
        Dim filterasof As String = ""
        Dim startSchedule As Date = txtfrmdate.Value.Date
        Dim endSchedule As Date = txttodate.Value.Date
        If ckasof.Checked = True Then
            filterasof = " and date_format(historydate,'%Y-%m-%d') <= '" + endSchedule.ToString("yyyy-MM-dd") + "' "
        Else
            filterasof = " and date_format(historydate,'%Y-%m-%d') between '" + startSchedule.ToString("yyyy-MM-dd") + "' AND '" + endSchedule.ToString("yyyy-MM-dd") + "' "
        End If
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select refcode as 'Document No.',(select doctitle from tbldocuments where refcode = tbldochistory.refcode) as 'Document', remarks as 'Action Taken', date_format(historydate,'%Y-%m-%d %r') as 'Date Action', (select fullname from tblaccounts where accountid=tbldochistory.historyby) as 'Action By' from tbldochistory where " _
                                        + " ((select doctitle from tbldocuments where refcode = tbldochistory.refcode) like '%" & txtsearch.Text & "%' or " _
                                        + " remarks like '%" & txtsearch.Text & "%' or " _
                                        + " (select fullname from tblaccounts where accountid=tbldochistory.historyby) like '%" & txtsearch.Text & "%' or " _
                                        + " date_format(historydate,'%Y-%m-%d') like '%" & txtsearch.Text & "%') " & filterasof & " order by historydate asc", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Document No."}, DataGridViewContentAlignment.MiddleCenter)
    End Sub

    Private Sub ToolStripSplitButton1_Click(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If txtsearch.Text = "" Then Exit Sub
        If e.KeyChar() = Chr(13) Then
            ShowDocumentList()
        End If
    End Sub

    Private Sub ckasof_CheckedChanged(sender As Object, e As EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        ShowDocumentList()
    End Sub

    Private Sub ExportToExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToExcelToolStripMenuItem.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                dst.WriteXml(f.SelectedPath & "\" & LCase(Me.Text) & ".xls")
                com.CommandText = "insert into tbldochistory set refcode='" & Me.Text & "',remarks='Exporting summary to excel', historydate=current_timestamp, historyby='" & globaluserid & "'" : com.ExecuteNonQuery()
                MessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub ckDeleted_CheckedChanged(sender As Object, e As EventArgs)
        ShowDocumentList()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        PrintDatagridview(Me.Text, "Database Records", "", MyDataGridView, Me)
    End Sub
End Class