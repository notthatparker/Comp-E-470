<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="finalversion2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign Up</title>
     <link rel='stylesheet' href='http://netdna.bootstrapcdn.com/bootstrap/3.0.2/css/bootstrap.min.css'/>
  <link rel="stylesheet" href="style2.css" />
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
<asp:TextBox ID="text_username"  class="form-control" name="username" placeholder="Email Address" required="" autofocus="" runat="server" OnTextChanged="text_username_TextChanged"></asp:TextBox>
<asp:TextBox ID="Text_password" textmode="Password" class="form-control" name="password" placeholder="Password" required="" autofocus="" runat="server" OnTextChanged="Text_password_TextChanged"></asp:TextBox>
<asp:Label ID="Label2" runat="server" Text=""  class="form-signin-heading"></asp:Label>
<asp:TextBox ID="Text_cpassword" textmode="Password" class="form-control" name="cpassword" placeholder="Confirm Password" required="" autofocus="" runat="server" OnTextChanged="Text_cpassword_TextChanged"></asp:TextBox>
<asp:Button ID="Register_btn"  class="btn btn-lg btn-primary btn-block" runat="server" Text="Register" OnClick="Register_btn_Click" />
          </div>
   
</div>
  
  
    </form>
</body>
</html>
