Imports Microsoft.AspNet.FriendlyUrls
Imports pos.BLL
Imports pos.BLL.DTO

Public Class RegisterPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub btnRegistration_Click(sender As Object, e As EventArgs)
        Try
            Dim _userBLL As New UserBLL()
            Dim _userDto As New UserCreateDTO()
            _userDto.Username = txtUsername.Text
            _userDto.Password = txtPassword.Text
            _userBLL.Insert(_userDto)

            ltMessage.Text = "<span class='alert alert-success'>User Registration Success</span><br/><br/>"
        Catch ex As Exception
            ltMessage.Text = "<span class='alert alert-danger'>Error: " & ex.Message & "</span><br/><br/>"
        End Try

        Response.Redirect("Login")



    End Sub

End Class