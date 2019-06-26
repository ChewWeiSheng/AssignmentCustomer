using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Assignment
{
    public partial class Signup : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtEmailSU_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
             
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sign"].ToString());
                conn.Open();
        
                SqlCommand cmd = new SqlCommand("insert into SignUp (username,password,email) values (@username,@password,@email)", conn);

               
                cmd.Parameters.Add("@username", txtNameSU.Text);
                cmd.Parameters.Add("@password", txtConfirmPass.Text);
                cmd.Parameters.Add("@email", txtConfirmEmail.Text);
                cmd.ExecuteNonQuery();

            Response.Write("<script language='javascript'>window.alert('Register Successfully!')</script>");

        }
    }
}