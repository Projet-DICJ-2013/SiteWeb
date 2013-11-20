<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Reunion.aspx.vb" Inherits="Reunion" %>

<script runat="server">

    Sub GetPdf_Click(ByVal sender As Object, ByVal e As EventArgs)
        
        Dim TempsFile As String
        Dim MonPdf As New GetPdf
        
        TempsFile = GetMyPDF(txtPDF.Text)
        
        HttpContext.Current.Session("Rapport") = TempsFile
        MonPdf.ProcessRequest(Me.Context)
    End Sub

</script>

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
        <asp:TextBox ID="txtPDF"
            runat="server" />

        <asp:Button id="btnPDF"
           Text="Click here for greeting..."
           OnClick="GetPdf_Click" 
           runat="server"/>
        
    </div>
</asp:Content>
