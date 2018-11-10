using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class politics : System.Web.UI.Page
{
    DataClassesDataContext dv = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        get_data_from_database();
       
        
    }

    void get_data_from_database()
    {
        var cust = from p in dv.posts
                   select p;
        Repeater1.DataSource = cust;
        Repeater1.DataBind();
      

    }

   
}