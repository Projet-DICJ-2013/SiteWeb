Imports System
Imports System.IO
Imports System.Linq

Partial Class Demande_Pret
    Inherits System.Web.UI.Page

    Private req As IQueryable(Of ExemplaireModele)

    Public Class ExemplaireModele
        Property Exemplaire As tblExemplaire
        Property Modele As tblModele
    End Class

    Sub Page_Load() Handles MyBase.Load
        Dim BD As New PresenceModelEntities
        req = (From r In BD.tblExemplaire
             Join m In BD.tblModele
             On m.NoModele Equals r.NoModele
             Where r.TypeEtat <> "Supprimé"
       Select New ExemplaireModele With {.Exemplaire = r, .Modele = m})
        drpModele.DataSource = req
    End Sub
End Class
