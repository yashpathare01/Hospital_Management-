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
    public partial class OPD_MASTER : System.Web.UI.Page
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
            }

            btn_new.CssClass = "btn btn-primary wow zoomIn";
            btn_save.CssClass = "btn btn-primary wow zoomIn";
            btn_update.CssClass = "btn btn-primary wow zoomIn";
            btn_delete.CssClass = "btn btn-primary wow zoomIn";

            txt_OPD_DATE.Text = System.DateTime.Now.ToString();
        }


        public void EnableText()
        {
            txt_OPD_ID.Enabled = true;
            txt_OPD_DATE.Enabled = false;
            txt_CHECKUP_FEES.Enabled = false;
            txt_PROBLEM.Enabled = true;
            txt_PRESC_MEDICINE.Enabled = true;
        }
        public void DisableText()
        {
            txt_OPD_ID.Enabled = false;
            txt_OPD_DATE.Enabled = false;
            txt_CHECKUP_FEES.Enabled = false;
            txt_PROBLEM.Enabled = false;
            txt_PRESC_MEDICINE.Enabled = false;
        }
        public void ClearText()
        {
            txt_OPD_ID.Text = "";
            txt_OPD_DATE.Text = "";
            txt_CHECKUP_FEES.Text = "";
            txt_PROBLEM.Text = "";
            txt_PRESC_MEDICINE.Text = "";

        }
        public void SetGrid()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from OPD_MASTER order by OPD_ID";
            dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
        }
        public int GetNewId()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select Max(OPD_ID) from OPD_MASTER";
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
            txt_OPD_ID.Text = Convert.ToString(GetNewId());
            btn_new.Enabled = false;
            btn_save.Enabled = true;
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;

                DateTime dt = Convert.ToDateTime(txt_OPD_DATE.Text);
                cmd.CommandText = "insert into OPD_MASTER values(" + txt_OPD_ID.Text + "," + DropDownList1.SelectedValue + "," + DropDownList2.SelectedValue + ",'" + (dt.ToString("MM-dd-yyyy")) + "'," + txt_CHECKUP_FEES.Text + ",'" + txt_PROBLEM.Text + "','" + txt_PRESC_MEDICINE.Text + "')";
                int x = cmd.ExecuteNonQuery();

                if (x > 0)
                {
                    MessageBox.Show("Inserted");

                    Session["opdid"] = txt_OPD_ID.Text;
                    Response.Redirect("~/casepaperreceipt.aspx");

                }
                else
                    MessageBox.Show("Not Inserted");
            }
            if (flag == 2)
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;

                DateTime dt = Convert.ToDateTime(txt_OPD_DATE.Text);
                cmd.CommandText = "update OPD_MASTER set DEPT_ID=" + DropDownList1.SelectedValue + ",CASEPAPER_ID=" + DropDownList2.SelectedValue + ",OPD_DATE='" + (dt.ToString("MM-dd-yyyy")) + "',CHECKUP_FEES=" + txt_CHECKUP_FEES.Text + ",PROBLEM='" + txt_PROBLEM.Text + "',PRESC_MEDICINE='" + txt_PRESC_MEDICINE.Text + "' where OPD_ID=" + txt_OPD_ID.Text;
                int x = cmd.ExecuteNonQuery();

                if (x > 0)
                {
                    MessageBox.Show("Updated");

                    Session["opdid"] = txt_OPD_ID.Text;
                    Response.Redirect("~/casepaperreceipt.aspx");
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
            cmd.CommandText = "delete from OPD_MASTER where OPD_ID=" + txt_OPD_ID.Text;
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
            txt_OPD_ID.Text = GridView1.SelectedRow.Cells[1].Text;
            DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[2].Text;
            DropDownList2.SelectedValue = GridView1.SelectedRow.Cells[3].Text;
            txt_OPD_DATE.Text = GridView1.SelectedRow.Cells[4].Text;
            txt_CHECKUP_FEES.Text = GridView1.SelectedRow.Cells[5].Text;
            txt_PROBLEM.Text = GridView1.SelectedRow.Cells[6].Text;
            txt_PRESC_MEDICINE.Text = GridView1.SelectedRow.Cells[7].Text;



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
            cmd.CommandText = "select * from CASEPAPER";
            dr = cmd.ExecuteReader();
            DropDownList2.DataSource = dr;
            DropDownList2.DataValueField = "CASEPAPER_ID";
            DropDownList2.DataBind();
            dr.Close();
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from CASEPAPER where casepaper_id="+DropDownList2.SelectedValue;
            dr = cmd.ExecuteReader();
            DateTime casepaperdate=new DateTime();
            DateTime opddate = DateTime.Now;
            int difference;
            while (dr.Read())
            {
                casepaperdate =Convert.ToDateTime( dr[1]);
            }
            dr.Close();

            difference = opddate.Day - casepaperdate.Day;
          //  MessageBox.Show("Diff=" + difference);

            if (difference == 0)
                txt_CHECKUP_FEES.Text = "500";
            else
                if(difference<31)
                    txt_CHECKUP_FEES.Text = "100";
                else
                    txt_CHECKUP_FEES.Text = "500";


        }

    }
}