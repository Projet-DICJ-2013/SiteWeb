<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Prets.aspx.vb" Inherits="Prets" %>

<asp:Content ID="ContenuTopPrets" ContentPlaceHolderID="ContenuTop" Runat="Server">

    	<div id="SousTitre">
		    <p> Découvrez tout l'inventaire! <br><br> Choisissez votre exemplaire,  <br><br>  voyez vos historiques 
                    <br><br> et notre inventaire</p>
	    </div>
				
	    <div id="ImgTop">
		    <img  src="./images/CNC.Laptop.png"/>
	    </div>

    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server" />

    
</asp:Content>

<asp:Content ID="ContenuCorpsPret" ContentPlaceHolderID="ContenuCorps" Runat="Server">

</asp:Content>