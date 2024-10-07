public class TestCicCy
{
    public static void main(String[] args)
    {
        Circle c1 = new Circle();
        Cylinder cy1 = new Cylinder();
        Circle c2 = new Circle(7.0, "green");
        Cylinder cy2 = new Cylinder(c2.getRadius(),3.5, c2.getColor());

        System.out.println(c1);
        System.out.println(cy1);
        System.out.println("Circle area = " + c1.getArea());
        System.out.println("Cylinder volume = " + cy1.getVolume());
        System.out.println();
        System.out.println(c2);
        System.out.println(cy2);
        System.out.println("Circle area = " + c2.getArea());
        System.out.println("Cylinder volume = " + cy2.getVolume());
    }
}