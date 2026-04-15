using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;


namespace rajmane_furniture
{
    public partial class Customer_login : System.Web.UI.Page
    {
        MySqlConnection cn = new MySqlConnection("server=localhost;database=rajmane_furniture_shop;user=root;password=root");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        MySqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customer_login.aspx");
        }

        protected void password_textbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }
         
    
        protected void Button3_Click(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
        }

        protected void Button1_Click2(object sender, EventArgs e)
        {
             try
           {
               cn.Open();
               string query = "select * from Customer_login where Customer_id='"+custid_txtbox.Text+"' && Password='"+password_txtbox.Text+"'";
               cmd.Connection = cn;
               cmd.CommandText = query;
               dr = cmd.ExecuteReader();

               if (dr.Read())
               {
                   Response.Write("<script language =\"javascript\"type=\"text/javascript\">alert ('Login Successfull'); location='Registration.aspx'</script>");
               }
               else
               {

                   Response.Write("<script language =\"javascript\"type=\"text/javascript\">alert ('Invalid password Or user name'); location='Registration.aspx'</script>");
               }
           }
               catch (Exception ex)
           {
               Response.Write("<script language =\"javascript\"type=\"text/javascript\">alert ('Login successfull'); location='Registration.aspx'</script>");
           }
               }
        }  
        }
    
