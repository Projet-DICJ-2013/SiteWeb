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
            Select m)


        'drpModele.DataSource = req.ToList()
        'drpModele.DataValueField = "NoModele"


    End Sub

    Sub OnType_Modified() Handles DropDownList1.SelectedIndexChanged

        req = req.Where(Function(r) CType(r.TypeMachine, String).Contains(DropDownList1.SelectedItem.Text))
        'TablePret.Rows.Clear()
        For Each modele As tblModele In req
            Dim NouvelleLigne As New TableRow
            Dim NouvelleCell As New TableCell
            Dim marquecell As TableCell = New TableCell With {.Text = modele.Marque}
            NouvelleLigne.Cells.Add(marquecell)
            Dim modelecell As TableCell = New TableCell With {.Text = modele.NoModele}
            NouvelleLigne.Cells.Add(modelecell)
            Dim notecell As TableCell = New TableCell With {.Text = modele.NoteModele}
            NouvelleLigne.Cells.Add(notecell)
            Dim garantiecell As TableCell = New TableCell With {.Text = modele.NbAnneeGarantie}
            NouvelleLigne.Cells.Add(garantiecell)
            TablePret.Rows.Add(NouvelleLigne)
        Next


        'If req.ToList.Count > 0 Then
        '    drpModele.DataSource = req.ToList
        '    drpModele.DataBind()
        '    drpModele.Items.Insert(0, New ListItem("Choisir un modèle", String.Empty))
        '    drpModele.SelectedIndex = 0
        'Else
        '    drpModele.Items.Clear()
        'End If

    End Sub


End Class
