Imports System.Data.SqlClient
Public Class ManageStaffDetails

    Dim Command As New SqlCommand

    Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")

    Public Sub GetData()
        Dim searchQuary As String = "Select username,name,mobileno,birthdate,address,nationality,email,dateofjoining,designation,salary,adminid,admindate from Registration"
        Dim command As New SqlCommand(searchQuary, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Adapter.Fill(table)
        DataGridView1.DataSource = table
        clearData()
    End Sub
    Private Sub ManageStaffDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
        clearData()
    End Sub


    Public Sub FilterData(valueToSearch As String)
        Dim searchQuary As String = "Select username,name,mobileno,birthdate,address,nationality,email,dateofjoining,designation,salary,adminid,admindate from Registration where username like '%" & valueToSearch & "%'"
        Dim command As New SqlCommand(searchQuary, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FilterData(txtstaffSearch.Text)
    End Sub

    Private Sub txtstaffSearch_TextChanged(sender As Object, e As EventArgs) Handles txtstaffSearch.TextChanged
        FilterData(txtstaffSearch.Text)
    End Sub

    Private Sub btnStaffLoad_Click(sender As Object, e As EventArgs) Handles btnStaffLoad.Click
        GetData()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            txtstaffUserName.Text = row.Cells(0).Value.ToString
            txtStaffName.Text = row.Cells(1).Value.ToString
            txtStaffmobileno.Text = row.Cells(2).Value.ToString
            dtpStaffdob.Text = row.Cells(3).Value.ToString
            txtStaffaddress.Text = row.Cells(4).Value.ToString
            txtNationality.Text = row.Cells(5).Value.ToString
            txtStaffEmail.Text = row.Cells(6).Value.ToString
            dtpStaffDateofjoining.Text = row.Cells(7).Value.ToString
            txtStaffDesignation.Text = row.Cells(8).Value.ToString
            txtStaffSalary.Text = row.Cells(9).Value.ToString
            txtStaffAdminID.Text = row.Cells(10).Value.ToString
            dtpStaffAdminID.Text = row.Cells(11).Value.ToString
        End If

    End Sub
    Public Sub clearData()

        txtStaffDesignation.Clear()
        txtStaffAdminID.Clear()
        txtStaffaddress.Clear()
        txtNationality.Clear()
        txtstaffUserName.Clear()
        txtstaffSearch.Clear()
        txtStaffmobileno.Clear()
        txtStaffName.Clear()
        txtStaffEmail.Clear()
        txtStaffSalary.Clear()
    End Sub
    Private Sub btnStaffClear_Click(sender As Object, e As EventArgs) Handles btnStaffClear.Click
        clearData()
    End Sub

    Public Sub updatedata()
        Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")
        Dim str As String = "UPDATE registration set username=@username,name=@name,mobileno=@mobileno,birthdate=@birthdate,address=@address,nationality=@nationality,email=@email,dateofjoining=@dateofjoining,designation=@designation,salary=@salary,adminid=@adminid,admindate=@admindate WHERE username=@username"
        Dim mycommand = New SqlCommand(str, myconnection)
        If myconnection.State = ConnectionState.Closed Then
            Try
                myconnection.Open()
                mycommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtstaffUserName.Text
                mycommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtStaffName.Text
                mycommand.Parameters.Add("@mobileno", SqlDbType.NVarChar).Value = txtStaffmobileno.Text
                mycommand.Parameters.Add("birthdate", SqlDbType.Date).Value = dtpStaffdob.Value
                mycommand.Parameters.Add("address", SqlDbType.NVarChar).Value = txtStaffaddress.Text
                mycommand.Parameters.Add("nationality", SqlDbType.NVarChar).Value = txtNationality.Text
                mycommand.Parameters.Add("email", SqlDbType.NVarChar).Value = txtStaffEmail.Text
                mycommand.Parameters.Add("dateofjoining", SqlDbType.Date).Value = dtpStaffDateofjoining.Value
                mycommand.Parameters.Add("designation", SqlDbType.NVarChar).Value = txtStaffDesignation.Text
                mycommand.Parameters.Add("salary", SqlDbType.NVarChar).Value = txtStaffSalary.Text
                mycommand.Parameters.Add("@adminid", SqlDbType.NVarChar).Value = txtStaffAdminID.Text
                mycommand.Parameters.Add("@AdminDate", SqlDbType.DateTime).Value = dtpStaffAdminID.Value

                If MessageBox.Show("Sure Update The Data", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then

                    If (mycommand.ExecuteNonQuery() > 0) Then
                        MessageBox.Show("Data are updated SuccessFully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GetData()
                        clearData()
                    Else
                        MessageBox.Show("Data Are Not Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
        myconnection.Close()
    End Sub

    Private Sub btnStaffUpdate_Click(sender As Object, e As EventArgs) Handles btnStaffUpdate.Click
        updatedata()
    End Sub
    Public Sub DeleteData()
        Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")
        If myconnection.State = ConnectionState.Closed Then
            Dim mycommand As New SqlCommand

            mycommand.Connection = myconnection
            Dim str As String = "DELETE  from registration where username=@username"
            mycommand = New SqlCommand(str, myconnection)

            Try
                myconnection.Open()
                mycommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtstaffUserName.Text

                If MessageBox.Show("Are u sure Delete  the Data", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then


                    If (mycommand.ExecuteNonQuery() > 0) Then


                        MessageBox.Show("Delete The Data", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        GetData()
                        clearData()
                    Else
                        MessageBox.Show("there Are Something Error,Please try Again", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show("please Enter Offer ID", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub




    Private Sub btnStaffDelete_Click(sender As Object, e As EventArgs) Handles btnStaffDelete.Click
        DeleteData()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub lnllblClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnllblClose.LinkClicked
        Me.Close()
        Admin.Show()
    End Sub
End Class