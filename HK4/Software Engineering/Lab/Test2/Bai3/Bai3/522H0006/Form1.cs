using BUS;

namespace _522H0006
{
    public partial class Form1 : Form
    {
        BUS_MuonSach muonsach;
        BUS_CTPM ctpm;
        public Form1()
        {
            InitializeComponent();
        }

        public void formload()
        {
            grp4.Enabled = false;
            BMUON.Enabled = false;            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formload();
        }

        private void grd2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPM.Text = grd2.CurrentRow.Cells[0].Value.ToString();
            grp4.Enabled = false;
            txtMaPM.Enabled = false;
            BMUON.Enabled = false;
        }

        private void CHITIET_Click(object sender, EventArgs e)
        {
            grp4.Enabled = false;
            DateTime a = ngayMuon.Value;
            ctpm = new BUS_CTPM("", "", a);
            grd2.DataSource = ctpm.SellectAllCTPM();
        }

        private void SHOW_Click(object sender, EventArgs e)
        {
            grp4.Enabled = false;
            DateTime a = ngayMuon.Value;
            muonsach = new BUS_MuonSach("", "", a);
            grd2.DataSource = muonsach.SelectAllMS();
        }

        private void BMUONMOI_Click(object sender, EventArgs e)
        {
            grp4.Enabled = true;
            BMUON.Enabled = true;
            txtMaPM.Clear();
            txtMaPM.Enabled = false;
        }

        private void BMUON_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maSachMuon.Text) || string.IsNullOrWhiteSpace(maDGMuon.Text) ||
                string.IsNullOrWhiteSpace(ngayMuon.Text) || string.IsNullOrWhiteSpace(ngayTra.Text))
            {
                MessageBox.Show("Please enter enought information!");
                return;
            }

            if (ngayTra.Value < ngayMuon.Value)
            {
                MessageBox.Show("The return date must be greater than or equal to the loan date!");
                return;
            }

            muonsach = new BUS_MuonSach(txtMaPM.Text, maDGMuon.Text, ngayMuon.Value);
            muonsach.AddMuonSach();
            ctpm = new BUS_CTPM(txtMaPM.Text, maSachMuon.Text, ngayTra.Value);
            ctpm.AddCTPM();
            MessageBox.Show("Done");
            grd2.DataSource = muonsach.SelectAllMS();
        }

        private string newMaMuon(string day)
        {
            string maMuonMoi = "";

            muonsach = new BUS_MuonSach("", "", DateTime.Now);
            string maPhieuMax = muonsach.maPhieuMuonMoi(); 

            if (!string.IsNullOrEmpty(maPhieuMax))
            {

                maMuonMoi = day + "-" + maPhieuMax;
            }
            else
            {
                maMuonMoi = day + "-001";
            }

            return maMuonMoi;
        }

        private void ngayMuon_Leave(object sender, EventArgs e)
        {
            DateTime a = ngayMuon.Value;
            string aAsString = a.ToString("yyyyMMdd");
            string maMuonMoi = newMaMuon(aAsString);
            txtMaPM.Text = maMuonMoi;
        }
    }
}