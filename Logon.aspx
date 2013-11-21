<%@ Page Language="VB" CodeFile="~/Logon.aspx.vb" Inherits="_Logon"%>
<%@ Import Namespace="System.Web.Security" %>

<script runat="server">
   
</script>

<html>
<head id="Head1" runat="server">
  <title>Page d'authentification</title>
    <link href="~/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
  <form id="form1" runat="server">
      <div id="Login">
        <h3> Formulaire de connexion</h3>
        <p> Nom d'utilisateur:</p>
        <asp:TextBox ID="UserID" runat="server" />
      
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
        ControlToValidate="UserID"
        Display="Dynamic" 
        ErrorMessage="*"
        runat="server" />

        <p>Mot de passe:</p> 
       
        <asp:TextBox ID="UserPass" TextMode="Password" 
        runat="server" />

        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
        ControlToValidate="UserPass"
        ErrorMessage="*"
        runat="server" />

        <p class="Souvenir">Se souvenir de moi? 
            <asp:CheckBox ID="Persist" runat="server" />
        </p> 

        <asp:Button ID="btnLogon" OnClick="Logon_Click" Text="Se connecter"  
           runat="server" />

        <p>
          <asp:Label ID="Msg" ForeColor="red" runat="server" />
        </p>
    </div>
  </form>
</body>
</html>

<style>
       
    body {
  font: 13px/20px 'Lucida Grande', Tahoma, Verdana, sans-serif;
  color: #404040;
  background: rgba(83, 172, 219, 1);
}

#form1 {
  margin: 80px auto;
  width: 640px;
}

#Login {
  position: relative;
  vertical-align:middle;
  margin: 0 auto;
  padding: 20px 20px 20px;
  width: 310px;
  background: white;
  border-radius: 3px;
  @include box-shadow(0 0 200px rgba(white, .5), 0 1px 2px rgba(black, .3));

  &:before {
    content: '';
    position: absolute;
    top: -8px; right: -8px; bottom: -8px; left: -8px;
    z-index: -1;
    background: rgba(black, .08);
    border-radius: 4px;
  }

  h3 {
    margin: -20px -20px 21px;
    line-height: 40px;
    font-size: 15px;
    font-weight: bold;
    color: #555;
    text-align: center;
    text-shadow: 0 1px white;
    background: #f3f3f3;
    border-bottom: 1px solid #cfcfcf;
    border-radius: 3px 3px 0 0;
    @include linear-gradient(top, whiteffd, #eef2f5);
    @include box-shadow(0 1px #f5f5f5);
  }

  p { margin: 20px 0 0; }
  p:first-child { margin-top: 0; }

  input[type=text], input[type=password] { width: 278px; }

  .Souvenir {
    float: left;

    label {
      font-size: 12px;
      color: #777;
      cursor: pointer;
    }

    input {
      position: relative;
      bottom: 1px;
      margin-right: 4px;
      vertical-align: middle;
    }
  }

  p.submit { text-align: right; }
}


#Persist {
    margin-left:10px;
    vertical-align:middle;
}


input[type=text], input[type=password] {
  margin: 5px;
  padding: 0 10px;
  width: 200px;
  height: 34px;
  color: #404040;
  background: white;
  border: 1px solid;
  border-color: #c4c4c4 #d1d1d1 #d4d4d4;
  border-radius: 2px;
  outline: 5px solid #eff4f7;
  -moz-outline-radius: 3px; // Can we get this on WebKit please?
  @include box-shadow(inset 0 1px 3px rgba(black, .12));

  &:focus {
    border-color: #7dc9e2;
    outline-color: #dceefc;
    outline-offset: 0; // WebKit sets this to -1 by default
  }
}

#btnLogon
{
    margin-left:80px;

    -moz-box-shadow:inset 0px 1px 0px 0px #cf866c;
    -webkit-box-shadow:inset 0px 1px 0px 0px #cf866c;
    box-shadow:inset 0px 1px 0px 0px #cf866c;
        
    background-color:#d0451b;
        
    -moz-border-radius:3px;
    -webkit-border-radius:3px;
    border-radius:3px;
        
    border:1px solid #942911;
        
    display:inline-block;
    color:#ffffff;
    font-family:arial;
    font-size:0.9em;
    font-weight:normal;
    
    text-decoration:none;
     padding:10px 30px;  
    text-shadow:0px 1px 0px #854629;
}

#btnLogon:hover
{
        
    background:-webkit-gradient(linear, left top, left bottom, color-stop(0.05, #cc5f2d), color-stop(1, #d0451b));
    background:-moz-linear-gradient(top, #cc5f2d 5%, #d0451b 100%);
    background:-webkit-linear-gradient(top, #cc5f2d 5%, #d0451b 100%);
    background:-o-linear-gradient(top, #cc5f2d 5%, #d0451b 100%);
    background:-ms-linear-gradient(top, #cc5f2d 5%, #d0451b 100%);
    background:linear-gradient(to bottom, #cc5f2d 5%, #d0451b 100%);
    filter:progid:DXImageTransform.Microsoft.gradient(startColorstr='#cc5f2d', endColorstr='#d0451b',GradientType=0);
        
    background-color:#cc5f2d;
}

#btnLogon:active
{
    position:relative;
    top:2px;
}
</style>