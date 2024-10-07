public class VoNhatHao_Fraction implements VoNhatHao_FractionI 
{
    // Data members
    private int numer;
    private int denom;
    // Constructors
    public VoNhatHao_Fraction() { this(1,1); }

    public VoNhatHao_Fraction(int numer, int denom) 
    {
        this.numer = numer;
        this.denom = denom;
    }
    // Accessors
    public int getNumer() // fill in the code 
    {
        return this.numer;
    }
    public int getDenom() // fill in the code 
    {
        return this.denom;
    }
    // Mutators
    public void setNumer(int numer) // fill in the code 
    {
        this.numer = numer;
    } 
    public void setDenom(int denom) // fill in the code
    {
        this.denom = denom;
    }
    // Returns greatest common divisor of a and b
    // private method as this is not accessible to clients
    private static int gcd(int a, int b) 
    {
        int rem;
        while (b > 0) 
        {
            rem = a%b;
            a = b;
            b = rem;
        }
        return a;
    }
    // Fill in the code for all the methods below
    public VoNhatHao_FractionI simplify() // fill in the code 
    {
        int rut_gon = gcd(this.numer, this.denom);
        return new VoNhatHao_Fraction(this.numer/rut_gon, this.denom/rut_gon);
    } 
    public VoNhatHao_FractionI add(VoNhatHao_FractionI f) // fill in the code 
    {
        int numer1 =  (this.numer * f.getDenom()) + (this.denom * f.getNumer());
        int denom1 = this.denom * f.getDenom();
        return new VoNhatHao_Fraction(numer1, denom1);
    } 
    public VoNhatHao_FractionI minus(VoNhatHao_FractionI f) // fill in the code 
    {
        int numer1 = (this.numer * f.getDenom()) - (this.denom * f.getNumer());
        int denom1 = this.denom * f.getDenom();
        return new VoNhatHao_Fraction(numer1, denom1);
    } 
    public VoNhatHao_FractionI times(VoNhatHao_FractionI f) // fill in the code 
    {
        int numer1 = this.numer * f.getNumer();
        int denom1 = this.denom * f.getDenom();
        return new VoNhatHao_Fraction(numer1, denom1);
    } 
    // Overriding methods toString() and equals()
    public String toString() // fill in the code 
    {
        return "Fraction [" + "Numerator = " + this.numer + ", Denominator = " + this.denom + "]";
    } 
    public boolean equals(Object obj) // fill in the code }
    {
        if (obj instanceof VoNhatHao_Fraction)
        {
            VoNhatHao_Fraction temp = (VoNhatHao_Fraction) obj;
            if (this.numer == temp.getNumer() && this.denom == temp.getDenom())
            {
                return true;
            }
        }
        return false;
    } 
}
