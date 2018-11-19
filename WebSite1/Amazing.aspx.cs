using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Amazing : System.Web.UI.Page
{
    int id;
    int num = 0;
    DataClassesDataContext dv = new DataClassesDataContext();
    string cs = ConfigurationManager.ConnectionStrings["sareAamConnectionString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {


        //get_data_from_database();       //yahan sirf wahe data show hoga jo uspage ka ha
        //side bar updates
        sidebar_latest_update();
        //searching();


      
        

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





    //        var query = "select top 12 * from post where page_id=3 order by post_id DESC";

    void Bind_data_with_repeater_loadmore(int NoOfRows)
    {
        int rowcount = get_total_rowsfromdatabase();
        if (NoOfRows > rowcount)
        {
            Button1.Visible = false;
        }

        using (SqlConnection con = new SqlConnection(cs))
        {
            var query = "select top (@val) * from post  where page_id=3 order by post_id DESC";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@val", NoOfRows);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Repeateramazing.DataSource = dt;
                Repeateramazing.DataBind();
            }
            else
            {
                Repeateramazing.DataSource = null;
                Repeateramazing.DataBind();
            }

        }
    }

    int get_total_rowsfromdatabase()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            var query = "select  count(*)  from post where page_id=3";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int rowscount = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return rowscount;
        }
    }



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

    protected void Button2_Click(object sender, EventArgs e)
    {
        //searching();
    }

    //void searching()
    //{
    //    //void searching 
    //    string cs = ConfigurationManager.ConnectionStrings["sareAamConnectionString"].ConnectionString;
    //    using (SqlConnection con = new SqlConnection(cs))
    //    {
            
    //        var query = "select * from post where page_id=3(select * from post where title  like (N'%  '"+TextBox1.Text+"' %'))";  
    //        SqlCommand com = new SqlCommand(query, con);
    //        con.Open();
    //        com.ExecuteReader();
    //        DataTable dt1 = new DataTable();
    //        SqlDataAdapter da1 = new SqlDataAdapter(com);
    //        da1.Fill(dt1);
    //        Repeateramazing.DataSource = dt1;
    //        Repeateramazing.DataBind();
    //        con.Close();
    //    }
    //}
}