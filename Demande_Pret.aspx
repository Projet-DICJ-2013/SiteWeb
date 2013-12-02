<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Demande_Pret.aspx.vb" Inherits="Demande_Pret" %>

<asp:Content ID="ContenuCorpsDemandePret" ContentPlaceHolderID="ContenuCorps" runat="Server">
    <div id="DivPret">
    <asp:Table id="TablePret" runat="server">
        <asp:TableRow runat="server">
            <asp:TableCell ID="TableCell3" runat="server">Type de matériel : </asp:TableCell>
            <asp:TableCell ID="TableCell4" runat="server">
                <asp:DropDownList AutoPostBack="true" ID="DropDownList1" runat="server">
                    <asp:ListItem Text="Choisir un type de matériel" Value="0" />
                    <asp:ListItem Text="Portable" Value="1" />
                    <asp:ListItem Text="Téléphone" Value="2" />
                    <asp:ListItem Text="Tablette" Value="3" />
                </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
            <asp:TableCell ID="TableCell1" runat="server">Liste des modèles disponibles</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="TableRow1" runat="server">
            <asp:TableCell runat="server">Marque</asp:TableCell>
            <asp:TableCell runat="server">No. Modèle</asp:TableCell>
            <asp:TableCell runat="server">Note</asp:TableCell>
            <asp:TableCell runat="server"></asp:TableCell>
        </asp:TableRow>
        
    </asp:Table>

        </div>
</asp:Content>
