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
        Dim BD As New PresenceModelEntitie
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
        Dim nbModele As Integer
        nbModele = 0
        For Each modele As tblModele In req

            Dim NouvelleLigne As New TableRow
            Dim NouvelleCell As New TableCell
            Dim marquecell As TableCell = New TableCell With {.Text = modele.Marque}
            NouvelleLigne.Cells.Add(marquecell)
            Dim modelecell As TableCell = New TableCell With {.Text = modele.NoModele}
            NouvelleLigne.Cells.Add(modelecell)
            Dim notecell As TableCell = New TableCell With {.Text = modele.NoteModele}
            NouvelleLigne.Cells.Add(notecell)
            notecell.Width = 100
            Dim chkcell As TableCell = New TableCell
            chkcell.ID = nbModele
            NouvelleLigne.Cells.Add(chkcell)
            Dim rdobox As New RadioButton
            chkcell.Controls.Add(rdobox)
            rdobox.GroupName = "pret"
            ' rdobox.Controls.Add(rdobox)
            TablePret.Rows.Add(NouvelleLigne)
            nbModele = nbModele + 1
        Next
        Dim LigneEnvoyer As New TableRow
        Dim CellEnvoyer As New TableCell

        LigneEnvoyer.Cells.Add(CellEnvoyer)
        TablePret.Rows.Add(LigneEnvoyer)

        'If req.ToList.Count > 0 Then
        '    drpModele.DataSource = req.ToList
        '    drpModele.DataBind()
        '    drpModele.Items.Insert(0, New ListItem("Choisir un modèle", String.Empty))
        '    drpModele.SelectedIndex = 0
        'Else
        '    drpModele.Items.Clear()
        'End If

    End Sub
    Sub BoutonEnvoyer_Click()

    End Sub

End Class
