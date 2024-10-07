public class Hao_Square extends Hao_Rectangle
{
    public Hao_Square()
    {
        super();
    }

    public Hao_Square(double side, String color, boolean filled)
    {
        super(side, side, color, filled);
    }

    public double getSide()
    {
        return getWidth();
    }

    public void setSide(double side)
    {
        super.setWidth(side);
        super.setLength(side);
    }

    public void setWidth(double side)
    {
        setSide(side);
    }

    public void setLength(double side)
    {
        setSide(side);
    }

    public boolean equals(Hao_Shape s)
    {
        if(s instanceof Hao_Shape)
        {
            Hao_Square temp = (Hao_Square) s;
            if(this.getArea() == temp.getArea())
            {
                return true;
            }
        }
        return false;
    }
}