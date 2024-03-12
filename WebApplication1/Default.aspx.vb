Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnKeTransaction_Click(sender As Object, e As EventArgs)
        Response.Redirect("TransaksiPembelian")
    End Sub
    Protected Sub btnKeLogout_Click(sender As Object, e As EventArgs)
        Session.Abandon()
        Response.Redirect("Login")
    End Sub



End Class