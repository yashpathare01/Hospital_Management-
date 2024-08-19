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
    public partial class IPD_MASTER : System.Web.UI.Page
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
        }

        public void EnableText()
        {
            txt_IPD_ID.Enabled = true;
            txt_IPD_DATE.Enabled = true;
            txt_WARD_NM.Enabled = true;
            txt_BED_NO.Enabled = true;
            txt_DIESE_NAME.Enabled = true;
            txt_TREATMENT.Enabled = true;
        }
        public void DisableText()
        {
            txt_IPD_ID.Enabled = false;
            txt_IPD_DATE.Enabled = false;
            txt_WARD_NM.Enabled = false;
            txt_BED_NO.Enabled = false;
            txt_DIESE_NAME.Enabled = false;
            txt_TREATMENT.Enabled = false;
        }
        public void ClearText()
        {
            txt_IPD_ID.Text = "";
            txt_IPD_DATE.Text = "";
            txt_WARD_NM.Text = "";
            txt_BED_NO.Text = "";
            txt_DIESE_NAME.Text = "";
            txt_TREATMENT.Text = "";

        }
        public void SetGrid()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from IPD_MASTER order by IPD_ID";
            dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
        }
        public int GetNewId()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select Max(IPD_ID) from IPD_MASTER";
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
            txt_IPD_ID.Text = Convert.ToString(GetNewId());
            btn_new.Enabled = false;
            btn_save.Enabled = true;
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into IPD_MASTER values(" + txt_IPD_ID.Text + "," + DropDownList1.SelectedValue + ",'" + txt_IPD_DATE.Text + "'," + DropDownList2.SelectedValue + ",'" + txt_WARD_NM.Text + "'," + txt_BED_NO.Text + ",'" + txt_DIESE_NAME.Text + "','" + txt_TREATMENT.Text + "')";
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
                cmd.CommandText = "update IPD_MASTER set DEPT_ID=" + DropDownList1.SelectedValue + ",IPD_DATE='" + txt_IPD_DATE.Text + "',CASEPAPER_ID=" + DropDownList2.SelectedValue + ",WARD_NM='" + txt_WARD_NM.Text + "',BED_NO=" + txt_BED_NO.Text + ",DIESE_NAME='" + txt_DIESE_NAME.Text + "',TREATMENT='" + txt_TREATMENT.Text + "' where IPD_ID=" + txt_IPD_ID.Text;
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
            cmd.CommandText = "delete from IPD_MASTER where IPD_ID=" + txt_IPD_ID.Text;
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
            cmd.CommandText = "select * from CASEPAPER";
            dr = cmd.ExecuteReader();
            DropDownList2.DataSource = dr;
            DropDownList2.DataValueField = "CASEPAPER_ID";
            DropDownList2.DataBind();
            dr.Close();
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            txt_IPD_ID.Text = GridView1.SelectedRow.Cells[1].Text;
            DropDownList1.Text = GridView1.SelectedRow.Cells[2].Text;
            txt_IPD_DATE.Text = GridView1.SelectedRow.Cells[3].Text;
            DropDownList2.Text = GridView1.SelectedRow.Cells[4].Text;
            txt_WARD_NM.Text = GridView1.SelectedRow.Cells[5].Text;
            txt_BED_NO.Text = GridView1.SelectedRow.Cells[6].Text;
            txt_DIESE_NAME.Text = GridView1.SelectedRow.Cells[7].Text;
            txt_TREATMENT.Text = GridView1.SelectedRow.Cells[8].Text;



            btn_new.Enabled = false;
            btn_save.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
        }

    }
}