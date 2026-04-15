using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace rajmane_furniture
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        MySqlConnection cn = new MySqlConnection("server=localhost;database=rajmane_furniture_shop;user=root;password=root");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            cn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                String querry = "insert into Webform1(Furniture_ID, Furniture_Name, Category, Color, Size, Price) values('" +TextBox1.Text+"', '" +TextBox2.Text+"', '" +DropDownList2.Text+"','" + TextBox3.Text+ "' '" +TextBox4.Text+ "','" +TextBox5.Text+"')";
                cmd.Connection = cn;
                cmd.CommandText = querry;
                int result = cmd.ExecuteNonQuery();
                Console.WriteLine("Data inserted successfully");
                Response.Write("<script language=\"javascript\"type=\"text/javascript\">alter('data inserted');</script>");
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    cn.Open();
                    String querry = "update set Webform1 Furniture_ID='" +TextBox1.Text+"', Furniture_Name='"+TextBox2.Text+ "', Category= '" +DropDownList2.Text+ "', Color= '" +TextBox3.Text+"', Size= '" +TextBox4.Text+"', Price= '" +TextBox5.Text+ "'";
                    cmd.Connection = cn;
                    cmd.CommandText = querry;
                    int result = cmd.ExecuteNonQuery();
                    Console.WriteLine("Data Updated successfully");
                    Response.Write("<script language=\"javascript\"type=\"text/javascript\">alert('data updated');</script>");
                    cn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}