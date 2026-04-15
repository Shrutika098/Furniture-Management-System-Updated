<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view_registration.aspx.cs" Inherits="rajmane_furniture.view_registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .img {
            background-image: url('img/fur7.jpg');
            height: 300px;
        }
        .grid {
            margin-left: 200px;
        }
    </style>
    <link rel="stylesheet" type="text/css" href="css/Style.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div>
        <nav>
            <ul>
                <li><a href="home.aspx">Home</a></li>
                <li><a href="home.aspx">About us</a></li>
                <li><a href="admin_login.aspx">Admin login</a></li>
                <li><a href="Add_product.aspx">Add product</a></li>
                <li><a href="add_cart.aspx">add cart</a></li>
                <li><a href="Booking.aspx">Booking</a></li>
                <li><a href="Cancel_booking.aspx">Cancel booking</a></li>
                <li><a href="feedback.aspx">Feedback</a></li>
                <li><a href="Registration.aspx">Registration</a></li>
                <li><a href="Bill_receipt.aspx">Bill receipt</a></li>

          
            </ul>
        </nav>
    </div>
    </div>
    <p>
        &nbsp;</p>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1">
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:rajmane_furniture_shopConnectionString %>" ProviderName="<%$ ConnectionStrings:rajmane_furniture_shopConnectionString.ProviderName %>" SelectCommand="select * Registration" OnSelecting="SqlDataSource1_Selecting"></asp:SqlDataSource>
    </form>
    </body>
</html>
