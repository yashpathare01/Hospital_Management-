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
    public partial class PATIENT_MASTER : System.Web.UI.Page
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
        }

        public void EnableText()
        {
            txt_PAT_ID.Enabled = true;
            txt_PAT_NM.Enabled = true;
            txt_PAT_ADDR.Enabled = true;
            txt_PAT_CITY.Enabled = true;
            txt_PAT_MOBILE.Enabled = true;
            txt_PAT_PINCODE.Enabled = true;
            txt_BLOOD_GRP.Enabled = true;
            txt_GENDER.Enabled = true;
            txt_AGE.Enabled = true;
            txt_PREV_DIESES.Enabled = true;
        }
        public void DisableText()
        {
            txt_PAT_ID.Enabled = false;
            txt_PAT_NM.Enabled = false;
            txt_PAT_ADDR.Enabled = false;
            txt_PAT_CITY.Enabled = false;
            txt_PAT_MOBILE.Enabled = false;
            txt_PAT_PINCODE.Enabled = false;
            txt_BLOOD_GRP.Enabled = false;
            txt_GENDER.Enabled = false;
            txt_AGE.Enabled = false;
            txt_PREV_DIESES.Enabled = false;
        }
        public void ClearText()
        {
            txt_PAT_ID.Text = "";
            txt_PAT_NM.Text = "";
            txt_PAT_ADDR.Text = "";
            txt_PAT_CITY.Text = "";
            txt_PAT_MOBILE.Text = "";
            txt_PAT_PINCODE.Text = "";
            txt_BLOOD_GRP.Text = "";
            txt_GENDER.Text = "";
            txt_AGE.Text = "";
            txt_PREV_DIESES.Text = "";
        }
        public void SetGrid()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from PATIENT_MASTER order by PAT_ID";
            dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
        }
        public int GetNewId()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select Max(PAT_ID) from PATIENT_MASTER";
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
            txt_PAT_ID.Text = Convert.ToString(GetNewId());
            btn_new.Enabled = false;
            btn_save.Enabled = true;
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into PATIENT_MASTER values(" + txt_PAT_ID.Text + ",'" + txt_PAT_NM.Text + "','" + txt_PAT_ADDR.Text + "','" + txt_PAT_CITY.Text + "','" + txt_PAT_MOBILE.Text + "','" + txt_PAT_PINCODE.Text + "','" + txt_BLOOD_GRP.Text + "','" + txt_GENDER.Text + "'," + txt_AGE.Text + ",'" + txt_PREV_DIESES.Text + "')";
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
                cmd.CommandText = "update PATIENT_MASTER set PAT_NM='" + txt_PAT_NM.Text + "',PAT_ADDR='" + txt_PAT_ADDR.Text + "',PAT_CITY='" + txt_PAT_CITY.Text + "',PAT_MOBILE='" + txt_PAT_MOBILE.Text + "',PAT_PINCODE='" + txt_PAT_PINCODE.Text + "',BLOOD_GRP='" + txt_BLOOD_GRP.Text + "',GENDER='" + txt_GENDER.Text + "',AGE=" + txt_AGE.Text + ",PREV_DIESES='" + txt_PREV_DIESES.Text + "' where PAT_ID=" + txt_PAT_ID.Text;
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
            cmd.CommandText = "delete from PATIENT_MASTER where PAT_ID=" + txt_PAT_ID.Text;
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
            txt_PAT_ID.Text = GridView1.SelectedRow.Cells[1].Text;
            txt_PAT_NM.Text = GridView1.SelectedRow.Cells[2].Text;
            txt_PAT_ADDR.Text = GridView1.SelectedRow.Cells[3].Text;
            txt_PAT_CITY.Text = GridView1.SelectedRow.Cells[4].Text;
            txt_PAT_MOBILE.Text = GridView1.SelectedRow.Cells[5].Text;
            txt_PAT_PINCODE.Text = GridView1.SelectedRow.Cells[6].Text;
            txt_BLOOD_GRP.Text = GridView1.SelectedRow.Cells[7].Text;
            txt_GENDER.Text = GridView1.SelectedRow.Cells[8].Text;
            txt_AGE.Text = GridView1.SelectedRow.Cells[9].Text;
            txt_PREV_DIESES.Text = GridView1.SelectedRow.Cells[10].Text;



            btn_new.Enabled = false;
            btn_save.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
        }
    }
}