using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Student
    {
        DTO_Student p;

        public DAL_Student(string txtSID, string txtPID, string IP, int distance, decimal result )
        {
            p = new DTO_Student(txtSID, txtPID, IP, distance, result);
        }

        public DataTable selectQuery()
        {
            string s = "select * from Student_Project";
            return Connection.selectQuery(s);
        }


        //get Datatable desc order
        
        public DataTable getProjectDesc()
        {
            string s = "select top 1 ProjectID from Student_Project order by ProjectID desc";
            return Connection.selectQuery(s);
        }
    }
}
