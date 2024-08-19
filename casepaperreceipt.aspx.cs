using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace hospitalmanagement
{
    public partial class casepaperreceipt : System.Web.UI.Page
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
            cmd.CommandText = "select OPD_ID,DEPT_NM,CASEPAPER.CASEPAPER_ID,OPD_DATE,CHECKUP_FEES,PROBLEM,PRESC_MEDICINE,PAT_NM,CASEPAPER_FEES from OPD_MASTER,DEPARTMENT,CASEPAPER,PATIENT_MASTER where DEPARTMENT.DEPT_ID=OPD_MASTER.DEPT_ID and CASEPAPER.CASEPAPER_ID=OPD_MASTER.CASEPAPER_ID and CASEPAPER.PAT_ID=PATIENT_MASTER.PAT_ID and OPD_MASTER.OPD_ID=" + Session["opdid"];
            dr = cmd.ExecuteReader();

            String OPD_ID = "", DEPT_NM = "", CASEPAPER_ID = "", OPD_DATE = "", CHECKUP_FEES = "", PROBLEM = "", PRESC_MEDICINE = "", PAT_NM = "", CASEPAPER_FEES="";

            if (dr.Read())
            {

                OPD_ID = dr[0].ToString();
                DEPT_NM = dr[1].ToString();
                CASEPAPER_ID = dr[2].ToString();
                OPD_DATE = dr[3].ToString();
                CHECKUP_FEES = dr[4].ToString();
                PROBLEM = dr[5].ToString();
                PRESC_MEDICINE = dr[6].ToString();
                PAT_NM = dr[7].ToString();
                CASEPAPER_FEES = dr[8].ToString();

            }
            dr.Close();

            PlaceHolder1.Controls.Add(new LiteralControl("<table style='text-align: left; width: 50px; height: 100px;' align='center'  id='bill' >" +



        "<tr>"+

            "<td class='auto-style1' rowspan='16'>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>"+
            "<td class='auto-style3' colspan='3' align='center'>"+
                "<h1 style='text-decoration: underline; width: 458px; text-align: center; color: #00D9A5;'   >Receipt</h1>"+
            "</td>"+
            "<td class='auto-style49' rowspan='16'>&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>"+

        "</tr>"+

        "<tr>"+

            "<td class='auto-style7' style='background-color: #DBFFE7;' aria-hidden='False'>"+
               " <h3><strong style='padding: 10px 0px 0px 0px'>&nbsp; Receipt No:</strong></h3>"+
            "</td>"+
            "<td class='auto-style8' colspan='2' style='background-color: #DBFFE7;' aria-hidden='False'>"+
              "  <h4 style='padding-top: 10px'>" + OPD_ID + "</h4>" +
            "</td>"+
           

        "</tr>"+

        "<tr>"+

            "<td class='auto-style62' style='background-color: #DBFFE7; border-top-style: solid; border-top-width: 2px;' aria-invalid='false'>"+
                "<h3 style='padding-top: 10px'><strong>&nbsp; OPD Dt</strong>:</h3>"+
            "</td>"+
            "<td class='auto-style61' colspan='2' style='background-color: #DBFFE7; border-top-style: solid; border-top-width: 2px;' aria-invalid='false'>"+
                "<h4 style='padding-top: 10px'>" + OPD_DATE + "</h4>" +
            "</td>"+
            

        "</tr>"+

       " <tr>"+

            "<td class='auto-style23' colspan='3'></td>"+

       " </tr>"+

        "<tr>"+

            "<td class='auto-style64' style='background-color: #DBFFE7'>"+
               " <h3 style='width: 315px; height: 49px'><strong style='margin: -6px; padding-top: 10px;'>&nbsp; Paient Name:</strong></h3>"+
            "</td>"+
           " <td class='auto-style63'  colspan ='2' style='background-color: #DBFFE7'>"+
            "    <h4 style='padding-top: 10px'>" + PAT_NM + "</h4>" +
       "     </td>"+

        "</tr>"+

      "  <tr>"+

            "<td class='auto-style19' colspan='3'> &nbsp;</td>"+

        "</tr>"+

        "<tr>"+

            "<td class='auto-style65' style='background-color: #DBFFE7'>"+
                "<h3><strong style='padding-top: 10px; border-style: inherit'>&nbsp; Casepaper No:</strong></h3>"+
           " </td>"+
           " <td class='auto-style56' colspan='2' style='background-color: #DBFFE7'>"+
              "  <h4 style='padding-top: 10px'>" + CASEPAPER_ID + "</h4>" +
            "</td>"+

       " </tr>"+

        "<tr>"+

            "<td class='auto-style27' colspan='3'>"+
              "  &nbsp;</td>"+

        "+</tr>"+

        "<tr>"+

            "<td class='auto-style64' style='background-color: #DBFFE7'>"+
               "<h3 style='width: 268px'><strong style='padding-top: 10px'>&nbsp; Received Rs:</strong></h3>"+
            "</td>"+
            "<td class='auto-style28' colspan='2' style='background-color: #DBFFE7'>"+
               " <h3 class='text-center' style='padding-top: 10px'>" + CHECKUP_FEES + "</h3>" +
           " </td>"+

        "</tr>"+

          "<tr>"+

            "<td class='auto-style31' colspan='3'></td>"+

        "</tr>"+

          "<tr>"+

            "<td class='auto-style66' colspan='2' rowspan='3' style='background-color: #DBFFE7'>"+
               "<h3><strong style='padding-top: 10px'>&nbsp; For the Consultation of </strong><strong> : </strong></h3>" +
              "</td>"+
           " <td class='text-center'></td>"+
           
        "</tr>"+

         " <tr>"+
         
            "<td class='text-center'>&nbsp;</td>"+

        "</tr>"+

         "<tr>"+

            "<td class='auto-style52' rowspan='2' style='border-bottom-style: none; border-bottom-width: 3px;'></td>"+

        "</tr>"+

         " <tr>"+

        "   <td class='auto-style67' colspan='2' style='background-color: #DBFFE7'>"+
               " <h4 style='padding: -8px 0px 0px 0px'></h4>"+
           "   </td>"+

      "  </tr>"+

      "   <tr>"+

            "<td class='auto-style68' colspan='2'></td>"+
          "  <td class='auto-style69'>"+
                "<h3><strong>Sign</strong></h3>"+
            " </td>"+

        "</tr>"+

       "  <tr>"+

            "<td class='auto-style54' colspan='3'></td>"+

      "  </tr>" +
         
        "</table>"));



        }
    }
}