Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmConfiguration

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
 
    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        com.CommandText = "select * from tblgeneralsettings" : rst = com.ExecuteReader
        While rst.Read
            txtorgname.Text = rst("orgname").ToString
            txtorgoffice.Text = rst("orgoffice").ToString
            txtorgtelephone.Text = rst("orgtelephone").ToString
            txtorgaddress.Text = rst("orgaddress").ToString
            CheckBox1.Checked = CBool(rst("headercenter"))

            txtFileMB.Text = Val(Val(rst("allowableattachsize").ToString) / 1024) / 1024
            txtFileDirectory.Text = rst("archiveddir").ToString
        End While
        rst.Close()
    End Sub
    Private Sub cmdset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdset.Click
        If txtorgname.Text = "" Then
            MessageBox.Show("Please enter organization name!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtorgname.Focus()
            Exit Sub
        ElseIf txtorgoffice.Text = "" Then
            MessageBox.Show("Please enter office name!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtorgoffice.Focus()
            Exit Sub
        ElseIf txtorgtelephone.Text = "" Then
            MessageBox.Show("Please enter telephone number!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtorgtelephone.Focus()
            Exit Sub
        ElseIf txtorgaddress.Text = "" Then
            MessageBox.Show("Please enter address!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtorgaddress.Focus()
            Exit Sub
        ElseIf txtFileMB.Text = "" Then
            MessageBox.Show("Please enter proper file size in MB!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFileMB.Focus()
            Exit Sub
        ElseIf txtFileDirectory.Text = "" Then
            MessageBox.Show("Please enter archieved directory!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFileDirectory.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to save Configuration? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "UPDATE tblgeneralsettings set orgname='" & rchar(txtorgname.Text) & "',orgoffice='" & rchar(txtorgoffice.Text) & "',orgtelephone='" & rchar(txtorgtelephone.Text) & "', orgaddress='" & rchar(txtorgaddress.Text) & "',headercenter=" & CheckBox1.CheckState & ", allowableattachsize='" & Val(CC(txtFileKB.Text)) * 1024 & "', archiveddir='" & rchar(txtFileDirectory.Text) & "'" : com.ExecuteNonQuery()
            LoadAccountDetails(globaluserid)
            MessageBox.Show("Configuration Successfully saved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub txtFullname_TextChanged(sender As Object, e As EventArgs) Handles txtFileMB.TextChanged
        txtFileKB.Text = FormatNumber(Val(CC(txtFileMB.Text)) * 1024, 2)
    End Sub
     
End Class