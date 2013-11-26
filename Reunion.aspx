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
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css">
  <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
  <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
  <script>
      $(function () {
          $("#from").datepicker({
              defaultDate: "+1w",
              changeMonth: true,
              numberOfMonths: 3,
              onClose: function (selectedDate) {
                  $("#to").datepicker("option", "minDate", selectedDate);
              }
          });
          $("#to").datepicker({
              defaultDate: "+1w",
              changeMonth: true,
              numberOfMonths: 3,
              onClose: function (selectedDate) {
                  $("#from").datepicker("option", "maxDate", selectedDate);
              }
          });
      });
  </script>
  
    

    <div id="PrincipalReunion">
        <div id="TitreRecherche"><h1>Consultation des ordres du jour et des procès-verbaux</h1></div>
        
        <div id="SectionCritere">
        <div id="TypeRercherche">
        <asp:RadioButton ID="RadOdj" runat="server" Text="Ordres du jours" GroupName="TypRech"/>
        <asp:RadioButton ID="RadPv" runat="server" Text="Procès-verbaux" GroupName="TypRech"/>
        </div>
        <div id="SectionCritereLigne">        
        <div id="SectionCritGauche">
        <p>Par Date</p>
         <div id="CritDate">        
        <label for="from">Du</label>
        <input type="text" id="from" name="from">
        <label for="to">Au</label>
        <input type="text" id="to" name="to">
        </div>
        </div>
        <div id="SectionCritDroit">
        <p>Par Participant</p>
        <div id="CritTypeParticipant">  
        <asp:DropDownList ID="lstTypeParticipant" runat="server" OnSelectedIndexChanged="lstTypeParticipant_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem>Aucun</asp:ListItem>
            <asp:ListItem>Professeur</asp:ListItem>
            <asp:ListItem>Etudiant - 1er</asp:ListItem>
            <asp:ListItem>Etudiant - 2e</asp:ListItem>
            <asp:ListItem>Etudiant - 3e</asp:ListItem>            
            </asp:DropDownList>
        <asp:DropDownList ID="lstParticipant" runat="server" Enabled="True"/>
            

  
        </div> 
        </div>
           
        </div>
        <div id="BoutonReu">
        <input id="ReuNouvRech" type="submit" value="Nouvelle Recherche" class="ReuRech">
        <input  type="submit" value="Rechercher" class="ReuRech">
        </div>        
        </div>
         <div id="SectionResultats">
         <asp:ListBox ID="ListeResultat" runat="server" >
             <asp:ListItem></asp:ListItem>
             </asp:ListBox>           
        </div>
        </div>
</asp:Content>
