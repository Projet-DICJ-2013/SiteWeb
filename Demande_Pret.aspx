﻿<%@ Page  Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Demande_Pret.aspx.vb" Inherits="Demande_Pret" %>

<asp:Content ID="ContenuTopDemandePret" ContentPlaceHolderID="ContenuTop" Runat="Server">


<asp:Table ID="Table1" runat="server">
            <asp:TableRow ID="TableRow1" runat="server">
                <asp:TableCell ID="TableCell1" runat="server">Modèle : </asp:TableCell>
                <asp:TableCell ID="TableCell2" runat="server">
                    <asp:DropDownList ID="drpModele" runat="server"></asp:DropDownList></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow ID="TableRow2" runat="server">
                <asp:TableCell ID="TableCell3" runat="server"></asp:TableCell>
                <asp:TableCell ID="TableCell4" runat="server"></asp:TableCell>
            </asp:TableRow>
        </asp:Table>

    </asp:Content>