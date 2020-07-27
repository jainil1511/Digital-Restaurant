Public Class UserHomePage

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        login.Show()
    End Sub


    Public Sub menu1()

    End Sub

    Private Sub btnoffer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnoffer.Click
        Offer.Show()
    End Sub

    Private Sub btnregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RegisterUser.Show()
    End Sub

    Private Sub btnorderstatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnorderstatus.Click
        Vieworder.Show()
    End Sub

    Private Sub btnrestinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrestinfo.Click
        RestuarantInformation.Show()
    End Sub


    Private Sub UserHomePage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logopb.Click

    End Sub

    Private Sub btnfeedback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfeedback.Click
        feedback.Show()
    End Sub


    Private Sub btnpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpayment.Click
        userPayment.Show()
    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        UserMenuShow.Show()
    End Sub
End Class