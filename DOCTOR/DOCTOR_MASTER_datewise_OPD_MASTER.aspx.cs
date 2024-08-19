using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace hospitalmanagement.DOCTOR
{
    public partial class DOCTOR_MASTER_datewise_OPD_MASTER : System.Web.UI.Page
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
            cmd.CommandText = "select OPD_ID,DEPT_NM,CASEPAPER.CASEPAPER_ID,OPD_DATE,CHECKUP_FEES,PROBLEM,PRESC_MEDICINE    from   OPD_MASTER,DEPARTMENT,CASEPAPER,DOCTOR_MASTER  where   DEPARTMENT.DEPT_ID=OPD_MASTER.DEPT_ID   and     CASEPAPER.CASEPAPER_ID=OPD_MASTER.CASEPAPER_ID   and    OPD_DATE    Between     '"+txt_fdate.Text+"' and '"+txt_tdate.Text+"' and DOCTOR_MASTER.DOCT_ID=1";
            dr = cmd.ExecuteReader();

            PlaceHolder1.Controls.Add(new LiteralControl("<table class='table' border= '2px' id='bill'><tr><th>OPD</th><th>DEPARTMENT</th> <th>CASEPAPER NO</th> <th>DATE</th> <th>CHECKUP FEES</th> <th>PROBLEM</th> <th>PRESCIPTION MEDICINE</th></tr>"));

            while (dr.Read())
            {
                PlaceHolder1.Controls.Add(new LiteralControl("<tr>"));

                PlaceHolder1.Controls.Add(new LiteralControl("<td>" + dr[0] + "</td>"));
                PlaceHolder1.Controls.Add(new LiteralControl("<td>" + dr[1] + "</td>"));
                PlaceHolder1.Controls.Add(new LiteralControl("<td>" + dr[2] + "</td>"));
                PlaceHolder1.Controls.Add(new LiteralControl("<td>" + dr[3] + "</td>"));
                PlaceHolder1.Controls.Add(new LiteralControl("<td>" + dr[4] + "</td>"));
                PlaceHolder1.Controls.Add(new LiteralControl("<td>" + dr[5] + "</td>"));
                PlaceHolder1.Controls.Add(new LiteralControl("<td>" + dr[6] + "</td>"));

                PlaceHolder1.Controls.Add(new LiteralControl("</tr>"));


            }
            PlaceHolder1.Controls.Add(new LiteralControl("</table>"));
            dr.Close();
        }
    }
}