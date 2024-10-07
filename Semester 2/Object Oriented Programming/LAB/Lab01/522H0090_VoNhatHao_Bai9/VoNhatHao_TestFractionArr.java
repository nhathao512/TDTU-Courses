import java.util.*;
public class VoNhatHao_TestFractionArr 
{
    public static void main(String[] args) 
    {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter 1st fraction: ");
        int a = sc.nextInt();
        int b = sc.nextInt();
        VoNhatHao_FractionI f1 = new VoNhatHao_FractionArr(a, b);
        System.out.print("Enter 2nd fraction: ");
        a = sc.nextInt();
        b = sc.nextInt();
        VoNhatHao_FractionI f2 = new VoNhatHao_FractionArr(a, b);
        // The rest of the code is the same as TestFraction.java
        System.out.println("1st fraction is " + f1);
        System.out.println("2nd fraction is " + f2);
        f1 = f1.simplify();
        f2 = f2.simplify();
        if (f1.equals(f2))
            System.out.println("The fractions are the same.");
        else
            System.out.println("The fractions are not the same.");

        VoNhatHao_FractionI sum = f1.add(f2);
        System.out.println("Sum is " + sum);
        VoNhatHao_FractionI minus = f1.minus(f2);
        System.out.println("Difference is " + minus);
        VoNhatHao_FractionI times = f1.times(f2);
        System.out.println("Product is " + times);
    }
}