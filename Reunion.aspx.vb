
Partial Class Reunion
    Inherits System.Web.UI.Page
    Private _foncRech As objRech
    Private _rapport As GenereRapport
    Private _lstmembres As List(Of tblMembre)
    Private _BD As New PresenceModel
    Private _listeOrdreDuJour As List(Of tblOrdreDuJour)
    Private _tempsFile As String
    Private _monPdf As New GetPDF




    Private Sub onload(sender As Object, e As EventArgs) Handles Me.Load

        If Me.IsPostBack = False Then
            ReloadListeResultat()
            RadOdj.Checked = True
        Else
            _foncRech = New objRech
            _listeOrdreDuJour = _foncRech.odjtypememb(Me.Context.User.Identity.Name)
        End If

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

    Sub GetPdf_Click(ByVal sender As Object, ByVal e As EventArgs)
        _tempsFile = GetMyPDF(_listeOrdreDuJour.Item(ListeResultat.SelectedIndex).NoOrdreDuJour)

        HttpContext.Current.Session("Rapport") = _tempsFile
        _MonPdf.ProcessRequest(Me.Context)
    End Sub
    Protected Sub ListeResultat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListeResultat.SelectedIndexChanged

    End Sub
    Private Sub ReloadListeResultat()
        ListeResultat.Items.Clear()
        _foncRech = New objRech
        _listeOrdreDuJour = _foncRech.odjtypememb(Me.Context.User.Identity.Name)
        ListeResultat.DataTextField = "TitreOrdreJour"
        ListeResultat.DataSource = _listeOrdreDuJour
        ListeResultat.DataBind()
    End Sub

    Protected Sub boutonNouv_Click(sender As Object, e As EventArgs)
        ReloadListeResultat()
        RadOdj.Checked = True
        Dim sada As Int16 = ListeResultat.SelectedIndex
    End Sub

    Protected Sub boutonRech_Click(sender As Object, e As EventArgs)
        Dim datefrom = Request.Form("from").ToString
        Dim dateto = Request.Form("to").ToString
        Dim idParticipant = lstParticipant.SelectedValue()

        If (datefrom IsNot Nothing) And (dateto IsNot Nothing) Then
            _listeOrdreDuJour = _foncRech.odjbydate(_listeOrdreDuJour, datefrom, dateto)
        End If

        If (idParticipant IsNot "") Then
            _listeOrdreDuJour = _foncRech.odjbyparticipant(_listeOrdreDuJour, idParticipant)
        End If

        ListeResultat.DataSource = Nothing
        ListeResultat.DataSource = _listeOrdreDuJour
    End Sub
End Class

Public Class Reunion
    Public Function ChargerParticipant(ByVal TypeRech As Int16) As List(Of tblMembre)
        If TypeRech = 1 Then
            _lstmembres = (From membre In _BD.tblMembre Join prof In _BD.tblProfesseur On prof.IdMembre Equals membre.IdMembre Select membre).ToList()
        ElseIf (TypeRech = 2 Or TypeRech = 3 Or TypeRech = 4) Then
            _lstmembres = (From membre In _BD.tblMembre Join etudiant In _BD.tblEtudiant On etudiant.IdMembre Equals membre.IdMembre Where etudiant.Annee = TypeRech - 1 Select membre).ToList()
        End If
        Return _lstmembres
    End Function
    Public Function GetMyPDF(ByVal PdfId As Integer) As String

        _rapport = New GenereRapport
        _rapport.CreerRapportOrd(PdfId)

        Return _rapport.TempFilePDF

    End Function
End Class