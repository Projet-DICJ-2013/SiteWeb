Imports Microsoft.VisualBasic

Public Module ModProvider

    Public Class Provider

        Private _UserName As String
        Private _PassWord As String
        Private _BD As New PresenceModEntity

        'L'Objet recoit le mot de passe et le username
        Public Sub New(username As String, password As String)
            _UserName = username
            _PassWord = password

        End Sub

        'On verifie que l'usager c'est connecter au moins une fois
        Public Function IsAuthentifiate() As Boolean

            Dim IsAuthenfiate As Boolean = (From User In _BD.tblLogin
                                            Where User.IdLogin = _UserName
                                    Select User.EstAutorise).FirstOrDefault

            If IsAuthenfiate = True Then
                Return True
            Else
                Return False
            End If

        End Function

        'Cette fonction effectue le changement de mot de passe à la première connexion
        Public Function ChangePassword(ByVal newpass As String) As Boolean
            Dim Compte As tblLogin = GetCompte().FirstOrDefault

            If GetCompte().Count Then
                Try
                    Compte.Hash = newpass
                    Compte.EstAutorise = True
                    _BD.SaveChanges()
                Catch ex As Exception
                    Return False
                End Try

                Return True
            Else
                Return False
            End If

        End Function

        'Cette fonction verifie que les informations de login entrés par l'uager sont valides
        Public Function ValidateUser() As Boolean

            If GetCompte().Count Then
                Return True
            Else
                Return False
            End If
        End Function

        'Recherche dans la BD les informations relatives à l'usager
        Protected Function GetCompte() As IQueryable(Of tblLogin)
            Dim Compte As IQueryable(Of tblLogin) = From MonLogin In _BD.tblLogin
            Where MonLogin.IdLogin = _UserName And MonLogin.Hash = _PassWord
                    Select MonLogin

            Return Compte
        End Function
    End Class

End Module