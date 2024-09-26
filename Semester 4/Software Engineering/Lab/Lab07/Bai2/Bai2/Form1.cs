using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Printing;
using System.Xml.Linq;
namespace Bai2
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
            //s = "server = <ten sverver>; database = <ten db>; uid = ; pwd = ";

            cn = new SqlConnection(s);
            cn.Open();
            formload();
        }

        private void grd_Click(object sender, EventArgs e)
        {
            maSV.Text = grd.CurrentRow.Cells[0].Value.ToString();
            tenSV.Text = grd.CurrentRow.Cells[1].Value.ToString();
            NS.Text = grd.CurrentRow.Cells[2].Value.ToString();
            txtQQ.Text = grd.CurrentRow.Cells[3].Value.ToString();
            gt.Text = grd.CurrentRow.Cells[4].Value.ToString();
            maKhoa.Text = grd.CurrentRow.Cells[5].Value.ToString();

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
            string sql = "select * from Sinhvien";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        private void bADD_Click(object sender, EventArgs e)
        {
            enable(grp1, true);
            maSV.Clear();
            tenSV.Clear();
            NS.Value = DateTime.Now;
            txtQQ.Clear();
            txtDC.Clear();
            maKhoa.Clear();

            maSV.Enabled = false;
            tenSV.Focus();
            bSAVE.Enabled = true;
            dk = 1;
        }

        private void bCANCEL_Click(object sender, EventArgs e)
        {
            formload();
        }

        private void tenSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void maKhoa_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maKhoa.Text) && maKhoa.Text.Length >= 2)
            {
                
                string maSoSinhVien = GenerateStudentID(maKhoa.Text);
                maSV.Text = maSoSinhVien;
            }
        }

        private string GenerateStudentID(string makhoa)
        {
            string query = "SELECT MAX(Masv) FROM SinhVien";
            SqlCommand cmd = new SqlCommand(query, cn);

            try
            {
                string maxStudentID = cmd.ExecuteScalar()?.ToString();

                if (string.IsNullOrEmpty(maxStudentID))
                    return makhoa + "0001";

                int currentNumber = int.Parse(maxStudentID.Substring(2));
                string newStudentID = makhoa + (currentNumber + 1).ToString("D4");

                return newStudentID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
                return null;
            }
        }
    }
}
