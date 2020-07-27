Imports System.Data.SqlClient
Public Class userPayment
    Dim Command As New SqlCommand
    Dim cbcolumn As New DataGridViewComboBoxColumn

    Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Backlbl.LinkClicked
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        UserHomePage.Close()
        Offer.Close()
        RegisterUser.Close()
        login.Close()
        RestuarantInformation.Close()
        Vieworder.Close()

        home.Show()
    End Sub

    Private Sub userPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")
        Dim mycommand As New SqlCommand


        mycommand.Connection = myconnection
        mycommand.CommandText = "INSERT INTO payment (tablenumber,username,amount,date)VALUES (@tablenumber,@username,@amount,@dtppayment)"
        Try

            If myconnection.State = ConnectionState.Closed Then
                myconnection.Open()
                mycommand.Parameters.Add("@tablenumber", SqlDbType.NVarChar).Value = txttable.Text

                mycommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtuname.Text
                mycommand.Parameters.Add("@amount", SqlDbType.NVarChar).Value = txtamount.Text
                mycommand.Parameters.Add("@dtppayment", SqlDbType.Date).Value = dtppayment.Value


                If (mycommand.ExecuteNonQuery() > 0) Then
                    MessageBox.Show("Payment Done!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    myconnection.Close()
                Else
                    MessageBox.Show("Data are Not Inserted SuccessFully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class