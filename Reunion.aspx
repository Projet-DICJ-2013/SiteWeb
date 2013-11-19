<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Reunion.aspx.vb" Inherits="Reunion" %>

<asp:Content ID="ContenuTopReu" ContentPlaceHolderID="ContenuTop" Runat="Server">

    	<div id="SousTitre">
		    <p> Ne manquez plus rien sur vos réunions! <br><br> Consultez les dates, lieux de vos réunions. <br><br> Accédez aux ordres du jour
                    <br><br> et aux procès verbaux</p>
	    </div>
				
	    <div id="ImgTop">
		    <img  src="./images/desk.png"/>
	    </div>

    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server" />

    
</asp:Content>

<asp:Content ID="ContenuCorpsReu" ContentPlaceHolderID="ContenuCorps" Runat="Server">

    <div>
        <input type="text" />
        <input type="button" value="Générer" />
        <iframe id="FramePdf"></iframe>
    </div>

</asp:Content>
