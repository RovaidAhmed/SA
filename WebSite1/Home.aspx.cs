using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Home : System.Web.UI.Page
{
    int id;
    DataClassesDataContext dv = new DataClassesDataContext();

    protected void Page_Load(object sender, EventArgs e)
    {
      

        sidebar_latest_update();
        news_slider();
        front_view();
        place_herat_angez();


    }

    void sidebar_latest_update()
    {

        using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-3N40DTS\\SQLEXPRESS;Initial Catalog=sareAam;Integrated Security=True"))
        {
            var query = "select top 6 pages.page_name, post.file_name,post.title  from pages INNER JOIN post on  pages.page_id=post.page_id order by post.post_id DESC";
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


    void news_slider()
    {

        using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-3N40DTS\\SQLEXPRESS;Initial Catalog=sareAam;Integrated Security=True"))
        {
            var query = "select top 5 title from post order by post_id desc";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            Repeater_home_latestnews_slider.DataSource = dt;
            Repeater_home_latestnews_slider.DataBind();
            con.Close();
        }


    }


    void front_view()
    {

        using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-3N40DTS\\SQLEXPRESS;Initial Catalog=sareAam;Integrated Security=True"))
        {
            var query = "select top 1 * from post where page_id=5 order by post_id desc";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            Repeaterfront.DataSource = dt;
            Repeaterfront.DataBind();
            con.Close();
        }


    }



    void place_herat_angez()
    {

        using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-3N40DTS\\SQLEXPRESS;Initial Catalog=sareAam;Integrated Security=True"))
        {
            var query = "select top 2 * from post where page_id=3 order by post_id desc";
            SqlCommand com = new SqlCommand(query, con);
            con.Open();
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            Repeater_herazangez.DataSource = dt;
            Repeater_herazangez.DataBind();
            con.Close();


        }


    }






}