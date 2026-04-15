using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace rajmane_furniture
{
    public partial class add_cart : System.Web.UI.Page
    {
        MySqlConnection cn = new MySqlConnection("server=localhost;database=rajmane_furniture_shop;user=root;password=root");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                String querry = "insert into add_cart(Furniture_id,Furniture_name,Category,Price,GST,Total) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + DropDownList1.Text + "','" + TextBox4.Text + "' '" + TextBox5.Text + "','" + TextBox6.Text + "')";
                cmd.Connection = cn;
                cmd.CommandText = querry;
                int result = cmd.ExecuteNonQuery();
                Console.WriteLine("Data inserted successfully");
                Response.Write("<script language=\"javascript\"type=\"text/javascript\">alert('data inserted');</script>");
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

       

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_cart.aspx");
        }
    }
}