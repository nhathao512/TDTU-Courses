public class Hao_Circle extends Hao_Shape
{
    private double radius;

    public Hao_Circle()
    {
        super();
        this.radius = 0;
    }

    public Hao_Circle(double radius)
    {
        super();
        this.radius = radius;
    }

    public Hao_Circle(double radius, String color, boolean filled)
    {
        super(color, filled);
        this.radius = radius;
    }

    public double getRadius()
    {
        return this.radius;
    }

    public void setRadius(double radius)
    {
        this.radius = radius;
    }

    public double getArea()
    {
        return this.radius  * this.radius * Math.PI;
    }

    public double getPerimeter()
    {
        return this.radius * 2.0;
    }

    public boolean equals(Hao_Shape s)
    {
        if(s instanceof Hao_Shape)
        {
            Hao_Shape temp = (Hao_Shape) s;
            if(this.radius() == temp.getRadius() && this.getArea() == temp.getArea())
            {
                return true;
            }  
        }
        return false;
    }

    public String toString()
    {
        return "Circle [" + "radius = " + this.radius + ", color = " + getColor() + "]";
    }
}