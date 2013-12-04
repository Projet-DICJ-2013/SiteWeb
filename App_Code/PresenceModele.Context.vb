﻿'------------------------------------------------------------------------------
' <auto-generated>
'    Ce code a été généré à partir d'un modèle.
'
'    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
'    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Linq

Partial Public Class PresenceModEntity
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=PresenceModEntity")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Property sysdiagrams() As DbSet(Of sysdiagrams)
    Public Property tblConstant() As DbSet(Of tblConstant)
    Public Property tblCours() As DbSet(Of tblCours)
    Public Property tblCoursSessionGroupe() As DbSet(Of tblCoursSessionGroupe)
    Public Property tblEtudiant() As DbSet(Of tblEtudiant)
    Public Property tblGroupe() As DbSet(Of tblGroupe)
    Public Property tblGroupeLocal() As DbSet(Of tblGroupeLocal)
    Public Property tblLocal() As DbSet(Of tblLocal)
    Public Property tblLogin() As DbSet(Of tblLogin)
    Public Property tblMembre() As DbSet(Of tblMembre)
    Public Property tblMembreAssociation() As DbSet(Of tblMembreAssociation)
    Public Property tblMembreAssociationEtudiant() As DbSet(Of tblMembreAssociationEtudiant)
    Public Property tblMembreParticipantReunion() As DbSet(Of tblMembreParticipantReunion)
    Public Property tblMembreStatutMembre() As DbSet(Of tblMembreStatutMembre)
    Public Property tblMessage() As DbSet(Of tblMessage)
    Public Property tblParticipant() As DbSet(Of tblParticipant)
    Public Property tblProfesseur() As DbSet(Of tblProfesseur)
    Public Property tblProfesseurStatutProfesseur() As DbSet(Of tblProfesseurStatutProfesseur)
    Public Property tblProgramme() As DbSet(Of tblProgramme)
    Public Property tblSession() As DbSet(Of tblSession)
    Public Property tblStatutCours() As DbSet(Of tblStatutCours)
    Public Property tblStatutCoursCours() As DbSet(Of tblStatutCoursCours)
    Public Property tblStatutMembre() As DbSet(Of tblStatutMembre)
    Public Property tblStatutProfesseur() As DbSet(Of tblStatutProfesseur)
    Public Property tblListePoint() As DbSet(Of tblListePoint)
    Public Property tblOrdreDuJour() As DbSet(Of tblOrdreDuJour)
    Public Property tblOrdreDuJourStatut() As DbSet(Of tblOrdreDuJourStatut)
    Public Property tblPieceJointe() As DbSet(Of tblPieceJointe)
    Public Property tblPoints() As DbSet(Of tblPoints)
    Public Property tblProcesVerbaux() As DbSet(Of tblProcesVerbaux)
    Public Property tblReunion() As DbSet(Of tblReunion)
    Public Property tblStatut() As DbSet(Of tblStatut)
    Public Property tblTypePoint() As DbSet(Of tblTypePoint)
    Public Property tblBesoin() As DbSet(Of tblBesoin)
    Public Property tblCompoModele() As DbSet(Of tblCompoModele)
    Public Property tblDemande() As DbSet(Of tblDemande)
    Public Property tblEtatDemande() As DbSet(Of tblEtatDemande)
    Public Property tblEtatExemplaire() As DbSet(Of tblEtatExemplaire)
    Public Property tblEtatPret() As DbSet(Of tblEtatPret)
    Public Property tblExemplaire() As DbSet(Of tblExemplaire)
    Public Property tblHistoriquePret() As DbSet(Of tblHistoriquePret)
    Public Property tblModele() As DbSet(Of tblModele)
    Public Property tblPret() As DbSet(Of tblPret)
    Public Property tblPretExemplaire() As DbSet(Of tblPretExemplaire)
    Public Property tblReparation() As DbSet(Of tblReparation)
    Public Property tblSysteme() As DbSet(Of tblSysteme)
    Public Property tblActualite() As DbSet(Of tblActualite)
    Public Property tblElement() As DbSet(Of tblElement)
    Public Property tblTypeRapport() As DbSet(Of tblTypeRapport)

    <EdmFunction("PresenceModEntity", "SelOrdreJour")>
    Public Overridable Function SelOrdreJour(noOrdre As Nullable(Of Integer)) As IQueryable(Of SelOrdreJour_Result)
        Dim noOrdreParameter As ObjectParameter = If(noOrdre.HasValue, New ObjectParameter("NoOrdre", noOrdre), New ObjectParameter("NoOrdre", GetType(Integer)))

         Return DirectCast(Me, IObjectContextAdapter).ObjectContext.CreateQuery(Of SelOrdreJour_Result)("[PresenceModEntity].[SelOrdreJour](@NoOrdre)", noOrdreParameter)
    End Function

    <EdmFunction("PresenceModEntity", "SelrdJour")>
    Public Overridable Function SelrdJour(noOrdre As Nullable(Of Integer)) As IQueryable(Of SelrdJour_Result)
        Dim noOrdreParameter As ObjectParameter = If(noOrdre.HasValue, New ObjectParameter("NoOrdre", noOrdre), New ObjectParameter("NoOrdre", GetType(Integer)))

         Return DirectCast(Me, IObjectContextAdapter).ObjectContext.CreateQuery(Of SelrdJour_Result)("[PresenceModEntity].[SelrdJour](@NoOrdre)", noOrdreParameter)
    End Function

    Public Overridable Function GetCompoModele(monMod As String) As ObjectResult(Of GetCompoModele_Result)
        Dim monModParameter As ObjectParameter = If(monMod IsNot Nothing, New ObjectParameter("MonMod", monMod), New ObjectParameter("MonMod", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of GetCompoModele_Result)("GetCompoModele", monModParameter)
    End Function

    Public Overridable Function SelLstEtu(idGroupe As Nullable(Of Short)) As ObjectResult(Of SelLstEtu_Result)
        Dim idGroupeParameter As ObjectParameter = If(idGroupe.HasValue, New ObjectParameter("IdGroupe", idGroupe), New ObjectParameter("IdGroupe", GetType(Short)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of SelLstEtu_Result)("SelLstEtu", idGroupeParameter)
    End Function

    Public Overridable Function SelOrdJour(noOrdre As Nullable(Of Integer)) As ObjectResult(Of SelOrdJour_Result)
        Dim noOrdreParameter As ObjectParameter = If(noOrdre.HasValue, New ObjectParameter("NoOrdre", noOrdre), New ObjectParameter("NoOrdre", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of SelOrdJour_Result)("SelOrdJour", noOrdreParameter)
    End Function

    Public Overridable Function SelPointById(noPoint As Nullable(Of Integer)) As ObjectResult(Of SelPointById_Result)
        Dim noPointParameter As ObjectParameter = If(noPoint.HasValue, New ObjectParameter("NoPoint", noPoint), New ObjectParameter("NoPoint", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of SelPointById_Result)("SelPointById", noPointParameter)
    End Function

    Public Overridable Function sp_alterdiagram(diagramname As String, owner_id As Nullable(Of Integer), version As Nullable(Of Integer), definition As Byte()) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Dim versionParameter As ObjectParameter = If(version.HasValue, New ObjectParameter("version", version), New ObjectParameter("version", GetType(Integer)))

        Dim definitionParameter As ObjectParameter = If(definition IsNot Nothing, New ObjectParameter("definition", definition), New ObjectParameter("definition", GetType(Byte())))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter)
    End Function

    Public Overridable Function sp_creatediagram(diagramname As String, owner_id As Nullable(Of Integer), version As Nullable(Of Integer), definition As Byte()) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Dim versionParameter As ObjectParameter = If(version.HasValue, New ObjectParameter("version", version), New ObjectParameter("version", GetType(Integer)))

        Dim definitionParameter As ObjectParameter = If(definition IsNot Nothing, New ObjectParameter("definition", definition), New ObjectParameter("definition", GetType(Byte())))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter)
    End Function

    Public Overridable Function sp_dropdiagram(diagramname As String, owner_id As Nullable(Of Integer)) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter)
    End Function

    Public Overridable Function sp_helpdiagramdefinition(diagramname As String, owner_id As Nullable(Of Integer)) As ObjectResult(Of sp_helpdiagramdefinition_Result)
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of sp_helpdiagramdefinition_Result)("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter)
    End Function

    Public Overridable Function sp_helpdiagrams(diagramname As String, owner_id As Nullable(Of Integer)) As ObjectResult(Of sp_helpdiagrams_Result)
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of sp_helpdiagrams_Result)("sp_helpdiagrams", diagramnameParameter, owner_idParameter)
    End Function

    Public Overridable Function sp_renamediagram(diagramname As String, owner_id As Nullable(Of Integer), new_diagramname As String) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Dim new_diagramnameParameter As ObjectParameter = If(new_diagramname IsNot Nothing, New ObjectParameter("new_diagramname", new_diagramname), New ObjectParameter("new_diagramname", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter)
    End Function

    Public Overridable Function sp_upgraddiagrams() As Integer
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_upgraddiagrams")
    End Function

End Class
