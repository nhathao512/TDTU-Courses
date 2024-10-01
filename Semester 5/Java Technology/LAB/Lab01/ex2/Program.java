import vn.edu.tdtu.ArrayOutput;
import java.util.Scanner;
import vn.edu.tdtu.ArrayHandler;


public class Program{
    public static void main(String[] args) {
        int a[] = {1, 3, 5, 7, 9};
        int b[] = {2, 4, 6, 8};
        System.out.println("Array a: ");
        ArrayOutput.print(a);
        System.out.println("Array b: ");
        ArrayOutput.print(b);
        int c[] = ArrayHandler.merge(a, b);
        System.out.println("Array c: ");
        ArrayOutput.print(c);
        ArrayHandler.sort(c);
        System.out.println("Array c sorted: ");
        ArrayOutput.print(c);
        ArrayOutput.write(c, "output.txt");
    }
}