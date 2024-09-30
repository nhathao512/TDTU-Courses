public class EWallet implements Payment, Transfer 
{
	// code here
	private int SDT;		//so dien thoai
	private double SDTK;	//so du tai khoan

	public EWallet(int SDT)
	{
		this.SDT = SDT;
		this.SDTK = 0.0;
	}

	public int getSDT()
	{
		return this.SDT;
	}

	public void setSDT(int SDT)
	{
		this.SDT = SDT;
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
		if (amount <= this.SDTK)
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
		if (STC <= this.SDTK)
		{
            this.SDTK = this.SDTK - STC;
			if (to instanceof EWallet)
			{
				EWallet ep = (EWallet) to;
				ep.topUp(amount);
            	return true;
			}
			else if (to instanceof BankAccount)
			{
				BankAccount ep = (BankAccount) to;
				ep.topUp(amount);
            	return true;
			}
            
        }
		return false;
		
	}

	public String toString()
	{
		return this.SDT + "," + this.SDTK;
	}
}
