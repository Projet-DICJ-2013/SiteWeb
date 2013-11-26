Imports System
Imports System.IO
Imports System.Linq

Partial Class Demande_Pret
    Inherits System.Web.UI.Page

    Private req As IQueryable(Of tblExemplaire)


    Sub Page_Load() Handles MyBase.Load
        Dim BD As New PresenceModel
        req = (From r In BD.tblExemplaire
        Where r.TypeEtat <> "Supprimé"
       Select r)


        drpModele.DataSource = req.ToList
        drpModele.DataValueField = "NoModele"
        drpModele.DataBind()

        drpModele.Items.Insert(0, New ListItem(String.Empty, String.Empty))
        drpModele.SelectedIndex = 0

    End Sub
End Class
