import java.util.*;
public class Calculator
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter number a: ");
        int a = sc.nextInt();

        System.out.print("Enter number b: ");
        int b = sc.nextInt();
        Calculator cal = new Calculator();
        try
        {
            double res = cal.divide(a, b);
            System.out.println("Divide: " + res);
        }
        catch (ArithmeticException e)
        {
            System.out.print(e.getMessage());
        }
        
        try
        {
            double res = cal.multiply(a, b);
            System.out.println("Multiply: " + res);
        }
        catch (NumberOutOfRangeException e)
        {
            System.out.print(e.getMessage());
        }
        sc.close();
    }
    public double divide(int a, int b) throws ArithmeticException
    {
        if (b == 0)
        {
            ArithmeticException a1 = new ArithmeticException("divide by zero");
            throw a1;
        }
        return (double)a/(double)b;
    }

    public int multiply(int a, int b) throws NumberOutOfRangeException
    {
        if (a < -1000 || a > 1000 || b < -1000 || b > 1000)
        {
            NumberOutOfRangeException a2 = new NumberOutOfRangeException("Number is outside the computation");
            throw a2;
        }
        return a * b;
    }
    public class NumberOutOfRangeException extends ArithmeticException
    {
        public NumberOutOfRangeException(String s)
        {
            super(s);
        }
    }   
}