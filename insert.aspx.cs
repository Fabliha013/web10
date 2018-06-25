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


public partial class insert : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
    string name, roll, dept, bat, desig,opr;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        opr = Request.QueryString["opr"].ToString();


        if (opr == "insert")
        {
            name = Request.QueryString["na"].ToString();
            roll = Request.QueryString["ro"].ToString();
            dept = Request.QueryString["dep"].ToString();
            bat = Request.QueryString["ba"].ToString();
            desig = Request.QueryString["de"].ToString();

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into instructors values('" + name.ToString() + "','" + roll.ToString() + "','" + dept.ToString() + "','" + bat.ToString() + "','" + desig.ToString() + "')";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        if (opr == "delete")
        {
            name = Request.QueryString["na"].ToString();
            

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from instructors where name='"+name.ToString()+"'";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        if (opr == "display")
        {
            
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from instructors";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            Response.Write("<table border='1'>");
            Response.Write("<tr>");
            Response.Write("<td>"); Response.Write("<font color=\"yellow\">"); Response.Write("name"); Response.Write("</td>");
            Response.Write("<td>"); Response.Write("<font color=\"yellow\">"); Response.Write("roll"); Response.Write("</td>");
            Response.Write("<td>"); Response.Write("<font color=\"yellow\">"); Response.Write("department"); Response.Write("</td>");
            Response.Write("<td>"); Response.Write("<font color=\"yellow\">"); Response.Write("batch"); Response.Write("</td>");
            Response.Write("<td>"); Response.Write("<font color=\"yellow\">"); Response.Write("designation"); Response.Write("</td>");
            Response.Write("<tr>");
            foreach (DataRow dr in dt.Rows)
            {
                Response.Write("<tr>");
                Response.Write("<td style=\"width:300px; left:20px; right:20px;\">"); Response.Write("<font color=\"white\">"); Response.Write(dr["name"].ToString()); Response.Write("</td>");
                Response.Write("<td style=\"width:300px; left:20px; right:20px;\">"); Response.Write("<font color=\"white\">"); Response.Write(dr["roll"].ToString()); Response.Write("</td>");
                Response.Write("<td style=\"width:300px; left:20px; right:20px;\">"); Response.Write("<font color=\"white\">"); Response.Write(dr["department"].ToString()); Response.Write("</td>");
                Response.Write("<td style=\"width:300px; left:20px; right:20px;\">"); Response.Write("<font color=\"white\">"); Response.Write(dr["batch"].ToString()); Response.Write("</td>");
                Response.Write("<td style=\"width:300px; left:20px; right:20px;\">"); Response.Write("<font color=\"white\">"); Response.Write(dr["designation"].ToString()); Response.Write("</td>");
                Response.Write("</tr>");

                

            }
            Response.Write("</table>");
            con.Close();
        }

        if (opr == "search")
        {
            name = Request.QueryString["nm1"].ToString();

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from instructors where name like('"+name.ToString()+"%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            Response.Write("<table border='1'>");
            Response.Write("<tr>");
            Response.Write("<td>"); Response.Write("<font color=\"yellow\">"); Response.Write("name"); Response.Write("</td>");
            Response.Write("<td>"); Response.Write("<font color=\"yellow\">"); Response.Write("roll"); Response.Write("</td>");
            Response.Write("<td>"); Response.Write("<font color=\"yellow\">"); Response.Write("department"); Response.Write("</td>");
            Response.Write("<td>"); Response.Write("<font color=\"yellow\">"); Response.Write("batch"); Response.Write("</td>");
            Response.Write("<td>"); Response.Write("<font color=\"yellow\">"); Response.Write("designation"); Response.Write("</td>");
            Response.Write("<tr>");
            foreach (DataRow dr in dt.Rows)
            {
                Response.Write("<tr>");
                Response.Write("<td style=\"width:200px; left:20px; right:20px;\">"); Response.Write("<font color=\"white\">"); Response.Write(dr["name"].ToString()); Response.Write("</td>");
                Response.Write("<td style=\"width:200px; left:20px; right:20px;\">"); Response.Write("<font color=\"white\">"); Response.Write(dr["roll"].ToString()); Response.Write("</td>");
                Response.Write("<td style=\"width:200px; left:20px; right:20px;\">"); Response.Write("<font color=\"white\">"); Response.Write(dr["department"].ToString()); Response.Write("</td>");
                Response.Write("<td style=\"width:200px; left:20px; right:20px;\">"); Response.Write("<font color=\"white\">"); Response.Write(dr["batch"].ToString()); Response.Write("</td>");
                Response.Write("<td style=\"width:200px; left:20px; right:20px;\">"); Response.Write("<font color=\"white\">"); Response.Write(dr["designation"].ToString()); Response.Write("</td>");
                Response.Write("<tr>");



            }
            Response.Write("</table>");
            con.Close();
        }

        


    }
}