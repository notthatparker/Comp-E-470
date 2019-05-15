using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace finalversion2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=signin;User id=root;password=root");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Text_password_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Text_cpassword_TextChanged(object sender, EventArgs e)
        {

        }

        protected void text_username_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Register_btn_Click(object sender, EventArgs e)
        {
            if (Text_password.Text == Text_cpassword.Text)
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into sign(username,password) values('"+ text_username.Text+"','"+Text_password.Text+"') ";
                
      
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Session["username"] = dr["username"].ToString();
                    Response.Redirect("WebForm1.aspx");

                }
                Response.Redirect("WebForm1.aspx");

            }
            else { Label2.Text = "invalid"; }
        }
    }
}