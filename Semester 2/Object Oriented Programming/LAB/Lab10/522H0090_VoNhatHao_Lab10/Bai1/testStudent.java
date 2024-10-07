public class testStudent
{
    public static void main(String[] args)
    {
        Student s1 = new Student("Vo Nhat Hao", "Cu Chi", "Nam", 8.5);
        Student s2 = new Student();

        Student.StudentOperater so1 = s1.new StudentOperater();
        Student.StudentOperater so2 = s2.new StudentOperater();

        so1.print();
        System.out.println("Student type: " + so1.type());
        so2.print();
        System.out.println("Student type: " + so2.type());

    }
}