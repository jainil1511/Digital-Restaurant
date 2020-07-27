Public Class MainHomepage
    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        'UserHomePage.Show()
        RegisterUser.Show()

    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        AdminLogin.Show()
    End Sub


    Private Sub btnKitchen_Click(sender As Object, e As EventArgs) Handles btnKitchen.Click
        KitchenLogin.Show()
    End Sub
End Class