Imports System.Data.SqlClient
Public Class AdminDailyreport

    Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")


    Public Sub loadData()
        Dim searchQuary As String = "select UserName,Feedback,Date from feedback"
        Dim command As New SqlCommand(searchQuary, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub

    Private Sub AdminDailyreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub Backlbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Backlbl.LinkClicked
        Me.Close()
    End Sub
End Class