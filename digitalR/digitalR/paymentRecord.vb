Imports System.Data.SqlClient
Public Class paymentRecord

    Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")

    Private Sub paymentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim searchQuary As String = "SELECT * FROM payment ORDER BY date DESC"
        Dim command As New SqlCommand(searchQuary, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub lnllblClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnllblClose.LinkClicked
        Me.Close()
    End Sub
End Class