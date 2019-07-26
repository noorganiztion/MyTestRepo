using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserManagement;
using System.Xml;
using System.Data;
namespace ASPWebAPP
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
                Response.Redirect("login.aspx");
            BinData();
        }

        private void BinData()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("Data.xml"));

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUserName.Text = "";
            ddlAge.SelectedValue = "18";

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            UserBE objProp = new UserBE();
            objProp.Age = Convert.ToInt16(ddlAge.SelectedValue.ToString());

            objProp.FirstName = txtFirstName.Text;
            objProp.LastName = txtLastName.Text;
            objProp.UserName = txtUserName.Text;

            User obj = new User();


            objProp.FilePath = Server.MapPath("Data.xml");

            lblOutput.Text = obj.SaveUserInfo(objProp);
        }
    }
}