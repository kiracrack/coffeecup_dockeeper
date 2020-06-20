Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmAccountInfo

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmNewDocument_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        mode.Text = ""
    End Sub
    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If LCase(globalusername) = "admin" Then
            ckadminuser.Enabled = True
        Else
            ckadminuser.Enabled = False
            ckadminuser.Checked = False
        End If
        If mode.Text = "edit" Then
            ShowInfo()
            ckChange.Visible = True
            txtPassword.ReadOnly = True
            txtVerify.ReadOnly = True
        Else
            CreateNewDocument()
            ckChange.Visible = False
            txtPassword.ReadOnly = False
            txtVerify.ReadOnly = False
        End If
    End Sub
    Public Sub CreateNewDocument()
        AccountId.Text = "AUTO"
        txtFullname.Text = ""
        txtPosition.Text = ""
        txtUsername.Text = ""
        txtFullname.Focus()
        txtPassword.Text = ""
        txtVerify.Text = ""
        mode.Text = ""
        ckChange.Visible = False
        txtPassword.ReadOnly = False
        txtVerify.ReadOnly = False
        If LCase(globalusername) = "admin" Then
            ckadminuser.Enabled = True
        Else
            ckadminuser.Enabled = False
            ckadminuser.Checked = False
        End If
    End Sub
 
    Public Sub ShowInfo()
        com.CommandText = "select * from tblaccounts where accountid='" & AccountId.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtFullname.Text = rst("fullname").ToString
            txtPosition.Text = rst("position").ToString
            txtUsername.Text = rst("username").ToString
            ckadminuser.Checked = rst("adminuser")
        End While
        rst.Close()

    End Sub
    Private Sub cmdset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdset.Click
        If txtFullname.Text = "" Then
            MessageBox.Show("Please enter fullname!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFullname.Focus()
            Exit Sub
        ElseIf txtPosition.Text = "" Then
            MessageBox.Show("Please enter position!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPosition.Focus()
            Exit Sub
        ElseIf txtUsername.Text = "" Then
            MessageBox.Show("Please enter username!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsername.Focus()
            Exit Sub
        ElseIf txtUsername.Text.Contains(" ") = True Then
            MessageBox.Show("Please enter username without spacing!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsername.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            If txtPassword.Text = "" And ckChange.Checked = True Then
                MessageBox.Show("Please enter password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtPassword.Focus()
                Exit Sub
            ElseIf txtVerify.Text = "" And ckChange.Checked = True Then
                MessageBox.Show("Please verify password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtVerify.Focus()
                Exit Sub
            ElseIf txtPassword.Text <> txtVerify.Text And ckChange.Checked = True Then
                MessageBox.Show("Your password did not match! please try again", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtVerify.Focus()
                Exit Sub
            End If
        Else
            If txtPassword.Text = "" Then
                MessageBox.Show("Please enter password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtPassword.Focus()
                Exit Sub
            ElseIf txtVerify.Text = "" Then
                MessageBox.Show("Please verify password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtVerify.Focus()
                Exit Sub
            ElseIf txtPassword.Text <> txtVerify.Text Then
                MessageBox.Show("Your password did not match! please try again", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtVerify.Focus()
                Exit Sub
            End If
        End If
        
        If MessageBox.Show("Are you sure you want to save Account? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "UPDATE tblaccounts set fullname='" & rchar(txtFullname.Text) & "', position='" & rchar(txtPosition.Text) & "', username='" & txtUsername.Text & "',  datereg=current_timestamp " & If(ckChange.Checked = True, ", password='" & EncryptTripleDES(UCase(txtUsername.Text) + txtPassword.Text) & "'", "") & ",adminuser=" & ckadminuser.CheckState & " where accountid='" & AccountId.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "insert into tblaccounts set fullname='" & rchar(txtFullname.Text) & "', position='" & rchar(txtPosition.Text) & "', username='" & txtUsername.Text & "',  datereg=current_timestamp, password='" & EncryptTripleDES(UCase(txtUsername.Text) + txtPassword.Text) & "',adminuser=" & ckadminuser.CheckState & "" : com.ExecuteNonQuery()
            End If
            CreateNewDocument() : frmUserAccounts.ShowDocumentList()
            MessageBox.Show("Account Successfully saved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
 
    Private Sub ckChange_CheckedChanged(sender As Object, e As EventArgs) Handles ckChange.CheckedChanged
        If ckChange.Checked = True Then
            txtPassword.ReadOnly = False
            txtVerify.ReadOnly = False
            txtPassword.Text = ""
            txtVerify.Text = ""
        Else
            txtPassword.ReadOnly = True
            txtVerify.ReadOnly = True
            txtPassword.Text = ""
            txtVerify.Text = ""
        End If
    End Sub
End Class