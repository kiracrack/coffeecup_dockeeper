Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class frmCategory
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtCategory.Text = "" Then
            MessageBox.Show("Please provide product name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCategory.Focus()

        End If
        If mode.Text = "edit" Then
            com.CommandText = "UPDATE tblcategory set description='" & txtCategory.Text & "' where id='" & id.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "INSERT into tblcategory set description='" & txtCategory.Text & "'" : com.ExecuteNonQuery()
        End If

        frmNewDocument.LoadCategory()
        LoadCategory() : txtCategory.Text = "" : mode.Text = "" : id.Text = ""
        ' MsgBox("Category successfully saved!", MsgBoxStyle.Information)
    End Sub

    Private Sub frmLoanAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategory()
    End Sub
    Public Sub LoadCategory()
        msda = New MySqlDataAdapter("select id, Description from tblcategory order by description asc", conn)
        MyDataGridView.DataSource = Nothing : dst = New DataSet
        msda.Fill(dst, 0)
        MyDataGridView.DataSource = dst.Tables(0)
        MyDataGridView.Columns("id").Visible = False

        txtCategory.Focus()
    End Sub



    Private Sub DuplicateItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuplicateItemToolStripMenuItem.Click
        id.Text = MyDataGridView.Item("id", MyDataGridView.CurrentRow.Index).Value().ToString
        txtCategory.Text = MyDataGridView.Item("Description", MyDataGridView.CurrentRow.Index).Value().ToString
        mode.Text = "edit"
    End Sub

    Private Sub DeleteCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteCategoryToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to continue?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            com.CommandText = "delete from tblcategory where id='" & MyDataGridView.Item("id", MyDataGridView.CurrentRow.Index).Value().ToString & "'" : com.ExecuteNonQuery()
            LoadCategory()
            MsgBox("Category successfully deleted!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtCategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCategory.KeyPress
        If e.KeyChar() = Chr(13) Then
            Button1.PerformClick()
        End If
    End Sub
     
End Class
