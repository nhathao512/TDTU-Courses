using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_MuonSach
    {
        private DTO_MuonSach muonSach;

        public DAL_MuonSach(string maPhieuMuon, string maDocGia, DateTime ngayMuon)
        {
            muonSach = new DTO_MuonSach(maPhieuMuon,maDocGia,ngayMuon);
        }

        public DataTable SelecttAllMS()
        {
            string query = "SELECT * FROM MuonSach";
            return Connection.selectQuery(query);
        }

        public void addPM()
        {
            string query = "INSERT INTO MuonSach VALUES ('" + muonSach.MaPhieuMuon + "', N'" + muonSach.MaDocGia + "', N'" + muonSach.NgayMuon.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            Connection.actionQuery(query);
        }

        public string getMaPhieuMuonMax()
        {
            string query = "SELECT MAX(CAST(SUBSTRING(MaPhieuMuon, LEN(MaPhieuMuon) - 2, 3) AS INT)) FROM MuonSach";

            using (DataTable dt = Connection.selectQuery(query))
            {
                if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                {
                    int maxNumber = Convert.ToInt32(dt.Rows[0][0]);

                    return (maxNumber + 1).ToString("D3");
                }
            }

            return "";
        }

    }

}