﻿
Imports System.Data
Imports System.Data.SqlClient

Public Class login
    Dim mycon As SqlConnection


    Private Sub chkboxpass_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxpass.CheckedChanged

        If txtpass.UseSystemPasswordChar = True Then
            'Hide Password
            txtpass.UseSystemPasswordChar = False
        Else
            txtpass.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim connection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")
        Dim command As New SqlCommand("select * from registration where username=@username and password=@password", connection)
        command.Parameters.Add("@username", SqlDbType.VarChar).Value = txtuname.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = txtpass.Text
        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)
        If String.IsNullOrEmpty(txtuname.Text) AndAlso String.IsNullOrEmpty(txtpass.Text) Then
            MessageBox.Show("Fields Are Empty", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf String.IsNullOrEmpty(txtuname.Text)
            MessageBox.Show("Required User Name", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf String.IsNullOrEmpty(txtpass.Text)
            MessageBox.Show("Required Password", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf table.Rows.Count() <= 0 Then
            MessageBox.Show("Username or Password are Invalid", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            MessageBox.Show("login Successfully", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UserMenuShow.Show()
            Me.Hide()
        End If
    End Sub


    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub lblcreate_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblcreate.LinkClicked
        Register.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
