using BusinessLayer;
using EntityLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        StudentEntity std = new StudentEntity
        {
            NAME = TxtName.Text,
            SURNAME = TxtSurName.Text,
            NUMBER = TxtNumber.Text,
            PHOTO = TxtPhoto.Text,
            PASSWORD = TxtPassword.Text,
        };
        StudentBusiness.AddStdBusiness(std);
    }
}