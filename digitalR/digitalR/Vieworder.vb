Imports System.Data.SqlClient
Imports System.Data

Public Class Vieworder

    Dim Command As New SqlCommand

    Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Backlbl.LinkClicked
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Close()
    End Sub
    Public Sub loadData()
        Dim str As String = "select  username,OrderDetails,OrderExtraNote,AmountTotal  from kitchenorderplace  where username='Arpita'"
        Dim command As New SqlCommand(str, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        DataGridView1.RowTemplate.Height = 80
        Adapter.Fill(table)
        DataGridView1.DataSource = table


    End Sub
    Private Sub Vieworder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub


    Public Sub FilterData(valueToSearch As String)
        Dim searchQuary As String = "Select foodItemName,foodPrice,AmountTotal from kitchenorderplace where username like '%" & valueToSearch & "%'"
        Dim command As New SqlCommand(searchQuary, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub





    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged
        FilterData(txtUserName.Text)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        FilterData(txtUserName.Text)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class