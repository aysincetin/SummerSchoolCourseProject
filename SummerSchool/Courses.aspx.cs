using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Courses : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Page.IsPostBack == false)
        {
            List<CourseEntity> course = CourseBusiness.ListBusiness();
            DropDownList1.DataSource = CourseBusiness.ListBusiness();
            DropDownList1.DataTextField = "COURSENAME";
            DropDownList1.DataValueField = "ID";
            DropDownList1.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ApplicationFormEntity entity = new ApplicationFormEntity();
        entity.APPTEACHERID = int.Parse(TextBox1.Text);
        entity.APPCOURSEID = int.Parse(DropDownList1.SelectedValue.ToString());
        CourseBusiness.AddRequestBusiness(entity);
    }
}