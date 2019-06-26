using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Assignment
{
    public partial class editprofile : System.Web.UI.Page

    {
       
        protected void Page_Load(object sender, EventArgs e)
            
        {   // SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sign"].ToString());
            //conn.Open();



            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = conn;
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select username from SignUp where Id= Current";
            //SqlDataReader rdr = cmd.ExecuteReader();
            //rdr.Read();
            //txtName.Text = rdr["username"].ToString();

            //rdr.Close();

        }

        protected void calBirth_SelectionChanged(object sender, EventArgs e)
        {
            
        
            txtDate.Text = calBirth.SelectedDate.ToShortDateString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        { 
            //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sign"].ToString());
           // conn.Open();

 

           // SqlCommand cmd = new SqlCommand("update SignUp set username=@username ,gender=@gender,email=@email,hpNo=@hpNo,birth=@birth,Address=@Address  where Id=Current" , conn);
            c//md.Parameters.Add("@username", txtName.Text);
            //cmd.Parameters.Add("@gender", rbtnGender.SelectedItem .Value);
            //cmd.Parameters.Add("@email", txtEmail.Text);
            //cmd.Parameters.Add("@hpNo", txtHP.Text);
            //cmd.Parameters.Add("@birth", txtDate.Text);
            //cmd.Parameters.Add("@Address", txtAddress.Text);
            //cmd.ExecuteNonQuery();
            

            //Response.Write("<script language='javascript'>window.alert('Register Successfully!')</script>");
        }
    }
}