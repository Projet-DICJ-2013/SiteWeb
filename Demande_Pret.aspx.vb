Imports System
Imports System.IO
Imports System.Linq

Partial Class Demande_Pret
    Inherits System.Web.UI.Page
    Dim req As IQueryable(Of tblModele)


    ''  Public Property Exemplaire As tblExemplaire
    '        Get
    '            Return _exemplaire
    '        End Get
    '        Set(value As tblExemplaire)
    '            _exemplaire = value
    '        End Set
    ''  End Property

    Sub Page_Load() Handles MyBase.Load
        Dim BD As New PresenceModel
        req = (From r In BD.tblExemplaire
                   Join m In BD.tblModele On m.NoModele Equals r.NoModele
            Where r.TypeEtat <> "Supprimé"
            Select m) 'New ExemplaireModele With {.Exemplaire = r, .Modele = m})


        drpModele.DataSource = req.ToList()


        drpModele.DataValueField = "NoModele"
        drpModele.DataBind()

        drpModele.Items.Insert(0, New ListItem(String.Empty, String.Empty))
        drpModele.SelectedIndex = 0

    End Sub

    Sub OnType_Modified() Handles DropDownList1.SelectedIndexChanged

        req = req.Where(Function(r) CType(r.TypeMachine, String).Contains(DropDownList1.SelectedItem.Text))
        If req.ToList.Count > 0 Then
            drpModele.DataSource = req.ToList
            drpModele.DataBind()
        Else
            drpModele.Items.Clear()
        End If

    End Sub


End Class
