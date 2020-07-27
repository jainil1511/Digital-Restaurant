Imports System.Data
Imports System.Data.SqlClient

Public Class RegisterUser
    Dim myconnection As SqlConnection

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub


    Public Sub RegisterData()

        Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")
        Dim mycommand As New SqlCommand

        'Dim myconnection As SqlConnection
        mycommand.Connection = myconnection
        mycommand.CommandText = "INSERT INTO registration (username,birthdate,mobileno)VALUES (@username,@birthdate,@mobileno)"
        Try

            If myconnection.State = ConnectionState.Closed Then
                myconnection.Open()
                mycommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtusername.Text

                mycommand.Parameters.Add("@birthdate", SqlDbType.Date).Value = dofbirthday.Value
                mycommand.Parameters.Add("@mobileno", SqlDbType.NVarChar).Value = txtmonumber.Text
                If String.IsNullOrEmpty(txtusername.Text) AndAlso String.IsNullOrEmpty(txtmonumber.Text) Then
                    MessageBox.Show("All Fields Are Required", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf String.IsNullOrEmpty(txtusername.Text) Then
                    MessageBox.Show("User Name Required", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                ElseIf String.IsNullOrEmpty(txtmonumber.Text)
                    MessageBox.Show("Mobile Number Required", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                ElseIf MessageBox.Show("Are u sure Register The Data?? ", "Insert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then

                    If (mycommand.ExecuteNonQuery() > 0) Then
                        MessageBox.Show("Your Data Are  Registered", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        clearData()
                        UserHomePage.Show()
                        Me.Hide()
                        myconnection.Close()
                    Else
                        MessageBox.Show("Data are Not Inserted SuccessFully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            End If



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Private Sub btnregister_Click_1(sender As Object, e As EventArgs) Handles btnregister.Click
        UserMenuShow.txtUserName.Text = txtusername.Text
        Vieworder.txtUserName.Text = txtusername.Text
        userPayment.txtuname.Text = txtusername.Text
        RegisterData()

    End Sub

    Public Sub clearData()
        txtmonumber.Clear()
        txtusername.Clear()
    End Sub

    Private Sub txtmonumber_TextChanged(sender As Object, e As EventArgs) Handles txtmonumber.TextChanged
        If txtmonumber.Text.Length >= 11 Then

            MessageBox.Show("Phone number must be 10 digits", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning)


            txtmonumber.Text = ""

            txtmonumber.Focus()

        End If

    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        clearData()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub RegisterUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class