using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab8
{
    public partial class Form1 : Form
    {
        BUS_Project l;
        int dk = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            l = new BUS_Project("", "", "", 0);
            grd.DataSource = l.selectQuery();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            dk = 1;
            txtPID.Text = l.getPID();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            string s = "";
            if (dk == 1)
            {
                l = new BUS_Project(txtPID.Text, txtName.Text, txtSup.Text, int.Parse(txtFun.Text));
                l.addQuery();
            }
            else if (dk == 2)
            {

            }
            grd.DataSource = l.selectQuery();
        }
    }
}
