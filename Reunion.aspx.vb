
Partial Class Reunion
    Inherits System.Web.UI.Page
    Private foncRech As objRech
    Private Rapport As GenereRapport


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
End Class
