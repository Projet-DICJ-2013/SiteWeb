<%@ Page Language="VB" MasterPageFile="~/Site.master" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<script runat="server" >


</script>

<asp:Content ID="headContent" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="ContenuTopDef" ContentPlaceHolderID="ContenuTop" Runat="Server">

    	<div id="SousTitre">
		    <p> Le site officiel du département! <br><br> Accéder à vos prêts,  <br><br>  informations sur vos cours 
                    <br><br> et vos emprunts de matériels</p>
	    </div>
				
	    <div id="ImgTop">
		    <img  src="./images/choipeau.png"/>
	    </div>

    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server" />

    
</asp:Content>


<asp:Content ID="ContenuCorpsAcc" ContentPlaceHolderID="ContenuCorps" Runat="Server">

    <div id="MesNews">

        <div id="BarreTri">


             <asp:TextBox ID="txtRecherche" runat="server" />
          
             <asp:Button ID="btnSearch" Text="Recherche" runat="server" />

           

        </div>

        <div id="New">

            <asp:UpdatePanel runat="server" ID="UpdatePanel1" UpdateMode="Conditional">
	          <ContentTemplate>

                    <asp:Button id="btnPrec" runat="server" onclick="btnPrec_Click" />
                
                    <div id="txtNew">

                        <asp:Label id="lblNew" runat="server"  />

                    </div>

                     <asp:Button id="btnNext" runat="server" OnClick="btnNext_Click" />

                </ContentTemplate>
                 <Triggers>
                     <asp:AsyncPostBackTrigger ControlID="btnPrec" EventName="Click" />
                     <asp:AsyncPostBackTrigger ControlID="btnNext" EventName="Click" />
                 </Triggers>
            </asp:UpdatePanel>
        </div>

    </div>
 



</asp:Content>




<%-- test jo --%>
<%-- test patrick --%>
<%-- test patrick2 --%>
<%-- test dany --%>
<%-- test kickass --%>
<%-- test chouine --%>
<%-- test lauzier --%>
<%-- test Pascal 02--%>