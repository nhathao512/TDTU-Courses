namespace DTO
{
    public class DTO_MuonSach
    {
        private string maPhieuMuon;
        private string maDocGia;
        private DateTime ngayMuon;

        public string MaPhieuMuon
        {
            get { return maPhieuMuon; }
            set { maPhieuMuon = value; }
        }

        public string MaDocGia
        {
            get { return maDocGia; }
            set { maDocGia = value; }
        }

        public DateTime NgayMuon
        {
            get { return ngayMuon; }
            set
            {
                ngayMuon = value;
            }
        }

        public DTO_MuonSach(string maPhieuMuon, string maDocGia, DateTime ngayMuon)
        {
            MaPhieuMuon = maPhieuMuon;
            MaDocGia = maDocGia;
            NgayMuon = ngayMuon;
        }
    }
}