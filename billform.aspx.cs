using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace hospitalmanagement
{
    public partial class billform : System.Web.UI.Page
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
            cmd.CommandText = "select IPD_BILL_ID,DEPT_NM,IPD_MASTER.IPD_ID,CASEPAPER.CASEPAPER_ID,BILL_DATE,NURSING_CHARGES,BED_CHARGES,TEST_AMOUNT,OPERATION_CHARGES,GST,TOTAL_AMOUNT,PAT_NM,PAT_ADDR from DEPARTMENT,IPD_MASTER,CASEPAPER,FINAL_BILLING,PATIENT_MASTER where DEPARTMENT.DEPT_ID=FINAL_BILLING.DEPT_ID and CASEPAPER.PAT_ID=PATIENT_MASTER.PAT_ID and IPD_MASTER.IPD_ID=FINAL_BILLING.IPD_ID and CASEPAPER.CASEPAPER_ID=FINAL_BILLING.CASEPAER_ID and final_billing.ipd_bill_id="+Session["billid"];
            dr = cmd.ExecuteReader();

            String IPD_BILL_ID = "", DEPT_NM = "", IPD_ID = "", CASEPAPER_ID = "", BILL_DATE = "", NURSING_CHARGES = "", BED_CHARGES = "", TEST_AMOUNT = "", OPERATION_CHARGES = "", GST = "", TOTAL_AMOUNT = "", PAT_NM = "", PAT_ADDR = "";

            if (dr.Read())
            {

                IPD_BILL_ID = dr[0].ToString();
                DEPT_NM = dr[1].ToString();
                IPD_ID = dr[2].ToString();
                CASEPAPER_ID = dr[3].ToString();
                BILL_DATE = dr[4].ToString();
                NURSING_CHARGES = dr[5].ToString();
                BED_CHARGES = dr[6].ToString();
                TEST_AMOUNT = dr[7].ToString();
                OPERATION_CHARGES = dr[8].ToString();
                GST = dr[9].ToString();
                TOTAL_AMOUNT = dr[10].ToString();
                PAT_NM = dr[11].ToString();
                PAT_ADDR = dr[12].ToString();


            }
            dr.Close();
            PlaceHolder1.Controls.Add(new LiteralControl("<table class='auto-style1' id='bill' >" +

        "<tr>" +
            "<td colspan='8'></td>" +
        "</tr>" +
        "<tr>" +
            "<td class='auto-style26' style='text-align: right' rowspan='31'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>" +
            "<td colspan='2' style='text-align: left; color: #00D9A5; font-size: 25px;' class='auto-style111'><br class='auto-style48' />" +
                "<span class='auto-style48'>+91 999 2222 888</span></td>" +
            "<td colspan='2' class='auto-style110'>" +
                "<h3 class='auto-style48'><span class='auto-style36'>vitalcare@gmail.com</span><br class='auto-style36' />" +
                "<span class='auto-style36'>vitalcare@gmail.com</span></h3>" +
            "</td>" +
            "<td colspan='2' style='text-align: center;' class='auto-style111'>" +
                "<h3 class='auto-style128'><span class='auto-style36'>kolhapur</span><br class='auto-style36' />" +
                "<span class='auto-style36'>kolhapur</span></h3>" +
            "</td>" +
            "<td style='text-align: left' rowspan='31'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>" +
        "</tr>" +
        "<tr>" +
            "<td colspan='6' style='text-align: center; color: #00D9A5; font-size: 25px;' class='auto-style92'></td>" +

        "</tr>" +
        "<tr>" +
            "<td class='auto-style40' colspan='3'>" +
                "<h3 class='newStyle8'><strong style='text-decoration: underline; font-size: 150px;' class='auto-style41'>INVOICE</strong></h3>" +
            "</td>" +
            "<td class='auto-style40' colspan='3'>" +
                "<h2 style='font-size: 50px'><span class='auto-style30' style='color: #00D9A5'>VITAL</span><span class='auto-style42'>-CARE</span></h2>" +
            "</td>" +
        "</tr>" +
        "<tr>" +
            "<td class='auto-style2' colspan='6'>" +
                "&nbsp;</td>" +
        "</tr>" +
        "<tr >" +
            "<td colspan='3' style='text-align: left' ><span class='auto-style48'><strong style='text-decoration: underline'>BILL TO :</strong></span><span class='auto-style46'> </span><br class='auto-style46' />" +
                "<span class='auto-style46'>" + PAT_NM + ",<br />" +
                "" + PAT_ADDR + "</span><br class='auto-style46' />" +
                "</td>" +
            "<td colspan='3'><span class='auto-style48'><strong>INVOCE DATE :</strong></span><span class='auto-style46'> " + System.DateTime.Now.ToString() + " <br />" +
                "</span><br class='auto-style46' />" +
                
                 "<span class='auto-style48'><strong>INVOICE NO :" + IPD_BILL_ID + " </strong></span>" +
                "<span class='auto-style46'></span></td>" +
        "</tr>" +
        "<tr >" +
           "<td colspan='6' style='text-align: left' class='auto-style120' ></td>" +
        "</tr>" +
        "<tr>" +
        "<td colspan='2' class='auto-style4' style='background-color: #DBFFE7; '>" +
           " <h3 class='auto-style48'><strong style='font-size: 40px'>SERVICES</strong></h3>" +
       " </td>" +

       "<td colspan='2' class='auto-style4' style='background-color: #DBFFE7;>" +
           " <h3 class='auto-style47'><strong style='font-size: 40px'>PRICE</strong></h3>" +
       " </td>" +
       " <td class='auto-style73' style='background-color: #DBFFE7; color: #000000' colspan='2'>" +
          "  <h3 class='auto-style48'><strong class='newStyle8'>TOTAL AMOUNT</strong></h3>" +
       " </td>" +

  "  </tr>" +
   " <tr>" +
      "  <td colspan='6' class='auto-style46'>&nbsp;</td>" +
  "  </tr>" +

   " <tr>" +
     "   <td colspan='2' class='auto-style112'>Bed Charges</td>" +

      "  <td class='auto-style147' colspan='2'>" +
          "  " + BED_CHARGES + "</td>" +
       " <td class='auto-style147' colspan='2'>" + BED_CHARGES + "</td>" +
  "  </tr>" +
    "<tr>" +
     "   <td colspan='6' class='auto-style46'>&nbsp;</td>" +
    "</tr>" +
   " <tr>" +
        "<td colspan='2' class='auto-style146' style='background-color: #DBFFE7; color: #000000; text-align: center; font-size: 30px;'>Nursing Charges</td>" +

        "<td class='auto-style145' style='background-color: #DBFFE7; color: #000000; text-align: center; font-size: 30px;' colspan='2'>" +
           " " + NURSING_CHARGES + "</td>" +
       " <td class='auto-style145' style='background-color: #DBFFE7; color: #000000; text-align: center; font-size: 30px;' colspan='2'>" + NURSING_CHARGES + "</td>" +
        " </tr>" +
    "<tr>" +
       " <td colspan='6' class='auto-style46'>&nbsp;</td>" +
   " </tr>" +
    "<tr>" +
      "  <td colspan='2' class='auto-style146' style='background-color: #DBFFE7; color: #000000; text-align: center; font-size: 30px;'>Test Charges</td>" +

        "<td class='auto-style145' style='background-color: #DBFFE7; color: #000000; text-align: center; font-size: 30px;' colspan='2'>" +
          "  " + TEST_AMOUNT + "</td>" +
        "<td class='auto-style145' style='background-color: #DBFFE7; color: #000000; text-align: center; font-size: 30px;' colspan='2'>" + TEST_AMOUNT + "</td>" +
  "  </tr>" +
    "<tr>" +
    "    <td colspan='6' class='auto-style46'>&nbsp;</td>" +
"    </tr>" +
"    <tr>" +
       " <td colspan='2' style='background-color: #DBFFE7; color: #000000; text-align: center;' class='auto-style131'>Operation Charges</td>" +

      " <td class='auto-style140' style='background-color: #DBFFE7; color: #000000; text-align: center; font-size: 30px;' colspan='2'>" +
          " " + OPERATION_CHARGES + "</td>" +
        "<td class='auto-style140' style='background-color: #DBFFE7; color: #000000; text-align: center; font-size: 30px;' colspan='2'>" + OPERATION_CHARGES + "</td>" +
  "  </tr>" +
       "<tr>" +
            "+<td colspan='6' class='auto-style50'></td>" +
        "</tr>" +

        "<tr>" +
            "<td colspan='3' rowspan='6' style='color: #00D9A5' class='auto-style48' >Terms And Conditions : <span class='auto-style116'></span></td>" +
        "</tr>" +
       " <tr>" +
           "+ <td class='auto-style46' colspan='3'>&nbsp;</td>" +
       " </tr>" +
        "<tr>" +
            "<td colspan='2' style='text-align: right; color: #00D9A5;' class='auto-style48'>GST:</td>" +
            "<td class='auto-style27' style='background-color: #FFFFFF'>" + GST + "</td>" +
       " </tr>" +
        "<tr>" +
           " <td class='auto-style46' colspan='3'>&nbsp;</td>" +
       " </tr>" +
        "<tr>" +
           " <td colspan='2' style='text-align: right; color: #00D9A5;' class='auto-style48'>DISCOUNT:</td>" +
            "<td class='auto-style27' style='background-color: #FFFFFF'>0%</td>" +
       " </tr>" +
       "<tr>" +
            "+<td class='auto-style46' colspan='3'>&nbsp;</td>" +
       " </tr>" +
        "<tr>" +
           " <td colspan='3' style='text-align: right' class='auto-style129'></td>" +
            "<td class='auto-style13' colspan='2' style='color: #00D9A5; background-color: #DBFFE7; text-decoration: underline;'>TOTAL AMOUNT:</td>" +
             "<td style='text-align: center; background-color: #DBFFE7;' class='auto-style130'>" + TOTAL_AMOUNT + "</td>" +
       " </tr>" +
        "<tr>" +
            "<td colspan='6' style='text-align: right' class='auto-style48'>&nbsp;</td>" +
        "</tr>" +
        "<tr>" +
            "<td colspan='6' style='color: #00D9A5;' class='auto-style108'>Payment Info :<span class='auto-style115'>Cash</span></td>" +
        "</tr>" +
        "<tr>" +
           "+ <td colspan='6' class='auto-style107'></td>" +
        "</tr>" +
        "<tr>" +
           " <td style='text-align: center; color: #00D9A5;' class='auto-style105'>Account :</td>" +
           " <td style='text-align: center; background-color: #DBFFE7;' class='auto-style68'></td>" +
           " <td class='auto-style106' colspan='4'></td>" +
        "</tr>" +
       " <tr>" +
           "<td colspan='5' class='auto-style104'></td>" +
           " <td rowspan='3' class='auto-style27'>&nbsp;</td>" +
       " </tr>" +
        "<tr>" +
            "<td style='text-align: center; color: #00D9A5;' class='auto-style101'>A/c Name :</td>" +
            "<td style='text-align: center; background-color: #DBFFE7;' class='auto-style102'></td>" +
           " <td class='auto-style103' colspan='3'></td>" +
        "</tr>" +
        "<tr>" +
            "<td colspan='5' class='auto-style127'></td>" +
        "</tr>" +
        "<tr>" +
            "<td style='text-align: center; color: #00D9A5;' class='auto-style124'>Bank Details :</td>" +
            "<td style='text-align: center; background-color: #DBFFE7;' class='auto-style125'></td>" +
            "<td class='auto-style126' colspan='3'></td>" +
           " <td style='text-align: center' class='auto-style99'>Signature</td>" +
       "</tr>" +
       " <tr>" +
           "<td class='auto-style151' colspan='8'></td>" +
        "</tr>" +
       " </table>"));
        }
  
        }
    }
