using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace hospitalmanagement.DOCTOR
{
    public partial class DOCTOR_MASTER_Datewise_IPD_MASTER : System.Web.UI.Page
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
            cmd.CommandText = "select IPD_ID,DEPT_NM,IPD_DATE,CASEPAPER.CASEPAPER_ID,WARD_NM,BED_NO,DIESE_NAME,TREATMENT    from   IPD_MASTER,DEPARTMENT,CASEPAPER,DOCTOR_MASTER    where      DEPARTMENT.DEPT_ID=IPD_MASTER.DEPT_ID     and     CASEPAPER.CASEPAPER_ID=IPD_MASTER.CASEPAPER_ID    and       IPD_DATE      Between     '" + txt_fdate.Text + "'    and     '" + txt_tdate.Text + "'    and     DOCTOR_MASTER.DOCT_ID=1";
            dr = cmd.ExecuteReader();
            PlaceHolder1.Controls.Add(new LiteralControl("<table class='table' border= '2px' id='bill'><tr>     <th>IPD</th>     <th>DEPARTMENT</th>      <th>DATE</th>     <th>CASEPAPER NO</th>    <th>WARD NAME</th>    <th>BED NO</th>     <th>DIESES NAME</th>  <th>TREATMENT</th>    </tr>"));

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
                PlaceHolder1.Controls.Add(new LiteralControl("<td>" + dr[7] + "</td>"));


                PlaceHolder1.Controls.Add(new LiteralControl("</tr>"));


            }
            PlaceHolder1.Controls.Add(new LiteralControl("</table>"));
            dr.Close();
        }
    }
}