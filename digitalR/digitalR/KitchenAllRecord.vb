Imports System.Data.SqlClient
Public Class KitchenAllRecord

    Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")

    Private Sub KitchenAllRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim searchQuary As String = "SELECT * FROM kitchenorderplace ORDER BY OrderDate DESC"
        Dim command As New SqlCommand(searchQuary, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub
End Class