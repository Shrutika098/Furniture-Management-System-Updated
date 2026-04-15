using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace rajmane_furniture
{
    public partial class Cancel_booking : System.Web.UI.Page
    {
        MySqlConnection cn = new MySqlConnection("server=localhost;database=rajmane_furniture_shop;user=root;password=root");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            
        }
   
   
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void return_amount_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void save_btn_Click(object sender, EventArgs e)
        {
            
        }
       

        protected void update_btn_Click(object sender, EventArgs e)
        {
           
        }

        protected void canceldate_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void cancel_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void save_btn_Click1(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                String querry = "insert into Cancel_booking(Booking_id, Product_name, Customer_name, Total_amount, Cancel_amount, Return_amount, Cancel_date) values('" + bookingid_txtbox.Text + "', '" + productname_txtbox.Text + "', '" + customername_txtbox.Text + "', '" + totalamount_txtbox.Text + "' , '" + cancelamount_txtbox.Text + "', '" + returnamount_txtbox.Text + "', '" + canceldate_txtbox.Text + "')";
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

        protected void update_btn_Click1(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                String querry = "update Cancel_booking set Booking_id='" + bookingid_txtbox.Text + "', Product_name= '" + productname_txtbox.Text + "', Customer_name= '" + customername_txtbox.Text + "',  Total_amount= '" + totalamount_txtbox.Text + "', Cancel_amount= '" + cancelamount_txtbox.Text + "',Return_amount='" + returnamount_txtbox.Text + "',Cancel_date='" + canceldate_txtbox.Text + "'";
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
