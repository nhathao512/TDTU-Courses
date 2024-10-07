public class MathStudent extends Student
{
    private String id;

    public MathStudent()
    {
        super();
        this.id = "522H0000"
    }

    public MathStudent(String name, double gpa, String id)
    {
        super(name, gpa);
        this.id = id;
    }

    public String getRank()
    {
        if ( this.gpa > 5.0)
            return "Pass";
        return "Fail";
    }

    public String toString()
    {
        return this.name + "-" + this.gpa + "-" + this.id;
    }
}