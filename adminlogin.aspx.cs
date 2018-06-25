using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using localhost;
using System.IO;

public partial class adminlogin : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["user1"] != null)
        {
            Response.Redirect("adminform.aspx");
        }
        else
        {
            con.Open();

        }

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string user = Request.Form["email"].Trim();
        bool t = false;
        string check = "select * from [checkadmin] where Name='" + Request.Form["Name"] + "'and email='" + Request.Form["email"] + "'and Password='" + Request.Form["Password"] + "'";
        SqlCommand cmd = new SqlCommand(check, con);
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        foreach (DataRow dr in dt.Rows)
        {

            t = true;

        }
        if (t == true)
        {

            Session["user1"] = user;
            Response.Redirect("adminform.aspx");
        }
        else
        {
            Label2.Visible = true;
        }




    }
    
    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Default3.aspx");

    }
}