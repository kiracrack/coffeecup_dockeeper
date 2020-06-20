Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing

Public Class frmDocumentList

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If LCase(globalusername) = "root" Then
            cmdRecover.Visible = True
        Else
            cmdRecover.Visible = False
        End If
        If globaladminuser = True Or LCase(globalusername) = "root" Then
            cmdDelete.Visible = True
        Else
            cmdDelete.Visible = False
        End If
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
            filterasof = " and date_format(datesaved,'%Y-%m-%d') <= '" + endSchedule.ToString("yyyy-MM-dd") + "' "
        Else
            filterasof = " and date_format(datesaved,'%Y-%m-%d') between '" + startSchedule.ToString("yyyy-MM-dd") + "' AND '" + endSchedule.ToString("yyyy-MM-dd") + "' "
        End If
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        If LCase(globalusername) = "root" Then
            msda = New MySqlDataAdapter("select refcode as 'Registration Code', doctitle as 'Document Title', Description, (select description from tblcategory where id =tbldocuments.category) as 'Category', referenceno as 'Reference #', date_format(docdate,'%Y-%m-%d') as 'Document Date',cast((select concat(count(*),' Attached File(s)') from tblattachmentlogs where refnumber=tbldocuments.refcode) as char) as 'Attachment', (select fullname from tblaccounts where accountid=tbldocuments.savedby) as 'Saved By', date_format(datesaved,'%Y-%m-%d %r') as 'Date Saved', passprotected as 'Protected',Deleted,(select fullname from tblaccounts where accountid=tbldocuments.deletedby) as 'Deleted By',date_format(datedeleted,'%Y-%m-%d %r') as 'Date Deleted' from tbldocuments where " _
                                        + " (refcode like '%" & txtsearch.Text & "%' or " _
                                        + " doctitle like '%" & txtsearch.Text & "%' or " _
                                        + " description like '%" & txtsearch.Text & "%' or " _
                                        + " (select description from tblcategory where id =tbldocuments.category)  like '%" & txtsearch.Text & "%' or " _
                                        + " referenceno like '%" & txtsearch.Text & "%' or " _
                                        + " date_format(docdate,'%Y-%m-%d') like '%" & txtsearch.Text & "%' or " _
                                        + " date_format(datesaved,'%Y-%m-%d') like '%" & txtsearch.Text & "%' or " _
                                        + " date_format(datedeleted,'%Y-%m-%d') like '%" & txtsearch.Text & "%' or " _
                                        + " (select fullname from tblaccounts where accountid=tbldocuments.savedby) like '%" & txtsearch.Text & "%' or " _
                                        + " (select fullname from tblaccounts where accountid=tbldocuments.deletedby) like '%" & txtsearch.Text & "%') " & If(txtsearch.Text = "", filterasof, "") & " order by doctitle asc", conn)
        Else
            msda = New MySqlDataAdapter("select refcode as 'Registration Code', doctitle as 'Document Title', Description, (select description from tblcategory where id =tbldocuments.category) as 'Category', referenceno as 'Reference #', date_format(docdate,'%Y-%m-%d') as 'Document Date',cast((select concat(count(*),' Attached File(s)') from tblattachmentlogs where refnumber=tbldocuments.refcode) as char) as 'Attachment',  (select fullname from tblaccounts where accountid=tbldocuments.savedby) as 'Saved By', date_format(datesaved,'%Y-%m-%d %r') as 'Date Saved', passprotected as 'Protected'  from tbldocuments where deleted=0 and " _
                                        + "  (refcode like '%" & txtsearch.Text & "%' or " _
                                        + " doctitle like '%" & txtsearch.Text & "%' or " _
                                        + " description like '%" & txtsearch.Text & "%' or " _
                                        + " (select description from tblcategory where id =tbldocuments.category)  like '%" & txtsearch.Text & "%' or " _
                                        + " referenceno like '%" & txtsearch.Text & "%' or " _
                                        + " date_format(docdate,'%Y-%m-%d') like '%" & txtsearch.Text & "%' or " _
                                        + " date_format(datesaved,'%Y-%m-%d') like '%" & txtsearch.Text & "%' or " _
                                        + " date_format(datedeleted,'%Y-%m-%d') like '%" & txtsearch.Text & "%' or " _
                                        + " (select fullname from tblaccounts where accountid=tbldocuments.savedby) like '%" & txtsearch.Text & "%' or " _
                                        + " (select fullname from tblaccounts where accountid=tbldocuments.deletedby) like '%" & txtsearch.Text & "%') " & If(txtsearch.Text = "", filterasof, "") & " order by doctitle asc", conn)
        End If
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Document Date", "Reference #", "Registration Code"}, DataGridViewContentAlignment.MiddleCenter)

        GridColumAutonWidth(MyDataGridView, {"Document Title"})

        MyDataGridView.Columns("Description").AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        MyDataGridView.Columns("Document Title").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        MyDataGridView.Columns("Description").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        GridColumnChoosed(MyDataGridView, Me.Text)
        'MyDataGridView.Columns("Document Title").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        'MyDataGridView.Columns("Document Title").Width = 250
        'MyDataGridView.Columns("Registration Code").Width = 160
        'MyDataGridView.Columns("Description").Width = 600
    End Sub

    Private Sub MyDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MyDataGridView.CellMouseDown
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.MyDataGridView.CurrentCell = Me.MyDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub ToolStripSplitButton1_Click(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.Click
        Me.Close()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        ShowDocumentList()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmNewDocument.Show(Me)
    End Sub

    Private Sub DeleteCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteCategoryToolStripMenuItem.Click
        If MyDataGridView.Item("Protected", MyDataGridView.CurrentRow.Index).Value() = True And LCase(globalusername) <> "root" Then
            frmConfirmPassword.refcode.Text = MyDataGridView.Item("Registration Code", MyDataGridView.CurrentRow.Index).Value().ToString
            frmConfirmPassword.ShowDialog(Me)
            If PasswordProtectConfirmed = False Then
                Exit Sub
            End If
            PasswordProtectConfirmed = False
        End If
        frmViewDocument.refcode.Text = MyDataGridView.Item("Registration Code", MyDataGridView.CurrentRow.Index).Value().ToString
        com.CommandText = "insert into tbldochistory set refcode='" & MyDataGridView.Item("Registration Code", MyDataGridView.CurrentRow.Index).Value().ToString & "',remarks='Viewing the document', historydate=current_timestamp, historyby='" & globaluserid & "'" : com.ExecuteNonQuery()
        frmViewDocument.ShowDialog(Me)
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        If MyDataGridView.Item("Protected", MyDataGridView.CurrentRow.Index).Value() = True And LCase(globalusername) <> "root" Then
            frmConfirmPassword.refcode.Text = MyDataGridView.Item("Registration Code", MyDataGridView.CurrentRow.Index).Value().ToString
            frmConfirmPassword.ShowDialog(Me)
            If PasswordProtectConfirmed = False Then
                Exit Sub
            End If
            PasswordProtectConfirmed = False
        End If
        frmNewDocument.mode.Text = "edit"
        frmNewDocument.refcode.Text = MyDataGridView.Item("Registration Code", MyDataGridView.CurrentRow.Index).Value().ToString
        frmNewDocument.Show(Me)
    End Sub

    Private Sub DeleteDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If MyDataGridView.Item("Protected", MyDataGridView.CurrentRow.Index).Value() = True And LCase(globalusername) <> "root" Then
            frmConfirmPassword.refcode.Text = MyDataGridView.Item("Registration Code", MyDataGridView.CurrentRow.Index).Value().ToString
            frmConfirmPassword.ShowDialog(Me)
            If PasswordProtectConfirmed = False Then
                Exit Sub
            End If
            PasswordProtectConfirmed = False
        End If
        If MessageBox.Show("Are you sure you want to delete selected document? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "update tbldocuments set deleted=1, deletedby='" & globaluserid & "', datedeleted=current_timestamp where refcode='" & MyDataGridView.Item("Registration Code", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            ShowDocumentList()
            MsgBox("Document successfully deleted", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If txtsearch.Text = "" Then Exit Sub
        If e.KeyChar() = Chr(13) Then
            ShowDocumentList()
        End If
    End Sub

    Private Sub cmdRecover_Click(sender As Object, e As EventArgs) Handles cmdRecover.Click
        If MessageBox.Show("Are you sure you want to restore selected document? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "update tbldocuments set deleted=0, deletedby='', datedeleted=null where refcode='" & MyDataGridView.Item("Registration Code", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            ShowDocumentList()
            com.CommandText = "insert into tbldochistory set refcode='" & MyDataGridView.Item("Registration Code", MyDataGridView.CurrentRow.Index).Value().ToString & "',remarks='Recover the document', historydate=current_timestamp, historyby='" & globaluserid & "'" : com.ExecuteNonQuery()
            MsgBox("Document successfully restored", MsgBoxStyle.Information)
        End If
    End Sub
 
    Private Sub ckasof_CheckedChanged(sender As Object, e As EventArgs) Handles ckasof.CheckedChanged
        If ckasof.Checked = True Then
            txtfrmdate.Enabled = False
        Else
            txtfrmdate.Enabled = True
        End If
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
     

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        PrintDatagridview(Me.Text, "Database Records", "", MyDataGridView, Me)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        ColumnGridSetup(Me.Text, MyDataGridView, Me)
    End Sub
End Class