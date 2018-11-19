using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Articles : System.Web.UI.Page
{
    string cs = ConfigurationManager.ConnectionStrings["sareAamConnectionString"].ConnectionString;

    DataClassesDataContext dv = new DataClassesDataContext();
    int id;
    int num = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
      /*  get_data_from_database(); */      //yahan sirf wahe data show hoga jo uspage ka ha
        sidebar_latest_update();         //side bar updates

        if (Request.QueryString["id"] == null)
        {
        }
        else
        {
            discription();
        }

        if (!IsPostBack)
        {
            num = 10;
            ViewState["num"] = num;
            Bind_data_with_repeater_loadmore(num);
        }

      

    }



    void Bind_data_with_repeater_loadmore(int NoOfRows)
    {
        int rowcount = get_total_rowsfromdatabase();
        if(NoOfRows> rowcount)
        {
            Btn_loadmore.Visible = false;
        }
       
        using (SqlConnection con = new SqlConnection(cs))
        {
            var query = "select top (@val) * from post  order by post_id DESC";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            sda.SelectCommand.Parameters.AddWithValue("@val", NoOfRows);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count>0)
            {
                RepeaterArticles.DataSource = dt;
                RepeaterArticles.DataBind();
            }
            else
            {
                RepeaterArticles.DataSource = null;
                RepeaterArticles.DataBind();
            }
          
        }
    }
    int get_total_rowsfromdatabase()
    {
        using(SqlConnection con = new SqlConnection(cs))
        {
            var query = "select  count(*)  from post";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
             int rowscount = Convert.ToInt32( cmd.ExecuteScalar());
            con.Close();
            return rowscount;
        }
    }






    //void get_data_from_database()
    //{

    //    string cs = ConfigurationManager.ConnectionStrings["sareAamConnectionString"].ConnectionString;
    //    using (SqlConnection con = new SqlConnection(cs))
    //    { 
    //        var query = "select top 20 * from post  order by post_id DESC";
    //        SqlCommand com = new SqlCommand(query, con);
    //        con.Open();
    //        com.ExecuteNonQuery();
    //        DataTable dt = new DataTable();
    //        SqlDataAdapter da = new SqlDataAdapter(com);
    //        da.Fill(dt);
    //        RepeaterArticles.DataSource = dt;
    //        RepeaterArticles.DataBind();
    //         con.Close();
    //    }


    //}

    void sidebar_latest_update()
    {

        string cs = ConfigurationManager.ConnectionStrings["sareAamConnectionString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(cs))
        { 
            var query = "select top 4 * from post  order by post_id DESC ";
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
        using (SqlConnection con = new SqlConnection(cs))
        { 
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






    protected void Unnamed1_Click(object sender, EventArgs e)  //load more button click
    {
        int numvalues = Convert.ToInt32(ViewState["num"]) + 10;
        Bind_data_with_repeater_loadmore(numvalues);
        ViewState["num"] = numvalues;


    }



}