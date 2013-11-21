
Partial Class Reunion
    Inherits System.Web.UI.Page

    Private Rapport As GenereRapport

    Public Function GetMyPDF(ByVal PdfId As Integer) As String

        Rapport = New GenereRapport
        Rapport.CreerRapportOrd(PdfId)

        Return Rapport.TempFilePDF

    End Function
End Class
