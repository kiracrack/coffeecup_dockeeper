Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmViewDocument

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    
    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowInfo()
    End Sub

    Public Sub ShowInfo()
        com.CommandText = "select *, (select description from tblcategory where id =tbldocuments.category) as 'catdesc' from tbldocuments where refcode='" & refcode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDocumentTitle.Text = rst("doctitle").ToString
            txtDescription.Text = rst("description").ToString
            txtCategory.Text = rst("catdesc").ToString
            txtReferenceNumber.Text = rst("referenceno").ToString
            txtDocDate.Text = rst("docdate").ToString
            If rst("passprotected") = True Then
                cmdRemoveEncryption.Visible = True
            Else
                cmdRemoveEncryption.Visible = False
            End If
        End While
        rst.Close()
        showExistingFile()
    End Sub
    Public Sub showExistingFile()
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select filename as 'File Name',concat(format((filesize/1024),2),' KB') as 'File Size' from tblattachmentlogs where refnumber='" & refcode.Text & "'", conn)
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        GridColumnAlignment(MyDataGridView, {"File Sized"}, DataGridViewContentAlignment.MiddleRight)
    End Sub
    
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ViewAttachmentPackage_Database(refcode.Text)
        com.CommandText = "insert into tbldochistory set refcode='" & refcode.Text & "',remarks='Viewed document attachments', historydate=current_timestamp, historyby='" & globaluserid & "'" : com.ExecuteNonQuery()
    End Sub

    Private Sub cmdRemoveEncryption_Click(sender As Object, e As EventArgs) Handles cmdRemoveEncryption.Click
        If MessageBox.Show("Are you sure you want to remove password protection? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tbldocuments set passprotected=0, password='' where refcode='" & refcode.Text & "'" : com.ExecuteNonQuery()
            com.CommandText = "insert into tbldochistory set refcode='" & refcode.Text & "',remarks='Removed protected password', historydate=current_timestamp, historyby='" & globaluserid & "'" : com.ExecuteNonQuery()
            ShowInfo()
            MessageBox.Show("Password Successfully Removed!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class