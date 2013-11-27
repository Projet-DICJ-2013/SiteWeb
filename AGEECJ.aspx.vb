Imports mod_smtp

Partial Class AGEECJ
    Inherits System.Web.UI.Page
    Dim BD As PresenceModel

    Private Sub ONLoad(ByVal sender As Object, e As EventArgs) Handles Me.Load
        BD = New PresenceModel
    End Sub

    Protected Sub btnEnvoyer_Click1(sender As Object, e As EventArgs)
        'Vérification du RadioBoutton choisi par l'utilisateur
        Dim choix As Int16
        If rbPremier.Checked = True Then
            choix = 1
        ElseIf rbDeuxieme.Checked = True Then
            choix = 2
        ElseIf rbTroisieme.Checked = True Then
            choix = 3
        ElseIf rbTous.Checked = True Then
            choix = 4
        End If
        'Envoie du message (voir procedure messageAnnée(choix as int16))
        messageAnnée(choix)
    End Sub

    Sub messageAnnée(choix As Int16)
        'Initialisation des variables pour l'envoie des messages en allant chercher les informations dans la BD
        Dim _nbrMail As Int16
        Dim _adresseEtu = (From adresse In BD.tblMembre Join _membre In BD.tblEtudiant On adresse.IdMembre Equals _membre.IdMembre Where _membre.Annee = choix Select adresse).ToList
        Dim _tblConstante = (From constant In BD.tblConstant Select constant).ToList()
        Dim _envoieMail = New objSmtp("dicj@cjonquiere.qc.ca", "dicj@cjonquiere.qc.ca", txtObjet.Text, txtArMessage.InnerText, _tblConstante.Item(0).AdresseEmail, _tblConstante.Item(0).MotdePasse)

        'Envoie de message, si il a plus de 10 destinataires envoyés les 10 premier et ensuite renvoyer un autre "Batch" pour contrer le bug du 10 maximum
        Try
            For Each invites In _adresseEtu
                _envoieMail.AddDestinataire(invites.CourrielMembre)
                _nbrMail += 1
                If (_nbrMail = 10) Then
                    _envoieMail.Envoie_Reset()
                    _nbrMail = 0
                End If
            Next
            'Envoie du message s'il a moin de 10 dans une "batch" de destinataires
            _envoieMail.EnvoiMessage()
            'Message à l'utilisateur si sa marche ou pas son envoie de messages
            lblCommentaire.Text = "Votre message a bien été envoyé"
            lblCommentaire.Visible = True
        Catch ex As Exception
            'Message à l'utilisateur si sa marche ou pas son envoie de messages
            lblCommentaire.Text = "Une erreur est survenu l'hors de l'envoie de votre message"
            lblCommentaire.Visible = True
        End Try
    End Sub
End Class
