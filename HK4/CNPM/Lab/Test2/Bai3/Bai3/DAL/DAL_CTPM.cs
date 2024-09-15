using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_CTPM
    {
        private DTO_CTPM ctpm;

        public DAL_CTPM (string maPhieuMuon, string maSach, DateTime ngayTra)
        {
            ctpm = new DTO_CTPM (maPhieuMuon, maSach, ngayTra);
        }

        public DataTable selectAllCTPM()
        {
            string query = "SELECT * FROM ChiTietPhieuMuon";
            return Connection.selectQuery(query);
        }

        public void addCTPM()
        {
            string query = "INSERT INTO ChiTietPhieuMuon VALUES ('" + ctpm.MaPhieuMuon + "', N'" + ctpm.MaSach + "', N'" + ctpm.NgayTra.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            Connection.actionQuery(query);
        }

    }
}
