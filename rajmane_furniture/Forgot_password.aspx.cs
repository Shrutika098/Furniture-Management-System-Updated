using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace rajmane_furniture
{
    public partial class Forgot_password : System.Web.UI.Page
    {
         MySqlConnection cn = new MySqlConnection("server=localhost; database=rajmane_furniture_shop; user=root; password=root");
        MySqlCommand cmd = new MySqlCommand(); 
        MySqlDataAdapter da = new MySqlDataAdapter();
    

        protected void Page_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string query = "update Registration Set Password='" + TextBox5.Text +"'";
                cmd.Connection = cn;
                cmd.CommandText = query;
                int result = cmd.ExecuteNonQuery();
                Console.WriteLine("Data inserted successfully");
                Response.Write("<script language =\"javascript\"type=\"text/javascript\">alert('Your Password Reset');</script>");
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {

        }
    }
}