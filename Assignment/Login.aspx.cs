using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Assignment
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sign"].ToString());
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from SignUp where username = '" + txtNameLogin.Text + "' and password = '" + txtPassLogin.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Session["User"] = txtNameLogin;

                Response.Redirect("~/Browse.aspx");

            }
            else
            {
                Response.Write("<script language='javascript'>window.alert('Your Username or Password is Invalid!')</script>");
            }
        }
    }
}