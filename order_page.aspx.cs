using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using localhost;
using System.IO;

public partial class order_page : System.Web.UI.Page
{
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter sda = new SqlDataAdapter();
    DataSet ds = new DataSet();
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        cmd.CommandText = "select * from [Table] where pw='" + Session["user"] + "'";
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        sda.Fill(ds);
        HyperLink1.Text = ds.Tables[0].Rows[0]["name"].ToString();
        HyperLink1.NavigateUrl = "userform.aspx";

        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool t = false;

        
        con.Open();

        SqlCommand cmd = new SqlCommand("insert into [issue_order]" + "(product_name,quantity) values(@product_name,@quantity)", con);
        cmd.Parameters.AddWithValue("@product_name", nametxt.Text);
        cmd.Parameters.AddWithValue("@quantity", TextBox1.Text);
        int i = cmd.ExecuteNonQuery();

        if (i > 0)
            t = true;
        if (t == true)
        {
            Label3.Visible = true;
        }
       
    }
}