Imports System.Data.SqlClient

Public Class kitchen


    Dim Command As New SqlCommand
    ' Dim myconnection As SqlConnection
    Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")

    Public Sub loaddata()
        Dim searchQuary As String = "SELECT top 4  TableNo,username,foodItemName,Quantity FROM kitchenorderplace ORDER BY OrderDate DESC;"
        Dim command As New SqlCommand(searchQuary, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub
    Private Sub kitchen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Timer1.Enabled = True
        'Me.Refresh()
        loaddata()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnconorder1_Click(sender As Object, e As EventArgs) Handles btnconorder1.Click
        UserMenuShow.Show()
        MsgBox("Order Confirmed Successfully")


    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        KitchenAllRecord.Show()
        Dim Command As New SqlCommand
        ' Dim myconnection As SqlConnection
        Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")
    End Sub
    Public Sub loadAllRecord()
        Dim searchQuary As String = "SELECT top 4  TableNo,username,foodItemName,Quantity FROM kitchenorderplace ORDER BY OrderDate DESC "
        Dim command As New SqlCommand(searchQuary, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Refresh()
    End Sub

    Private Sub btnreferesh_Click(sender As Object, e As EventArgs) Handles btnreferesh.Click
        Timer1.Enabled = True
    End Sub

    Private Sub lnllblClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnllblClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class