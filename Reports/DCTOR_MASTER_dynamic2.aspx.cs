using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace hospitalmanagement.Reports
{
    public partial class DCTOR_MASTER_dynamic2 : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-M7MH1D3U\\SQLEXPRESS;Initial Catalog=hospitalmanagement;Integrated Security=True";
            cn.Open();

            if (!IsPostBack)
                Setdropdown();
        }

        public void Setdropdown()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "Select*from DEGREE_MASTER";
            dr = cmd.ExecuteReader();
            DropDownList1.DataSource = dr;
            DropDownList1.DataTextField = "DEGREE_NM";
            DropDownList1.DataValueField = "DEGREE_ID";
            DropDownList1.DataBind();
            dr.Close();
        }

        protected void btn_show_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "Select DOCT_ID,DOCT_NAME,DEPT_NM,DEGREE_NM,DOCT_LICENSE,DOCT_MOBILE,DOCT_ADDRESS,DOCT_GENDER,DOCT_SPECIALITY,DOCT_EMAIL,DOCT_PASS from DEGREE_MASTER,DOCTOR_MASTER,DEPARTMENT where DEPARTMENT.DEPT_ID=DOCTOR_MASTER.DEPT_ID and DEGREE_MASTER.DEGREE_ID=DOCTOR_MASTER.DEGREE_ID and DOCTOR_MASTER.DEGREE_ID=" + DropDownList1.SelectedValue;
            dr = cmd.ExecuteReader();
            PlaceHolder1.Controls.Add(new LiteralControl("<table class='table' border= '2px' id='bill'><tr> <th>DOCTOR</th> <th>NAME</th> <th>DEPARTMENT</th> <th>DEGREE</th> <th>LICENSE</th> <th>MOBILE</th> <th>ADDRESS</th> <th>GENDER</th> <th>SPECIALITY</th>  <th>EMAIL</th> <th>PASS</th> </tr>"));

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