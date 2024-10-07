public class Hao_Triangle extends Hao_Shape
{
    private double base;
    private double height;

    public Hao_Triangle()
    {
        super();
        this.base = 0;
        this.height = 0;
    }

    public Hao_Triangle(double base, double height, String color)
    {
        super(color);
        this.base = base;
        this.height = height;
    }

    public double getArea()
    {
        return 1.0/2 * this.base * this.height;
    }

    public String toString()
    {
        return "Triangle [" + "base = " + this.base + ", height = " + this.height + ", color = " + getColor() + "]";
    }
}