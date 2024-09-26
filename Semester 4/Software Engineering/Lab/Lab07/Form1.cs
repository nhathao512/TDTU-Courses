using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Printing;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;

namespace Lab07
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        int dk = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string s = "initial catalog = CourseRegis; data source = NHATHAO-512; integrated security = true";

            cn = new SqlConnection(s);
            cn.Open();
            formload();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMK.Text = grd.CurrentRow.Cells[0].Value.ToString();
            txtTK.Text = grd.CurrentRow.Cells[1].Value.ToString();
            txtDD.Text = grd.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = grd.CurrentRow.Cells[3].Value.ToString();

            bDEL.Enabled = true;
            bEDIT.Enabled = true;
        }

        void formload()
        {
            showGRD();
            enable(grp1, false);
            bDEL.Enabled = false;
            bEDIT.Enabled = false;
            bSAVE.Enabled = false;
            dk = 0;
        }

        public void enable(GroupBox grp, bool b)
        {
            grp.Enabled = b;
        }

        public void showGRD()
        {
            string sql = "select * from Khoa";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        private void bADD_Click(object sender, EventArgs e)
        {
            enable(grp1, true);
            txtMK.Clear();
            txtTK.Clear();
            txtDD.Clear();
            txtSDT.Clear();

            txtMK.Enabled = false;
            txtTK.Focus();
            bSAVE.Enabled = true;
            dk = 1;
        }

        private void bDEL_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Delete?", "Delete", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {

                string s = "Delete from Khoa where Makhoa ='" + txtMK.Text + "'";
                cm = new SqlCommand(s, cn);
                cm.ExecuteNonQuery();
                showGRD();

            }
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void bSAVE_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (dk == 1)//Add
            {
                //check primary key
                sql = "select * from Khoa where Makhoa = '" + txtMK.Text + "'";
                data = new SqlDataAdapter(sql, cn);
                tb = new DataTable();
                data.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Khoa exists");
                    txtMK.Focus();
                    return;
                }
                //Insert into
                sql = "insert into Khoa values ('" + txtMK.Text + "', N'" + txtTK.Text + "', N'" + txtDD.Text + "', '" + "', '" + txtSDT.Text + "')";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
            }
            else //dk =2
            {
                //Update
                sql = "update Khoa set Tenkhoa = N'" + txtMK.Text + "', Tenkhoa = N'" + txtTK.Text + "', Diadiem = " + txtDD.Text + "Dienthoai = '" + txtSDT.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
            }
            formload();
        }

        private void bEDIT_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            string[] t = txtTK.Text.Split(' ');
            string res = "";
            for (int i = 0; i < t.Length; ++i)
                res = res + t[i].Substring(0, 1);

            txtMK.Text = res;
        }
    }
}
