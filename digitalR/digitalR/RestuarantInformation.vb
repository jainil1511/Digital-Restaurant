Imports System.Data.SqlClient
Imports System.Data

Public Class RestuarantInformation
    Dim mycommans As New SqlCommand


    Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")


    Public Sub loadData()
        Dim searchQuary As String = "Select Id,ResPhoto,ResTitle,ResInfo from RestaurantInfo"
        Dim command As New SqlCommand(searchQuary, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Adapter.Fill(table)




    End Sub
    Private Sub RestuarantInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub
End Class