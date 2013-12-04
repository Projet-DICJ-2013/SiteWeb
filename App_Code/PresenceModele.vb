﻿'------------------------------------------------------------------------------
' <auto-generated>
'    Ce code a été généré à partir d'un modèle.
'
'    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
'    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class sysdiagrams
    Public Property name As String
    Public Property principal_id As Integer
    Public Property diagram_id As Integer
    Public Property version As Nullable(Of Integer)
    Public Property definition As Byte()

End Class
Partial Public Class tblActualite
    Public Property IDActualite As Integer
    Public Property TexteActu As String
    Public Property TitreActu As String
    Public Property AuteurActu As String
    Public Property ImangeActu As String

End Class
Partial Public Class tblBesoin
    Public Property IdBesoin As Short
    Public Property IdGroupe As Nullable(Of Short)
    Public Property DateBesoin As Date

    Public Overridable Property tblGroupe As tblGroupe
    Public Overridable Property tblExemplaire As ICollection(Of tblExemplaire) = New HashSet(Of tblExemplaire)

End Class
Partial Public Class tblCompoModele
    Public Property IdCompo As Short
    Public Property TypeCompo As String

    Public Overridable Property tblModele As ICollection(Of tblModele) = New HashSet(Of tblModele)

End Class
Partial Public Class tblConstant
    Public Property AdresseEmail As String
    Public Property MotdePasse As String

End Class
Partial Public Class tblCours
    Public Property CodeCours As String
    Public Property NomCours As String
    Public Property DescriptionCours As String
    Public Property PonderationCours As String
    Public Property AnneeCours As String

    Public Overridable Property tblCoursSessionGroupe As ICollection(Of tblCoursSessionGroupe) = New HashSet(Of tblCoursSessionGroupe)
    Public Overridable Property tblStatutCoursCours As ICollection(Of tblStatutCoursCours) = New HashSet(Of tblStatutCoursCours)
    Public Overridable Property tblProgramme As ICollection(Of tblProgramme) = New HashSet(Of tblProgramme)

End Class
Partial Public Class tblCoursSessionGroupe
    Public Property CodeCours As String
    Public Property IdSession As String
    Public Property IdGroupe As Short

    Public Overridable Property tblCours As tblCours
    Public Overridable Property tblGroupe As tblGroupe
    Public Overridable Property tblSession As tblSession

End Class
Partial Public Class tblDemande
    Public Property IdDemande As Short
    Public Property DateDemande As Date
    Public Property IdMembre As Nullable(Of Short)
    Public Property TypeEtat As String

    Public Overridable Property tblMembre As tblMembre
    Public Overridable Property tblEtatDemande As tblEtatDemande
    Public Overridable Property tblExemplaire As ICollection(Of tblExemplaire) = New HashSet(Of tblExemplaire)

End Class
Partial Public Class tblElement
    Public Property IdTypeElement As String
    Public Property TypeElement As String
    Public Property IdStyle As String
    Public Property PositionElement As String
    Public Property IdTypeRapport As String

    Public Overridable Property tblTypeRapport As tblTypeRapport

End Class
Partial Public Class tblEtatDemande
    Public Property TypeEtat As String
    Public Property DescriptionEtat As String

    Public Overridable Property tblDemande As ICollection(Of tblDemande) = New HashSet(Of tblDemande)

End Class
Partial Public Class tblEtatExemplaire
    Public Property TypeEtat As String
    Public Property DescriptionEtat As String

    Public Overridable Property tblExemplaire As ICollection(Of tblExemplaire) = New HashSet(Of tblExemplaire)

End Class
Partial Public Class tblEtatPret
    Public Property TypeEtat As String
    Public Property DescriptionEtat As String

    Public Overridable Property tblPret As ICollection(Of tblPret) = New HashSet(Of tblPret)

End Class
Partial Public Class tblEtudiant
    Public Property DaEtudiant As Integer
    Public Property DateInscriptionEtudiant As Date
    Public Property IdMembre As Short
    Public Property Annee As Short

    Public Overridable Property tblMembreAssociationEtudiant As ICollection(Of tblMembreAssociationEtudiant) = New HashSet(Of tblMembreAssociationEtudiant)
    Public Overridable Property tblMembre As tblMembre
    Public Overridable Property tblGroupe As ICollection(Of tblGroupe) = New HashSet(Of tblGroupe)
    Public Overridable Property tblProgramme As ICollection(Of tblProgramme) = New HashSet(Of tblProgramme)

End Class
Partial Public Class tblExemplaire
    Public Property CodeBarre As Integer
    Public Property NoSerie As String
    Public Property NoteExemplaire As String
    Public Property NomReseau As String
    Public Property NoModele As String
    Public Property DateAchat As Date
    Public Property AReimager As Boolean
    Public Property TypeEtat As String

    Public Overridable Property tblEtatExemplaire As tblEtatExemplaire
    Public Overridable Property tblPretExemplaire As ICollection(Of tblPretExemplaire) = New HashSet(Of tblPretExemplaire)
    Public Overridable Property tblModele As tblModele
    Public Overridable Property tblReparation As ICollection(Of tblReparation) = New HashSet(Of tblReparation)
    Public Overridable Property tblSysteme As ICollection(Of tblSysteme) = New HashSet(Of tblSysteme)
    Public Overridable Property tblBesoin As ICollection(Of tblBesoin) = New HashSet(Of tblBesoin)
    Public Overridable Property tblDemande As ICollection(Of tblDemande) = New HashSet(Of tblDemande)

End Class
Partial Public Class tblGroupe
    Public Property IdGroupe As Short
    Public Property NoGroupe As Short

    Public Overridable Property tblCoursSessionGroupe As ICollection(Of tblCoursSessionGroupe) = New HashSet(Of tblCoursSessionGroupe)
    Public Overridable Property tblBesoin As ICollection(Of tblBesoin) = New HashSet(Of tblBesoin)
    Public Overridable Property tblGroupeLocal As ICollection(Of tblGroupeLocal) = New HashSet(Of tblGroupeLocal)
    Public Overridable Property tblEtudiant As ICollection(Of tblEtudiant) = New HashSet(Of tblEtudiant)
    Public Overridable Property tblProfesseur As ICollection(Of tblProfesseur) = New HashSet(Of tblProfesseur)

End Class
Partial Public Class tblGroupeLocal
    Public Property IdGroupe As Short
    Public Property NoLocal As String
    Public Property JoursCours As String
    Public Property HeureCours As System.TimeSpan

    Public Overridable Property tblGroupe As tblGroupe
    Public Overridable Property tblLocal As tblLocal

End Class
Partial Public Class tblHistoriquePret
    Public Property idHistorique As Short
    Public Property AncientEtat As String
    Public Property DateChangementEtat As Date

End Class
Partial Public Class tblListePoint
    Public Property NoListePoint As Integer
    Public Property NoOrdreDuJour As Nullable(Of Integer)

    Public Overridable Property tblPoints As ICollection(Of tblPoints) = New HashSet(Of tblPoints)
    Public Overridable Property tblOrdreDuJour As tblOrdreDuJour
    Public Overridable Property tblPoints1 As ICollection(Of tblPoints) = New HashSet(Of tblPoints)

End Class
Partial Public Class tblLocal
    Public Property NoLocal As String
    Public Property TypeLocal As String

    Public Overridable Property tblGroupeLocal As ICollection(Of tblGroupeLocal) = New HashSet(Of tblGroupeLocal)

End Class
Partial Public Class tblLogin
    Public Property IdLogin As String
    Public Property Administrateur As Boolean
    Public Property IdMembre As Nullable(Of Short)
    Public Property Hash As String
    Public Property EstAutorise As Nullable(Of Boolean)

    Public Overridable Property tblMembre As tblMembre

End Class
Partial Public Class tblMembre
    Public Property IdMembre As Short
    Public Property NomMembre As String
    Public Property PrenomMembre As String
    Public Property TelephoneMembre As String
    Public Property CourrielMembre As String
    Public Property NoCiviqueMembre As String
    Public Property AdresseMembre As String
    Public Property VilleMembre As String

    Public Overridable Property tblEtudiant As ICollection(Of tblEtudiant) = New HashSet(Of tblEtudiant)
    Public Overridable Property tblLogin As ICollection(Of tblLogin) = New HashSet(Of tblLogin)
    Public Overridable Property tblDemande As ICollection(Of tblDemande) = New HashSet(Of tblDemande)
    Public Overridable Property tblMembreParticipantReunion As ICollection(Of tblMembreParticipantReunion) = New HashSet(Of tblMembreParticipantReunion)
    Public Overridable Property tblMembreStatutMembre As ICollection(Of tblMembreStatutMembre) = New HashSet(Of tblMembreStatutMembre)
    Public Overridable Property tblPret As ICollection(Of tblPret) = New HashSet(Of tblPret)
    Public Overridable Property tblProfesseur As ICollection(Of tblProfesseur) = New HashSet(Of tblProfesseur)
    Public Overridable Property tblMessage As ICollection(Of tblMessage) = New HashSet(Of tblMessage)

End Class
Partial Public Class tblMembreAssociation
    Public Property NomRole As String
    Public Property DescriptionRole As String

    Public Overridable Property tblMembreAssociationEtudiant As ICollection(Of tblMembreAssociationEtudiant) = New HashSet(Of tblMembreAssociationEtudiant)

End Class
Partial Public Class tblMembreAssociationEtudiant
    Public Property NomRole As String
    Public Property DaEtudiant As Integer
    Public Property DateRole As Date
    Public Property CommRole As String

    Public Overridable Property tblEtudiant As tblEtudiant
    Public Overridable Property tblMembreAssociation As tblMembreAssociation

End Class
Partial Public Class tblMembreParticipantReunion
    Public Property IdMembre As Short
    Public Property IdTypeMembre As String
    Public Property NoReunion As Integer

    Public Overridable Property tblMembre As tblMembre
    Public Overridable Property tblParticipant As tblParticipant
    Public Overridable Property tblReunion As tblReunion

End Class
Partial Public Class tblMembreStatutMembre
    Public Property NomStatut As String
    Public Property IdMembre As Short
    Public Property ComStatutMembre As String
    Public Property DateStatut As Date

    Public Overridable Property tblMembre As tblMembre
    Public Overridable Property tblStatutMembre As tblStatutMembre

End Class
Partial Public Class tblMessage
    Public Property IdMessage As Short
    Public Property DateMessage As Date
    Public Property ObjetMessage As String
    Public Property ContenuMessage As String
    Public Property IdMembre As Short

    Public Overridable Property tblMembre As ICollection(Of tblMembre) = New HashSet(Of tblMembre)

End Class
Partial Public Class tblModele
    Public Property NoModele As String
    Public Property Marque As String
    Public Property NbAnneeGarantie As Integer
    Public Property TypeMachine As String
    Public Property NoteModele As String
    Public Property PhotoModele As Byte()
    Public Property PrixModele As Nullable(Of Decimal)

    Public Overridable Property tblExemplaire As ICollection(Of tblExemplaire) = New HashSet(Of tblExemplaire)
    Public Overridable Property tblCompoModele As ICollection(Of tblCompoModele) = New HashSet(Of tblCompoModele)

End Class
Partial Public Class tblOrdreDuJour
    Public Property NoOrdreDuJour As Integer
    Public Property TitreOrdreJour As String
    Public Property Notes As String

    Public Overridable Property tblListePoint As ICollection(Of tblListePoint) = New HashSet(Of tblListePoint)
    Public Overridable Property tblProcesVerbaux As ICollection(Of tblProcesVerbaux) = New HashSet(Of tblProcesVerbaux)
    Public Overridable Property tblReunion As ICollection(Of tblReunion) = New HashSet(Of tblReunion)

End Class
Partial Public Class tblOrdreDuJourStatut
    Public Property NoOrdreDuJour As Integer
    Public Property CodeStatut As String
    Public Property DateStatut As Date
    Public Property CommStatut As String

    Public Overridable Property tblStatut As tblStatut

End Class
Partial Public Class tblParticipant
    Public Property IdTypeMembre As String
    Public Property DescriptionTypeMembre As String

    Public Overridable Property tblMembreParticipantReunion As ICollection(Of tblMembreParticipantReunion) = New HashSet(Of tblMembreParticipantReunion)

End Class
Partial Public Class tblPieceJointe
    Public Property IdPieceJointe As Integer
    Public Property DonneePieceJointe As Byte()
    Public Property NomFichier As String
    Public Property ExtentionFichier As String
    Public Property Description As String

    Public Overridable Property tblPoints As ICollection(Of tblPoints) = New HashSet(Of tblPoints)

End Class
Partial Public Class tblPoints
    Public Property IDPoint As Integer
    Public Property ListeEnfants As Nullable(Of Integer)
    Public Property NumeroPoint As Nullable(Of Double)
    Public Property TitrePoint As String
    Public Property InformationPoint As String
    Public Property PieceJointeOrdre As Nullable(Of Integer)
    Public Property NomPoint As String
    Public Property ChiffrePoint As String

    Public Overridable Property tblListePoint As tblListePoint
    Public Overridable Property tblTypePoint As tblTypePoint
    Public Overridable Property tblPieceJointe As ICollection(Of tblPieceJointe) = New HashSet(Of tblPieceJointe)
    Public Overridable Property tblListePoint1 As ICollection(Of tblListePoint) = New HashSet(Of tblListePoint)

End Class
Partial Public Class tblPret
    Public Property IdPret As Short
    Public Property IdMembre As Short
    Public Property TypeEtat As String

    Public Overridable Property tblMembre As tblMembre
    Public Overridable Property tblEtatPret As tblEtatPret
    Public Overridable Property tblPretExemplaire As ICollection(Of tblPretExemplaire) = New HashSet(Of tblPretExemplaire)

End Class
Partial Public Class tblPretExemplaire
    Public Property IdPret As Short
    Public Property CommentairePretEx As String
    Public Property DateFinPretEx As Nullable(Of Date)
    Public Property DateDebutPretEx As Nullable(Of Date)
    Public Property CodeBarre As Integer

    Public Overridable Property tblExemplaire As tblExemplaire
    Public Overridable Property tblPret As tblPret

End Class
Partial Public Class tblProcesVerbaux
    Public Property NoProcesVerbaux As Integer
    Public Property NotesProcesVerbaux As String
    Public Property NoOrdreDuJour As Integer

    Public Overridable Property tblOrdreDuJour As tblOrdreDuJour
    Public Overridable Property tblProcesVerbaux1 As tblProcesVerbaux
    Public Overridable Property tblProcesVerbaux2 As tblProcesVerbaux

End Class
Partial Public Class tblProfesseur
    Public Property NoEmploye As Integer
    Public Property ChargeTravailProfesseur As String
    Public Property CourrielCegepProfesseur As String
    Public Property NoBureauProfesseur As String
    Public Property PosteTelephoneProfesseur As Short
    Public Property IdMembre As Short

    Public Overridable Property tblMembre As tblMembre
    Public Overridable Property tblProfesseurStatutProfesseur As ICollection(Of tblProfesseurStatutProfesseur) = New HashSet(Of tblProfesseurStatutProfesseur)
    Public Overridable Property tblGroupe As ICollection(Of tblGroupe) = New HashSet(Of tblGroupe)

End Class
Partial Public Class tblProfesseurStatutProfesseur
    Public Property NomStatut As String
    Public Property NoEmploye As Integer
    Public Property DateDebutStatut As Date
    Public Property DateFinStatut As Date
    Public Property CommTache As String

    Public Overridable Property tblProfesseur As tblProfesseur
    Public Overridable Property tblStatutProfesseur As tblStatutProfesseur

End Class
Partial Public Class tblProgramme
    Public Property CodeProg As String
    Public Property NomProg As String
    Public Property ObjectifProg As String

    Public Overridable Property tblCours As ICollection(Of tblCours) = New HashSet(Of tblCours)
    Public Overridable Property tblEtudiant As ICollection(Of tblEtudiant) = New HashSet(Of tblEtudiant)

End Class
Partial Public Class tblReparation
    Public Property IdReparation As Short
    Public Property ProblemeRep As String
    Public Property SolutionRep As String
    Public Property DateDepart As Date
    Public Property DateRetour As Nullable(Of Date)
    Public Property EstTermine As Boolean
    Public Property CodeBarre As Integer

    Public Overridable Property tblExemplaire As tblExemplaire

End Class
Partial Public Class tblReunion
    Public Property NoReunion As Integer
    Public Property DateReunion As Date
    Public Property EndroitReunion As String
    Public Property NoOrdreDuJour As Integer
    Public Property NoLocal As String

    Public Overridable Property tblMembreParticipantReunion As ICollection(Of tblMembreParticipantReunion) = New HashSet(Of tblMembreParticipantReunion)
    Public Overridable Property tblOrdreDuJour As tblOrdreDuJour

End Class
Partial Public Class tblSession
    Public Property IdSession As String
    Public Property NomSession As String

    Public Overridable Property tblCoursSessionGroupe As ICollection(Of tblCoursSessionGroupe) = New HashSet(Of tblCoursSessionGroupe)

End Class
Partial Public Class tblStatut
    Public Property CodeStatut As String
    Public Property NomStatut As String
    Public Property DescriptionStatut As String

    Public Overridable Property tblOrdreDuJourStatut As ICollection(Of tblOrdreDuJourStatut) = New HashSet(Of tblOrdreDuJourStatut)

End Class
Partial Public Class tblStatutCours
    Public Property NomStatutCours As String
    Public Property DescriptionStatut As String

    Public Overridable Property tblStatutCoursCours As ICollection(Of tblStatutCoursCours) = New HashSet(Of tblStatutCoursCours)

End Class
Partial Public Class tblStatutCoursCours
    Public Property CodeCours As String
    Public Property NomStatutCours As String
    Public Property DateAcquisitionStatut As Date
    Public Property CommStatut As String

    Public Overridable Property tblCours As tblCours
    Public Overridable Property tblStatutCours As tblStatutCours

End Class
Partial Public Class tblStatutMembre
    Public Property NomStatut As String
    Public Property DescriptionStatut As String

    Public Overridable Property tblMembreStatutMembre As ICollection(Of tblMembreStatutMembre) = New HashSet(Of tblMembreStatutMembre)

End Class
Partial Public Class tblStatutProfesseur
    Public Property NomStatut As String
    Public Property DescriptionTache As String

    Public Overridable Property tblProfesseurStatutProfesseur As ICollection(Of tblProfesseurStatutProfesseur) = New HashSet(Of tblProfesseurStatutProfesseur)

End Class
Partial Public Class tblSysteme
    Public Property IdSysteme As Short
    Public Property ServiceTag As String
    Public Property NomReseau As String
    Public Property CodeBarre As Integer

    Public Overridable Property tblExemplaire As tblExemplaire

End Class
Partial Public Class tblTypePoint
    Public Property NomPoint As String
    Public Property DescriptionPoint As String

    Public Overridable Property tblPoints As ICollection(Of tblPoints) = New HashSet(Of tblPoints)

End Class
Partial Public Class tblTypeRapport
    Public Property IdTypeRapport As String
    Public Property NomTypeRapport As String
    Public Property NomFichierRapport As String

    Public Overridable Property tblElement As ICollection(Of tblElement) = New HashSet(Of tblElement)

End Class
Partial Public Class GetCompoModele_Result
    Public Property IdCompo As Short
    Public Property TypeCompo As String

End Class
Partial Public Class SelLstEtu_Result
    Public Property AnneeCours As String
    Public Property CodeCours As String
    Public Property DescriptionCours As String
    Public Property NomCours As String
    Public Property PonderationCours As String
    Public Property NoGroupe As Short
    Public Property DaEtudiant As Integer
    Public Property NomMembre As String
    Public Property PrenomMembre As String
    Public Property AdresseMembre As String
    Public Property CourrielMembre As String

End Class
Partial Public Class SelOrdJour_Result
    Public Property NumeroPoint As Nullable(Of Double)
    Public Property TitrePoint As String
    Public Property NomPoint As String
    Public Property TitreOrdreJour As String
    Public Property Notes As String
    Public Property ChiffrePoint As String

End Class
Partial Public Class SelOrdreJour_Result
    Public Property NoPoint As Nullable(Of Double)
    Public Property TitPoint As String
    Public Property Infos As String

End Class
Partial Public Class SelPointById_Result
    Public Property IDPoint As Integer
    Public Property InformationPoint As String
    Public Property ListeEnfants As Nullable(Of Integer)
    Public Property NomPoint As String
    Public Property NumeroPoint As Nullable(Of Double)
    Public Property PieceJointeOrdre As Nullable(Of Integer)
    Public Property TitrePoint As String
    Public Property ChiffrePoint As String

End Class
Partial Public Class SelrdJour_Result
    Public Property NoPoint As Nullable(Of Double)
    Public Property TitPoint As String
    Public Property Infos As String

End Class
Partial Public Class sp_helpdiagramdefinition_Result
    Public Property version As Nullable(Of Integer)
    Public Property definition As Byte()

End Class
Partial Public Class sp_helpdiagrams_Result
    Public Property Database As String
    Public Property Name As String
    Public Property ID As Integer
    Public Property Owner As String
    Public Property OwnerID As Integer

End Class
