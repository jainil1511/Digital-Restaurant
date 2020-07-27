Public Class Admin
    Private Sub btnlogin_Click(sender As Object, e As EventArgs)
        login.Show()
    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Register.Show()
    End Sub

    Private Sub btnorderdetails_Click(sender As Object, e As EventArgs) Handles btnorderdetails.Click
        adminorderview.Show()
    End Sub

    Private Sub btnoffer_Click(sender As Object, e As EventArgs) Handles btnoffer.Click
        offerupdate.Show()
    End Sub

    Private Sub btndailyreport_Click(sender As Object, e As EventArgs) Handles btndailyreport.Click
        AdminDailyreport.Show()
    End Sub
    Private Sub btnstaff_Click(sender As Object, e As EventArgs) Handles btnstaff.Click
        ManageStaffDetails.Show()
    End Sub

    Private Sub btnrestinfo_Click(sender As Object, e As EventArgs) Handles btnrestinfo.Click
        RestaurantDetailManage.Show()
    End Sub

    Private Sub btncategory_Click(sender As Object, e As EventArgs) Handles btncategory.Click
        category.Show()
    End Sub

    Private Sub btnkitchen_Click(sender As Object, e As EventArgs)
        kitchen.Show()
    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        ManageItem.Show()
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnpayment_Click(sender As Object, e As EventArgs) Handles btnpayment.Click
        paymentRecord.Show()
    End Sub
End Class