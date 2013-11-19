
Partial Class Reunion
    Inherits System.Web.UI.Page

    Private Rapport As GenereRapport

    Private Sub Form_Load() Handles Me.Load

        Rapport = New GenereRapport
        Rapport.CreerRapportOrd("1149")

        DirectCast(Me.FindControl("FramePdf"), HtmlControl).Attributes("src") = Rapport.TempFile

    End Sub
End Class
