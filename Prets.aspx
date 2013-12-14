<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Prets.aspx.vb" Inherits="Prets" %>

<asp:Content ID="ContenuTopPrets" ContentPlaceHolderID="ContenuTop" Runat="Server">

            <asp:Table ID="Table1" runat="server">
            <asp:TableRow ID="TableRow1" runat="server">
                <asp:TableCell ID="TableCell1" VerticalAlign="Top" runat="server">    	
                    <div id="SousTitre">
		    <p> Découvrez tout l'inventaire! <br><br> Choisissez votre exemplaire,  <br><br>  voyez vos historiques 
                    <br><br> et notre inventaire</p>
	    </div>

                </asp:TableCell>
                <asp:TableCell RowSpan="2"  ID="TableCell2" runat="server">	    
                    <div id="ImgTop">
		    <img  src="./images/CNC.Laptop.png"/>
	    </div></asp:TableCell>
            </asp:TableRow>
        </asp:Table>

    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server" />

    
</asp:Content>

<asp:Content ID="ContenuCorpsPret" ContentPlaceHolderID="ContenuCorps" Runat="Server">
    <div id="DivPret">
        <div id="TitrePret">Demande de prêt</div>
        <asp:UpdatePanel ID="UpdatePanelPret" runat="server" UpdateMode="Conditional">
            <Triggers>
                <asp:AsyncPostBackTrigger controlid="btnEnvDem" EventName="Click"/>
            </Triggers>
            <ContentTemplate>
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

            <asp:GridView  DataContext="{Binding}" AutoGenerateColumns="false"  ItemsSource="{Binding}" ID="GridModele" runat="server">
                <Columns>
                    <asp:TemplateField HeaderText="Code Barre" >
                          <ItemTemplate>
                            <asp:label text='<%#Eval("exemplaire.CodeBarre")%>' DataContext="{Binding}" ID="CodeBarre" ItemsSource="{Binding}" runat="server" DataField="exemplaire.CodeBarre"></asp:label>
                          </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField HeaderText="Modèle" DataField="modele.NoModele"/>
                    <asp:BoundField HeaderText="Marque" DataField="modele.Marque"/>
                    <asp:BoundField HeaderText="Note" DataField="Exemplaire.NoteExemplaire"/>
                    <asp:TemplateField >
                          <ItemTemplate>
                            <asp:Checkbox ID="checkmodele" Visible="true" runat="server" />
                          </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>


            </div>
                </contenttemplate>
            </asp:UpdatePanel>
        <div id="divEnvDem"><asp:Button id="btnEnvDem" OnClick="BoutonEnvoyer_Click" runat="server" text="Envoyer la demande" class="ReuRech" autopostback="true"/></div>
        </div>
</asp:Content>