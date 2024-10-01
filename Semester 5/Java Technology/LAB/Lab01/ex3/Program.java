import java.util.List;

public class Program {
    public static void main(String[] args) {

        // 1. kh?i t?o danh s�ch sinh vi�n
        List<Student> list = StudentUtils.generate();
        StudentUtils.print(list);

        // 2. s?p x?p theo t�n v� in ra k?t qu?
        System.out.print("Sorted by Name");
        StudentUtils.sortByName(list);
        StudentUtils.print(list);

        // 3. s?p x?p t�ng d?n theo �i?m trung b?nh v� in ra k?t qu?
        System.out.print("Sorted by average score asendingly");
        StudentUtils.sortByAvg(list);
        StudentUtils.print(list);

        // @TODO: s?p x?p gi?m d?n theo tu?i r?i in k?t qu?
        System.out.print("Sorted by age desendingly");
        StudentUtils.sortByAgeDescending(list);
        StudentUtils.print(list);

        // @TODO: t�nh �i?m trung b?nh c?a to�n b? danh s�ch r?i in k?t qu?
        System.out.println("Average score of all students: " + StudentUtils.avg(list));


        // @TODO: l?y danh s�ch T�N h?c sinh gi?i r?i in k?t qu?
        System.out.println("List names of good students: " +  StudentUtils.goodStudentName(list));
    }
}