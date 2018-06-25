using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class review : System.Web.UI.Page
{
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter sda = new SqlDataAdapter();
    DataSet ds = new DataSet();
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        string s = "select name,message from [table1]";
        SqlDataAdapter da = new SqlDataAdapter(s, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
       GridView1.DataSource = ds;
       GridView1.DataBind();
        con.Close();




        cmd.CommandText = "select * from [checkadmin] where email='" + Session["user1"] + "'";
        cmd.Connection = con;
        sda.SelectCommand = cmd;
        sda.Fill(ds);
        HyperLink1.Text = ds.Tables[0].Rows[0]["Name"].ToString();


    }
    protected void Listview1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}