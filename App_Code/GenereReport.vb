﻿Imports System
Imports System.Text
Imports System.IO
Imports System.Xml.Linq
Imports System.Collections.Generic
Imports System.Xml
Imports P2013_CreateDoc
Imports System.Windows

Public Module ModRapport


    Public Class GenereRapport
        Inherits System.Web.UI.Page

        Private ModeleRapport As RaportOrd
        Private ModeleMat As RaportModele
        Private ModeleCours As RaportCours
        Private MonRapport As P2013_CreateDoc.CreateReport
        Private MonStyle As ModeleStyle
        Private MonPDF As P2013_CreateDoc.GenerePdf
        Private Path As String
        Private Temp As String
        Private FilePDF As String
        Private FileWord As String

        Public Property TempFilePDF As String
            Get
                Return FilePDF
            End Get
            Set(value As String)
                FilePDF = value
            End Set
        End Property

        Public Sub New()
            Path = Server.MapPath("~/") + "bin/"
            Temp = Guid.NewGuid().ToString
        End Sub

        Public Sub CreerRapportOrd(ByVal Id As Integer)

            Dim mon_msg As String

            ModeleRapport = New RaportOrd(Id)

            MonStyle = New ModeleStyle("OrdJour001")

            MonRapport = New P2013_CreateDoc.CreateReport(ModeleRapport.GetContenuDoc, Temp, Path, False)

            MonRapport.DefineStyle(MonStyle.GetStyle(), Path + MonStyle.GetModele())

            MonRapport.CreerWorld()
            mon_msg = MonRapport.IsGenere()


            MonPDF = New P2013_CreateDoc.GenerePdf(Temp, Path)
            mon_msg = MonPDF.ConvertToPDF()

            File.Delete(Path + Temp + ".docx")
            TempFilePDF = Path + Temp + ".pdf"
        End Sub

        Public Sub CreerRapportMat(ByVal Id As String)

            Dim mon_msg As String

            ModeleMat = New RaportModele(Id)

            MonStyle = New ModeleStyle("LstMat001")

            MonRapport = New P2013_CreateDoc.CreateReport(ModeleMat.GetContenuDoc, Id, Path, False)

            MonRapport.DefineStyle(MonStyle.GetStyle(), MonStyle.GetModele())

            MonRapport.CreerWorld()
            mon_msg = MonRapport.IsGenere()
            MsgBox(mon_msg)

            MonPDF = New P2013_CreateDoc.GenerePdf(Id, Path)
            mon_msg = MonPDF.ConvertToPDF()
            MsgBox(mon_msg)

            File.Delete(Path + Temp + ".docx")
            TempFilePDF = Path + Temp + ".pdf"
        End Sub

        Public Sub CreerRapportCours(ByVal Id As String)

            Dim mon_msg As String

            ModeleCours = New RaportCours(Id)

            MonStyle = New ModeleStyle("LCours001")

            MonRapport = New P2013_CreateDoc.CreateReport(ModeleCours.GetContenuDoc, Id, Path, False)

            MonRapport.DefineStyle(MonStyle.GetStyle(), MonStyle.GetModele())

            MonRapport.CreerWorld()
            mon_msg = MonRapport.IsGenere()
            MsgBox(mon_msg)

            MonPDF = New P2013_CreateDoc.GenerePdf(Id, Path)
            mon_msg = MonPDF.ConvertToPDF()
            MsgBox(mon_msg)

            File.Delete(Path + Temp + ".docx")
            TempFilePDF = Path + Temp + ".pdf"
        End Sub
    End Class

    Public Class RaportOrd
        Inherits P2013_CreateDoc.ModeleInfos

        Private _Bd_Presence As New PresenceModEntity

        Public Sub New(ByVal IdOrdre As String)
            MyBase.New(IdOrdre)
            GetData()
        End Sub

        Protected Overloads Sub GetData()

            Dim NoOrdre = (From Ordre In _Bd_Presence.tblOrdreDuJour
                           Where Ordre.NoOrdreDuJour = _IdElem
                           Select Ordre.TitreOrdreJour)


            Dim res = From od As tblListePoint In _Bd_Presence.tblListePoint Where od.NoOrdreDuJour = _IdElem Select od
            Dim prem = res.First()

            Dim rap = New XElement("root", New XElement("Contenu", New XElement("Head", New XAttribute("id", "Pts003"), NoOrdre)))

            TraiterPoint(rap, prem.tblPoints1)

            _ContenuDoc = rap

        End Sub

        Protected Sub TraiterPoint(parent As XElement, lst As IEnumerable(Of tblPoints))
            Dim enf As XElement
            For Each p As tblPoints In lst
                Try
                    enf = New XElement("Titre", p.ChiffrePoint & "  " & p.TitrePoint)
                    parent.Element("Contenu").Add(enf)

                    If p.ChiffrePoint.Length >= 6 Then
                        enf.Add(New XAttribute("id", "Pts004"))
                    ElseIf p.ChiffrePoint.Length >= 4 And p.ChiffrePoint.Length < 6 Then
                        enf.Add(New XAttribute("id", "Pts002"))
                    ElseIf p.ChiffrePoint.Length >= 2 And p.ChiffrePoint.Length < 4 Then
                        enf.Add(New XAttribute("id", "Pts001"))
                    End If

                    If p.ListeEnfants IsNot Nothing Then
                        TraiterPoint(parent, p.tblListePoint.tblPoints1)
                    End If
                Catch ex As Exception

                End Try

            Next

        End Sub

        Public Overloads Function GetContenuDoc()
            Return _ContenuDoc
        End Function



    End Class

    Public Class RaportModele
        Inherits P2013_CreateDoc.ModeleInfos

        Private _Bd_Presence As New PresenceModEntity
        Private _ModListe As XElement = <Liste>
                                            <Date></Date>
                                            <NoSerie></NoSerie>
                                            <Marque></Marque>
                                            <TypeMachine></TypeMachine>
                                            <Prix></Prix>
                                            <Commentaire></Commentaire>
                                        </Liste>

        Public Sub New(ByVal IdOrdre As String)
            MyBase.New(IdOrdre)
            GetData()
        End Sub

        Protected Overloads Sub GetData()

            Dim Materiel As XElement
            Dim Rap As New XElement("Root", New XElement("Head", New XElement _
            ("header", New XAttribute("id", "Mat005"), "Rapport de prêt - " & Date.Today)))

            Dim Pret = (From MonPret As tblPret In _Bd_Presence.tblPret
                        Where MonPret.IdPret = _IdElem
                        Select MonPret).First

            Materiel = New XElement("LstEmprunt", New XAttribute("id", "Mat006"))

            Rap.Add(New XElement("Corps",
                    New XElement("Nom",
                        New XAttribute("id", "Mat002"),
                        "Matériel prêté:  " & Pret.tblMembre.PrenomMembre _
                        & "  " & Pret.tblMembre.NomMembre), Materiel))

            Materiel.Add(CreateLstMat("Date du prêt", "Numéro de série", "Marque", "Type de machine", "Prix", "Commentaire", _
                                      New XAttribute("id", "Mat003")))

            Dim PretExemp As IEnumerable(Of tblPretExemplaire) = Pret.tblPretExemplaire

            For Each exemp As tblPretExemplaire In PretExemp

                Materiel.Add(CreateLstMat("Du: " & exemp.DateDebutPretEx & "  " & "Au: " & exemp.DateFinPretEx, _
                                exemp.tblExemplaire.NoSerie, _
                                exemp.tblExemplaire.tblModele.Marque, _
                                exemp.tblExemplaire.tblModele.TypeMachine, _
                                exemp.tblExemplaire.tblModele.PrixModele, _
                                exemp.CommentairePretEx, _
                                 New XAttribute("id", "Mat002")))
                'Materiel.Add(New XElement("Image", New XAttribute("id", "Mat007"), "\images\dell.jpg"))
            Next


            _ContenuDoc = Rap

        End Sub

        Public Overloads Function GetContenuDoc()
            Return _ContenuDoc
        End Function

        Protected Function CreateLstMat(DatePret As String, NoSerie As String, Marque As String, Type As String, _
                                         ByVal Prix As String, ByVal Commentaire As String, ByVal Attr As XAttribute) As XElement
            Dim lstMat As New XElement(_ModListe)

            lstMat.Element("Date").Add(New XAttribute(Attr), New XText(DatePret))
            lstMat.Element("NoSerie").Add(New XAttribute(Attr), New XText(NoSerie))
            lstMat.Element("Marque").Add(New XAttribute(Attr), New XText(Marque))
            lstMat.Element("TypeMachine").Add(New XAttribute(Attr), New XText(Type))
            lstMat.Element("Prix").Add(New XAttribute(Attr), New XText(Prix))
            If (Commentaire Is Nothing) Then
                lstMat.Element("Commentaire").Add(New XAttribute(Attr), New XText("Aucun"))
            Else
                lstMat.Element("Commentaire").Add(New XAttribute(Attr), New XText(Commentaire))
            End If


            Return lstMat
        End Function

    End Class

    Public Class RaportCours
        Inherits P2013_CreateDoc.ModeleInfos

        Private _Bd_Presence As New PresenceModEntity

        Public Sub New(ByVal IdOrdre As String)
            MyBase.New(IdOrdre)
            GetData()
        End Sub

        Protected Overloads Sub GetData()

            '_ContenuDoc = New XElement("Root",
            '    (From Lst In _Bd_Presence.LstEtu(_IdElem)
            '        Select New With {Lst.NomCours,
            '                         Lst.PonderationCours,
            '                         Lst.DescriptionCours,
            '                         Lst.AnneeCours,
            '                         Lst.DaEtudiant,
            '                         Lst.PrenomMembre,
            '                         Lst.NomMembre,
            '                         Lst.AdresseMembre,
            '                         Lst.CourrielMembre}).ToList.Select(
            '              Function(x) New XElement("Cours", New XElement("Conteneur",
            '                       New XElement("NomCours",
            '                           New XAttribute("id", "Co001"),
            '                           x.NomCours),
            '                        New XElement("Ponderation",
            '                               New XAttribute("id", "Co002"),
            '                               x.PonderationCours),
            '                       New XElement("DescCours",
            '                           New XAttribute("id", "Co002"),
            '                           x.DescriptionCours),
            '                       New XElement("Annee",
            '                           New XAttribute("id", "Co002"),
            '                           x.AnneeCours),
            '                    New XElement("Fiche", New XAttribute("id", "Co004"),
            '                        New XElement("DaEtudiant",
            '                               New XAttribute("id", "Co003"),
            '                               x.DaEtudiant),
            '                       New XElement("Prenom",
            '                           New XAttribute("id", "Co003"),
            '                           x.PrenomMembre),
            '                       New XElement("NomMembre",
            '                           New XAttribute("id", "Co003"),
            '                           x.NomMembre),
            '                        New XElement("Adresse",
            '                               New XAttribute("id", "Co003"),
            '                               x.AdresseMembre),
            '                       New XElement("Courriel",
            '                           New XAttribute("id", "Co003"),
            '                           x.CourrielMembre)
            '                       )))))


        End Sub

        Public Overloads Function GetContenuDoc()
            Return _ContenuDoc
        End Function



    End Class

End Module