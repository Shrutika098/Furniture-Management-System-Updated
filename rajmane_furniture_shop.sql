create schema rajmane_furniture_shop;

use rajmane_furniture_shop;

create table Registration(
Cust_id nvarchar(50),
Customer_name nvarchar(50),
Gender nvarchar(50),
Address nvarchar(50),
Mobile_no nvarchar(50),
Email nvarchar(50),
Password nvarchar(50),rajmane_furniture_shop
Confirm_password nvarchar(50)
);

create table feedback(
Cust_name nvarchar(50),
Cust_id nvarchar(50),
Address nvarchar(50),
Contact_no nvarchar(50),
Email_id nvarchar(50),
Message nvarchar(50)
);

create table Add_product(
Furniture_id nvarchar(50),
Furniture_name nvarchar(50),
Category nvarchar(50),
Color nvarchar(50),
Size nvarchar(50),
Price nvarchar(50)
);

create table add_cart(
Furniture_id nvarchar(50),
Furniture_name nvarchar(50),
Category nvarchar(50),
Price nvarchar(50),
GST nvarchar(50),
Total nvarchar(50)
);

create table Booking(
Booking_id nvarchar(50),
Cust_id nvarchar(50),
Furniture_id nvarchar(50),
Category nvarchar(50),
Quantity nvarchar(50),
GST nvarchar(50),
Booking_date nvarchar(50),
Cust_name nvarchar(50),
Furniture_name nvarchar(50),
Furniture_price nvarchar(50),
Advance_amount nvarchar(50),
Amount nvarchar(50)
);

create table Cancel_booking(
Booking_id nvarchar(50),
Product_name nvarchar(50),
Customer_name nvarchar(50),
Total_amount nvarchar(50),
Cancel_amount nvarchar(50),
Return_amount nvarchar(50),
Cancel_date nvarchar(50)
);

drop table Bill_receipt;
create table Bill_receipt(
Bill_id nvarchar(50),
Bill_date nvarchar(50),
Cust_id nvarchar(5),
Mobile_no nvarchar (50),
Furniture_name nvarchar(50),
Booking_id nvarchar(50),
Booking_date nvarchar(50),
GST nvarchar(50),
Total_amount  nvarchar(50)
);

create table Webform1(
Furniture_ID nvarchar(50),
Furniture_Name nvarchar(50),
Category nvarchar(50),
Color nvarchar(50),
Size nvarchar(50),
Price nvarchar(50)
);

create table payment(
Cust_id nvarchar(50),
Cust_name nvarchar(50),
Furniture_id nvarchar(50),
Furniture_name nvarchar(50),
Furniture_price nvarchar(50),
Card_no nvarchar(50),
Bank_name nvarchar(50),
Branch nvarchar(50),
IFSC_Code nvarchar(50)
);

create table Bill_receipt1(
Bill_id nvarchar(50),
Bill_date nvarchar(50),
Cust_id nvarchar(5),
Mobile_no nvarchar (50),
Furniture_name nvarchar(50),
Booking_id nvarchar(50),
Booking_date nvarchar(50),
GST nvarchar(50),
Total_amount  nvarchar(50)
);
