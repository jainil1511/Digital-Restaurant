Imports System.Data
Imports System.Data.SqlClient

Public Class Register
    Dim Command As New SqlCommand
    Dim mycon As SqlConnection
    Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")


    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        InsertData()
    End Sub
    Public Sub InsertData()

        Dim mycommand As New SqlCommand


        mycommand.Connection = myconnection
        mycommand.CommandText = "INSERT INTO registration (username,password,name,birthdate,email,address,mobileno,nationality,dateofjoining,salary,designation)VALUES (@username,@password,@name,@birthdate,@email,@address,@mobileno,@nationality,@dateofjoining,@salary,@designation)"

        myconnection.Open()

        Try
            mycommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtUserName.Text
            mycommand.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtpass.Text
            mycommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtName.Text
            mycommand.Parameters.Add("@birthdate", SqlDbType.Date).Value = dtpdob.Value
            mycommand.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtEmail.Text
            mycommand.Parameters.Add("@address", SqlDbType.NVarChar).Value = txtaddress.Text
            mycommand.Parameters.Add("@mobileno", SqlDbType.NVarChar).Value = txtmobileno.Text
            mycommand.Parameters.Add("@nationality", SqlDbType.NVarChar).Value = txtnationality.Text
            mycommand.Parameters.Add("@dateofjoining", SqlDbType.Date).Value = dtpDateofjoining.Value
            mycommand.Parameters.Add("@salary", SqlDbType.NVarChar).Value = txtSalary.Text
            mycommand.Parameters.Add("@designation", SqlDbType.NVarChar).Value = txtDesignation.Text

            If MessageBox.Show("Are U sure Insert the Data", "insert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then


                If (mycommand.ExecuteNonQuery() > 0) Then
                    MessageBox.Show("Data are Inserted SuccessFully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearData()

                Else
                    MessageBox.Show("Data are Not Inserted SuccessFully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Required Fill The Details  ", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        myconnection.Close()

    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged

    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lnllblClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnllblClose.LinkClicked
        Me.Close()
        Admin.Show()
    End Sub



    Public Sub ClearData()
        txtpass.Clear()
        txtName.Clear()
        txtUserName.Clear()
        txtSalary.Clear()
        txtmobileno.Clear()
        txtnationality.Clear()
        txtDesignation.Clear()
        txtEmail.Clear()
        txtaddress.Clear()

    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearData()
    End Sub
End Class
