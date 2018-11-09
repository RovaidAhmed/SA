using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebSite1_Admin_Default : System.Web.UI.Page
{
    DataClassesDataContext dv = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Btnlogout_Click(object sender, EventArgs e)
    {
        Session.Remove("username");
        Session.Remove("pass");
        Response.Redirect("../login.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            var cust = from c in dv.posts                                          //retreive column  from database passing id 
                       where c.post_id == Convert.ToInt32(Txtpostid.Text)
                       select new { c.Title, c.Breif ,c.disclaimer};


            foreach (var items in cust)
            {
                Txtupdatetitle.Text = items.Title;
                Txtdisclaimer.Text = items.disclaimer;
                editor1.InnerHtml = items.Breif;



            }
        }
        catch(Exception ex)
        {
            lblerror.Text = "You not updated yet (Refresh browser and enter another id)";
        }
       





    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("view.aspx");

    }

    protected void Btnupdate_Click(object sender, EventArgs e)
    {
                                                                             //update record
        var query = from u in dv.posts
                    where u.post_id == Convert.ToInt32(Txtpostid.Text)
                    select u;

        foreach(var items in query)
        {
            items.Title = Txtupdatetitle.Text;
            items.disclaimer = Txtdisclaimer.Text;
            items.Breif = editor1.InnerHtml.ToString();
        }
        try
        {
            dv.SubmitChanges();
        }
        catch(Exception ex)
        {
            lblerror.Text = "problem in update record";
        }
        Txtdisclaimer.Text = " ";
        Txtupdatetitle.Text = " ";
        Txtpostid.Text = " ";
              

    }


}