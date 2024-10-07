public abstract class Hao_Shape
{
    protected String color;
    public Hao_Shape() 
    {
        this.color = "";
    }

    public Hao_Shape(String color) 
    {
        this.color = color;
    }
    public abstract double getArea();

    public String getColor() 
    {
        return this.color;
    }

    public void setColor(String color)
    {
        this.color = color;
    }
}