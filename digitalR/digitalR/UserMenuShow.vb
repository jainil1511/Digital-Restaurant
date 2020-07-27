Imports System.Data.SqlClient
Public Class UserMenuShow
    Dim Command As New SqlCommand
    Dim cbcolumn As New DataGridViewComboBoxColumn

    Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")

    Public Sub loadData()
        Dim str As String = "select fooditemName,rate,FoodDescription,FoodItemPhoto from Item "
        Dim command As New SqlCommand(str, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        DataGridView1.RowTemplate.Height = 90


        'cbcolumn.Name = "Quantity"
        'cbcolumn.Items.Add("elect")
        'For value As Integer = 1 To 10
        '    cbcolumn.Items.Add(value.ToString)

        'Next

        'DataGridView2.Columns.Add(cbcolumn)


        Dim iii As New DataGridViewColumn()

        iii = DataGridView1.Columns(2)
        '  iii.DataGridView.Columns = DataGridViewAutoSizeColumnsMode.DisplayedCells

        Dim imgc As New DataGridViewImageColumn()
        imgc = DataGridView1.Columns(3)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch


        Adapter.Fill(table)
        DataGridView1.DataSource = table

        'DataGridViewCellEventArgs    DataSource = table



    End Sub
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DigitalrDataSet.Item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.DigitalrDataSet.Item)
        loadData()



    End Sub
    Public Sub PanjabiItem()
        Dim str As String = "select fooditemName,rate,FoodDescription,FoodItemPhoto from Item where categoryid=2"
        Dim command As New SqlCommand(str, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub


    Private Sub btnPanjabi_Click(sender As Object, e As EventArgs) Handles btnPanjabi.Click
        PanjabiItem()
    End Sub

    Private Sub btnGujrati_Click(sender As Object, e As EventArgs) Handles btnGujrati.Click
        Dim str As String = "select fooditemName,rate,FoodDescription,FoodItemPhoto from Item where categoryid=3"
        Dim command As New SqlCommand(str, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
    Public Sub ChieneseItem()
        Dim str As String = "select fooditemName,rate,FoodDescription,FoodItemPhoto from Item where status='Available'"
        Dim command As New SqlCommand(str, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Adapter.Fill(table)
        DataGridView1.DataSource = table


    End Sub

    Private Sub btnChiensese_Click(sender As Object, e As EventArgs) Handles btnChiensese.Click
        ChieneseItem()
    End Sub

    Private Sub btnOther_Click(sender As Object, e As EventArgs) Handles btnOther.Click
        OtherItem()
    End Sub
    Public Sub OtherItem()
        Dim str As String = "select fooditemName,rate,FoodDescription,FoodItemPhoto from Item where categoryid=4 "
        Dim command As New SqlCommand(str, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub
    Private Sub lnllblClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnllblClose.LinkClicked
        Me.Close()
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick




        Dim Index = e.RowIndex
        If DataGridView1.Rows(Index).Selected = True Then

            MessageBox.Show("Your  Item Is Successfully Done??", "Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        Else
            MessageBox.Show("The Item Is Not Added", "Menu", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Dim dr As New System.Windows.Forms.DataGridViewRow
        Dim temp_data As String = ""
        For Each dr In Me.DataGridView1.SelectedRows
            'Me.DataGridView2.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(4).Value)
            temp_data = dr.Cells(0).Value
        Next

        Dim temp As Integer = 0
        If (DataGridView2.Rows.Count > 0) Then
            For i As Integer = 0 To DataGridView2.RowCount - 1

                For j As Integer = 0 To DataGridView2.ColumnCount - 1
                    If DataGridView2.Rows(i).Cells(0).Value.ToString = temp_data.ToString() Then
                        MsgBox("Item already exists ! Please remove and add it. ")
                        temp = 1
                        GoTo l
                    End If
                Next


            Next
        End If
l:
        If temp = 0 Then
            For Each dr In Me.DataGridView1.SelectedRows
                Me.DataGridView2.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, 1, dr.Cells(1).Value)
            Next
        End If



    End Sub



    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim index As Integer
        index = DataGridView2.CurrentCell.RowIndex
        DataGridView2.Rows.RemoveAt(index)


    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs)
        DataGridView2.ClearSelection()
    End Sub

    Private Sub btnorder_Click(sender As Object, e As EventArgs) Handles btnorder.Click
        kitchen.txtextranote.Text = txtExtraNote.Text




        Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")

        'If MessageBox.Show("Sure your order Is confirmed?? ", "Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then


        For x As Integer = 0 To DataGridView2.Rows.Count - 1


            Dim mycommand As New SqlCommand


            mycommand.Connection = myconnection
            If myconnection.State = ConnectionState.Closed Then
                myconnection.Open()
            End If


            mycommand.CommandText = "INSERT INTO kitchenorderplace(username,foodItemName,foodPrice,Quantity,OrderExtraNote, TableNo, OrderDate, AmountTotal)VALUES (@username,@foodItemName,@foodPrice,@Quantity,@OrderExtraNote,@TableNo,@OrderDate,@AmountTotal)"


            mycommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtUserName.Text
            mycommand.Parameters.Add("@foodItemName", SqlDbType.NVarChar).Value = DataGridView2.Rows(x).Cells(0).Value
            mycommand.Parameters.Add("@foodPrice", SqlDbType.NVarChar).Value = DataGridView2.Rows(x).Cells(1).Value
            mycommand.Parameters.Add("@Quantity", SqlDbType.NVarChar).Value = DataGridView2.Rows(x).Cells(2).Value
            mycommand.Parameters.Add("@OrderExtraNote", SqlDbType.NVarChar).Value = txtExtraNote.Text
            mycommand.Parameters.Add("@TableNo", SqlDbType.NVarChar).Value = txttablenumber.Text
            mycommand.Parameters.Add("@OrderDate", SqlDbType.DateTime).Value = dtporderdate.Value
            mycommand.Parameters.Add("@AmountTotal", SqlDbType.NVarChar).Value = txttotal.Text
            'mycommand.ExecuteNonQuery()
            If (mycommand.ExecuteNonQuery() > 0) Then
                MessageBox.Show("Your Order Is Confirmed", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
        Next

        myconnection.Close()
        ' If (mycommand.ExecuteNonQuery() > 0) Then

        MessageBox.Show("Your Order Is Confirmed", "Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
        myconnection.Close()
        '  Else
        ' MessageBox.Show("Your Order Is Not Confirmed.please Try Again", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End If
        'End If

        Try




        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        loadData()
    End Sub






    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    'Private Sub DataGridView1_EditingControlShowing(ByVal sender As System.Object, ByVal e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing

    '    Dim editingComboBox As ComboBox = e.Control
    '    AddHandler editingComboBox.SelectedIndexChanged, AddressOf Me.cbcolumn_SelectedValueChanged

    'End Sub


    'Private Sub cbcolumn_SelectedValueChanged(sender As Object, e As EventArgs)
    '    Dim dr As New System.Windows.Forms.DataGridViewRow
    '    For Each dr In Me.DataGridView1.SelectedRows
    '        Me.DataGridView2.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(4).Value)
    '    Next
    'End Sub



    Public Sub FilterData(valueToSearch As String)
        Dim searchQuary As String = "Select fooditemName,rate,FoodItemPhoto,FoodDescription from Item where fooditemName like '%" & valueToSearch & "%'"
        Dim command As New SqlCommand(searchQuary, myconnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles userSearch.TextChanged
        FilterData(userSearch.Text)
    End Sub

    'Private Sub btnserch_Click(sender As Object, e As EventArgs)
    '    FilterData(userSearch.Text)
    'End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
    Private Sub DataGridView2_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellEndEdit
        Try
            Dim iCell1 As Integer
            Dim icell2 As Integer
            Dim icellResult As Integer
            iCell1 = DataGridView2.CurrentRow.Cells(1).Value
            icell2 = DataGridView2.CurrentRow.Cells(2).Value
            If String.IsNullOrEmpty(iCell1) OrElse String.IsNullOrEmpty(icell2) Then Exit Sub
            If Not IsNumeric(iCell1) OrElse Not IsNumeric(icell2) Then Exit Sub
            icellResult = CDbl(iCell1) * CDbl(icell2)
            DataGridView2.CurrentRow.Cells(3).Value = icellResult
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub btncal_Click(sender As Object, e As EventArgs) Handles btncal.Click
        Dim total As Integer = 0
        For i As Integer = 0 To DataGridView2.Rows.Count - 1
            total += DataGridView2.Rows(i).Cells(3).Value

        Next
        txttotal.Text = total
        userPayment.txtamount.Text = txttotal.Text
        userPayment.txttable.Text = txttablenumber.Text
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class