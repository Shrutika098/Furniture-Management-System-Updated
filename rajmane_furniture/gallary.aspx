<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gallary.aspx.cs" Inherits="rajmane_furniture.gallary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .d1 {
            background-image: url('img/rajmane.jpg');
            height: 300px;
            width: 300px;
        }
        .d2 {
            background-image: url('img/booking.jpeg');
            height: 300px;
            width: 300px;
            margin-left: 20px;
            margin-top: 20px;
        }
        .d3 {
            background-image: url('img/fur1.jpg');
            height: 300px;
            width: 300px;
            margin-left: 20px;
            margin-top: 20px;
        }
            
        </style>
    
         <div>
            <nav>
                <ul>
                    <li><a href="Home.aspx">Home</a></li>
                    <li><a href="Aboutus.aspx">About us</a></li>
                    <li><a href="Gallery.aspx">Gallery</a></li>
                    <li><a href="Registration.aspx">Registration</a></li>
                    <li><a href="CustomerLogin.aspx">Login</a></li>

                </ul>
            </nav>
        </div>
      
   <div>
       <h2> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <div class ="row"> 
               <div class="col-sm-3"><div class="d1" style="background-image:url('IM/GreatDane1.jpg'); background-size:100%;background-repeat:no-repeat;" ></div></div>
               <div class="col-sm-3"><div class="d1" style="background-image:url('IM/GreatDane.jpg'); background-size:100%;background-repeat:no-repeat;" ></div></div>
                <div class="col-sm-3"><div class="d1" style="background-image:url('IM/Labrador Retriever.jpg'); background-size:100%;background-repeat:no-repeat;" ></div></div>
                <div class="col-sm-3"><div class="d1" style="background-image:url('IM/pugs.jpg'); background-size:100%;background-repeat:no-repeat;" ></div></div>

           </div>
           <h2> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <div class ="row"> 
               <div class="col-sm-3"><div class="d1" style="background-image:url('IM/GreatDane1.jpg'); background-size:100%;background-repeat:no-repeat;" ></div></div>
               <div class="col-sm-3"><div class="d1" style="background-image:url('IM/GreatDane.jpg'); background-size:100%;background-repeat:no-repeat;" ></div></div>
                <div class="col-sm-3"><div class="d1" style="background-image:url('IM/Labrador Retriever.jpg'); background-size:100%;background-repeat:no-repeat;" ></div></div>
                <div class="col-sm-3"><div class="d1" style="background-image:url('IM/pugs.jpg'); background-size:100%;background-repeat:no-repeat;" ></div></div>

           </div>

       </h2>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="d1"> </div>
        <div class="d2"></div>
        <div class="d3"></div>
    </div>
    </form>
</body>
</html>
