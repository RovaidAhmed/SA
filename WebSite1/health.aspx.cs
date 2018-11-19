using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class health : System.Web.UI.Page
{
    int id;
    DataClassesDataContext dv = new DataClassesDataContext();
    int num = 0;
    string cs = ConfigurationManager.ConnectionStrings["sareAamConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get_data_from_database();       //yahan sirf wahe data show hoga jo uspage ka ha
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
        if (NoOfRows > rowcount)
        {
            Button1.Visible = false;
        }

        using (SqlConnection con = new SqlConnection(cs))
        {
            var query = "select top (@val) * from post  where page_id=9 order by post_id DESC";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@val", NoOfRows);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Repeaterhealth.DataSource = dt;
                Repeaterhealth.DataBind();
            }
            else
            {
                Repeaterhealth.DataSource = null;
                Repeaterhealth.DataBind();
            }

        }
    }

    int get_total_rowsfromdatabase()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            var query = "select  count(*)  from post where page_id=9";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int rowscount = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return rowscount;
        }
    }



    //void get_data_from_database()
    //{

    //    string cs = ConfigurationManager.ConnectionStrings["sareAamConnectionString"].ConnectionString;
    //    using (SqlConnection con = new SqlConnection(cs))
    //    { 
    //        var query = "select top 12 * from post where page_id=9 order by post_id DESC";
    //        SqlCommand com = new SqlCommand(query, con);
    //        con.Open();
    //        com.ExecuteNonQuery();
    //        DataTable dt = new DataTable();
    //        SqlDataAdapter da = new SqlDataAdapter(com);
    //        da.Fill(dt);
    //        Repeaterhealth.DataSource = dt;
    //        Repeaterhealth.DataBind();
    //        con.Close();
    //    }


    //}

    void sidebar_latest_update()
    {

        string cs = ConfigurationManager.ConnectionStrings["sareAamConnectionString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(cs))
        { 
            var query = "select top 4 * from post where page_id=2 order by post_id DESC";
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











    protected void Button1_Click(object sender, EventArgs e)
    {

        int numvalues = Convert.ToInt32(ViewState["num"]) + 10;
        Bind_data_with_repeater_loadmore(numvalues);
        ViewState["num"] = numvalues;
    }
}