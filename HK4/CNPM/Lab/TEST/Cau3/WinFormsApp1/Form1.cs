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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Drawing.Printing;
using System.Xml.Linq;

namespace WinFormsApp1
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
            string s = "initial catalog = QLTV; data source = NHATHAO-512 ; integrated security = true";
            //s = "server = <ten sverver>; database = <ten db>; uid = ; pwd = ";

            cn = new SqlConnection(s);
            cn.Open();
            formload();
        }

        public void enable(GroupBox grp, bool b)
        {
            grp.Enabled = b;
        }
        public void showGRD()
        {
            string sql = "select * from CTPM";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }
        void formload()
        {
            showGRD();
            enable(grp1, true);
            button1.Enabled = true;
            button2.Enabled = true;
            dk = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select distinct MuonSach.* from CTPM, MuonSach where NgayMuon <= NgayTra";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }
    }
}
