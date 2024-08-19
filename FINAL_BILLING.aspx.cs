using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hospitalmanagement
{
    public partial class FINAL_BILLING : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        static int flag = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-M7MH1D3U\\SQLEXPRESS;Initial Catalog=hospitalmanagement;Integrated Security=True";
            cn.Open();
            SetGrid();
            if (!IsPostBack)
            {
                SetDropdown1();
                SetDropdown2();
                SetDropdown3();

            }

            btn_new.CssClass = "btn btn-primary wow zoomIn";
            btn_save.CssClass = "btn btn-primary wow zoomIn";
            btn_update.CssClass = "btn btn-primary wow zoomIn";
            btn_delete.CssClass = "btn btn-primary wow zoomIn";

            txt_BILL_DATE.Text = System.DateTime.Now.ToString();
        }

            public void EnableText()
        {
            txt_IPD_BILL_ID.Enabled = true;
            txt_BILL_DATE.Enabled = false;
            txt_NURSING_CHARGES.Enabled = true;
            txt_BED_CHARGES.Enabled = true;
            txt_TEST_AMOUNT.Enabled = true;
            txt_OPERATION_CHARGES.Enabled = true;
            txt_GST.Enabled = false;
            txt_TOTAL_AMOUNT.Enabled = false;
        }
        public void DisableText()
        {
            txt_IPD_BILL_ID.Enabled = false;
            txt_BILL_DATE.Enabled = false;
            txt_NURSING_CHARGES.Enabled = false;
            txt_BED_CHARGES.Enabled = false;
            txt_TEST_AMOUNT.Enabled = false;
            txt_OPERATION_CHARGES.Enabled = false;
            txt_GST.Enabled = false;
            txt_TOTAL_AMOUNT.Enabled = false;
        }
        public void ClearText()
        {
            txt_IPD_BILL_ID.Text = "";
            txt_BILL_DATE.Text = "";
            txt_NURSING_CHARGES.Text = "";
            txt_BED_CHARGES.Text = "";
            txt_TEST_AMOUNT.Text = "";
            txt_OPERATION_CHARGES.Text = "";
            txt_GST.Text = "";
            txt_TOTAL_AMOUNT.Text = "";

        }
        public void SetGrid()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from FINAL_BILLING order by IPD_BILL_ID";
            dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
        }
        public int GetNewId()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select Max(IPD_BILL_ID) from FINAL_BILLING";
            object x = cmd.ExecuteScalar();

            if (Convert.ToString(x) == "")
                return 1;
            else
                return (Convert.ToInt32(x) + 1);
        }

        protected void btn_new_Click(object sender, EventArgs e)
        {
            flag = 1;
            EnableText();
            txt_IPD_BILL_ID.Text = Convert.ToString(GetNewId());
            btn_new.Enabled = false;
            btn_save.Enabled = true;
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
             if (flag == 1)
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;

                DateTime dt = Convert.ToDateTime(txt_BILL_DATE.Text);
                cmd.CommandText = "insert into FINAL_BILLING values(" + txt_IPD_BILL_ID.Text + "," + DropDownList1.SelectedValue + "," + DropDownList2.SelectedValue + "," + DropDownList3.SelectedValue + ",'" + (dt.ToString("MM-dd-yyyy")) + "'," + txt_NURSING_CHARGES.Text + "," + txt_BED_CHARGES.Text + "," + txt_TEST_AMOUNT.Text + "," + txt_OPERATION_CHARGES.Text + "," + txt_GST.Text + "," + txt_TOTAL_AMOUNT.Text + ")";
                int x = cmd.ExecuteNonQuery();
               
                if (x > 0)
                {
                    MessageBox.Show("Inserted");
                    Session["billid"] = txt_IPD_BILL_ID.Text;
                    Response.Redirect("~/billform.aspx");
                  
                }
                else
                    MessageBox.Show("Not Inserted");
            }
            if (flag == 2)
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;

                DateTime dt = Convert.ToDateTime(txt_BILL_DATE.Text);
                cmd.CommandText = "update FINAL_BILLING set DEPT_ID=" + DropDownList1.SelectedValue + ",IPD_ID=" + DropDownList2.SelectedValue + ",CASEPAER_ID=" + DropDownList3.SelectedValue + ",BILL_DATE='" + (dt.ToString("MM-dd-yyyy")) + "',NURSING_CHARGES=" + txt_NURSING_CHARGES.Text + ",BED_CHARGES=" + txt_BED_CHARGES.Text + ",TEST_AMOUNT=" + txt_TEST_AMOUNT.Text + ",OPERATION_CHARGES=" + txt_OPERATION_CHARGES.Text + ",GST=" + txt_GST.Text + ",TOTAL_AMOUNT=" + txt_TOTAL_AMOUNT.Text + " where IPD_BILL_ID=" + txt_IPD_BILL_ID.Text;
                int x = cmd.ExecuteNonQuery();

                if (x > 0)
                {
                    MessageBox.Show("Updated");

                    Session["billid"] = txt_IPD_BILL_ID.Text;
                    Response.Redirect("~/billform.aspx");
                }
                else
                    MessageBox.Show("Not Updated");
            }

            SetGrid();
            ClearText();
            DisableText();
            btn_new.Enabled = true;
            btn_save.Enabled = false;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            flag = 2;
            EnableText();
            btn_new.Enabled = false;
            btn_save.Enabled = true;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "delete from FINAL_BILLING where IPD_BILL_ID=" + txt_IPD_BILL_ID.Text;
            int x = cmd.ExecuteNonQuery();

            if (x > 0)
                MessageBox.Show("Deleted");
            else
                MessageBox.Show("Not Deleted");

            SetGrid();
            ClearText();
            DisableText();
            btn_new.Enabled = true;
            btn_save.Enabled = false;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
             txt_IPD_BILL_ID.Text = GridView1.SelectedRow.Cells[1].Text;
             DropDownList1.Text = GridView1.SelectedRow.Cells[2].Text;
             DropDownList2.Text = GridView1.SelectedRow.Cells[3].Text;
             DropDownList3.Text = GridView1.SelectedRow.Cells[4].Text;
            txt_BILL_DATE.Text = GridView1.SelectedRow.Cells[5].Text;
            txt_NURSING_CHARGES.Text = GridView1.SelectedRow.Cells[6].Text;
            txt_BED_CHARGES.Text = GridView1.SelectedRow.Cells[7].Text;
            txt_TEST_AMOUNT.Text = GridView1.SelectedRow.Cells[8].Text;
            txt_OPERATION_CHARGES.Text = GridView1.SelectedRow.Cells[9].Text;
            txt_GST.Text = GridView1.SelectedRow.Cells[10].Text;
            txt_TOTAL_AMOUNT.Text = GridView1.SelectedRow.Cells[11].Text;



            btn_new.Enabled = false;
            btn_save.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
        }

        public void SetDropdown1()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from DEPARTMENT";
            dr = cmd.ExecuteReader();
            DropDownList1.DataSource = dr;
            DropDownList1.DataValueField = "DEPT_ID";
            DropDownList1.DataTextField = "DEPT_NM";
            DropDownList1.DataBind();
            dr.Close();
        }
        public void SetDropdown2()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from IPD_MASTER";
            dr = cmd.ExecuteReader();
            DropDownList2.DataSource = dr;
            DropDownList2.DataValueField = "IPD_ID";
            DropDownList2.DataBind();
            dr.Close();
        }
        public void SetDropdown3()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from CASEPAPER";
            dr = cmd.ExecuteReader();
            DropDownList3.DataSource = dr;
            DropDownList3.DataValueField = "CASEPAPER_ID";
            DropDownList3.DataBind();
            dr.Close();
        }

        protected void txt_OPERATION_CHARGES_TextChanged(object sender, EventArgs e)
        {
            int nursing, bedcharg, testamt, opercharg, total, gstamt, gtotal;

            nursing = Convert.ToInt32(txt_NURSING_CHARGES.Text);
            bedcharg = Convert.ToInt32(txt_BED_CHARGES.Text);
            testamt = Convert.ToInt32(txt_TEST_AMOUNT.Text);
            opercharg = Convert.ToInt32(txt_OPERATION_CHARGES.Text);

            total = nursing + bedcharg + testamt + opercharg;

            gstamt = (total * 5) / 100;

            gtotal = total + gstamt;

            txt_GST.Text = Convert.ToString(gstamt);
            txt_TOTAL_AMOUNT.Text = Convert.ToString(gtotal);
        }

        }
    }
