Imports System.Data.SqlClient
Public Class feedback
    Dim myconnection As New SqlConnection("Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil")
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfeedback.TextChanged

    End Sub


    Public Sub feedbackData()
        Dim mycommand As New SqlCommand
        mycommand.Connection = myconnection
        mycommand.CommandText = "INSERT INTO feedback (UserName,Feedback,Date)VALUES (@UserName,@Feedback,@Date)"

        Try
            myconnection.Open()
            mycommand.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = txtuname.Text
            mycommand.Parameters.Add("@Feedback", SqlDbType.NVarChar).Value = txtfeedback.Text
            mycommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = dtpDate.Value
            If MessageBox.Show("Sure Sent To A feedBack??", "FeedBack", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then

                If (mycommand.ExecuteNonQuery() > 0) Then
                    MessageBox.Show("Thank u For Your FeedBack", "FeedBack", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clearData()
                    Me.Hide()
                    UserHomePage.Show()

                    myconnection.Close()
                Else
                    MessageBox.Show("Something Error.Please Try Again Later", "FeedBack", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        feedbackData()

    End Sub
    Public Sub clearData()
        txtfeedback.Clear()
        txtuname.Clear()

    End Sub

    Private Sub txtcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcancel.Click
        Me.Close()
    End Sub

    Private Sub backlbl1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles backlbl1.LinkClicked
        Me.Close()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class