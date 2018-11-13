using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class world : System.Web.UI.Page
{
    DataClassesDataContext dv = new DataClassesDataContext();
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        get_data_from_database();       //yahan sirf wahe data show hoga jo uspage ka ha
        sidebar_latest_update();         //side bar updates

        if (Request.QueryString["id"] == null)
        {

        }
        else
        {
            discription();
        }

    }



    void get_data_from_database()
    {

        string cs = ConfigurationManager.ConnectionStrings["sareAamConnectionString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(cs))
        { 
            var query = "select top 12 * from post where page_id=6 order by post_id DESC";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            Repeaterworld.DataSource = dt;
            Repeaterworld.DataBind();
            con.Close();
        }


    }

    void sidebar_latest_update()
    {

        string cs = ConfigurationManager.ConnectionStrings["sareAamConnectionString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(cs))
        { 
            var query = "select top 4 * from post where page_id=5 order by post_id DESC";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            Repeatersidebar.DataSource = dt;
            Repeatersidebar.DataBind();
            con.Close();
        }


    }


    void discription()
    {
        string cs = ConfigurationManager.ConnectionStrings["sareAamConnectionString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(cs)) { 

              if (Request.QueryString["id"] == null)
            {

            }
            else
            {

                id = Convert.ToInt32(Request.QueryString["id"].ToString());
                var query = " select top 12 * from post  where post_id='" + id + "'";
                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                com.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
                con.Close();
            }
        }
    }










}