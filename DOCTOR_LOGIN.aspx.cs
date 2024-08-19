using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace hospitalmanagement
{
    public partial class DOCTOR_LOGIN : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;


        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-M7MH1D3U\\SQLEXPRESS;Initial Catalog=hospitalmanagement;Integrated Security=True";
            cn.Open();

        }

        protected void btb_login_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select*from DOCTOR_MASTER where DOCT_EMAIL='"+txt_email_id.Text+"' and DOCT_PASS='"+txt_pass.Text+"'",cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session.Add("cid", dr[0]);
                Session.Add("cnm", dr[1]);
                MessageBox.Show("Login Successful");
                Response.Redirect("~/DOCT_DashBord.aspx");

            }
            else
            {
                MessageBox.Show("Login Failed");
                txt_email_id.Text = "";
                txt_pass.Text = "";
            }

        }
    }
}