Imports System.Data
Imports System.Data.SqlClient
Public Class updateAdmin

    Dim myconnection As SqlConnection

    Dim mycommand As SqlCommand

    Dim dr As SqlDataReader

    Dim dr1 As SqlDataReader

    Dim ra As Integer

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        myconnection = New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")
        myconnection.Open()
        mycommand = New SqlCommand()

        mycommand.ExecuteNonQuery()


    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged

    End Sub
End Class