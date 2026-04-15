using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;



namespace rajmane_furniture
{
    public partial class Owner_login : System.Web.UI.Page
    {
         MySqlConnection cn = new MySqlConnection("server=localhost;database=rajmane_furniture_shop;user=root;password=root");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            cmd.Connection=cn;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                if ((TextBox1.Text == "admin") && (TextBox2.Text == "1234"))
                {
                    Response.Write("<script language=\"javascript\"type=\"text/javascript\">alert('Login Successfull');location='Add_product.aspx'</script>");
                }
                else
                {
                    Response.Write("script language=\"javascript\"type=\"text/javascript\">alert('Invalid Username Or Password');</script>");
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script language=\"javascript\"type=\"text/javascript\">alert('" + ex.ToString() + "');</script>");
            }
        


        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}