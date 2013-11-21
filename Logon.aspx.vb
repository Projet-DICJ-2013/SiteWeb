
Partial Class _Logon
    Inherits Page


    Sub Logon_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim Authentificate As New Provider

        If Authentificate.ValidateUser(UserID.Text, UserPass.Text) Then
            FormsAuthentication.RedirectFromLoginPage _
                 (UserID.Text, Persist.Checked)
        Else
            Msg.Text = "L'usager ou le mot de passe sont incorrects!"
        End If

    End Sub

End Class
