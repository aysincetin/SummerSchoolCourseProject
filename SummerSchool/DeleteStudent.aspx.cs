using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLayer;

public partial class DeleteStudent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["STDID"]);
        Response.Write(x);
        StudentEntity std = new StudentEntity();
        std.ID = x;
        StudentBusiness.DeleteStdBusiness(std.ID);
        Response.Redirect("StudentList.aspx");
    }
}