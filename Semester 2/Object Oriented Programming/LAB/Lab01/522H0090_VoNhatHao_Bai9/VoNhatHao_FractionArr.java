public class VoNhatHao_FractionArr implements VoNhatHao_FractionI 
{
    // Data members
    private int[] members;
    // Constructors
    public VoNhatHao_FractionArr() { this(1,1); }
    public VoNhatHao_FractionArr(int numer, int denom) 
    {
        members = new int[2];
        setNumer(numer);
        setDenom(denom);
    }
    // Accessors
    public int getNumer() // fill in the code
    {
        return this.members[0];
    }
    public int getDenom() // fill in the code
    {
        return this.members[1];
    }
    // Mutators
    public void setNumer(int numer) // fill in the code
    {
        this.members[0] = numer;
    }
    public void setDenom(int denom)  // fill in the code
    {
        this.members[1] = denom;
    }
    // The rest are omitted here
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
        int rut_gon = gcd(this.members[0], this.members[1]);
        return new VoNhatHao_Fraction(this.members[0]/rut_gon, this.members[1]/rut_gon);
    } 
    public VoNhatHao_FractionI add(VoNhatHao_FractionI f) // fill in the code 
    {
        int numer1 =  (this.members[0] * f.getDenom()) + (this.members[1] * f.getNumer());
        int denom1 = this.members[1] * f.getDenom();
        return new VoNhatHao_Fraction(numer1, denom1);
    } 
    public VoNhatHao_FractionI minus(VoNhatHao_FractionI f) // fill in the code 
    {
        int numer1 = (this.members[0] * f.getDenom()) - (this.members[1] * f.getNumer());
        int denom1 = this.members[1] * f.getDenom();
        return new VoNhatHao_Fraction(numer1, denom1);
    } 
    public VoNhatHao_FractionI times(VoNhatHao_FractionI f) // fill in the code 
    {
        int numer1 = this.members[0] * f.getNumer();
        int denom1 = this.members[1] * f.getDenom();
        return new VoNhatHao_Fraction(numer1, denom1);
    } 
    // Overriding methods toString() and equals()
    public String toString() // fill in the code 
    {
        return "Fraction [" + "Numerator = " + this.members[0] + ", Denominator = " + this.members[1] + "]";
    } 
    public boolean equals(Object obj) // fill in the code }
    {
        if (obj instanceof VoNhatHao_FractionArr)
        {
            VoNhatHao_FractionArr temp = (VoNhatHao_FractionArr) obj;
            if (this.members[0] == temp.getNumer() && this.members[1] == temp.getDenom())
            {
                return true;
            }
        }
        return false;
    }
}