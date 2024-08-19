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
    public partial class DEGREE_MASTER : System.Web.UI.Page
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
            txt_DEGREE_ID.Enabled = true;
            txt_DEGREE_NM.Enabled = true;
        }

        public void DisableText()
        {
            txt_DEGREE_ID.Enabled = false;
            txt_DEGREE_NM.Enabled = false;
        }

        public void clearText()
        {
            txt_DEGREE_ID.Text = "";
            txt_DEGREE_NM.Text = "";
        }

        public void SetGrid()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "Select*from DEGREE_MASTER order by DEGREE_ID";
            dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
            
        }

        public int GetNewId()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "Select max(DEGREE_ID)from DEGREE_MASTER";
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
            txt_DEGREE_ID.Text = Convert.ToString(GetNewId());
            
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into DEGREE_MASTER values("+txt_DEGREE_ID.Text+",'"+txt_DEGREE_NM.Text+"')";
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                    MessageBox.Show("Inserted");
                else
                    MessageBox.Show("Not Inserted");
            }
            if(flag==2)
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "update DEGREE_MASTER set DEGREE_NM='"+txt_DEGREE_NM.Text+"'where DEGREE_ID="+txt_DEGREE_ID.Text;
                int x = cmd.ExecuteNonQuery();

                if (x > 0)
                    MessageBox.Show(" Updated");
                else
                    MessageBox.Show(" Not Updated");
            }

                SetGrid();
                clearText();
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
            cmd.CommandText = "delete from DEGREE_MASTER where DEGREE_ID="+txt_DEGREE_ID.Text;
            int x = cmd.ExecuteNonQuery();

            if (x > 0)
                MessageBox.Show(" Deleted");
            else
                MessageBox.Show(" Not Deleted");
            SetGrid();
            clearText();
            DisableText();
            btn_new.Enabled = true;
            btn_save.Enabled = false;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_DEGREE_ID.Text = GridView1.SelectedRow.Cells[1].Text;
            txt_DEGREE_NM.Text = GridView1.SelectedRow.Cells[2].Text;
            btn_new.Enabled = false;
            btn_save.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;

        }
    }
}