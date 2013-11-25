Public Class objRech

    Private entBd As PresenceEntities
    Private typemembre As Int16

    Public Sub New()

        entBd = New PresenceEntities

    End Sub

    Public Function odjtypememb(idmembre As Integer)

        Dim listeOdjMem = (From tblodj In entBd.tblOrdreDuJour Select tblodj).ToList
        Dim Odj As IList(Of tblOrdreDuJour) = New List(Of tblOrdreDuJour)
        Dim indexOdj As Integer = 0
        Dim typembconnect As Integer = trouverTypeMembre(idmembre)

        For Each elmodj In listeOdjMem.ToList

            typeMembre = trouverRedac(elmodj.NoOrdreDuJour)
            If (typeMembre = typembconnect) Then
                Odj.Add(elmodj)
            End If
        Next

        Return Odj

    End Function

    Private Function trouverRedac(idordrejour As Integer)

        Dim idmembre As Integer

        Dim listeMembreOdj = (From tblRenPar In entBd.tblMembreParticipantReunion Where tblRenPar.tblReunion.NoOrdreDuJour = idordrejour And tblRenPar.tblParticipant.DescriptionTypeMembre = "Redacteur" Select tblRenPar)

        idmembre = listeMembreOdj.First.IdMembre

        Return trouverTypeMembre(idmembre)

    End Function
    Private Function trouverTypeMembre(idmembre As Integer)

        Dim typmembre As Int16
        Dim membreetu = (From tbletudiant In entBd.tblEtudiant Where idmembre = tbletudiant.IdMembre Select tbletudiant).ToList
        If (membreetu.Count = 1) Then
            typmembre = 0
        Else
            typmembre = 1
        End If

        Return typmembre

    End Function
    Public Function odjbydate(listOdj As List(Of tblOrdreDuJour), datedebut As Date, datefin As Date)

        Dim listbydate = (From tblodj In listOdj Join tblren In entBd.tblReunion On tblren.NoOrdreDuJour Equals tblodj.NoOrdreDuJour Where tblren.DateReunion > datedebut And tblren.DateReunion < datefin Select tblodj).ToList

        Return listbydate

    End Function
    Public Function odjbyparticipant(listOdj As IList(Of tblOrdreDuJour), idmembre As Integer)

        Dim listbypart = (From tblodj In listOdj Join tblren In entBd.tblReunion On tblren.NoOrdreDuJour Equals tblodj.NoOrdreDuJour Join tblpart In entBd.tblMembreParticipantReunion On tblren.NoReunion Equals tblpart.NoReunion Where idmembre = tblpart.IdMembre Select tblodj).ToList

        Return listbypart

    End Function

End Class
