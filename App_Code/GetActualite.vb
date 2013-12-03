Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Web.DynamicData
Imports System.Windows.Data
Imports System.Web.UI

' Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class GetActualite
     Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Shared Function GetNews(ByVal index As Integer) As String
        Return "Hello World"
    End Function

End Class

Class MesNews

    Private MesNews As ListCollectionView
    Private BD As New PresenceModel

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