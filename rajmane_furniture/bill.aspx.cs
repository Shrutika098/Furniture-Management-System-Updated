using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;


namespace rajmane_furniture
{
    public partial class bill : System.Web.UI.Page
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
                String query = "insert into bill(Bill_id, Bill_date, Cust_name, Booking_id, Total)values('"+TextBox1.Text+"', '"+TextBox2.Text+"', '"+TextBox3.Text+"', '"+TextBox4.Text+"', '"+TextBox5.Text+"')";
                cmd.Connection = cn;
                cmd.CommandText = query;
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

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            try
                {
                    cn.Open();
                    String querry = "update bill set Bill_id='" +TextBox1.Text+"',  Bill_date='"+TextBox2.Text+"',  Cust_name='"+TextBox3.Text+"', Booking_id='"+TextBox4.Text+"', Total='"+TextBox5.Text+"'";
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
