using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;


namespace rajmane_furniture
{
    public partial class Add_product : System.Web.UI.Page
    {
        MySqlConnection cn = new MySqlConnection("server=localhost;database=rajmane_furniture_shop;user=root;password=root");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }

        protected void furniture_id_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void cancel_btn_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    cn.Open();
                    String querry = "update Add_product set Furniture_id='" + furnitureid_txtbox.Text + "', Furniture_name= '" + furniturename_txtbox.Text + "', Category= '" + DropDownList1.Text + "', Color= '" + color_txtbox.Text + "', Size= '" + size_txtbox.Text + "', Price= '" + price_txtbox.Text + "'";
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

        protected void save_btn_Click(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                String querry = "Delete from Add_product where Furniture_id='"+furnitureid_txtbox.Text+"'";
                cmd.Connection = cn;
                cmd.CommandText = querry;
                int result = cmd.ExecuteNonQuery();
                Console.WriteLine("Data Deleted successfully");
                Response.Write("<script language=\"javascript\"type=\"text/javascript\">alert('data deleted');</script>");
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void price_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void save_btn_Click1(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                String query = "insert into Add_product(Furniture_id, Furniture_name, Category, Color, Size, Price) values('" + furnitureid_txtbox.Text + "', '" + furniturename_txtbox.Text + "', '" + DropDownList1.Text + "','" + color_txtbox.Text + "' ,'" + size_txtbox.Text + "','" + price_txtbox.Text + "')";
                cmd.Connection = cn;
                cmd.CommandText = query;
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

        protected void Button1_Click1(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                String query = "Delete from Add_product where Furniture_id='" + furnitureid_txtbox.Text + "'";
                cmd.Connection = cn;
                cmd.CommandText = query;
                int result = cmd.ExecuteNonQuery();
                Console.WriteLine("Data Deleted successfully");
                Response.Write("<script language=\"javascript\"type=\"text/javascript\">alert('data inserted');</script>");
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}