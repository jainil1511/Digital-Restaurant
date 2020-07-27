Imports System.Data.SqlClient

Public Class category
    Dim Command As New SqlCommand
    ' Dim myconnection As SqlConnection
    Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")

    Public Sub GetData()
        Dim searchQuary As String = "select categoryId,categoryName,status,adminId,adminDate from category"
        Dim command As New SqlCommand(searchQuary, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub
    Private Sub category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
    End Sub
    Private Sub btnCategoryLoad_Click(sender As Object, e As EventArgs) Handles btnCategoryLoad.Click
        GetData()
        clearData()


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            txtCategoryID.Text = row.Cells(0).Value.ToString

            txtCategoryName.Text = row.Cells(1).Value.ToString
            txtCategoryAvailable.Text = row.Cells(2).Value.ToString

            txtCategoryAdminID.Text = row.Cells(3).Value.ToString
            dtpCategoryAdminDate.Text = row.Cells(4).Value.ToString
        End If
    End Sub

    Public Sub FilterData(valueToSearch As String)
        Dim searchQuary As String = "Select categoryId,categoryName,status,adminId,adminDate from category where categoryName like '%" & valueToSearch & "%'"
        Dim command As New SqlCommand(searchQuary, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub btncategorySearch_Click(sender As Object, e As EventArgs) Handles btncategorySearch.Click
        FilterData(txtCategorySearch.Text)
    End Sub

    Private Sub txtCategorySearch_TextChanged(sender As Object, e As EventArgs) Handles txtCategorySearch.TextChanged
        FilterData(txtCategorySearch.Text)
    End Sub

    Public Sub clearData()
        txtCategoryID.Clear()
        txtCategoryName.Clear()
        txtCategoryAvailable.Clear()
        txtCategorySearch.Clear()
        txtCategoryAdminID.Clear()

    End Sub
    Private Sub btnCategoryClear_Click(sender As Object, e As EventArgs) Handles btnCategoryClear.Click

        clearData()
    End Sub

    Public Sub Add()
        Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")
        Dim mycommand As New SqlCommand


        mycommand.Connection = myconnection
        mycommand.CommandText = "INSERT INTO category ( categoryId,categoryName,status,adminId,adminDate)VALUES (@categoryId,@categoryName,@status,@adminId,@adminDate)"


        Try
            myconnection.Open()
            mycommand.Parameters.Add("@categoryId", SqlDbType.Int).Value = txtCategoryID.Text
            mycommand.Parameters.Add("@categoryName", SqlDbType.NVarChar).Value = txtCategoryName.Text
            mycommand.Parameters.Add("@status", SqlDbType.NVarChar).Value = txtCategoryAvailable.Text


            mycommand.Parameters.Add("@adminId", SqlDbType.NVarChar).Value = txtCategoryID.Text
            mycommand.Parameters.Add("@adminDate", SqlDbType.DateTime).Value = dtpCategoryAdminDate.Value

            If MessageBox.Show("Sure Insert The Data?? ", "Insert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then

                If (mycommand.ExecuteNonQuery() > 0) Then
                    MessageBox.Show("Data are Inserted SuccessFully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetData()
                    clearData()

                Else
                    MessageBox.Show("Data are Not Inserted SuccessFully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If



        Catch ex As Exception
            MessageBox.Show("Required Fill The Fields", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            myconnection.Close()
        End Try


    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Add()
    End Sub

    Public Sub updatedata()
        Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")
        Dim mycommand As New SqlCommand


        Dim str As String = "UPDATE category set categoryId=@categoryId,categoryName=@categoryName,status=@status,adminId=@adminId,admindate=@Admindate WHERE categoryId=@categoryId"

        mycommand.Connection = myconnection
        mycommand = New SqlCommand(str, myconnection)

        Try
            myconnection.Open()
            mycommand.Parameters.Add("@categoryId", SqlDbType.Int).Value = txtCategoryID.Text
            mycommand.Parameters.Add("@categoryName", SqlDbType.NVarChar).Value = txtCategoryName.Text
            mycommand.Parameters.Add("@status", SqlDbType.NVarChar).Value = txtCategoryAvailable.Text
            mycommand.Parameters.Add("@adminId", SqlDbType.NVarChar).Value = txtCategoryAdminID.Text
            mycommand.Parameters.Add("@admindate", SqlDbType.Date).Value = dtpCategoryAdminDate.Value

            If MessageBox.Show("Sure Update The Data??", "update", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                If (mycommand.ExecuteNonQuery() > 0) Then
                    MessageBox.Show("Data are updated SuccessFully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetData()
                    clearData()

                Else
                    MessageBox.Show("Category Id Cannnot Be changes", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If


        Catch ex As Exception
            MessageBox.Show("Required Fill the Fields", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            myconnection.Close()
        End Try


    End Sub

    Private Sub btnCategoryUpdate_Click(sender As Object, e As EventArgs) Handles btnCategoryUpdate.Click
        updatedata()
    End Sub
    Public Sub deleteData()

    End Sub
    Private Sub btnCategoryDelete_Click(sender As Object, e As EventArgs) Handles btnCategoryDelete.Click

        Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")
        Dim mycommand As New SqlCommand

        mycommand.Connection = myconnection
        Dim str As String = "DELETE  from category where categoryId=@categoryid"
        mycommand = New SqlCommand(str, myconnection)

        Try
            myconnection.Open()
            mycommand.Parameters.Add("@categoryId", SqlDbType.NVarChar).Value = txtCategoryID.Text

            If MessageBox.Show("Are u sure Delete  the Data", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then


                If (mycommand.ExecuteNonQuery() > 0) Then


                    MessageBox.Show("Delete The Data", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetData()
                    clearData()

                Else
                    MessageBox.Show("Category ID Can't Be Change", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Required Fill The Fields", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            myconnection.Close()
        End Try
    End Sub

    Private Sub lnllblClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnllblClose.LinkClicked
        Me.Close()
        Admin.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class