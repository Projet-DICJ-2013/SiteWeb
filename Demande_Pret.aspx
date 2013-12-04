<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Demande_Pret.aspx.vb" Inherits="Demande_Pret" %>

<asp:Content ID="ContenuCorpsDemandePret" ContentPlaceHolderID="ContenuCorps" runat="Server">
    <div id="DivPret">
        <div id="TitrePret">Demande de prêt</div>
        <div id="TypeMat">
        Type de matériel : 
            
                 <asp:DropDownList AutoPostBack="true" ID="DropDownList1" runat="server">
                    <asp:ListItem Text="Choisir un type de matériel" Value="0" />
                    <asp:ListItem Text="Portable" Value="1" />
                    <asp:ListItem Text="Téléphone" Value="2" />
                    <asp:ListItem Text="Tablette" Value="3" />
                </asp:DropDownList>
            </div>
             
        <div id="ListeMod">
               Liste des modèles disponibles
    <asp:Table id="TablePret" runat="server">
        <asp:TableRow ID="TableRow1" runat="server">
            <asp:TableCell runat="server">Marque</asp:TableCell>
            <asp:TableCell runat="server">No. Modèle</asp:TableCell>
            <asp:TableCell runat="server">Note</asp:TableCell>
            <asp:TableCell runat="server"></asp:TableCell>
        </asp:TableRow>
        
    </asp:Table>
            </div>
        <div id="divEnvDem"><asp:Button runat="server" text="Envoyer la demande" OnClick="BoutonEnvoyer_Click" class="ReuRech"/></div>
        </div>
</asp:Content>
