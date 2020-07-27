Imports System.Data.SqlClient


Public Class connection
    Public Shared myconnection As New SqlConnection

    Sub New()

        myconnection.ConnectionString = "Data Source=JAINIL-PC\SQLEXPRESS2;Initial Catalog=digitalr;Persist Security Info=True;User ID=sa;Password=jainil"

    End Sub

End Class
