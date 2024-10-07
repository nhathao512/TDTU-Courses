public class Hao_Rectangle extends Hao_Shape
{
    private double width;
    private double length;

    public Hao_Rectangle()
    {
        super();
        this.width = 0;
        this.length = 0;
    }

    public Hao_Rectangle(double width, double length, String color, boolean filled)
    {
        super(color, filled);
        this.width = this.width;
        this.length = this.length;
    }

    public double getWidth()
    {
        return this.width;
    }

    public double getLength()
    {
        return this.length;
    }

    public void setWidth(double width)
    {
        this.width = this.width;
    }

    public void setLength(double length)
    {
        this.length = this.length;
    }

    public double getArea() 
    {
        return this. length * this.width;
    }

    public double getPerimeter() 
    {
        return (this.length + this.width) * 2.0;
    }

    public boolean equals(Hao_Shape s)
    {
        if(s instanceof Hao_Shape)
        {
            Hao_Shape temp = (Hao_Shape) s;
            if(this.getArea() == temp.getArea())
            {
                return true;
            }
        }
        return false;
    }

    public String toString()
    {
        return "Rectangle [" + "width =" + this.width + ", length = " + this.length + "area = " + getArea() + "perimeter = " + getPerimeter() + "]";
    }
}