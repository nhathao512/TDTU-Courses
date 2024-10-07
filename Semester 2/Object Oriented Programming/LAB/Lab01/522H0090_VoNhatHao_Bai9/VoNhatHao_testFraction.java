import java.util.*;
public class VoNhatHao_testFraction 
{
    public static void main(String[] args) 
    {
        Scanner sc = new Scanner(System.in);

        System.out.print("Enter 1st fraction: ");
        int a = sc.nextInt();
        int b = sc.nextInt();
        VoNhatHao_FractionI f1 = new VoNhatHao_Fraction(a, b);

        System.out.print("Enter 2nd fraction: ");
        a = sc.nextInt();
        b = sc.nextInt();
        VoNhatHao_FractionI f2 = new VoNhatHao_Fraction(a, b);
        f1 = f1.simplify();
        f2 = f2.simplify();
        System.out.println("1st fraction is " + f1);
        System.out.println("2nd fraction is " + f2);

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