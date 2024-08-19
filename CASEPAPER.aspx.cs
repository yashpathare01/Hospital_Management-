using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hospitalmanagement
{
    public partial class CASEPAPER : System.Web.UI.Page
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

            txt_CASEPAPER_FEES.Text = Convert.ToString("500");
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
        }

        public void EnableText()
        {
            txt_CASEPAPER_ID.Enabled = true;
            txt_CASE_DATE.Enabled = true;
            txt_CASEPAPER_FEES.Enabled = false;
        }
        public void DisableText()
        {
            txt_CASEPAPER_ID.Enabled = false;
            txt_CASE_DATE.Enabled = false;
            txt_CASEPAPER_FEES.Enabled = false;
        }
        public void ClearText()
        {
            txt_CASEPAPER_ID.Text = "";
            txt_CASE_DATE.Text = "";
            //txt_CASEPAPER_FEES.Text = "";

        }
        public void SetGrid()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from CASEPAPER order by CASEPAPER_ID";
            dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
        }
        public int GetNewId()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select Max(CASEPAPER_ID) from CASEPAPER";
            object x = cmd.ExecuteScalar();

            if (Convert.ToString(x) == "")
                return 101;
            else
                return (Convert.ToInt32(x) + 1);
        }

        protected void btn_new_Click(object sender, EventArgs e)
        {
            flag = 1;
            EnableText();
            txt_CASEPAPER_ID.Text = Convert.ToString(GetNewId());
            btn_new.Enabled = false;
            btn_save.Enabled = true;
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into CASEPAPER values(" + txt_CASEPAPER_ID.Text + ",'" + txt_CASE_DATE.Text + "'," + DropDownList1.SelectedValue + "," + DropDownList2.SelectedValue + ","+DropDownList3.SelectedValue+"," + txt_CASEPAPER_FEES.Text + ")";
                int x = cmd.ExecuteNonQuery();

                if (x > 0)
                    MessageBox.Show("Inserted");
                else
                    MessageBox.Show("Not Inserted");
            }

            if (flag == 2)
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "update CASEPAPER set CASE_DATE='" + txt_CASE_DATE.Text + "',DEPT_ID=" + DropDownList1.SelectedValue + ",PAT_ID=" + DropDownList2.SelectedValue + ",DOCT_ID=" + DropDownList3.SelectedValue + ",CASEPAPER_FEES=" + txt_CASEPAPER_FEES.Text + " where CASEPAPER_ID=" + txt_CASEPAPER_ID.Text;
                int x = cmd.ExecuteNonQuery();

                if (x > 0)
                    MessageBox.Show("Updated");
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
            cmd.CommandText = "delete from CASEPAPER where CASEPAPER_ID=" + txt_CASEPAPER_ID.Text;
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
            cmd.CommandText = "select * from PATIENT_MASTER";
            dr = cmd.ExecuteReader();
            DropDownList2.DataSource = dr;
            DropDownList2.DataValueField = "PAT_ID";
            DropDownList2.DataTextField = "PAT_NM";
            DropDownList2.DataBind();
            dr.Close();
        }

        public void SetDropdown3()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from DOCTOR_MASTER";
            dr = cmd.ExecuteReader();
            DropDownList3.DataSource = dr;
            DropDownList3.DataValueField = "DOCT_ID";
            DropDownList3.DataTextField = "DOCT_NAME";
            DropDownList3.DataBind();
            dr.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_CASEPAPER_ID.Text = GridView1.SelectedRow.Cells[1].Text;
            txt_CASE_DATE.Text = GridView1.SelectedRow.Cells[2].Text;
            DropDownList1.Text = GridView1.SelectedRow.Cells[3].Text;
            DropDownList3.Text = GridView1.SelectedRow.Cells[4].Text;
            DropDownList2.Text = GridView1.SelectedRow.Cells[5].Text;
            txt_CASEPAPER_FEES.Text = GridView1.SelectedRow.Cells[6].Text;



            btn_new.Enabled = false;
            btn_save.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
        }

    }
}