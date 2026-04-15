using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace rajmane_furniture
{
    public partial class Booking : System.Web.UI.Page
    {
        MySqlConnection cn = new MySqlConnection("server=localhost; database=rajmane_furniture_shop; user=root; password=root");
        MySqlCommand cmd = new MySqlCommand(); 
        MySqlDataAdapter da = new MySqlDataAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    cn.Open();
                    String querry = "update Booking set Booking_id='" + bookingid_txtbox.Text+ "', Cust_id= '" + custid_txtbox.Text+ "', Furniture_id= '" + furnitureid_txtbox.Text+ "', Category = '" + DropDownList1.Text+ "', Quantity='"+quantity_txtbox.Text+"', GST= '"+gst_txtbox.Text+"', Booking_date= '"+bookingdate_txtbox.Text+"', Cust_name= '"+custname_txtbox.Text+"', Furniture_name= '"+furniturename_txtbox.Text+"', Furniture_price='"+furnitureprice_txtbox.Text+"', Advance_amount= '"+advanceamount_txtbox.Text+"'";
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

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void booking_date_TextChanged(object sender, EventArgs e)
        {
            
        }

         

        protected void cancel_textbox_Click(object sender, EventArgs e)
        {
            Response.Redirect("Booking.aspx");
        }

        protected void furnitureprice_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                String querry = "insert into booking(Booking_id, Cust_id, Furniture_id, Category, Quantity, GST, Booking_date, Cust_name, Furniture_name, Furniture_price, Advance_amount, Amount)values('" + bookingid_txtbox.Text + "', '" + custid_txtbox.Text + "', '" + furnitureid_txtbox.Text + "', '" + DropDownList1.SelectedItem + "', '" + quantity_txtbox.Text + "', '" + gst_txtbox.Text + "', '" + bookingdate_txtbox.Text + "', '" + custname_txtbox.Text + "', '" + furniturename_txtbox.Text + "', '" + furnitureprice_txtbox.Text + "', '" + advanceamount_txtbox.Text + "', '" + amount_txtbox.Text + "')";
                cmd.Connection = cn;
                cmd.CommandText = querry;
                int result = cmd.ExecuteNonQuery();
                Console.WriteLine("Data Inserted Successfully");
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
