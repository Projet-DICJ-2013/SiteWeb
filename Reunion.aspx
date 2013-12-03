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
        <div id="PrincipalReunion">
        
         <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
                            <ContentTemplate>
  <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css">
  <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
  <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"> </script>
    


  <script>

      $(document).ready(function () {
          $(function () {
              $("#from").datepicker({
                  dateFormat: "yy-mm-dd",
                  defaultDate: "+1w",
                  changeMonth: true,
                  numberOfMonths: 1,
                  onClose: function (selectedDate) {
                      $("#to").datepicker("option", "minDate", selectedDate);
                  }
              });
              $("#to").datepicker({
                  dateFormat: "yy-mm-dd",
                  defaultDate: "+1w",
                  changeMonth: true,
                  numberOfMonths: 1,
                  onClose: function (selectedDate) {
                      $("#from").datepicker("option", "maxDate", selectedDate);
                  }
              });

          });
      });

      var prm = Sys.WebForms.PageRequestManager.getInstance();

      prm.add_endRequest(function () {
          $(function () {
              $("#from").datepicker({
                  dateFormat: "yy-mm-dd",
                  defaultDate: "+1w",
                  changeMonth: true,
                  numberOfMonths: 1,
                  onClose: function (selectedDate) {
                      $("#to").datepicker("option", "minDate", selectedDate);
                  }
              });
              $("#to").datepicker({
                  dateFormat: "yy-mm-dd",
                  defaultDate: "+1w",
                  changeMonth: true,
                  numberOfMonths: 1,
                  onClose: function (selectedDate) {
                      $("#from").datepicker("option", "maxDate", selectedDate);
                  }
              });

          });
      });

     
  </script>
  
    

        <div id="SectionCritere">
            <div id="TitreRecherche">Consultation des ordres du jour et des procès-verbaux</div>

            <div id="SectionCritereLigne">        
                <div id="SectionCritGauche">
                    <p>Par Date</p>
                    <div id="CritDate">
                    <div id="CritDate1">
                                
                        <label for="from">Du</label>
                        <input type="text" id="from" name="from"/>
                          
                    </div>
                    <div id="CritDate2">
                        
                        <label for="to">Au</label>
                        <input type="text" id="to" name="to">
                         
                    </div>
                    </div>
                </div>
                <div id="SectionCritDroit">
                    <p>Par Participant</p>
                    <div id="CritTypeParticipant">
                                                 <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">

                            <ContentTemplate>
                        <asp:DropDownList ID="lstTypeParticipant" runat="server" OnSelectedIndexChanged="lstTypeParticipant_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem>Aucun</asp:ListItem>
                            <asp:ListItem>Professeur</asp:ListItem>
                            <asp:ListItem>Etudiant - 1er</asp:ListItem>
                            <asp:ListItem>Etudiant - 2e</asp:ListItem>
                            <asp:ListItem>Etudiant - 3e</asp:ListItem>            
                            </asp:DropDownList>

                            
                              
                                                   
                                 <asp:DropDownList ID="lstParticipant" runat="server"/>
                                 
                             </ContentTemplate>
                                </asp:UpdatePanel>
                                 

                </div>
           </div>
                </div>
            <div id="BoutonReu">
                <asp:Button  id="boutonNouv" text="Nouvelle Recherche" runat="server" class="ReuRech" OnClick="boutonNouv_Click" autopostback="true"/>
                <asp:Button  id="boutonRech" text="Rechercher" runat="server" class="ReuRech" OnClick="boutonRech_Click"/>
            </div>        
        
           
        <div id="SectionResultats">
           <div id="SectionRes">
            
                <asp:RadioButtonList ID="TypeRecherche" runat="server">
                    <asp:ListItem Text="Ordres du jours"></asp:ListItem>
                    <asp:ListItem Text="Procès-verbaux"></asp:ListItem>
                </asp:RadioButtonList>
                
           
               <div id="partieRes">
             <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                 <Triggers><asp:AsyncPostBackTrigger ControlID="boutonRech" EventName="Click" /></Triggers>
                            <ContentTemplate>
            <asp:ListBox ID="ListeResultat" runat="server" OnSelectedIndexChanged="ListeResultat_SelectedIndexChanged" AutoPostBack="true" >
            </asp:ListBox> 
            </ContentTemplate>
                                </asp:UpdatePanel>
                   </div>
               </div>
                                     <asp:Button ID="btnPDF" text="Ouvrir"  OnClick="GetPdf_Click" runat="server" class="ReuRech"/>         
        </div>
               
        </div>
                </ContentTemplate>
             </asp:UpdatePanel>
                </div>
</asp:Content>
