Imports System.Web.DynamicData
Imports System.Windows.Data

Class _Default
    Inherits Page

    Private News As New MesNews
    Private i As Integer = 0

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

        AfficheActu()

    End Sub

    Public Sub btnPrec_Click(ByVal sender As Object, ByVal e As EventArgs)

        News.lstActu.MoveCurrentToPrevious()
        AfficheActu()


    End Sub

    Public Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs)

        News.lstActu.MoveCurrentToNext()
        AfficheActu()

    End Sub

    Private Sub AfficheActu()
        'lblNew.Text = CType(News.lstActu.CurrentItem, tblActualite).TexteActu

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
                    Order By News.IDActualite Descending
                    Select News).ToList


        lstActu = New ListCollectionView(lstNews)
    End Sub
End Class
