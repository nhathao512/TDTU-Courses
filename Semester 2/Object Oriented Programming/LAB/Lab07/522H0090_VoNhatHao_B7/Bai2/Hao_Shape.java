public abstract class Hao_Shape
{
    protected String color;
    protected boolean filled;

    public Hao_Shape()
    {
        this.color = "";
        this.filled = true;
    }

    public Hao_Shape(String color, boolean filled)
    {
        this.color = this.color;
        this.filled = this.filled;
    }

    public String getColor()
    {
        return this.color;
    }

    public void setColor(String color)
    {
        this.color = color;
    }

    public boolean isFilled()
    {
        this.filled = true;
    }

    public void setFilled(boolean filled)
    {
        this.filled = filled;
    }

    public boolean equals(Hao_Shape s)
    {
        if(s instanceof Hao_Shape)
        {
            Hao_Shape temp = (Hao_Shape) s;
            if(this.getColor() == temp.getColor() && this.isFilled() == temp.isFilled())
            {
                return true;
            }  
        }
        return false;
    }

    public abstract double getArea();
    
    public abstract double getPerimeter();

    public String toString()
    {
        return "Shape [" + "color = " + color + ", boolean = " + filled + "]";
    }

}

