<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Owner_login.aspx.cs" Inherits="rajmane_furniture.Owner_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .w1 {
            background-image: url('Img/shruti5.jpg');
            background-repeat: no-repeat;
            background-size: 100%;
        }
        .x1 {
            border-style: solid;
            border-color: black;
            height: 350px;
            width: 400px;
            margin-left: 400px;
            margin-top: 250px;
            text-align: justify;
        }

    </style>
       
</head>
<body class="w1">
    <form id="form1" runat="server">
            <div class="x1">

       
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="XX-Large" Text="Owner login" Font-Names="Algerian" BackColor="Black" ForeColor="White"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Owner name" Font-Names="Arial Black"></asp:Label>
&nbsp;<br />
        <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="258px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Password" Font-Names="Arial Black"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;<asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="251px" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Font-Bold="True" Height="40px" Text="Login" Width="113px" OnClick="Button1_Click" Font-Names="Arial Black" BackColor="#993399" ForeColor="White" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;</div>
    </div>
    </form>
</body>
</html>
