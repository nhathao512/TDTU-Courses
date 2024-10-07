public class Hao_Test
{
    public static void main(String[] args)
    {
        Hao_Shape s = new Hao_Rectangle(3, "white", true);
        System.out.println(s.toString());
        System.out.println("Area = " + s.getArea());

        s = new Hao_Circle(4, "black", true);
        System.out.println(s.toString());
        System.out.println("Area = " + s.getArea());

        Hao_Shape[] shapes = new Hao_Shape[5];
        shapes[0] = new Hao_Circle(4, "Red", true);
        shapes[1] = new Hao_Rectangle(8, 4, "Blue", true);
        shapes[2] = new Hao_Square(10, "Black", true);
        shapes[3] = new Hao_Circle(9);
        shapes[4] = new Hao_Rectangle(12, 8, "Blue", true);

        for(int i = 0; i < shapes.length; i++)
        {
            System.out.println("Area " + i + "=" + shapes[i].getArea());
        }

        double max = 0;
        for (int i = 0; i < shapes.length; i++)
        {
            double area = shapes[i].getArea();
            if(area > max)
            {
                max = area;
            }
        }
        System.out.println();
        System.out.println("The largest area in the list below is =" + max);
    }
}
