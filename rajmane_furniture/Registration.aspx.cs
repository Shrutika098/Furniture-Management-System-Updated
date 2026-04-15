using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace rajmane_furniture
{
    public partial class Registration : System.Web.UI.Page
    {
        MySqlConnection cn = new MySqlConnection("server=localhost;database=rajmane_furniture_shop;user=root;password=root");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
         MySqlDataReader dr;
         String gender;

         public void getid()
         {
             try
             {
                 cn.Close();
                 cn.Open();
                 cmd.CommandText = "select Cust_id from Registration";
                 MySqlDataReader dr = cmd.ExecuteReader();
                 if (dr.HasRows)
                 {
                     while (dr.Read())
                     {
                        Textbox1.Text = (Convert.ToInt32(dr.GetInt32(0)) + 1).ToString();
                     }
                 }
                 else
                 {
                     Textbox1.Text = "1";
                 }

                 cn.Close();
             }

             catch (Exception ex)
             {
                 Console.Write(ex.ToString());
             }
         }



        protected void Page_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            getid();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                String querry = "insert into Registration(Cust_id, Customer_name, Gender, Address, Mobile_no, Email, Password, Confirm_password) values('"+Textbox1.Text+"','" + TextBox2.Text + "','" + RadioButtn1.Text+ "', '"+RadioButton2.Text+"', '"+TextBox3.Text+"','" + TextBox4.Text + "' '" + TextBox5.Text + "', '"+TextBox7.Text+"','"+TextBox8.Text+"')";
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
        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtn1.Checked == true)
            {
                gender = "Male";
                RadioButton2.Checked = false;
            }


        }

        protected void RadioButtn1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked == true)
            {
                gender = "Female";
                RadioButtn1.Checked = false;
            }
        }
    }
}