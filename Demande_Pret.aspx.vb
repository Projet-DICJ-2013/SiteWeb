Imports System
Imports System.IO
Imports System.Linq

Partial Class Demande_Pret
    Inherits System.Web.UI.Page
    Dim req As IQueryable(Of ModeleExemplaire)
    Dim BD As New PresenceModel

    Class ModeleExemplaire
        Property modele As tblModele
        Property exemplaire As tblExemplaire
    End Class
    Sub Page_Load() Handles MyBase.Load

        req = (From r In BD.tblExemplaire
                   Join m In BD.tblModele On m.NoModele Equals r.NoModele
        Where r.TypeEtat <> "Supprimé"
            Select New ModeleExemplaire With {.modele = m, .exemplaire = r})

    End Sub



    Sub OnType_Modified() Handles DropDownList1.SelectedIndexChanged

        req = req.Where(Function(r) CType(r.modele.TypeMachine, String).Contains(DropDownList1.SelectedItem.Text))
        Dim nbModele As Integer
        nbModele = 0
        For Each modeleexemplaire As ModeleExemplaire In req

            Dim NouvelleLigne As New TableRow

            Dim NouvelleCell As New TableCell
            Dim marquecell As TableCell = New TableCell With {.Text = modeleexemplaire.modele.Marque}
            NouvelleLigne.Cells.Add(marquecell)
            Dim modelecell As TableCell = New TableCell With {.Text = modeleexemplaire.modele.NoModele}
            NouvelleLigne.Cells.Add(modelecell)
            Dim notecell As TableCell = New TableCell With {.Text = modeleexemplaire.modele.NoteModele}
            NouvelleLigne.Cells.Add(notecell)
            notecell.Width = 100
            Dim chkcell As TableCell = New TableCell
            chkcell.ID = modeleexemplaire.exemplaire.CodeBarre

            NouvelleLigne.Cells.Add(chkcell)
            Dim rdobox As New CheckBox
            chkcell.Controls.Add(rdobox)
            TablePret.Rows.Add(NouvelleLigne)
        Next
        Dim LigneEnvoyer As New TableRow
        Dim CellEnvoyer As New TableCell
        TablePret.Rows.Add(LigneEnvoyer)
        LigneEnvoyer.Cells.Add(CellEnvoyer)

    End Sub
    'Context.User.Identity.Name
    Sub BoutonEnvoyer_Click()
        Dim Demande As New tblDemande With {.IdMembre = (From l In BD.tblLogin
                                                   Where l.IdLogin = Context.User.Identity.Name
                                                Select l.IdMembre).Single, .TypeEtat = "actif", .DateDemande = Today}
        For Each CurrentRow As TableRow In TablePret.Rows
            For Each CurrentCell As TableCell In CurrentRow.Cells
                For Each chkButton As Control In CurrentCell.Controls
                    If TypeOf chkButton Is CheckBox Then
                        If CType(chkButton, CheckBox).Checked Then
                            Demande.tblExemplaire.Add(New tblExemplaire() With {.CodeBarre = chkButton.ID})
                        End If
                    End If
                Next
            Next
        Next
        BD.tblDemande.Add(Demande)
        BD.SaveChanges()
    End Sub
End Class
