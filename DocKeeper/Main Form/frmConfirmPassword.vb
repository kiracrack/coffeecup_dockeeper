Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports System.Security
Imports System.IO

Public Class frmConfirmPassword
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmLoanAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub
    
    Private Sub cmdset_Click(sender As Object, e As EventArgs) Handles cmdset.Click
        If countqry("tbldocuments", "password='" & EncryptTripleDES(txtVerifyPassword.Text) & "' and refcode='" & refcode.Text & "'") = 1 Then
            PasswordProtectConfirmed = True
        Else
            MessageBox.Show("Invalid Password! please try again", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVerifyPassword.Focus()
            PasswordProtectConfirmed = False
            Exit Sub
        End If
        txtVerifyPassword.Text = ""
        Me.Close()
    End Sub
End Class
