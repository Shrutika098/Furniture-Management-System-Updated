<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view_booking.aspx.cs" Inherits="rajmane_furniture.view_booking" %>

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
<body style="height: 370px; width: 1027px">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <nav>
         <ul>
                <li><a href="home.aspx">Home</a></li>
                <li><a href="home.aspx">About us</a></li>
                <li><a href="admin_login.aspx">Admin login</a></li>
                <li><a href="Add_product.aspx">Add product</a></li>
                <li><a href="Booking.aspx">Booking</a></li>
                <li><a href="Cancel_booking.aspx">Cancel booking</a></li>
                <li><a href="feedback.aspx">Feedback</a></li>
                <li><a href="Registration.aspx">Registration</a></li>
                <li><a href="Bill_receipt.aspx">Bill receipt</a></li>
                <li></li>

          
            </ul>
            </nav>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" Height="204px" Width="999px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Booking_id" HeaderText="Booking_id" SortExpression="Booking_id" />
                <asp:BoundField DataField="Cust_id" HeaderText="Cust_id" SortExpression="Cust_id" />
                <asp:BoundField DataField="Furniture_id" HeaderText="Furniture_id" SortExpression="Furniture_id" />
                <asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                <asp:BoundField DataField="GST" HeaderText="GST" SortExpression="GST" />
                <asp:BoundField DataField="Booking_date" HeaderText="Booking_date" SortExpression="Booking_date" />
                <asp:BoundField DataField="Cust_name" HeaderText="Cust_name" SortExpression="Cust_name" />
                <asp:BoundField DataField="Furniture_name" HeaderText="Furniture_name" SortExpression="Furniture_name" />
                <asp:BoundField DataField="Furniture_price" HeaderText="Furniture_price" SortExpression="Furniture_price" />
                <asp:BoundField DataField="Advance_amount" HeaderText="Advance_amount" SortExpression="Advance_amount" />
                <asp:BoundField DataField="Amount" HeaderText="Amount" SortExpression="Amount" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:rajmane_furniture_shopConnectionString %>" ProviderName="<%$ ConnectionStrings:rajmane_furniture_shopConnectionString.ProviderName %>" SelectCommand="select * from Booking"></asp:SqlDataSource>
    </form>
</body>
</html>
