using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace hospitalmanagement
{
    public partial class AdminLogin : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_log_Click(object sender, EventArgs e)
        {
            if (txt_admin.Text == "admin" && txt_pass.Text == "1234")
            {
                MessageBox.Show("Login Successful");
                Response.Redirect("~/DashBoard.aspx");

            }
            else
            {
                MessageBox.Show("Enter Correct Password");
            }
        }
    }
}