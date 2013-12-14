
Partial Class Prets
    Inherits System.Web.UI.Page

    Sub btnDemande_Click()
        Response.Redirect("Demande_Pret.aspx")
    End Sub

    Dim req As IQueryable(Of ModeleExemplaire)
    Dim BD As New PresenceModEntity

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

        GridModele.DataSource = req.ToList
        GridModele.DataBind()



    End Sub
    Sub BoutonEnvoyer_Click()
        Try

            Dim Demande As New tblDemande With {.IdMembre = (From l In BD.tblLogin
                                                       Where l.IdLogin = Context.User.Identity.Name
                                                    Select l.IdMembre).Single, .TypeEtat = "actif", .DateDemande = Today}

            For Each row As GridViewRow In GridModele.Rows
                If CType(row.FindControl("checkmodele"), CheckBox).Checked Then
                    Dim _codeBarre As Integer
                    _codeBarre = CType(row.FindControl("CodeBarre"), Label).Text
                    Dim Exemplaire = (From e In BD.tblExemplaire
                                     Where e.CodeBarre = _codeBarre).SingleOrDefault
                    Demande.tblExemplaire.Add(Exemplaire)
                End If
            Next

            BD.tblDemande.Add(Demande)
            BD.SaveChanges()

        Catch ex As System.Data.Entity.Validation.DbEntityValidationException

            For Each a In ex.EntityValidationErrors
                For Each b In a.ValidationErrors
                    Dim st1 As String = b.PropertyName
                    Dim st2 As String = b.ErrorMessage
                Next

            Next


        End Try
    End Sub
End Class
