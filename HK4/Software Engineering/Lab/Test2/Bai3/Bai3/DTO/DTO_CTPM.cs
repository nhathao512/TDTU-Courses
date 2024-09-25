using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO
{
    public class DTO_CTPM
    {
        private string maPhieuMuon;
        private string maSach;
        private DateTime ngayTra;

        public string MaPhieuMuon
        {
            get { return maPhieuMuon; }
            set { maPhieuMuon = value; }
        }

        public string MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }

        public DateTime NgayTra
        {
            get { return ngayTra; }
            set
            {
                ngayTra = value;
            }
        }

        public DTO_CTPM(string maPhieuMuon, string maSach, DateTime ngayTra)
        {
            MaPhieuMuon = maPhieuMuon;
            MaSach = maSach;
            NgayTra = ngayTra;
        }
    }

}
