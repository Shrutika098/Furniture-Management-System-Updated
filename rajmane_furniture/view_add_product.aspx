<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view_add_product.aspx.cs" Inherits="rajmane_furniture.view_add_product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .img1 {
            background-image: url('img/fur7.jpg');
            height: 300px;
        }
        .grid1 {
            margin-left: 200px;
        }
    </style>
    <link rel="stylesheet" type="text/css" href="css/Style.css" />
</head>
<body  style="background-image:url('img/shruti5.jpg'); background-size:100%;">
    <form id="form2" runat="server">
    <div>
    <div>
        </div>
        </div>
    <p>
        &nbsp;</p>
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
                <li><a href="Add_product.aspx">Logout</a></li>
                
          
            </ul>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" Height="197px" Width="1004px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Furniture_id" HeaderText="Furniture_id" SortExpression="Furniture_id" />
                    <asp:BoundField DataField="Furniture_name" HeaderText="Furniture_name" SortExpression="Furniture_name" />
                    <asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category" />
                    <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" />
                    <asp:BoundField DataField="Size" HeaderText="Size" SortExpression="Size" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                </Columns>
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:rajmane_furniture_shopConnectionString %>" ProviderName="<%$ ConnectionStrings:rajmane_furniture_shopConnectionString.ProviderName %>" SelectCommand="select * from Add_product"></asp:SqlDataSource>
            </nav>
    </form>
    </body>
</html>
