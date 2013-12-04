
Class Site
    Inherits MasterPage


    Sub Page_Load(ByVal Src As Object, ByVal e As EventArgs)
        Dim Bd As PresenceModEntity


        btnLogin.Text = "Se déconnecter - " + Context.User.Identity.Name
    End Sub

    Sub Signout_Click(ByVal sender As Object, ByVal e As EventArgs)
        FormsAuthentication.SignOut()
        Response.Redirect("Logon.aspx")
    End Sub
End Class

