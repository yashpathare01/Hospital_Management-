﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace hospitalmanagement
{
    public partial class CASEPAPER_list_report : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;


        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-M7MH1D3U\\SQLEXPRESS;Initial Catalog=hospitalmanagement;Integrated Security=True";
            cn.Open();

            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select CASEPAPER_ID,CASE_DATE,DEPT_NM,DOCT_NAME,PAT_NM,CASEPAPER_FEES from DOCTOR_MASTER,CASEPAPER,DEPARTMENT,PATIENT_MASTER where DEPARTMENT.DEPT_ID=CASEPAPER.DEPT_ID and DOCTOR_MASTER.DOCT_ID=CASEPAPER.DOCT_ID and PATIENT_MASTER.PAT_ID=CASEPAPER.PAT_ID";
            dr = cmd.ExecuteReader();

            PlaceHolder1.Controls.Add(new LiteralControl("<table class='table' border= '2px' id='bill'><tr> <th>CASEPAPER NO</th> <th>DATE</th> <th>DEPARTMENT</th> <th>DOCTOR</th> <th>PATIENT</th> <th>FEES</th> </tr>"));

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