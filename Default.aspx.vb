Imports System.Web.DynamicData
Imports System.Windows.Data
Imports System.Threading.Tasks

Class _Default
    Inherits Page

    Private News As New MesNews

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs)



    End Sub

End Class


Class MesNews

    Private MesNews As ListCollectionView
    Private BD As New PresenceModEntity

    Public Property lstActu As ListCollectionView

        Get
            Return MesNews
        End Get
        Set(value As ListCollectionView)
            MesNews = value
        End Set
    End Property

    Public Sub New()

        Dim lstNews = (From News In BD.tblActualite
                    Order By News.IDActualite Ascending
                    Select News).ToList


        lstActu = New ListCollectionView(lstNews)
    End Sub

    Public Function GetRech(ByVal rech As String)

        Dim lstNews = (From News In BD.tblActualite
                    Order By News.IDActualite Ascending
                    Select News)

    End Function

End Class
