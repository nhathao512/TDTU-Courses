public abstract class Student
{
    protected String name;
    protected double gpa;

    public Student()
    {
        this.name = "";
        this.gpa = 0.0;
    }

    public Student(String name, double gpa)
    {
        this.name = name;
        this.gpa = gpa;
    }

    public abstract String getRank();
    public String toString()
    {
        return "Student [name: " + this.name + ", gpa: " + this.gpa  + "]";
    }
}