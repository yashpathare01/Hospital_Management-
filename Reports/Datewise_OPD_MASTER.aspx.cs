using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace hospitalmanagement.Reports
{
    public partial class Datewise_OPD_MASTER : System.Web.UI.Page
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
            cmd.CommandText = "select*from OPD_MASTER where OPD_DATE Between'" + txt_fdate.Text + "' and '" + txt_tdate.Text + "'";
            dr = cmd.ExecuteReader();

            PlaceHolder1.Controls.Add(new LiteralControl("<table class='table' border= '2px' id='bill'><tr> <th>OPD</th> <th>DEPARTMENT</th> <th>CASEPAPER NO</th> <th>DATE</th> <th>CHECKUP FEES</th> <th>PROBLEM</th> <th>PRESCIPTION MEDICINE</th> </tr>"));

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