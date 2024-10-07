public class testPerson
{
    public static void main(String[] args)
    {
        Person p1 = new Person("Vo Nhat Hao", "28 Nguyen Thi Suong");
        Student s1 = new Student(p1.getName(), p1.getAddress(), "Information Technology", 2022, 100000000);
        Staff st1 = new Staff(p1.getName(), p1.getAddress(), "Ton Duc Thang University", 50000);

        System.out.println(p1);
        System.out.println(s1);
        System.out.println(st1);
    }
}