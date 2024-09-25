using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Project
    {
        DTO_Project p;

        public DAL_Project(string pid, string pname, string sup, int fun)
        {
            p = new DTO_Project(pid, pname, sup, fun);
        }

        public void addQuery()
        {
            string query = "insert into Project values ('" + p._PID + "', N'" + p._PNAME + "', N'" + p._SUPERVISOR + "', " + p._FUNDING + ")";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "update Project set PName = N'" + p._PNAME + "', Supervisor = N'" + p._SUPERVISOR + "', Funding = " + p._FUNDING + "' where PID = '" + p._PID + "'";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "delete from Project where PID = '" + p._PID + "'";
            Connection.actionQuery(query);
        }
        public DataTable selectQuery()
        {
            string s = "select * from Project";
            return Connection.selectQuery(s);
        }


        //get Datatable desc order
        public DataTable getProjectDesc()
        {
            string s = "select top 1 PID from Project order by PID desc";
            return Connection.selectQuery(s);
        }
    }
}
