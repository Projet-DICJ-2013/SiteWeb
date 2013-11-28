<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="AGEECJ.aspx.vb" Inherits="AGEECJ" %>

<asp:Content ID="ContenuTopAGEECJ" ContentPlaceHolderID="ContenuTop" Runat="Server">

    	<div id="SousTitre">
		    <p> Bienvenu aux membre de l'AGEECJ <br><br> Envoyer des messages aux étudiants   <br><br> et préparer vos réunion 
                    <br><br> à partir des internets </p>
	    </div>
				
	    <div id="ImgTop">
            <img src="./images/AGEECJ_sans.png" />
	    </div>

    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server" />

    
</asp:Content>

<asp:Content ID="ContenuCorpsAGEECJ" ContentPlaceHolderID="ContenuCorps" Runat="Server">  
    <div id="divAGEECJ">
    <asp:Panel ID="panRadio" runat="server" GroupingText="Destinataires: " Width="30%">
        <Table runat="server">
            <tr>
                <td>
                    <asp:RadioButton ID="rbPremier" runat="server" GroupName="rads" Checked="true" Text="Première année  " />
                    <asp:RadioButton ID="rbTroisieme" runat="server" GroupName="rads" Text="Troisième année" />

                </td>
            </tr>

            <tr>
                <td>
                    <asp:RadioButton ID="rbDeuxieme" runat="server" GroupName="rads" Text="Deuxième année" />
                    <asp:RadioButton ID="rbTous" runat="server" GroupName="rads" Text="Tous les années" />
                </td>
            </tr>
        </Table>
    </asp:Panel>

    <div id="divObjet">
        <asp:label id="lblObjet" runat="server">Objet:</asp:label>
        <asp:TextBox ID="txtObjet" runat="server"></asp:TextBox>
    </div>
    
    <div id="divMessage">
        <asp:label id="lblMessage" runat="server">Message:</asp:label>
    </div>
<textarea ID="txtArMessage" runat="server" rows="5" cols ="60">Votre Message Ici!</textarea><br />

    <asp:Button ID="btnEnvoyer" runat="server" Height="30px" Width="100px" Text="Envoyer" OnClick="btnEnvoyer_Click1"/>
    <asp:Label ID="lblCommentaire" runat="server" Visible="false"/>
</div>
</asp:Content>