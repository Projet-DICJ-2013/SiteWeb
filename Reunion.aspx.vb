
Partial Class Reunion
    Inherits System.Web.UI.Page
    Private foncRech As objRech
    Private Rapport As GenereRapport
    Private _lstmembres As List(Of tblMembre)
    Private BD As New PresenceMod

    Public Function GetMyPDF(ByVal PdfId As Integer) As String

        Rapport = New GenereRapport
        Rapport.CreerRapportOrd(PdfId)

        Return Rapport.TempFilePDF

    End Function

    Private Sub onload(sender As Object, e As EventArgs) Handles Me.Load
        foncRech = New objRech
        ListeResultat.DataTextField = "TitreOrdreJour"
        ListeResultat.DataSource = foncRech.odjtypememb(Me.Context.User.Identity.Name)
        ListeResultat.DataBind()
        If lstTypeParticipant.SelectedIndex <> 4 Then
            lstParticipant.DataTextField = "PrenomMembre"
            lstParticipant.DataSource = ChargerParticipant(lstTypeParticipant.SelectedIndex)
            lstParticipant.DataBind()
        Else
            lstParticipant.Items.Clear()
        End If


    End Sub


    Protected Sub RadOdj_CheckedChanged(sender As Object, e As EventArgs) Handles RadOdj.CheckedChanged
        If RadOdj.Checked = False Then
            RadOdj.Checked = True
        End If
        RadPv.Checked = False
    End Sub

    Protected Sub RadPv_CheckedChanged(sender As Object, e As EventArgs) Handles RadPv.CheckedChanged
        If RadPv.Checked = False Then
            RadPv.Checked = True
        End If
        RadOdj.Checked = False
    End Sub

    Protected Sub lstTypeParticipant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTypeParticipant.SelectedIndexChanged

    End Sub
End Class

Public Class Reunion
    Public Function ChargerParticipant(ByVal TypeRech As Int16) As List(Of tblMembre)
        
        Select Case TypeRech
            Case 0
                _lstmembres = (From membre In BD.tblMembre Join prof In BD.tblProfesseur On prof.IdMembre Equals membre.IdMembre Select membre).ToList()
            Case 1
                _lstmembres = (From membre In BD.tblMembre Join etudiant In BD.tblEtudiant On etudiant.IdMembre Equals membre.IdMembre Where etudiant.Annee = 1 Select membre).ToList()
            Case 2
                _lstmembres = (From membre In BD.tblMembre Join etudiant In BD.tblEtudiant On etudiant.IdMembre Equals membre.IdMembre Where etudiant.Annee = 2 Select membre).ToList()
            Case 3
                _lstmembres = (From membre In BD.tblMembre Join etudiant In BD.tblEtudiant On etudiant.IdMembre Equals membre.IdMembre Where etudiant.Annee = 3 Select membre).ToList()

        End Select
        Return _lstmembres
    End Function
End Class