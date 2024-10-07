public class TestPoint
{
    public static void main(String[] args)
    {
        Point2D p1 = new Point2D();
        Point3D p11 = new Point3D();
        Point2D p2 = new Point2D(1.5f, 3.5f);
        Point3D p22 = new Point3D(p2.getX(), p2.getY(), 7.5f);

        System.out.println(p1);
        System.out.println(p11);
        System.out.println(p2);
        System.out.println(p22);
    }
}