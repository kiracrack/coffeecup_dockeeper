Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmNewDocument

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        'If keyData = (Keys.Escape) Then
        '    Me.Close()
        'End If
        Return ProcessCmdKey
    End Function

    Private Sub frmNewDocument_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If countqry("tblattachmentlogs", "refnumber='" & refcode.Text & "'") > 0 And countqry("tbldocuments", "refcode='" & refcode.Text & "'") = 0 Then
            If MessageBox.Show("Are you sure you want to cancel current transaction? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
                Dim to_delete As String = ""
                com.CommandText = "select * from tblattachmentlogs where refnumber='" & refcode.Text & "'" : rst = com.ExecuteReader
                While rst.Read
                    to_delete = to_delete + "delete from " & rst("databasename").ToString & " where refnumber='" & refcode.Text & "';" + Chr(13)
                    DelFileFromZip(rst("databasename").ToString.Replace("tbl", ""), rst("archievedname").ToString)
                End While
                rst.Close()
                If to_delete <> "" Then
                    com.CommandText = to_delete : com.ExecuteNonQuery()
                    com.CommandText = "delete from tblattachmentlogs where refnumber='" & refcode.Text & "'" : com.ExecuteNonQuery()
                End If
            Else
                e.Cancel = True
            End If
        End If
        mode.Text = ""
    End Sub
    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCategory()
        If mode.Text = "edit" Then
            ShowInfo()
        Else
            CreateNewDocument()
        End If
    End Sub
    Public Sub CreateNewDocument()
        Dim vno As String = getControlNumber(Now.Year.ToString, "tbldocuments")
        refcode.Text = Now.Year.ToString & "-" & CDate(Now).ToString("MM") & "-" & vno
        seriesno.Text = vno
        txtDocumentTitle.Text = ""
        txtDescription.Text = ""
        txtReferenceNumber.Text = ""
        txtDocDate.Value = Now
        mode.Text = ""
        ckPasswordProtect.Checked = False
        CountAttachment()
        txtDocumentTitle.Focus()
    End Sub
    
    Public Sub LoadCategory()
        LoadToComboBox("select * from tblcategory order by description asc", "description", "id", txtCategory)
    End Sub
    Public Sub CountAttachment()
        txtAttachedCount.Text = countqry("tblattachmentlogs", "refnumber='" & refcode.Text & "'") & " Attached File(s)"
    End Sub
    Public Sub ShowInfo()
        com.CommandText = "select *, (select description from tblcategory where id =tbldocuments.category) as 'catdesc' from tbldocuments where refcode='" & refcode.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDocumentTitle.Text = rst("doctitle").ToString
            txtDescription.Text = rst("description").ToString
            catid.Text = rst("category").ToString
            txtCategory.Text = rst("catdesc").ToString
            txtReferenceNumber.Text = rst("referenceno").ToString
            txtDocDate.Value = rst("docdate").ToString
            ckPasswordProtect.Checked = rst("passprotected")
            If rst("passprotected") = True Then
                txtNewPassword.Text = DecryptTripleDES(rst("password").ToString)
                txtVerifyPassword.Text = DecryptTripleDES(rst("password").ToString)
            End If
        End While
        rst.Close()
        CountAttachment()
    End Sub
    Private Sub cmdset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdset.Click
        If txtDocumentTitle.Text = "" Then
            MessageBox.Show("Please enter Document Title!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDocumentTitle.Focus()
            Exit Sub
        ElseIf txtDescription.Text = "" Then
            MessageBox.Show("Please enter short description of document!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescription.Focus()
            Exit Sub
        ElseIf txtCategory.Text = "" Then
            MessageBox.Show("Please select category!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCategory.Focus()
            Exit Sub
        ElseIf txtNewPassword.Text = "" And ckPasswordProtect.Checked = True Then
            MessageBox.Show("Please enter password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNewPassword.Focus()
            Exit Sub
        ElseIf txtVerifyPassword.Text = "" And ckPasswordProtect.Checked = True Then
            MessageBox.Show("Please verify password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVerifyPassword.Focus()
            Exit Sub
        ElseIf txtNewPassword.Text <> txtVerifyPassword.Text And ckPasswordProtect.Checked = True Then
            MessageBox.Show("Your password did not match! please try again", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVerifyPassword.Focus()
            Exit Sub

        End If
        If MessageBox.Show("Are you sure you want to save document? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "UPDATE tbldocuments set doctitle='" & rchar(txtDocumentTitle.Text) & "',description='" & rchar(txtDescription.Text) & "', category='" & catid.Text & "',referenceno='" & rchar(txtReferenceNumber.Text) & "',docdate='" & txtDocDate.Value.Date.ToString("yyyy-MM-dd") & "', passprotected=" & ckPasswordProtect.CheckState & ", password='" & If(ckPasswordProtect.Checked = True, EncryptTripleDES(txtVerifyPassword.Text), "") & "' where refcode='" & refcode.Text & "'" : com.ExecuteNonQuery()
                com.CommandText = "insert into tbldochistory set refcode='" & refcode.Text & "',remarks='" & If(mode.Text = "edit", "Editing the content", "Added new document") & "', historydate=current_timestamp, historyby='" & globaluserid & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tbldocuments set refcode='" & refcode.Text & "',seriesno='" & seriesno.Text & "',doctitle='" & rchar(txtDocumentTitle.Text) & "', description='" & rchar(txtDescription.Text) & "', category='" & catid.Text & "',referenceno='" & rchar(txtReferenceNumber.Text) & "',docdate='" & txtDocDate.Value.Date.ToString("yyyy-MM-dd") & "', datesaved=current_timestamp, savedby='" & globaluserid & "',passprotected=" & ckPasswordProtect.CheckState & ", password='" & If(ckPasswordProtect.Checked = True, EncryptTripleDES(txtVerifyPassword.Text), "") & "'" : com.ExecuteNonQuery()
                com.CommandText = "insert into tbldochistory set refcode='" & refcode.Text & "',remarks='" & If(mode.Text = "edit", "Editing the content", "Added new document") & "', historydate=current_timestamp, historyby='" & globaluserid & "'" : com.ExecuteNonQuery()
            End If
            
            CreateNewDocument()
            frmDocumentList.ShowDocumentList()
            MessageBox.Show("Document Successfully saved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub ckEnableEmailNotification_CheckedChanged(sender As Object, e As EventArgs) Handles ckPasswordProtect.CheckedChanged
        If ckPasswordProtect.Checked = True Then
            txtNewPassword.ReadOnly = False
            txtVerifyPassword.ReadOnly = False

        Else
            txtNewPassword.Text = ""
            txtVerifyPassword.Text = ""
            txtNewPassword.ReadOnly = True
            txtVerifyPassword.ReadOnly = True

        End If
    End Sub

    Private Sub cmda1_Click(sender As Object, e As EventArgs) Handles cmdAttachment.Click
        frmFileUploader.trncode.Text = refcode.Text
        frmFileUploader.ShowDialog(Me)
    End Sub

    Private Sub ckQuotation_CheckedChanged(sender As Object, e As EventArgs) Handles ckQuotation.CheckedChanged
        If ckQuotation.Checked = True Then
            cmdAttachment.Enabled = True
        Else
            cmdAttachment.Enabled = False
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmCategory.ShowDialog(Me)
    End Sub

    Private Sub ToolStripSplitButton1_Click(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.Click
        Me.Close()
    End Sub

  
    Private Sub txtCategory_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtCategory.SelectedValueChanged
        If mode.Text = "edit" Or mode.Text = "view" Then Exit Sub
        If txtCategory.Text <> "" Then
            catid.Text = DirectCast(txtCategory.SelectedItem, ComboBoxItem).HiddenValue()
        End If
    End Sub

    Private Sub txtAttachedCount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles txtAttachedCount.LinkClicked
        frmFileViewer.trncode.Text = refcode.Text
        frmFileViewer.ShowDialog(Me)
    End Sub
End Class