public class BankAccount implements Payment, Transfer
{
    // code here
    private int STK;        //so tai khoan
    private double TLLS;    //ti le lai suat
    private double SDTK;    //so du tai khoan

    public BankAccount(int STK, double TLLS)
    {
        this.STK = STK;
        this.TLLS = TLLS;
        this.SDTK = 50.0;
    }

    public int getSTK()
    {
        return this.STK;
    }

    public void setSTK(int STK)
    {
        this.STK = STK;
    }

    public double getTLLS()
    {
        return this.TLLS;
    }

    public void setTLLS(double TLLS)
    {
        this.TLLS = TLLS;
    }

    public double getSDTK()
    {
        return this.SDTK;
    }

    public void setSDTK(double SDTK)
    {
        this.SDTK = SDTK;
    }

    public void topUp(double amount) 
	{
        this.SDTK = this.SDTK + amount;
    }

    public double checkBalance()
    {
        return this.SDTK;
    }

    public boolean pay (double amount)
    {
        if (amount + 50 <= this.SDTK)
        {
            this.SDTK = this.SDTK - amount;
            return true;
        }
        else
        {
            return false;
        }
    }

    public boolean transfer (double amount, Transfer to)
	{
		double STC = amount + (double)(Transfer.transferFee * amount);		//STC: so tien chuyen
        if (STC + 50 <= this.SDTK ) 
		{
            this.SDTK = this.SDTK - STC;
			if (to instanceof BankAccount)
			{
				BankAccount ep = (BankAccount) to;
				ep.topUp(amount);
            	return true;
			}
            else if (to instanceof EWallet)
			{
				EWallet ep = (EWallet) to;
				ep.topUp(amount);
            	return true;
			}
            
        }
        return false;
    }


    public String toString()
    {
        return this.STK + "," + this.TLLS + "," + this.SDTK;
    }
}
