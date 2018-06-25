using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

public partial class adminform : System.Web.UI.Page
{
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter sda = new SqlDataAdapter();
    DataSet ds = new DataSet();
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user1"] == null)
        {
            Response.Redirect("loginpage.aspx");
        }
        else
        {
            con.Open();
            showdata();

        }



    }
    public void showdata()
    {


        cmd.CommandText = "select * from [checkadmin] where email='" + Session["user1"] + "'";
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        sda.Fill(ds);
        Label2.Text = ds.Tables[0].Rows[0]["Name"].ToString();
        Label1.Text = ds.Tables[0].Rows[0]["email"].ToString();

        cmd.CommandText = "select profile_pic from [checkadmin] where email='" + Session["user1"] + "'";
        cmd.Connection = con;
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                byte[] imgdata = (byte[])dr["profile_pic"];
                String img = Convert.ToBase64String(imgdata, 0, imgdata.Length);
                Image1.ImageUrl = "Data:image/jpg;base64," + img;

            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("upload.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

        Session["user1"] = null;
        Response.Redirect("loginpage.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("practice.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("add_instructors.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("review.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("onlineorder.aspx");
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("checkorder.aspx");
    }
}