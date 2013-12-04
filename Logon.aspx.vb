Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Data.SqlClient

Partial Class _Logon
    Inherits Page


    Sub Logon_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim Authentificate As New Provider(UserID.Text, StringToMd5(UserPass.Text))

        If Authentificate.ValidateUser() Then
            If Authentificate.IsAuthentifiate() = True Then
                FormsAuthentication.RedirectFromLoginPage _
                     (UserID.Text, Persist.Checked)
            Else
                Session("UserName") = UserID.Text
                Response.Redirect("./ChangePassword.aspx")
            End If
        Else
            Msg.Text = "L'usager ou le mot de passe sont incorrects!"
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

