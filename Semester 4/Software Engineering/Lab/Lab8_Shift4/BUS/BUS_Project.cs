using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Project
    {
        DAL_Project p;

        public BUS_Project(string pid, string pname, string sup, int fun)
        {
            p = new DAL_Project(pid, pname, sup, fun);
        }

        public void addQuery()
        {
            p.addQuery();
        }

        public void updateQuere()
        {
            p.updateQuery();
        }

        public void deleteQuery()
        {
            p.deleteQuery();
        }

        public DataTable selectQuery()
        {
            return p.selectQuery();
        }

        public string getPID()
        {
            DataTable tb = p.getProjectDesc();
            if (tb.Rows.Count > 0)
            {
                string res = tb.Rows[0][0].ToString();
                int stt = int.Parse(res.Substring(2, 3)) + 1;
                if (stt < 10)
                    res = "PO00" + stt.ToString();
                else if (stt < 100)
                    res = "PO0" + stt.ToString();
                else
                    res = "PO" + stt.ToString();
                return res;
            }
            else
            {
                return "PO001";
            }
        }
    }
}
