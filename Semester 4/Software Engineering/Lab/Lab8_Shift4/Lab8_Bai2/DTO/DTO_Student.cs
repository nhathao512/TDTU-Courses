using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Student
    {
        private string StudentID, FullName, Hometown;
        private DateTime DOB;
        private decimal GPA;

        public string _StudentID
        {
            get
            {
                return StudentID;
            }
            set
            {
                StudentID = value;
            }
        }

        public string _FullName
        {
            get
            {
                return FullName;
            }
            set
            {
                FullName = value;
            }
        }

        public string _Hometown
        {
            get
            {
                return Hometown;
            }
            set
            {
                Hometown = value;
            }
        }

        public DateTime _DOB
        {
            get
            {
                return DOB;
            }
            set
            {
                DOB = value;
            }
        }

        private decimal _GPA
        {
            get
            {
                return GPA;
            }
            set
            {
                GPA = value;
            }
        }

        public DTO_Student(string StudentID, string FullName, string Hometown, DateTime DOB, decimal GPA)
        {
            this.StudentID = StudentID;
            this.FullName = FullName;
            this.Hometown = Hometown;
            this.DOB = DOB;
            this.GPA = GPA;
        }
    }
}
