using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Amazing : System.Web.UI.Page
{
    int did;
    DataClassesDataContext dv = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

        get_data_from_database();       //yahan sirf wahe data show hoga jo uspage ka ha
        sidebar_latest_update();         //side bar updates


        discription_div();

    }



    void get_data_from_database()
    {

        using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-3N40DTS\\SQLEXPRESS;Initial Catalog=sareAam;Integrated Security=True"))
        {
            var query = "select top 12 * from post where page_id=3 order by post_id DESC";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            Repeateramazing.DataSource = dt;
            Repeateramazing.DataBind();
            con.Close();
        }


    }

    void sidebar_latest_update()
    {

        using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-3N40DTS\\SQLEXPRESS;Initial Catalog=sareAam;Integrated Security=True"))
        {
            var query = " select * from post  where post.page_id=3";
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



    void discription_div()
    {
        if (IsPostBack)
        {
            did = Convert.ToInt32(Request.QueryString["id"].ToString());
        }
        var cust = from p in dv.posts
                   where p.post_id == did
                   select p;

    }






}