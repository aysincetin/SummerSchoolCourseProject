using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLayer;
public partial class StudentList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<StudentEntity> StdList = StudentBusiness.ListStdBusiness();
        Repeater1.DataSource = StdList;
        Repeater1.DataBind();
    }
}