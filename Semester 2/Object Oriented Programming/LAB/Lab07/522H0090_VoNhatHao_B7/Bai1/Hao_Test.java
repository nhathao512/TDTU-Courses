public class Hao_Test 
{
    public static void main(String[] args) 
    {
    Hao_Shape s = new Hao_Rectangle(3, 4, "white");
    System.out.println(s.toString());
    System.out.println("Area = " + s.getArea());

    s = new Hao_Triangle(4, 5, "black");
    System.out.println(s.toString());
    System.out.println("Area = " + s.getArea());
    }
}