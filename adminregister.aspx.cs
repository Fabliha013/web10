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

public partial class adminregister : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool t = false;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
        con.Open();
        int length = FileUpload1.PostedFile.ContentLength;
        byte[] pic = new byte[length];
        FileUpload1.PostedFile.InputStream.Read(pic, 0, length);
        SqlCommand cmd = new SqlCommand("insert into [checkadmin]" + "(Name,Password,contact_no,email,profile_pic) values(@Name,@Password,@contact_no,@email,@profile_pic)", con);
        cmd.Parameters.AddWithValue("@Name", nametxt.Text);
        cmd.Parameters.AddWithValue("@email", emailtxt.Text);
        cmd.Parameters.AddWithValue("@Password", passtxt.Text);
        cmd.Parameters.AddWithValue("@contact_no", contacttxt.Text);
        cmd.Parameters.AddWithValue("@profile_pic", pic);
        int i = cmd.ExecuteNonQuery();

        if (i > 0)
            t = true;
        if (t == true)
        {
            Label3.Visible = true;
        }
    }
}