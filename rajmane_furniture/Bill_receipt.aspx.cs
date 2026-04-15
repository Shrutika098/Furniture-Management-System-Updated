using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace rajmane_furniture
{
    public partial class Bill_receipt : System.Web.UI.Page
    {
        MySqlConnection cn = new MySqlConnection("server=localhost;database=rajmane_furniture_shop;user=root;password=root");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void bill_date_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void customer_name_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void delete_textbox_Click(object sender, EventArgs e)
        {
        }

        protected void update_btn_Click(object sender, EventArgs e)
        {
        }
    
        protected void bookingdate_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void save_btn_Click3(object sender, EventArgs e)
        {
        }

        protected void update_btn_Click1(object sender, EventArgs e)
        {

            try
            {
                cn.Open();
                string query = "update Bill_receipt1 set Bill_id='" + billid_txtbox.Text + "', Bill_date='" + billdate_txtbox.Text + "',Cust_id='" + custid_txtbox.Text + "',Mobile_no='" + mobileno_txtbox.Text + "',Furniture_name='" + furniturename_txtbox.Text + "',Booking_id='" + bookingid_txbox.Text + "',Booking_date='" + bookingdate_txtbox.Text + "',GST='" + gst_txtbox.Text + "',Total_amount='" + totalamount_txtbox.Text + "'";
                cmd.Connection = cn;
                cmd.CommandText = query;
                int Result = cmd.ExecuteNonQuery();
                Console.WriteLine("Data Updated Successfully");
                Response.Write("<script language=\"javascript\"type=\"text/javascript\">alert('data updated');</script>");
                cn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        protected void delete_textbox_Click1(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                String query = "Delete from Bill_receipt1 where Bill_id='" + billid_txtbox.Text + "'";
                cmd.Connection = cn;
                cmd.CommandText = query;
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

        protected void save_btn_Click1(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                String query = "insert into Bill_receipt1(Bill_id, Bill_date,Cust_id, Mobile_no, Furniture_name, Booking_id, Booking_date, GST, Total_amount) values('" + billid_txtbox.Text + "','" + billdate_txtbox.Text + "','" + custid_txtbox.Text + "','" + mobileno_txtbox.Text + "' ,'" + furniturename_txtbox.Text + "','" + bookingid_txbox.Text + "','" + bookingdate_txtbox.Text + "','" + gst_txtbox.Text + "', '" + totalamount_txtbox.Text + "')";
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
    }
}