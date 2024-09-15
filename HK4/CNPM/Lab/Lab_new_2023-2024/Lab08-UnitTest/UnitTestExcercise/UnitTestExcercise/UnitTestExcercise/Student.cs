using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class Student
    {
        public String ID { set; get; }
        public String Name { set; get; }
        public int Age { set; get; }

        public double Score { set; get; }

        public Student(String id, String name, int age, double score)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.Score = score;
        }

    }
}
