using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace rajmane_furniture
{
    public partial class Payment : System.Web.UI.Page
    {
        MySqlConnection cn = new MySqlConnection("server=localhost;database=rajmane_furniture_shop;user=root;password=root");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string query = "insert into payment(Cust_id, Cust_name, Furniture_id, Furniture_name, Furniture_price, Card_no, Bank_name, Branch, IFSC_Code) values ('" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "', '" + TextBox5.Text + "', '" + TextBox6.Text + "', '" + TextBox7.Text + "', '" + TextBox8.Text + "', '" + TextBox9.Text + "')";
                cmd.Connection = cn;
                cmd.CommandText = query;
                int result = cmd.ExecuteNonQuery();
                Console.WriteLine("Data inserted Successfully");
                Response.Write("<script language=\"javascript\"type=\"text/javascript\">alert('pay successfull');</script>");
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Payment.aspx");
        }
    }
}