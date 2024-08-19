using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace hospitalmanagement.DOCTOR
{
    public partial class DOCTOR_MASTER_wise_CASEPAPER : System.Web.UI.Page
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

        protected void btn_show_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select CASEPAPER_ID,CASE_DATE,DEPT_NM,DOCT_NAME,PAT_NM,CASEPAPER_FEES from DOCTOR_MASTER,CASEPAPER,DEPARTMENT,PATIENT_MASTER where CASEPAPER.DEPT_ID=DEPARTMENT.DEPT_ID and CASEPAPER.DOCT_ID=DOCTOR_MASTER.DOCT_ID and CASEPAPER.PAT_ID=PATIENT_MASTER.PAT_ID and CASEPAPER_ID=" + txt_DOCT_ID.Text;
            dr = cmd.ExecuteReader();
            PlaceHolder1.Controls.Add(new LiteralControl("<table class='table' border= '2px' id='bill'><tr><th>CASEPAPER NO</th><th>DATE</th><th>DEPARTMENT</th><th>DOCTOR</th><th>PATIENT</th><th>CASEPAPER FEES</th></tr>"));

            while (dr.Read())
            {
                PlaceHolder1.Controls.Add(new LiteralControl("<tr>"));

                PlaceHolder1.Controls.Add(new LiteralControl("<td>" + dr[0] + "</td>"));
                PlaceHolder1.Controls.Add(new LiteralControl("<td>" + dr[1] + "</td>"));
                PlaceHolder1.Controls.Add(new LiteralControl("<td>" + dr[2] + "</td>"));
                PlaceHolder1.Controls.Add(new LiteralControl("<td>" + dr[3] + "</td>"));
                PlaceHolder1.Controls.Add(new LiteralControl("<td>" + dr[4] + "</td>"));
                PlaceHolder1.Controls.Add(new LiteralControl("<td>" + dr[5] + "</td>"));


                PlaceHolder1.Controls.Add(new LiteralControl("</tr>"));


            }
            PlaceHolder1.Controls.Add(new LiteralControl("</table>"));

            dr.Close();
        }
    }
}