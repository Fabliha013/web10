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
using System.Web.UI.WebControls;


public partial class gallarey : System.Web.UI.Page
{
    SqlCommand cmd = new SqlCommand();
    SqlDataAdapter da = new SqlDataAdapter();
    DataSet ds = new DataSet();
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user1"] != null)
        {

            cmd.CommandText = "select * from [checkadmin] where email='" + Session["user1"] + "'";
            cmd.Connection = con;
            da.SelectCommand = cmd;
            da.Fill(ds);
            HyperLink1.Text = ds.Tables[0].Rows[0]["Name"].ToString();
            HyperLink1.NavigateUrl = "adminform.aspx";
        }
        else if (Session["user"] != null)
        {
            cmd.CommandText = "select * from [Table] where pw='" + Session["user"] + "'";
            cmd.Connection = con;
            da.SelectCommand = cmd;
            da.Fill(ds);
            HyperLink1.Text = ds.Tables[0].Rows[0]["name"].ToString();
            HyperLink1.NavigateUrl = "userform.aspx";
        }
        else
        {
            HyperLink1.Text = "non_user";

        }


    }
}