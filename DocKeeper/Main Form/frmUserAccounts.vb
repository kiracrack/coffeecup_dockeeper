Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing

Public Class frmUserAccounts

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If globaladminuser = True Or LCase(globalusername) = "root" Then
            cmdDelete.Visible = True
            ToolStripSeparator2.Visible = True
            cmdEdit.Visible = True
            cmdNew.Visible = True
            ToolStripSeparator3.Visible = True
        Else
            cmdEdit.Visible = False
            cmdDelete.Visible = False
            ToolStripSeparator2.Visible = False
            cmdNew.Visible = False
            ToolStripSeparator3.Visible = False
        End If
        ShowDocumentList()
    End Sub
   
    Public Sub ShowDocumentList()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select accountid as 'Account ID', Fullname, Position, Username, adminuser as 'Admin User', date_format(datereg,'%Y-%m-%d %r') as 'Date Registered' from tblaccounts where " _
                                        + " (accountid like '%" & txtsearch.Text & "%' or " _
                                        + " Fullname like '%" & txtsearch.Text & "%' or " _
                                        + " Position like '%" & txtsearch.Text & "%' or " _
                                        + " Username like '%" & txtsearch.Text & "%' or " _
                                        + " date_format(datereg,'%Y-%m-%d') like '%" & txtsearch.Text & "%') and username <> 'ROOT' order by Fullname asc", conn)

        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"Account ID", "Username", "Admin User"}, DataGridViewContentAlignment.MiddleCenter)
    End Sub



    Private Sub ToolStripSplitButton1_Click(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.Click
        Me.Close()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        ShowDocumentList()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        frmAccountInfo.Show(Me)
    End Sub

   
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        frmAccountInfo.mode.Text = "edit"
        frmAccountInfo.AccountId.Text = MyDataGridView.Item("Account ID", MyDataGridView.CurrentRow.Index).Value().ToString
        frmAccountInfo.Show(Me)
    End Sub

    Private Sub DeleteDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If MessageBox.Show("Are you sure you want to delete selected Account? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "delete from tblaccounts where accountid='" & MyDataGridView.Item("Account ID", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            ShowDocumentList()
            MsgBox("Account successfully deleted", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If txtsearch.Text = "" Then Exit Sub
        If e.KeyChar() = Chr(13) Then
            ShowDocumentList()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        PrintDatagridview(Me.Text, "Database Records", "", MyDataGridView, Me)
    End Sub
End Class