using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Student
    {
        DTO_Student student;

        public DAL_Student(string StudentID, string FullName, string Hometown, DateTime DOB, decimal GPA)
        {
            student = new DTO_Student(StudentID, FullName, Hometown, DOB, GPA);
        }

        public void addQuery()
        {
            string query = "insert into student values ('" + student._StudentID + "', N'" + student._FullName + "', N'" + student._Hometown + "', " + student._DOB + "', "  + student._GPA + ")";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "update student set FullName = N'" + student._FullName + "', Hometown = N'" + student._Hometown + "', DOB = " + student._DOB + "' where PID = '" + student._GPA + "'";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "delete from student where StudentID = '" + student._StudentID + "'";
            Connection.actionQuery(query);
        }
        public DataTable selectQuery()
        {
            string s = "select * from student";
            return Connection.selectQuery(s);
        }


        //get Datatable desc order
        public DataTable getProjectDesc()
        {
            string s = "select top 1 StudentID from student order by StudentID desc";
            return Connection.selectQuery(s);
        }
    }
}
