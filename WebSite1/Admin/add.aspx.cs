using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class Admin_add : System.Web.UI.Page
{
    DataClassesDataContext dv = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        //**session
        try
        {
            if (Session["username"] != null)
            {
                Label1.Text = "Welcome to " + Session["username"].ToString();
            }

        }
        catch(Exception ex)
        {
            Label1.Text = "problem with login details";
        }
        //fetch admin id from session whose login
        try
        {
            var adName = dv.admins.First(c => c.ad_username == Session["username"].ToString());
            var adID = adName.ad_id;
            Txtadminid.Text = adID.ToString();
        }
        catch(Exception ex)
        {

        }

    }
    protected void Btnlogout_Click(object sender, EventArgs e)
    {
        Session.Remove("username");
        Session.Remove("pass");
        Response.Redirect("../login.aspx");
    }

    protected void Btnsubmit_Click(object sender, EventArgs e)
    {
        string filename = FileUpload1.FileName;            //add files
        string filelocation = "../files/";
        string pathstring = System.IO.Path.Combine(filelocation, filename);

        post p = new post
        {
            disclaimer = Txtdisclaimer.Text,
            Title = Txttitle.Text,
            link = Txtlink.Text,
            file_name = pathstring,
            page_id = Convert.ToInt32(Txtpageid.Text),
            ad_id = Convert.ToInt32(Txtadminid.Text),
            Breif = editor1.InnerHtml.ToString() 




        };
        dv.posts.InsertOnSubmit(p);
        dv.SubmitChanges();
        FileUpload1.SaveAs(MapPath(pathstring));
       
    }




    void get_pid()      //**page id fetch from page  table
    {
        
            string cs = ConfigurationManager.ConnectionStrings["sareAamConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand comm = new SqlCommand("select * from pages where page_id=" + DropDownpage.SelectedValue, con);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Txtpageid.Text = reader["page_id"].ToString();
                }

                con.Close();

                var tb = new DataTable();
                tb.Load(reader);


            };
        
       
    }
    //page_id fetch from page  table**






    protected void DropDownpage_SelectedIndexChanged(object sender, EventArgs e)
    {
        get_pid();
    }
}