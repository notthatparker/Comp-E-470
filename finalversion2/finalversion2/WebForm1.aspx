<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="finalversion2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>main</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div id="fullBg" />
  <link rel="stylesheet" href="style.css" />

              <link rel="stylesheet" href="Style4.css" />
              <link rel='stylesheet' href='http://netdna.bootstrapcdn.com/bootstrap/3.0.2/css/bootstrap.min.css'/>

            <h1>hello</h1>
             <section class="container">
                 <asp:Button ID="Button1" runat="server" Text="Log out"  class="btn color-1 material-design" data-color="#2f5398" OnClick="Button1_Click"/>
                 <asp:Button ID="Button2" runat="server" Text="Delete account"  class="btn color-1 material-design" data-color="#2f5398" OnClick="Button2_Click"/>

                 <asp:Button ID="Button3" runat="server" Text="Display" class="btn color-1 material-design" OnClick="Button3_Click" />

 </section>
            <asp:GridView ID="GridView1" class="mydatagrid" runat="server" BorderColor="#99FF66" HorizontalAlign="Center"></asp:GridView>
        </div>
    </form>
</body>
</html>
