Imports System.Data.SqlClient
Public Class offerupdate
    Dim Command As New SqlCommand

    Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")


    Public Sub FilterData(valueToSearch As String)
        Dim searchQuary As String = "Select OfferId,OfferName,Discount,OfferStartDate,OfferEndDate,AdminId,AdminDate from offer where OfferName like '%" & valueToSearch & "%'"
        Dim command As New SqlCommand(searchQuary, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
    Public Sub GetData()
        Dim searchQuary As String = "Select OfferId,OfferName,Discount,OfferStartDate,OfferEndDate,AdminId,AdminDate from offer"
        Dim command As New SqlCommand(searchQuary, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Adapter.Fill(table)
        DataGridView1.DataSource = table
        clearData()
    End Sub
    Private Sub offerupdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()

    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        GetData()
    End Sub


    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.SelectedRows(0).Cells(0).Value.ToString()

    End Sub
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        FilterData(txtsearch.Text)

    End Sub


    Public Sub updatedata()


        Dim str As String = "UPDATE offer set OfferId=@OfferId,OfferName=@OfferName,Discount=@Discount,OfferStartDate=@OfferStartDate,OfferEndDate=@OfferEndDate,AdminId=@AdminId,AdminDate=@AdminDate WHERE OfferId=@OfferId"
        Dim mycommand = New SqlCommand(str, myconnection)

        Try
            myconnection.Open()
            mycommand.Parameters.Add("@OfferId", SqlDbType.Int).Value = txtOfferID.Text
            mycommand.Parameters.Add("@OfferName", SqlDbType.NVarChar).Value = txtOfferName.Text
            mycommand.Parameters.Add("@Discount", SqlDbType.NVarChar).Value = txtOfferDiscount.Text
            mycommand.Parameters.Add("@OfferStartDate", SqlDbType.Date).Value = dtpOfferStartDate.Value
            mycommand.Parameters.Add("@OfferEndDate", SqlDbType.Date).Value = dtpOfferEndDate.Value
            mycommand.Parameters.Add("@AdminId", SqlDbType.NVarChar).Value = txtAdminID.Text
            mycommand.Parameters.Add("@AdminDate", SqlDbType.DateTime).Value = dtpAdminDate.Value

            If MessageBox.Show(" Are u Sure Update The Data", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) Then
                If (mycommand.ExecuteNonQuery() > 0) Then
                    MessageBox.Show("Data are updated SuccessFully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetData()
                    clearData()
                Else
                    MessageBox.Show("Offer Id Can't Be Change", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Required Fill  the Fields ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try
        myconnection.Close()
    End Sub
    Public Sub clearData()
        txtsearch.Clear()
        txtOfferName.Clear()
        txtOfferID.Clear()
        txtOfferDiscount.Clear()
        txtAdminID.Clear()
    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clearData()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            txtOfferID.Text = row.Cells(0).Value.ToString
            txtOfferName.Text = row.Cells(1).Value.ToString
            txtOfferDiscount.Text = row.Cells(2).Value.ToString
            dtpOfferStartDate.Text = row.Cells(3).Value.ToString
            dtpOfferEndDate.Text = row.Cells(4).Value.ToString
            txtAdminID.Text = row.Cells(5).Value.ToString
            dtpAdminDate.Text = row.Cells(6).Value.ToString
        End If


    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        FilterData(txtsearch.Text)
    End Sub

    Private Sub btnadd_Click_1(sender As Object, e As EventArgs)

    End Sub
    Public Sub Add()

        Dim mycommand As New SqlCommand


        mycommand.Connection = myconnection
        mycommand.CommandText = "INSERT INTO offer (OfferId,OfferName,Discount,OfferStartDate,OfferEndDate,AdminId,AdminDate)VALUES (@OfferId,@OfferName,@Discount,@OfferStartDate,@OfferEndDate,@AdminID,@AdminDate)"


        Try
            myconnection.Open()
            mycommand.Parameters.Add("@OfferId", SqlDbType.Int).Value = txtOfferID.Text
            mycommand.Parameters.Add("@OfferName", SqlDbType.NVarChar).Value = txtOfferName.Text
            mycommand.Parameters.Add("@Discount", SqlDbType.VarChar).Value = txtOfferDiscount.Text
            mycommand.Parameters.Add("@OfferStartDate", SqlDbType.Date).Value = dtpOfferStartDate.Value
            mycommand.Parameters.Add("@OfferEndDate", SqlDbType.Date).Value = dtpOfferEndDate.Value
            mycommand.Parameters.Add("@AdminId", SqlDbType.NVarChar).Value = txtAdminID.Text
            mycommand.Parameters.Add("@AdminDate", SqlDbType.Date).Value = dtpAdminDate.Value
            If MessageBox.Show("Are u sure?? Insert The Data", "Insert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                If (mycommand.ExecuteNonQuery() > 0) Then
                    MessageBox.Show("Data are Inserted SuccessFully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetData()
                    clearData()
                Else
                    MessageBox.Show("Data are Not Inserted SuccessFully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            End If


        Catch ex As Exception
            MessageBox.Show("Required Fll The Fields ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try
        myconnection.Close()

    End Sub
    Private Sub btnADD_Click_2(sender As Object, e As EventArgs) Handles btnADD.Click
        Add()

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        updatedata()
    End Sub


    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        delete()
    End Sub
    Public Sub delete()


        Dim mycommand As New SqlCommand

        mycommand.Connection = myconnection
        Dim str As String = "DELETE  from offer where OfferId=@OfferId"
        mycommand = New SqlCommand(str, myconnection)

        Try
            myconnection.Open()
            mycommand.Parameters.Add("@OfferId", SqlDbType.Int).Value = txtOfferID.Text

            If MessageBox.Show("Are u sure Delete The Data", "delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                If (mycommand.ExecuteNonQuery() > 0) Then
                    MessageBox.Show("Delete The Data", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetData()
                    clearData()
                End If
            Else
                MessageBox.Show("Data  Are Not Deleted,Please Enter OfferId", "delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Required Fil The Fields ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try
        myconnection.Close()
    End Sub

    Private Sub Backlbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Backlbl.LinkClicked
        Me.Close()
    End Sub


End Class
