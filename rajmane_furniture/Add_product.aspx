<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_product.aspx.cs" Inherits="rajmane_furniture.Add_product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .c {
            background-image:url('Img/wallp3.jpg');
            background-repeat:no-repeat;
            background-size:100%;

        }

        .e {
            border-style:solid;
            border-color:white;
            height:400px;
            width:500px;
            margin-left:100px;
            margin-top:200px;
            text-align:justify;
        }
    </style>
</head>
<body class="c">
    <form id="form1" runat="server">
    <div id="textbox">
        <div class="e">
          
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="X-Large" Text="Add product" Font-Names="Algerian" ForeColor="#CC0000" BackColor="White" BorderColor="White"></asp:Label>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Furniture id" ForeColor="Black" BackColor="White" Font-Names="Arial Black"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;<asp:TextBox ID="furnitureid_txtbox" runat="server" Height="16px" Width="233px" OnTextChanged="furniture_id_textbox_TextChanged"></asp:TextBox>
        <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label8" runat="server" Font-Bold="True" Text="Furniture name" BackColor="White" Font-Names="Arial Black"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="furniturename_txtbox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Category" ForeColor="Black" BackColor="White" Font-Names="Arial Black"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="Bed"></asp:ListItem>
                <asp:ListItem Value="sofa"></asp:ListItem>
                <asp:ListItem Value="chair"></asp:ListItem>
                <asp:ListItem Value="table"></asp:ListItem>
                <asp:ListItem Value="Cupboards"></asp:ListItem>
                <asp:ListItem Value="Dressing Tables"></asp:ListItem>
                <asp:ListItem Value="Hanging Chairs"></asp:ListItem>
                <asp:ListItem Value="Stools"></asp:ListItem>
            </asp:DropDownList>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Color" ForeColor="Black" BackColor="White" Font-Names="Arial Black"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="color_txtbox" runat="server" Height="16px" Width="232px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Label ID="Label6" runat="server" Font-Bold="True" Text="Size" ForeColor="Black" BackColor="White" Font-Names="Arial Black"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="size_txtbox" runat="server" Height="16px" Width="232px"></asp:TextBox>
        <br />
        &nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Price" ForeColor="Black" BackColor="White" BorderColor="White" Font-Names="Arial Black"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="price_txtbox" runat="server" Height="16px" Width="241px" OnTextChanged="price_txtbox_TextChanged"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="save_btn" runat="server" Font-Bold="True" Height="40px" Text="SAVE" Width="71px" BackColor="#993399" BorderStyle="Solid" Font-Names="Arial Black" ForeColor="White" OnClick="save_btn_Click1" />
            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Button ID="cancel_btn" runat="server" Font-Bold="True" Height="44px" Text="UPDATE" Width="75px" ForeColor="White" OnClick="cancel_btn_Click" BackColor="#993399" Font-Names="Arial Black" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" BackColor="#993399" Height="41px" Text="DELETE" Width="71px" Font-Bold="True" Font-Names="Arial Black" ForeColor="White" OnClick="Button1_Click1" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
    </div>
    </form>
</body>
</html>
