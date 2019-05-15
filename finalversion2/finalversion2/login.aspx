<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="finalversion2.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta charset="UTF-8">
  <title> Login</title>
  <link rel='stylesheet' href='http://netdna.bootstrapcdn.com/bootstrap/3.0.2/css/bootstrap.min.css'/>
  <link rel="stylesheet" href="style.css" />

</head>
<body>

    <form id="form1" runat="server">
        <div id="fullBg" />

<div class="container">
      <div class="form-signin">       
      <h1 class="form-signin-heading" id="">Please Login</h1>
          <td colspan="2">
              <asp:Label ID="Label1" runat="server" Text="" class="form-signin-heading"></asp:Label>
          </td>
<asp:TextBox ID="text_username"  class="form-control" name="username" placeholder="Email Address" required="" autofocus="" runat="server"></asp:TextBox>
<asp:TextBox ID="Text_password" textmode="Password" class="form-control" name="password" placeholder="Password" required="" autofocus="" runat="server"></asp:TextBox>
          <asp:Button ID="Button1" class="btn btn-lg btn-primary btn-block" runat="server" Text="Log in" OnClick="Button1_Click" />
      </div>
    
  <p class="text-center sign-up"><strong><a href="WebForm2.aspx">Sign up<a/></strong> for a new account</p>
</div>
  
  
    </form>
</body>
</html>
