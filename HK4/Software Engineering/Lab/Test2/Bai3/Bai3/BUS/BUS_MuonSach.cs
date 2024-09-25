using DAL;
using System.Data;

namespace BUS
{
    public class BUS_MuonSach
    {
        private DAL_MuonSach dalMuonSach;

        public BUS_MuonSach(string maPhieuMuon, string maDocGia, DateTime ngayMuon)
        {
            dalMuonSach = new DAL_MuonSach(maPhieuMuon, maDocGia, ngayMuon);
        }

        public DataTable SelectAllMS()
        {
            return dalMuonSach.SelecttAllMS();
        }

        public void AddMuonSach()
        {
            dalMuonSach.addPM();
        }

        public string maPhieuMuonMoi()
        {
            return dalMuonSach.getMaPhieuMuonMax();
        }
    }
}