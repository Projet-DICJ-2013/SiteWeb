
Partial Class Reunion
    Inherits System.Web.UI.Page
    Private foncRech As objRech
    Private Rapport As GenereRapport
    Private _lstmembres As List(Of tblMembre)
    Private BD As New PresenceModelEntitie
    Private ListeOrdreDuJour As List(Of tblOrdreDuJour)
    Private TempsFile As String
    Private MonPdf As New GetPDF




    Private Sub onload(sender As Object, e As EventArgs) Handles Me.Load

        If Me.IsPostBack = False Then
            ReloadListeResultat()
            TypeRecherche.SelectedIndex = 0
        Else
            foncRech = New objRech
            ListeOrdreDuJour = foncRech.odjtypememb(Me.Context.User.Identity.Name)
        End If

    End Sub

    Sub GetPdf_Click(ByVal sender As Object, ByVal e As EventArgs)
        TempsFile = GetMyPDF(ListeOrdreDuJour.Item(ListeResultat.SelectedIndex).NoOrdreDuJour)

        HttpContext.Current.Session("Rapport") = TempsFile
        MonPdf.ProcessRequest(Me.Context)
    End Sub
    Protected Sub ListeResultat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListeResultat.SelectedIndexChanged

    End Sub
    Private Sub ReloadListeResultat()
        ListeResultat.Items.Clear()
        foncRech = New objRech
        ListeOrdreDuJour = foncRech.odjtypememb(Me.Context.User.Identity.Name)
        ListeResultat.DataTextField = "TitreOrdreJour"
        ListeResultat.DataSource = ListeOrdreDuJour
        ListeResultat.DataBind()
    End Sub

    Protected Sub boutonNouv_Click(sender As Object, e As EventArgs) Handles boutonNouv.Click
        ReloadListeResultat()
        TypeRecherche.SelectedIndex = 0
        lstParticipant.Items.Clear()
        lstTypeParticipant.SelectedIndex = 0

    End Sub

    Protected Sub lstTypeParticipant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTypeParticipant.SelectedIndexChanged
        If lstTypeParticipant.SelectedIndex <> 0 Then
            lstParticipant.DataTextField = "PrenomMembre"
            lstParticipant.DataSource = ChargerParticipant(lstTypeParticipant.SelectedIndex)
            lstParticipant.DataBind()
        Else
            lstParticipant.Items.Clear()
        End If
    End Sub

    Protected Sub boutonRech_Click(sender As Object, e As EventArgs) Handles boutonRech.Click
        Dim impfrom = Request.Form("from")
        Dim impto = Request.Form("to")
        ListeOrdreDuJour.clear()
        If (impfrom IsNot "" And impto IsNot "") Then
            ListeOrdreDuJour = foncRech.odjbydate(lstParticipant, impfrom, impto)
        End If

        If (lstParticipant.SelectedValue IsNot "") Then
            Dim y As Integer
            y = 2
        End If
        ListeResultat.ClearSelection()
    End Sub
End Class

Public Class Reunion
    Public Function ChargerParticipant(ByVal TypeRech As Int16) As List(Of tblMembre)
        If TypeRech = 1 Then
            _lstmembres = (From membre In BD.tblMembre Join prof In BD.tblProfesseur On prof.IdMembre Equals membre.IdMembre Select membre).ToList()
        ElseIf (TypeRech = 2 Or TypeRech = 3 Or TypeRech = 4) Then
            _lstmembres = (From membre In BD.tblMembre Join etudiant In BD.tblEtudiant On etudiant.IdMembre Equals membre.IdMembre Where etudiant.Annee = TypeRech - 1 Select membre).ToList()
        End If
        Return _lstmembres
    End Function
    Public Function GetMyPDF(ByVal PdfId As Integer) As String

        Rapport = New GenereRapport
        Rapport.CreerRapportOrd(PdfId)

        Return Rapport.TempFilePDF

    End Function
End Class