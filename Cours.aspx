<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Cours.aspx.vb" Inherits="Cours" %>

<asp:Content ID="ContenuTopCours" ContentPlaceHolderID="ContenuTop" Runat="Server">

    	<div id="SousTitre">
		    <p> Parcourez tous vos cours! <br><br> Voyez les messages de vos enseignants  <br><br> et consulter toutes les 
                    <br><br> informations sur vos cours </p>
	    </div>
				
	    <div id="ImgTop">
		    <img  src="./images/group-icon.png"/>
	    </div>

    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server" />

    
</asp:Content>

<asp:Content ID="ContenuCorpsCours" ContentPlaceHolderID="ContenuCorps" Runat="Server">

</asp:Content>