using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class StudentManager
    {
        private List<Student> list;

        public StudentManager()
        {
            list = new List<Student>();
        }

        /* - Thêm một sinh viên vào danh sách
         * - Chỉ thêm khi sinh viên có mã số đó chưa tồn tại trong danh sách
         * - Nếu tham số nhận vào là null thì ném ra ngoại lệ NullReferenceException
         * - Nếu thêm thành công thì số lượng sinh viên tăng 1 và phương thức trả về true
         * - Nếu thêm không thành công thì phương thức trả về false
         * 
         * */
        public bool addStudent(Student s)
        {
            foreach (Student x in list)
            {
                if (x.ID == s.ID)
                {
                    return true;
                }
            }

            list.Add(s);
            return true;
        }

        /* - Lấy sinh viên tại vị trí position 
         * - Nếu position nằm ngoài phạm vi của mảng (0 -> n-1) thì ném ra ngoại lệ ArrayIndexException với message là:
         * 'Index {i} is not available in this array', trong đó {i} là giá trị của biến position và ArrayIndexException là ngoại lệ do người dùng định nghĩa
         * 
         */
        public Student getStudentAt(int position)
        {
            if (position >= list.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            return list[position];
        }

        /* - Tìm một sinh viên theo tuổi
         * - Trả về sinh viên đầu tiên tìm được
         * - Nếu không tìm được thì trả về null 
         */
        public Student findStudentByAge(int age)
        {
            Student sv = null;

            foreach (Student x in list)
            {
                if (x.Age == age)
                {
                    sv = x;
                    return sv;
                }
            }

            return sv;
        }

        /* - Tính điểm trung bình điểm của toàn bộ sinh viên trong danh sách
         * - Nếu chưa có sinh viên trong danh sách thì ném ra ngoại lệ Exception
         * - Ngoại lệ có message là "Student list is empty"
         * 
         */
        public double getAverageScore()
        {
            if (list.Count == 0)
            {
                throw new Exception("No student");
            }

            double sum = 0;
            foreach (Student x in list)
            {
                sum += x.Score;
            }

            return sum / list.Count;
        }

        /* - Tìm sinh viên có điểm số thấp nhất trong lớp
         * - Nếu lớp không có sinh viên nào thì trả về null
         * - Nếu lớp có nhiều sinh viên cùng có điểm thấp nhất thì trả về sinh viên nằm ở cuối
         * 
         * 
         * 
         **/
        public Student findStudentWithMinScore()
        {
            if (list.Count == 0)
            {
                return null;
            }

            // find min score
            double minScore = list[0].Score;
            foreach (Student x in list)
            {
                if (x.Score < minScore)
                    minScore = x.Score;
            }
          
            // find student with min score
            foreach (Student x in list)
            {
                if (x.Score == minScore)
                {
                    return x;
                }
            }

            return null;
        }




        /* Sắp xếp danh sách theo tuổi giảm dần
         * 
         * 
         **/
        public void sortByAge()
        {
            list.Sort(new CompareByAge());
        }

        /* - Lấy danh sách sinh viên loại giỏi (điểm >= 8.0)
         * - Sắp xếp danh sách đó theo điểm giảm dần
         * - Không thay đổi trên danh sách cũ
         * - Nêu không có sinh viên nào loại giỏi thì trả về null
         * 
         * 
         **/
        public List<Student> filterByScore()
        {
            list.Sort(new CompareByScore());

            List<Student> ds = new List<Student>();
            foreach (Student x in list)
            {
                if (x.Score > 8.0)
                    ds.Add(x);
            }
            return ds;
        }

        class CompareByAge : Comparer<Student>
        {

            public override int Compare(Student x, Student y)
            {
                if (x.Age > y.Age)
                    return -1;
                if (x.Age < y.Age)
                    return 1;
                return 0;
            }
        }

        class CompareByScore : Comparer<Student>
        {
            public override int Compare(Student x, Student y)
            {
                if (x.Score < y.Score)
                    return 1;
                if (x.Score > y.Score)
                    return -1;
                return 0;
            }
        }

    }
}
