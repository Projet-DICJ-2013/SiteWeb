<%@ Page Language="VB" MasterPageFile="~/Site.master" CodeFile="Default.aspx.vb" Inherits="_Default"  %>



<script runat="server" >
    
    'Service web permettant d'obtenir l'actualité à l'index envoyé par le client
    <System.Web.Services.WebMethod()> _
    Public Shared Function GetNews(index As Integer) As String
    
        Dim News As New MesNews
        Dim Var As String
        Try
            News.lstActu.MoveCurrentToPosition(index)
            Var = CType(News.lstActu.CurrentItem, tblActualite).TexteActu
        Catch ex As Exception
            Return Nothing
        End Try
        
        Return Var
    End Function
    


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

    <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Always">
    <ContentTemplate>
        <div id="MesNews" onload="GetPDF();">

            <div id="titreActu"> Liste des actualités </div>

            <div id="BarreTri">

                 <asp:TextBox ID="txtRecherche" runat="server" Width="55%"  Font-Size="Large"/>
          
                 <asp:Button class="btnTri" ID="btnSearch" Text="Recherche" runat="server" OnClick="btnSearch_Click"  />

                  <input type="button" class="btnTri" id="btnPrec" value="<"/>

                 <input class="btnTri" type="button" id="btnNext" value=">"/>

            </div>

            <div id="New">

                <asp:Label ID="lblNew" runat="server" />

            </div>

        </div>
 
    </ContentTemplate>
    </asp:UpdatePanel> 

    <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
  <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"> </script>
    <script type="text/javascript">
        
        $(function () {

            var ActuIndex;
            /* Fonction asynchrone permattant d'envoyer l'index de l'actualité et de récupérer le contenu de celle-ci  */
            function GetInfNews() {
                $("#New").empty()
                $.ajax({
                    type: 'POST',
                    url: 'Default.aspx/GetNews',
                    data: JSON.stringify({ index: ActuIndex }),
                    contentType: "application/json; charset=utf-8",
                    dataType: 'json',
                    error: function (XMLHttpRequest, textStatus, errorThrown) {
                        alert("Request: " + XMLHttpRequest.toString() + "\n\nStatus: " + textStatus + "\n\nError: " + errorThrown);
                    },
                    success: function (resp) {
                        if (resp.d != null) {
                            $("#New").append(resp.d);
                            $("#btnNext").show();
                        }
                        else {
                            $("#btnNext").hide();
                        }
                    }
                });
            };

            $("#btnPrec").click(function () {
                if (ActuIndex > 0) {
                    ActuIndex = ActuIndex - 1;

                    if (ActuIndex == 1) {
                        $("#btnPrec").hide();
                    }
                }
                
                GetInfNews();
            });

            $("#btnNext").click(function () {
                ActuIndex = ActuIndex + 1;

                if (ActuIndex > 1) {
                    $("#btnPrec").show();
                }

                GetInfNews();
            });

            $(document).ready(function () {
                ActuIndex = 0;
                GetInfNews();
            });


        });

    </script>


</asp:Content>




<%-- test jo --%>
<%-- test patrick --%>
<%-- test patrick2 --%>
<%-- test dany --%>
<%-- test kickass --%>
<%-- test chouine --%>
<%-- test lauzier --%>
<%-- test Pascal 02--%>