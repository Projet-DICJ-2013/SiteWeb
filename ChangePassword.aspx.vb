
Partial Class ChangePassword
    Inherits System.Web.UI.Page

    Private Authentification As Provider

    Protected Sub btnChange_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnChange.Click


        Authentification = New Provider(Session("UserName"), StringToMd5(PassOld.Text))

        If (PassNew.Text = PassConf.Text) Then

            If Authentification.ChangePassword(StringToMd5(PassNew.Text)) Then
                FormsAuthentication.RedirectFromLoginPage(Session("UserName"), False)
            Else
                Msg.Text = "Erreur lors du changement du mot de passe"
            End If
        Else
            Msg.Text = "Les deux mots de passe doivent être pareils"
        End If
    End Sub

    Private Function StringToMd5(ByRef Content As String) As String
        Dim M5 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(Content)
        ByteString = M5.ComputeHash(ByteString)
        Dim FinalString As String = Nothing

        For Each byt As Byte In ByteString
            FinalString &= byt.ToString("x2")

        Next
        Return FinalString.ToUpper()
    End Function
End Class
