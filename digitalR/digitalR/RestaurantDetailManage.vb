Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Drawing.Imaging

Public Class RestaurantDetailManage
    Dim mycommans As New SqlCommand


    Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")

    Private Sub btnResBrowse_Click(sender As Object, e As EventArgs) Handles btnResBrowse.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)| *.jpg;*.png;*.gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PcbResPhoto.Image = Image.FromFile(opf.FileName)

        End If
        Dim ms As New MemoryStream
        PcbResPhoto.Image.Save(ms, PcbResPhoto.Image.RawFormat)

    End Sub

    Public Sub addData()


        Dim mycommand As New SqlCommand


        mycommand.Connection = myconnection
        Dim ms As New MemoryStream
        PcbResPhoto.Image.Save(ms, PcbResPhoto.Image.RawFormat)
        Dim img() As Byte

        img = ms.ToArray


        mycommand.CommandText = "INSERT INTO RestaurantInfo(Id,ResPhoto,ResTitle,ResInfo)VALUES(@Id,@img,@ResTitle,@ResInfo)"

        myconnection.Open()

        Try

            mycommand.Parameters.Add("@id ", SqlDbType.Int).Value = txtResID.Text
            mycommand.Parameters.Add("@img", SqlDbType.VarBinary).Value = img
            mycommand.Parameters.Add("@ResTitle", SqlDbType.NVarChar).Value = txtResTitle.Text


            mycommand.Parameters.Add("@ResInfo", SqlDbType.NVarChar).Value = txtResDes.Text

            If MessageBox.Show("Are u sure?? Insert The Data", "Insert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                If (mycommand.ExecuteNonQuery() > 0) Then
                    MessageBox.Show("Data are Inserted SuccessFully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetData()
                    clearData()
                Else
                    MessageBox.Show("Data are Not Inserted SuccessFully,Required ID", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            End If


        Catch ex As Exception

            MessageBox.Show("There Are Something Error,Plese Try Again Later", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        myconnection.Close()

    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        addData()
    End Sub

    Public Sub GetData()
        Dim searchQuary As String = "Select Id,ResPhoto,ResTitle,ResInfo from RestaurantInfo"
        Dim command As New SqlCommand(searchQuary, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Adapter.Fill(table)

        DataGridView1.RowTemplate.Height = 80
        Dim imgc As New DataGridViewImageColumn
        'imgc = DataGridView1.CurrentRow.Cells(1).Value
        imgc.ImageLayout = DataGridViewImageCellLayout.Zoom
        DataGridView1.DataSource = table

    End Sub

    Private Sub RestaurantDetailManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            txtResID.Text = row.Cells(0).Value.ToString

            Dim bytes As Byte() = row.Cells(1).Value
            Dim ms As New MemoryStream(bytes)
            PcbResPhoto.Image = Image.FromStream(ms)


            txtResTitle.Text = row.Cells(2).Value.ToString
            txtResDes.Text = row.Cells(3).Value.ToString


        End If


    End Sub




    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        'PcbResPhoto.Image = DataGridView1.CurrentRow.Cells(0).Value
        'txtResTitle.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        'txtResDes.Text = DataGridView1.CurrentRow.Cells(2).Value
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        GetData()
        clearData()
    End Sub
    Public Sub clearData()

        txtResDes.Clear()
        txtResTitle.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearData()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        updatedata()
    End Sub

    Public Sub updatedata()
        'Dim mycommand As New SqlCommand


        Dim ms As New MemoryStream
        PcbResPhoto.Image.Save(ms, PcbResPhoto.Image.RawFormat)
        Dim img() As Byte

        img = ms.ToArray


        Dim str As String = "UPDATE RestaurantInfo set  ResPhoto=@img,ResTitle=@ResTitle,ResInfo=@ResInfo WHERE Id=@Id"
        Dim mycommand = New SqlCommand(str, myconnection)

        Try
            myconnection.Open()
            mycommand.Parameters.Add("@id", SqlDbType.Int).Value = txtResID.Text
            mycommand.Parameters.Add("@img", SqlDbType.VarBinary).Value = img
            mycommand.Parameters.Add("@ResTitle", SqlDbType.NVarChar).Value = txtResTitle.Text
            mycommand.Parameters.Add("@ResInfo", SqlDbType.NVarChar).Value = txtResDes.Text


            If MessageBox.Show(" Are u Sure Update The Data", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) Then
                If (mycommand.ExecuteNonQuery() > 0) Then
                    MessageBox.Show("Data are updated SuccessFully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetData()
                    clearData()

                Else
                    MessageBox.Show("ID can't be Change", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End If
            End If

        Catch ex As Exception
            MessageBox.Show("There Are Something Error,Plese Try Again Later", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            myconnection.Close()
        End Try
        myconnection.Close()
    End Sub
    Public Sub DeleteData()
        Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")
        Dim mycommand As New SqlCommand

        mycommand.Connection = myconnection
        Dim str As String = "DELETE  from RestaurantInfo where Id=@Id"
        mycommand = New SqlCommand(str, myconnection)

        Try
            myconnection.Open()

            mycommand.Parameters.Add("@ID", SqlDbType.Int).Value = txtResID.Text

            If MessageBox.Show("Are u sure Delete The Data", "delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
                If (mycommand.ExecuteNonQuery() > 0) Then
                    MessageBox.Show("Delete The Data", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GetData()
                    clearData()
                End If
            Else
                MessageBox.Show("Data  Are Not Deleted,Required ID", "delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("There Are Something Error,Plese Try Again Later", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        myconnection.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteData()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class