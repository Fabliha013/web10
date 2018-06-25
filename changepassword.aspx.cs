using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;


public partial class changepassword : System.Web.UI.Page
{
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter sda = new SqlDataAdapter();
    DataSet ds = new DataSet();
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user1"] != null)
        {
            Label1.Text = Session["user1"].ToString();

            cmd.CommandText = "select * from [checkadmin] where email='" + Session["user1"] + "'";
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            HyperLink1.Text = ds.Tables[0].Rows[0]["Name"].ToString();
            HyperLink1.NavigateUrl = "adminform.aspx";
        }
        else
        {
            Label1.Text = Session["user"].ToString();
            cmd.CommandText = "select * from [Table] where pw='" + Session["user"] + "'";
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            HyperLink1.Text = ds.Tables[0].Rows[0]["name"].ToString();
            HyperLink1.NavigateUrl = "userform.aspx";
        }
   
        

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Session["user"] != null){


        

        String myquery = "select * from [table] where pw='" + Session["user"] + "'";
       
        cmd.CommandText = myquery;
        cmd.Connection = con;
        
        sda.SelectCommand = cmd;
        sda.Fill(ds);
        String pass;
        pass = ds.Tables[0].Rows[0]["email"].ToString();
        con.Close();
        if (pass == TextBox1.Text)
        {
            if (TextBox2.Text == TextBox3.Text && TextBox2.Text != "")
            {
                String updatepass = "update [table] set email='" + TextBox2.Text +
                "' where pw='" + Label1.Text + "'";
                SqlConnection s = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
                s.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandText = updatepass;
                cmd1.Connection = s;
                cmd1.ExecuteNonQuery();
                Session.Abandon();
                
            }
            else
            {
                Label2.Text = "New Password and Re-enter Password Not Matched / Blank Password Not Accepted";
            }
        }
        else
        {
            Label2.Text = "Invalid Username or Password - Cannot Change Password";


        }
    }
    
    else
{
   

       String myquery = "select * from [checkadmin] where email='" + Session["user1"] + "'";
       
        cmd.CommandText = myquery;
        cmd.Connection = con;
        
        sda.SelectCommand = cmd;
        sda.Fill(ds);
        String pass;
        pass = ds.Tables[0].Rows[0]["Password"].ToString();
        con.Close();
        if (pass == TextBox1.Text)
        {
            if (TextBox2.Text == TextBox3.Text && TextBox2.Text != "")
            {
                String updatepass = "update [checkadmin] set Password='" + TextBox2.Text +
                "' where email='" + Label1.Text + "'";
                SqlConnection s = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
                s.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandText = updatepass;
                cmd1.Connection = s;
                cmd1.ExecuteNonQuery();
                Session.Abandon();
                
            }
            else
            {
                Label2.Text = "New Password and Re-enter Password Not Matched / Blank Password Not Accepted";
            }
        }
        else
        {
            Label2.Text = "Invalid Username or Password - Cannot Change Password";


        }
    }
    



}
}