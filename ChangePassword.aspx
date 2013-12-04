<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ChangePassword.aspx.vb" Inherits="ChangePassword" %>

<script runat="server">
   
</script>

<html>
<head id="Head1" runat="server">
  <title> Changer le mot de passe </title>
    <link href="~/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
  <form id="form1" runat="server">
      <div id="Password">
        <h3> Formulaire de changement de mot de passe</h3>

        <div id="OldPass">
            <p> Ancien mot de passe:</p>
            <asp:TextBox ID="PassOld" TextMode="Password"  runat="server" />

            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
            ControlToValidate="PassOld"
            Display="Dynamic" 
            ErrorMessage="*"
            runat="server" />
         </div>

        <div id="NewPass">
            <p>Nouveau mot de passe:</p> 
       
            <asp:TextBox ID="PassNew" TextMode="Password" 
            runat="server" />

            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
            ControlToValidate="PassNew"
            ErrorMessage="*"
            runat="server" />

         </div>

        <div id="ConfPass">
            <p>Confirmer mot de passe:</p> 
       
            <asp:TextBox ID="PassConf" TextMode="Password" 
            runat="server" />

            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
            ControlToValidate="PassConf"
            ErrorMessage="*"
            runat="server" />

         </div>

        <asp:Button ID="btnChange"  Text="Soumettre"  
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
  background: rgba(239, 239, 239, 1);
}

#form1 {
  margin: 80px auto;
  width: 640px;
}

    #Password {
        display:block;
        position: relative;
        vertical-align: middle;
        text-align:center;
        margin: 0 auto;
        padding: 20px 20px 20px;
        width: 390px;
        min-height:470px;
        background: white;
        border:2px solid #cfcfcf;
        border-radius: 3px;
        @include box-shadow(0 0 200px rgba(white, .5), 0 1px 2px rgba(black, .3));
    }
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
    font-size: 1.4em;
    padding:10px;
    color: white;
    text-align: center;
    text-shadow: 0 1px white;
    background: rgb(4, 172, 209);
    border-bottom: 1px solid #cfcfcf;
    border-radius: 3px 3px 0 0;
    @include linear-gradient(top, whiteffd, #eef2f5);
    @include box-shadow(0 1px #f5f5f5);
  }

    #OldPass, #NewPass, #ConfPass {
        position:relative;
        padding:15px;
    }

  p { font-size:1.3em;}

    #OldPass p {
        margin: 20px 100px 0 0; 
        padding-bottom:10px;
    }

    #NewPass p {
        margin: 20px 90px 0 0; 
        padding-bottom:10px;
    }

    #ConfPass p {
        margin: 20px 85px 0 0; 
        padding-bottom:10px;
    }

  input[type=text], input[type=password] { width: 278px; padding-top:30px; }

  .Souvenir {

    margin-right:80px;
    padding:15px;

    label {
      font-size: 36px;
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
  width: 250px;
  height: 36px;
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

#btnChange
{
    margin-top:20px;

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
    font-size:1.4em;
    font-weight:normal;
    
    text-decoration:none;
     padding:15px 40px;  
    text-shadow:0px 1px 0px #854629;
}

#btnChange:hover
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

#btnChange:active
{
    position:relative;
    top:2px;
}

    #msg {
        padding:15px;
    }
</style>