using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
   }
        
        

   

    protected void Btnlogin_Click1(object sender, EventArgs e)
    {
        
            DataClassesDataContext dv = new DataClassesDataContext();
            //admin a = new admin
            //{
            //    ad_username = Txtusername.Text,               //insertion of the  data
            //    ad_password = txtpassword.Text
            //};
            //dv.admins.InsertOnSubmit(a);
            //dv.SubmitChanges();


            var cust = from c in dv.admins
                       where c.ad_username == Txtusername.Text &&
                       c.ad_password == txtpassword.Text
                       select c;

        
        if (cust.Any())
        {

            lblerror.Text = "success";
            Session["username"] = Txtusername.Text;
            Session["pass"] = txtpassword.Text;
            Response.Redirect("./Admin/add.aspx");
        }
        else
        {
            lblerror.Text = "check you pass and username ";
        }





    }
}