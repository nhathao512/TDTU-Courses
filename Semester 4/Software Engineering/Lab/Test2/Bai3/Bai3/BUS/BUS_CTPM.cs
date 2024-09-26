using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS;
using DAL;

namespace BUS
{
    public class BUS_CTPM
    {
        private DAL_CTPM dalCTPM;

        public BUS_CTPM(string maPhieuMuon, string maSach, DateTime ngayTra)
        {
            dalCTPM = new DAL_CTPM(maPhieuMuon, maSach, ngayTra);
        }

        public DataTable SellectAllCTPM()
        {
            return dalCTPM.selectAllCTPM();
        }

        public void AddCTPM()
        {
            dalCTPM.addCTPM();
        }
    }
}
