using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace hospitalmanagement.Reports
{
    public partial class Datewise_FINAL_BILLING : System.Web.UI.Page
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
            cmd.CommandText = "select*from FINAL_BILLING where BILL_DATE Between'" + txt_fdate.Text + "' and '" + txt_tdate.Text + "'";
            dr = cmd.ExecuteReader();

            PlaceHolder1.Controls.Add(new LiteralControl("<table class='table' border= '2px' id='bill'><tr> <th>BILL NO</th> <th>DEPARTMENT</th> <th>IPD</th> <th>CASEPAPER NO</th> <th>DATE</th> <th>NURSING CHARGES</th> <th>BED CHARGES</th> <th>TEST AMOUNT</th> <th>OPERATION CHARGES</th> <th>GST</th> <th>TOTAL AMOUNT</th> </tr>"));

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
                PlaceHolder1.Controls.Add(new LiteralControl("<td>" + dr[8] + "</td>"));
                PlaceHolder1.Controls.Add(new LiteralControl("<td>" + dr[9] + "</td>"));
                PlaceHolder1.Controls.Add(new LiteralControl("<td>" + dr[10] + "</td>"));

                PlaceHolder1.Controls.Add(new LiteralControl("</tr>"));


            }
            PlaceHolder1.Controls.Add(new LiteralControl("</table>"));
            dr.Close();
        }
    }
}