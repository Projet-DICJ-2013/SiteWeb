Public Class objRech

    Private entBd As PresenceMod
    Private typemembre As Int16

    Public Sub New()

        entBd = New PresenceMod

    End Sub

    Public Function odjtypememb(namelogin As String)

        Dim listeOdjMem = (From tblodj In entBd.tblOrdreDuJour Select tblodj).ToList
        Dim Odj As IList(Of tblOrdreDuJour) = New List(Of tblOrdreDuJour)
        Dim indexOdj As Integer = 0
        Dim idmembre As Integer = 0

        Dim listeMembre = (From tblmembre In entBd.tblMembre Join tbllogin In entBd.tblLogin On tbllogin.IdMembre Equals tblmembre.IdMembre Where namelogin = tbllogin.IdLogin Select tblmembre).ToList

        idmembre = listeMembre.Item(0).IdMembre

        Dim typembconnect As Integer = trouverTypeMembre(idmembre)




        For Each elmodj In listeOdjMem.ToList

            typemembre = trouverRedac(elmodj.NoOrdreDuJour)
            If (typemembre = typembconnect) Then
                Odj.Add(elmodj)
            End If
        Next

        Return Odj

    End Function
    Private Function trouverRedac(idordrejour As Integer)

        Dim idmembre As Integer

        Dim listeMembreOdj = (From tblRenPar In entBd.tblMembreParticipantReunion Where tblRenPar.tblReunion.NoOrdreDuJour = idordrejour And tblRenPar.tblParticipant.IdTypeMembre = "Rédacteur" Select tblRenPar).ToList
        If (listeMembreOdj.Count = 0) Then
            Return 3
        Else
            idmembre = listeMembreOdj.First.IdMembre
        End If


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
