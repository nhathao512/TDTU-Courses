public class ITStudent extends Student
{
    private int id;
    
    public ITStudent()
    {
        super();
        this.id = 52200000;
    }

    public ITStudent(String name, double gpa, int id)
    {
        super(name, gpa);
        this.id = id;
    }

    public String getRank()
    {
        if(this.gpa > 8.0 && this.gpa <= 10.0)
            return "A";
        else if (this.gpa > 5.0 && this.gpa <= 8.0)
            return "B";
        else 
            return "C";
    }

    public String toString()
    {
        return this.name + " - " + this.id + " - " + this.gpa;
    }
}