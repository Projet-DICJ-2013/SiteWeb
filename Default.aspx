<%@ Page Language="VB" MasterPageFile="~/Site.master" CodeFile="Default.aspx.vb" Inherits="_Default" %>



<script runat="server" >

    <System.Web.Services.WebMethod()> _
    Public Shared Function GetNews(ByVal index As Integer) As String
        Return "Hello World"
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

    <div id="MesNews">

        <div id="BarreTri">


             <asp:TextBox ID="txtRecherche" runat="server" />
          
             <asp:Button ID="btnSearch" Text="Recherche" runat="server" />

           

        </div>

        <div id="New">

            <asp:Button  id="btnPrec" runat="server" OnClick="btnPrec_Click" />
                
            <div id="txtNew">

                <asp:Label id="txtMail" runat="server" />

            </div>

            <asp:Button  id="btnNext" runat="server" />

        </div>

    </div>
 
    <script src="scripts/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">

        $(function () {

            var ActuIndex = 0;

            function GetPDF() {
                $.ajax({
                    type: 'POST',
                    url: 'Default.aspx/GetNews',
                    data: "index=" + ActuIndex,
                    contentType: "application/json; charset=utf-8",
                    dataType: 'json',
                    error: function (XMLHttpRequest, textStatus, errorThrown) {
                        alert("Request: " + XMLHttpRequest.toString() + "\n\nStatus: " + textStatus + "\n\nError: " + errorThrown);
                    },
                    success: function (resp) {
                        $("#txtNew").append(resp);
                    }
                });
            };


            $("#btnPrec").click(function () {

            });

            $("#btnNext").click(function () {

            });

            $(document).ready(function () {
                GetPDF();
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