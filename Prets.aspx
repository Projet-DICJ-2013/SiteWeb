<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Prets.aspx.vb" Inherits="Prets" %>

<asp:Content ID="ContenuTopPrets" ContentPlaceHolderID="ContenuTop" Runat="Server">


				

            <asp:Table ID="Table1" runat="server">
            <asp:TableRow ID="TableRow1" runat="server">
                <asp:TableCell ID="TableCell1" VerticalAlign="Top" runat="server">    	
                    <div id="SousTitre">
		    <p> Découvrez tout l'inventaire! <br><br> Choisissez votre exemplaire,  <br><br>  voyez vos historiques 
                    <br><br> et notre inventaire</p>
	    </div>

                </asp:TableCell>
                <asp:TableCell RowSpan="2"  ID="TableCell2" runat="server">	    
                    <div id="ImgTop">
		    <img  src="./images/CNC.Laptop.png"/>
	    </div></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow ID="TableRow2" runat="server">

                <asp:TableCell VerticalAlign="Top" ID="TableCell3" runat="server">
                    <asp:Button Width="300" Height="50" id="btnDemande"
           Text="Faire une demande de prêt..."
           OnClick="btnDemande_Click" 
           runat="server"/></asp:TableCell>

            </asp:TableRow>
        </asp:Table>

    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server" />

    
</asp:Content>

<asp:Content ID="ContenuCorpsPret" ContentPlaceHolderID="ContenuCorps" Runat="Server">

</asp:Content>