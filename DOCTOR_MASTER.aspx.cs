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
    public partial class DOCTOR_MASTER : System.Web.UI.Page
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

            btn_new.CssClass = "btn btn-primary wow zoomIn";
            btn_save.CssClass = "btn btn-primary wow zoomIn";
            btn_update.CssClass = "btn btn-primary wow zoomIn";
            btn_delete.CssClass = "btn btn-primary wow zoomIn";

            if (!IsPostBack)
            {
                SetDropdown1();
                SetDropdown2();
            }
            
            
            
        }
        public void EnableText()
        {
            txt_DOCT_ID.Enabled = true;
            txt_DOCT_NAME.Enabled = true;
            txt_DOCT_LICENSE.Enabled = true;
            txt_DOCT_MOBILE.Enabled = true;
            txt_DOCT_ADDRESS.Enabled = true;
            txt_DOCT_GENDER.Enabled = true;
            txt_DOCT_SPECIALITY.Enabled = true;
            txt_DOCT_EMAIL.Enabled = true;
            txt_DOCT_PASS.Enabled = true;


        }

        public void DisableText()
        {
            txt_DOCT_ID.Enabled = false;
            txt_DOCT_NAME.Enabled = false;
            txt_DOCT_LICENSE.Enabled = false;
            txt_DOCT_MOBILE.Enabled = false;
            txt_DOCT_ADDRESS.Enabled = false;
            txt_DOCT_GENDER.Enabled = false;
            txt_DOCT_SPECIALITY.Enabled = false;
            txt_DOCT_EMAIL.Enabled = false;
            txt_DOCT_PASS.Enabled = false;



        }

        public void ClearText()
        {
            txt_DOCT_ID.Text = "";
            txt_DOCT_NAME.Text = "";
            txt_DOCT_LICENSE.Text ="";
            txt_DOCT_MOBILE.Text = "";
            txt_DOCT_ADDRESS.Text ="" ;
            txt_DOCT_GENDER.Text = "";
            txt_DOCT_SPECIALITY.Text = "";
            txt_DOCT_EMAIL.Text = "";
            txt_DOCT_PASS.Text = "";

        }

        public void SetGrid()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "Select * from DOCTOR_MASTER order by DOCT_ID";
            dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
        }

        public int GetNewId()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select Max(DOCT_ID) from DOCTOR_MASTER";
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
            btn_new.Enabled = false;
            btn_save.Enabled = true;
            txt_DOCT_ID.Text = Convert.ToString(GetNewId());
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into DOCTOR_MASTER values(" + txt_DOCT_ID.Text + ",'" + txt_DOCT_NAME.Text + "'," + DropDownList1.SelectedValue + "," + DropDownList2.SelectedValue + ",'" + txt_DOCT_LICENSE.Text + "','" + txt_DOCT_MOBILE.Text + "','" + txt_DOCT_ADDRESS.Text + "','" + txt_DOCT_GENDER.Text + "','" + txt_DOCT_SPECIALITY.Text + "','"+txt_DOCT_EMAIL.Text+"','"+txt_DOCT_PASS.Text+"')";
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
                cmd.CommandText = "update DOCTOR_MASTER set DOCT_NAME='" + txt_DOCT_NAME.Text + "',DEPT_ID=" + DropDownList1.SelectedValue + ",DEGREE_ID=" + DropDownList2.SelectedValue + ",DOCT_LICENSE='" + txt_DOCT_LICENSE.Text + "',DOCT_MOBILE='" + txt_DOCT_MOBILE.Text + "',DOCT_ADDRESS='" + txt_DOCT_ADDRESS.Text + "',DOCT_GENDER='" + txt_DOCT_GENDER.Text + "',DOCT_SPECIALITY='" + txt_DOCT_SPECIALITY.Text + "',DOCT_EMAIL='" + txt_DOCT_EMAIL.Text + "',DOCT_PASS='" + txt_DOCT_PASS.Text + "' where DOCT_ID=" + txt_DOCT_ID.Text;
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
            cmd.CommandText = "delete from DOCTOR_MASTER where DOCT_ID=" + txt_DOCT_ID.Text;
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
            cmd.CommandText = "select * from DEGREE_MASTER";
            dr = cmd.ExecuteReader();
            DropDownList2.DataSource = dr;
            DropDownList2.DataValueField = "DEGREE_ID";
            DropDownList2.DataTextField = "DEGREE_NM";
            DropDownList2.DataBind();
            dr.Close();
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            txt_DOCT_ID.Text = GridView1.SelectedRow.Cells[1].Text;
            txt_DOCT_NAME.Text = GridView1.SelectedRow.Cells[2].Text;
            
            txt_DOCT_LICENSE.Text = GridView1.SelectedRow.Cells[5].Text;
            txt_DOCT_MOBILE.Text = GridView1.SelectedRow.Cells[6].Text;
            txt_DOCT_ADDRESS.Text = GridView1.SelectedRow.Cells[7].Text;
            txt_DOCT_GENDER.Text = GridView1.SelectedRow.Cells[8].Text;
            txt_DOCT_SPECIALITY.Text = GridView1.SelectedRow.Cells[9].Text;
            txt_DOCT_EMAIL.Text = GridView1.SelectedRow.Cells[10].Text;
            txt_DOCT_PASS.Text = GridView1.SelectedRow.Cells[11].Text;



            btn_new.Enabled = false;
            btn_save.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
        }




    }
}