Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class ManageItem


    Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")


    Public Sub GetData()
        ' Dim ResPhoto As Image
        Dim searchQuary As String = "Select * from Item"
        Dim command As New SqlCommand(searchQuary, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Adapter.Fill(table)
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridView1.RowTemplate.Height = 100

        Dim imgc As New DataGridViewImageColumn()

        DataGridView1.DataSource = table

        imgc = DataGridView1.Columns(4)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch





    End Sub
    Private Sub ManageItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
    End Sub
    Private Sub btnStaffLoad_Click(sender As Object, e As EventArgs) Handles btnStaffLoad.Click
        GetData()
    End Sub


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)| *.jpg;*.png;*.gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            pcbItem.Image = Image.FromFile(opf.FileName)

        End If
        Dim ms As New MemoryStream
        pcbItem.Image.Save(ms, pcbItem.Image.RawFormat)
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click

        txtID.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtFoodItem.Text = DataGridView1.CurrentRow.Cells(1).Value

        txtItemName.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txtFoodDescription.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txtRate.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString

        txtCategoryID.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        txtFoodStatus.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        txtFoodAdminID.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString



    End Sub

    Public Sub ItemAdd()
        Dim mycommand As New SqlCommand


        mycommand.Connection = myconnection
        Dim ms As New MemoryStream
        pcbItem.Image.Save(ms, pcbItem.Image.RawFormat)
        Dim img() As Byte

        img = ms.ToArray


        mycommand.CommandText = "INSERT INTO Item (fooditemid,fooditemName,FoodDescription,FoodItemPhoto,categoryid,rate,status,adminId,admindate)VALUES (@fitem,@fitemName,@fdes,@img,@fcategoryid,@rate,@status,@adminId,@admindate)"

        myconnection.Open()

        Try

            mycommand.Parameters.Add("@fitem", SqlDbType.NVarChar).Value = txtFoodItem.Text
            mycommand.Parameters.Add("@fitemName", SqlDbType.NVarChar).Value = txtItemName.Text
            mycommand.Parameters.Add("@fdes", SqlDbType.NVarChar).Value = txtFoodDescription.Text
            mycommand.Parameters.Add("@fcategoryid", SqlDbType.NVarChar).Value = txtCategoryID.Text
            mycommand.Parameters.Add("@img", SqlDbType.VarBinary).Value = img

            mycommand.Parameters.Add("@rate", SqlDbType.NVarChar).Value = txtRate.Text
            mycommand.Parameters.Add("@status", SqlDbType.NVarChar).Value = txtFoodStatus.Text

            mycommand.Parameters.Add("@AdminId", SqlDbType.NVarChar).Value = txtFoodAdminID.Text
            mycommand.Parameters.Add("@AdminDate", SqlDbType.DateTime).Value = dtpFoodIAdminDate.Value
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


            MsgBox(ex.Message)

        End Try
        myconnection.Close()

    End Sub
    Private Sub btnItemAdd_Click(sender As Object, e As EventArgs) Handles btnItemAdd.Click
        ItemAdd()
    End Sub

    Private Sub txtItemName_TextChanged(sender As Object, e As EventArgs) Handles txtItemName.TextChanged

    End Sub

    Public Sub FilterData(valueToSearch As String)
        Dim searchQuary As String = "Select * from Item where fooditemName like '%" & valueToSearch & "%'"
        Dim command As New SqlCommand(searchQuary, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FilterData(txtfoodSearch.Text)
    End Sub

    Private Sub txtfoodSearch_TextChanged(sender As Object, e As EventArgs) Handles txtfoodSearch.TextChanged
        FilterData(txtfoodSearch.Text)
    End Sub


    Public Sub updatedata()
        'Dim mycommand As New SqlCommand


        Dim ms As New MemoryStream
        pcbItem.Image.Save(ms, pcbItem.Image.RawFormat)
        Dim img() As Byte

        img = ms.ToArray

        myconnection.Open()
        Dim str As String = "UPDATE Item set fooditemid=@fid,fooditemName=@fooditemName,FoodDescription=@FoodDescription,FoodItemPhoto=@img,categoryid=@categoryid,rate=@rate,status=@status,adminId=@adminId,admindate=@admindate WHERE ID=@ID"
        Dim mycommand = New SqlCommand(str, myconnection)

        Try

            mycommand.Parameters.Add("@ID", SqlDbType.Int).Value = txtID.Text
            mycommand.Parameters.Add("@fid", SqlDbType.NVarChar).Value = txtFoodItem.Text
            mycommand.Parameters.Add("@fooditemName", SqlDbType.NVarChar).Value = txtItemName.Text
            mycommand.Parameters.Add("@FoodDescription", SqlDbType.NVarChar).Value = txtFoodDescription.Text
            mycommand.Parameters.Add("@categoryid", SqlDbType.NVarChar).Value = txtCategoryID.Text
            mycommand.Parameters.Add("@img", SqlDbType.VarBinary).Value = img

            mycommand.Parameters.Add("@rate", SqlDbType.NVarChar).Value = txtRate.Text
            mycommand.Parameters.Add("@status", SqlDbType.NVarChar).Value = txtFoodStatus.Text

            mycommand.Parameters.Add("@adminId", SqlDbType.NVarChar).Value = txtFoodAdminID.Text
            mycommand.Parameters.Add("admindate", SqlDbType.DateTime).Value = dtpFoodIAdminDate.Value

            If MessageBox.Show(" Are u Sure Update The Data", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) Then
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
        myconnection.Close()
    End Sub

    Private Sub btnStaffUpdate_Click(sender As Object, e As EventArgs) Handles btnStaffUpdate.Click
        updatedata()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            txtID.Text = row.Cells(0).Value.ToString
            txtFoodItem.Text = row.Cells(1).Value.ToString
            txtItemName.Text = row.Cells(2).Value.ToString
            txtFoodDescription.Text = row.Cells(3).Value.ToString
            txtRate.Text = row.Cells(6).Value.ToString

            Dim bytes As [Byte]() = row.Cells(4).Value
            Dim ms As New MemoryStream(bytes)
            pcbItem.Image = Image.FromStream(ms)

            txtCategoryID.Text = row.Cells(5).Value.ToString
            txtFoodStatus.Text = row.Cells(7).Value.ToString
            txtFoodAdminID.Text = row.Cells(8).Value.ToString

        End If

    End Sub
    Public Sub deleteData()
        Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")
        Dim mycommand As New SqlCommand
        myconnection.Open()
        mycommand.Connection = myconnection
        Dim str As String = "DELETE  from Item where ID=@ID"
        mycommand = New SqlCommand(str, myconnection)

        Try

            mycommand.Parameters.Add("@ID", SqlDbType.NVarChar).Value = txtID.Text

            If MessageBox.Show("Are u sure Delete The Data", "delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                If (mycommand.ExecuteNonQuery() > 0) Then
                    MessageBox.Show("Delete The Data", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetData()
                    clearData()

                End If
            Else
                MessageBox.Show("Data  Are Not Deleted", "delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'please Enter Offer ID", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try
        myconnection.Close()
    End Sub
    Private Sub btnStaffDelete_Click(sender As Object, e As EventArgs) Handles btnStaffDelete.Click
        deleteData()
    End Sub
    Public Sub clearData()
        txtID.Clear()
        txtFoodItem.Clear()
        txtFoodDescription.Clear()
        txtCategoryID.Clear()
        txtfoodSearch.Clear()
        txtItemName.Clear()
        txtRate.Clear()
        txtFoodStatus.Clear()
    End Sub
    Private Sub btnStaffClear_Click(sender As Object, e As EventArgs) Handles btnStaffClear.Click
        clearData()
    End Sub

    Private Sub lnllblClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnllblClose.LinkClicked

        Me.Close()
        Admin.Show()
    End Sub
End Class