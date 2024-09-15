using System.Data;
using System.Data.SqlClient;

namespace Lab2._2
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

        public void showGRD()
        {
            string sql = "select * from Project";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        public void enable(bool b1, bool b2)
        {
            bDEL.Enabled = b1;
            bEDIT.Enabled = b1;
            bSAVE.Enabled = b1;
            msDeTai.ReadOnly = b2;
            tenDT.ReadOnly = b2;
            CNDT.ReadOnly = b2;
            kinhphi.ReadOnly = b2;
        }

        void formload()
        {
            showGRD();
            enable(false, true);
            bDEL.Enabled = false;
            bEDIT.Enabled = false;
            bSAVE.Enabled = false;
            dk = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string s = "initial catalog = InternManage; data source = NHATHAO-512; integrated security = true";
            //s = "server = <ten sverver>; database = <ten db>; uid = ; pwd = ";

            cn = new SqlConnection(s);
            cn.Open();
            formload();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            enable(false, true);
            bSAVE.Enabled = true;
            tenDT.Clear();
            kinhphi.Clear();
            msDeTai.Clear();
            dk = 1;
        }

        void showGrd()
        {
            string s = "select * from project";
            data = new SqlDataAdapter(s, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        void showText()
        {
            msDeTai.Text = grd.CurrentRow.Cells[0].Value.ToString();
            tenDT.Text = grd.CurrentRow.Cells[1].Value.ToString();
            CNDT.Text = grd.CurrentRow.Cells[2].Value.ToString();
            kinhphi.Text = grd.CurrentRow.Cells[3].Value.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            formload();
        }
        /*
        private void bSAVE_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (dk == 1)
            {
                sql = "select * from Project where ProjectID = '" + msDeTai.Text + "'";
                data = new SqlDataAdapter(sql, cn);
                tb = new DataTable();
                data.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Project exists");
                    msDeTai.Focus();
                    return;
                }

                sql = "insert into project values ('" + msDeTai.Text + "', N'" + tenDT.Text + "', N'" + CNDT.Text + "', '" + kinhphi.Text + "')";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
            }
            else
            {

                sql = "update project set ProjectName = N'" + tenDT.Text + "', Supervisor = N'" + CNDT.Text + "', Funding = '" + kinhphi.Text + " where ProjectID = '" + msDeTai.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
            }
            formload();
        }*/

        private void bSAVE_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (dk == 1)//Add
            {
                //check primary key
                sql = "select * from Project where ProjectID = '" + msDeTai.Text + "'";
                data = new SqlDataAdapter(sql, cn);
                tb = new DataTable();
                data.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Student exists");
                    msDeTai.Focus();
                    return;
                }
                //Insert into
                sql = "insert into Project values ('" + msDeTai.Text + "', N'" + tenDT.Text + "', N'" + cnDT.Text + "', '" + "', '" + kinhPhi.Text + "')";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
            }
            else //dk =2
            {
                //Update
                sql = "update Project set ProjectName = N'" + tenDT.Text + "', Supervisor = N'" + cnDT.Text + "', Funding = " + kinhPhi.Text + " where ProjectID = '" + msDeTai.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
            }
            formload();
        }

        private void bEDIT_Click(object sender, EventArgs e)
        {
            enable(false, true);
            msDeTai.Enabled = false;
            tenDT.Focus();
            bSAVE.Enabled = true;

            dk = 2;
        }

        private void bDEL_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Delete?", "Delete", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {

                string s = "Delete from project where ProjectID ='" + msDeTai.Text + "'";
                cm = new SqlCommand(s, cn);
                cm.ExecuteNonQuery();
                showGrd();
                showText();
            }
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            msDeTai.Text = grd.CurrentRow.Cells[0].Value.ToString();
            tenDT.Text = grd.CurrentRow.Cells[1].Value.ToString();
            CNDT.Text = grd.CurrentRow.Cells[2].Value.ToString();
            kinhphi.Text = grd.CurrentRow.Cells[3].Value.ToString();

            bDEL.Enabled = true;
            bEDIT.Enabled = true;
            bSAVE.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void grd_Click(object sender, EventArgs e)
        {
            msDeTai.Text = grd.CurrentRow.Cells[0].Value.ToString();
            tenDT.Text = grd.CurrentRow.Cells[1].Value.ToString();
            CNDT.Text = grd.CurrentRow.Cells[2].Value.ToString();
            kinhphi.Text = grd.CurrentRow.Cells[3].Value.ToString();

            bDEL.Enabled = true;
            bEDIT.Enabled = true;
            bSAVE.Enabled = true;
        }
    }
}
