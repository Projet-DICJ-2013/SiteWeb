Imports Microsoft.VisualBasic

Public Module ModProvider

    Public Class Provider

        Private _UserName As String
        Private _PassWord As String
        Private _BD As New PresenceModEntity

        Public Sub New(username As String, password As String)
            _UserName = username
            _PassWord = password

        End Sub

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

        Public Function ValidateUser() As Boolean

            If GetCompte().Count Then
                Return True
            Else
                Return False
            End If
        End Function

        Protected Function GetCompte() As IQueryable(Of tblLogin)
            Dim Compte As IQueryable(Of tblLogin) = From MonLogin In _BD.tblLogin
            Where MonLogin.IdLogin = _UserName And MonLogin.Hash = _PassWord
                    Select MonLogin

            Return Compte
        End Function
    End Class

End Module