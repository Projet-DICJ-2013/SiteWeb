﻿Imports Microsoft.VisualBasic

Public Module ModProvider

    Public Class Provider
        Inherits MembershipProvider

        Private Username
        Private BD As New PresenceModelEntities

        Public Overrides Property ApplicationName As String

        Public Property GetUserName
            Get

            End Get
            Set(value)

            End Set
        End Property
        Public Overrides Function ChangePassword(username As String, oldPassword As String, newPassword As String) As Boolean

        End Function

        Public Overrides Function ChangePasswordQuestionAndAnswer(username As String, password As String, newPasswordQuestion As String, newPasswordAnswer As String) As Boolean

        End Function

        Public Overrides Function CreateUser(username As String, password As String, email As String, passwordQuestion As String, passwordAnswer As String, isApproved As Boolean, providerUserKey As Object, ByRef status As MembershipCreateStatus) As MembershipUser

        End Function

        Public Overrides Function DeleteUser(username As String, deleteAllRelatedData As Boolean) As Boolean

        End Function

        Public Overrides ReadOnly Property EnablePasswordReset As Boolean
            Get

            End Get
        End Property

        Public Overrides ReadOnly Property EnablePasswordRetrieval As Boolean
            Get

            End Get
        End Property

        Public Overrides Function FindUsersByEmail(emailToMatch As String, pageIndex As Integer, pageSize As Integer, ByRef totalRecords As Integer) As MembershipUserCollection

        End Function

        Public Overrides Function FindUsersByName(usernameToMatch As String, pageIndex As Integer, pageSize As Integer, ByRef totalRecords As Integer) As MembershipUserCollection

        End Function

        Public Overrides Function GetAllUsers(pageIndex As Integer, pageSize As Integer, ByRef totalRecords As Integer) As MembershipUserCollection

        End Function

        Public Overrides Function GetNumberOfUsersOnline() As Integer

        End Function

        Public Overrides Function GetPassword(username As String, answer As String) As String

        End Function

        Public Overloads Overrides Function GetUser(providerUserKey As Object, userIsOnline As Boolean) As MembershipUser

        End Function

        Public Overloads Overrides Function GetUser(username As String, userIsOnline As Boolean) As MembershipUser

        End Function

        Public Overrides Function GetUserNameByEmail(email As String) As String

        End Function

        Public Overrides ReadOnly Property MaxInvalidPasswordAttempts As Integer
            Get

            End Get
        End Property

        Public Overrides ReadOnly Property MinRequiredNonAlphanumericCharacters As Integer
            Get

            End Get
        End Property

        Public Overrides ReadOnly Property MinRequiredPasswordLength As Integer
            Get

            End Get
        End Property

        Public Overrides ReadOnly Property PasswordAttemptWindow As Integer
            Get

            End Get
        End Property

        Public Overrides ReadOnly Property PasswordFormat As MembershipPasswordFormat
            Get

            End Get
        End Property

        Public Overrides ReadOnly Property PasswordStrengthRegularExpression As String
            Get

            End Get
        End Property

        Public Overrides ReadOnly Property RequiresQuestionAndAnswer As Boolean
            Get

            End Get
        End Property

        Public Overrides ReadOnly Property RequiresUniqueEmail As Boolean
            Get

            End Get
        End Property

        Public Overrides Function ResetPassword(username As String, answer As String) As String

        End Function

        Public Overrides Function UnlockUser(userName As String) As Boolean

        End Function

        Public Overrides Sub UpdateUser(user As MembershipUser)

        End Sub

        Public Overrides Function ValidateUser(username As String, password As String) As Boolean

            Dim IsConnect = (From MonLogin In BD.tblLogin
                    Where MonLogin.IdLogin = username And MonLogin.MotDePasseLogin = password
                    Select MonLogin).Count

            If IsConnect > 0 Then
                Return True
            Else
                Return False
            End If
        End Function
    End Class

End Module