<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="AGEECJ.aspx.vb" Inherits="AGEECJ" %>

<asp:Content ID="ContenuTopAGEECJ" ContentPlaceHolderID="ContenuTop" Runat="Server">

    	<div id="SousTitre">
		    <p> Bienvenue aux membre de l'AGEECJ <br><br> Envoyer des messages aux étudiants   <br><br> et préparer vos réunion 
                    <br><br> à partir des internets </p>
	    </div>
				
	    <div id="ImgTop">
            <img src="./images/AGEECJ_sans.png" />
	    </div>

    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server" />

    
</asp:Content>

<asp:Content ID="ContenuCorpsAGEECJ" ContentPlaceHolderID="ContenuCorps" Runat="Server">  
    
    <div id="divAGEECJ">
        <div id="TitreAsso">Envoi de messages aux membres de l'association étudiante</div>
        <div id="CritereMessage">
            <asp:label id="lblDest" runat="server">Destinataires:</asp:label>
            <asp:Panel ID="panRadio" runat="server" >
                <Table runat="server">
                    
                    <tr>

                        <td>
                            <asp:RadioButton ID="rbPremier" runat="server" GroupName="rads" Checked="true" Text="Première année" /> &nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:RadioButton ID="rbDeuxieme" runat="server" GroupName="rads" Text="Deuxième année" />&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:RadioButton ID="rbTroisieme" runat="server" GroupName="rads" Text="Troisième année" />&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:RadioButton ID="rbTous" runat="server" GroupName="rads" Text="Tous les années" />&nbsp;&nbsp;&nbsp;&nbsp;
                        </td>

                    </tr>
                </Table>
            </asp:Panel>
        </div>
        <div id="ContenuMessage">
            <div id="divObjet">
            <asp:label id="lblObjet" runat="server">Objet:</asp:label>
            <asp:TextBox ID="txtObjet" runat="server" Width="88%"></asp:TextBox>  
            </div>
            <div id="divMessage">
            <asp:label id="lblMessage" runat="server">Message:</asp:label>
            </div>
            <div id="divTexte">
            <textarea ID="txtArMessage" runat="server" rows="5" cols ="100">Votre Message Ici!</textarea><br />
            </div>
             
        </div>
        <div id="divEnvoyer">
            <asp:Button ID="btnEnvoyer" class="ReuRech" runat="server" Text="Envoyer" OnClick="btnEnvoyer_Click1"/>
            <asp:Label ID="lblCommentaire" runat="server" Visible="false"/>
            </div>
        </div>
       
</asp:Content>