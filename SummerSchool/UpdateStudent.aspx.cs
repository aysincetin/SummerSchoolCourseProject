using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using EntityLayer;
using BusinessLayer;

public partial class UpdateStudent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["STDID"].ToString());
        TxtID.Text = x.ToString();
        TxtID.Enabled = false;

        if (Page.IsPostBack == false)
        {
            List<StudentEntity> StdList = StudentBusiness.DetailStdBusiness(x);
            TxtName.Text = StdList[0].NAME.ToString();
            TxtSurName.Text = StdList[0].SURNAME.ToString();
            TxtNumber.Text = StdList[0].NUMBER.ToString();
            TxtPhoto.Text = StdList[0].PHOTO.ToString();
            TxtPassword.Text = StdList[0].PASSWORD.ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        StudentEntity std = new StudentEntity();
        std.NAME = TxtName.Text.ToString();
        std.SURNAME = TxtSurName.Text.ToString();
        std.NUMBER = TxtNumber.Text.ToString();
        std.PHOTO = TxtPhoto.Text.ToString();
        std.PASSWORD = TxtPassword.Text.ToString();
        std.ID = Convert.ToInt32(TxtID.Text);
        StudentBusiness.UpdateStdBusiness(std);
        Response.Redirect("StudentList.aspx");
    }
}