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

namespace Lab3
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;

        public Form1()
        {
            InitializeComponent();
        }
        void showHT()
        {
            cbHT.Items.Add("Sài Gòn");
            cbHT.Items.Add("Tiền Giang");
            cbHT.Items.Add("Quảng Ngãi");
            cbHT.Items.Add("Kiên Giang");

        }
        void showCNDT()
        {
            cndt.Items.Add("Nguyễn Thễ Hữu");
            cndt.Items.Add("Trần Trung Hiếu");
            cndt.Items.Add("Nguyễn Công Tâm");
            cndt.Items.Add("Đặng Đức Trung");
            cndt.Items.Add("Đặng Đức Trung");
            cndt.Items.Add("Trịnh Thanh Duy");
        }

        void showStu()
        {
            stu.Items.Add("SV01");
            stu.Items.Add("SV02");
            stu.Items.Add("SV03");
            stu.Items.Add("SV04");
            stu.Items.Add("SV05");
        }

        void showDT()
        {
            dt.Items.Add("DT01");
            dt.Items.Add("DT02");
            dt.Items.Add("DT03");
            dt.Items.Add("DT04");
            dt.Items.Add("DT05");

        }


        void showHT1()
        {
            string sql = "select distinct Hometown from student";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            cbHT.DataSource = tb;
            cbHT.DisplayMember = "Hometown";
            cbHT.ValueMember = "Hometown";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from student where Hometown like N'" + cbHT.Text + "'";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "initial catalog = InternManage1; data source = NHATHAO-512; integrated security = true";
            cn = new SqlConnection(sql);
            cn.Open();
            //showHT1();
            showHT();
            showCNDT();
            showStu();
            showDT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from student";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (grd.Rows.Count - 1 > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(grd.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            //add column
                            foreach (DataGridViewColumn column in grd.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            //add value
                            for (int i = 0; i < grd.Rows.Count - 1; ++i)
                            {
                                for (int j = 0; j < grd.Columns.Count; ++j)
                                {
                                    // string s = grd.Rows[i].Cells[j].Value.ToString();
                                    pdfTable.AddCell(grd.Rows[i].Cells[j].Value.ToString());

                                }
                            }

                            /*
                            foreach (DataGridViewRow row in grd.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }
                            */
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                            // Application.Run(sfd.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string sql = "select * from Project where Funding < 10000000";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "select * from Project where Funding <= 100000000";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "select * from Project where Funding > 100000000";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string sql = "select * from Project where Supervisor like N'" + cndt.Text + "'";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql = "select * from Project";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (grd.Rows.Count - 1 > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(grd.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            //add column
                            foreach (DataGridViewColumn column in grd.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            //add value
                            for (int i = 0; i < grd.Rows.Count - 1; ++i)
                            {
                                for (int j = 0; j < grd.Columns.Count; ++j)
                                {
                                    // string s = grd.Rows[i].Cells[j].Value.ToString();
                                    pdfTable.AddCell(grd.Rows[i].Cells[j].Value.ToString());

                                }
                            }

                            /*
                            foreach (DataGridViewRow row in grd.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }
                            */
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                            // Application.Run(sfd.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        /*private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            string sql = "select * from student where StudentID like '" + stu.Text + "'";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }*/
        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
   
            string sql = "SELECT s.*, sp.Distance FROM student s INNER JOIN Student_Project sp ON s.StudentID = sp.StudentID WHERE s.StudentID LIKE '" + stu.Text + "'";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from Project where ProjectID like '" + dt.Text + "'";
            
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        


        private void button7_Click(object sender, EventArgs e)
        {
            string sql = "select * from student";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string sql = "select * from Student_Project";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }
    }
}
