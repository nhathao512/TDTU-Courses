import java.time.Year;
public class ConvenientCard implements Payment
{
	// code here
	private double SDTK;		//so du tai khoan
	private IDCard TDD;			//the dinh danh
    private String type;

	public String getType() 
	{
		return this.type;
	}

	public IDCard getTDD()
	{
		return this.TDD;
	}

	public void setTDD(IDCard TDD)
	{
		this.TDD = TDD;
	}

	public double SDTK()
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

	public int getSDD()
	{
		return TDD.So_Dinh_Danh;
	}

	public String getGioiTinh()
	{
		return TDD.Gioi_Tinh;
	}

	public int getSDT()
	{
		return TDD.So_Dien_Thoai;
	}

	public int getNamSinh()
	{
		return Year.now().getValue() - Integer.valueOf(TDD.getNamSinh().substring(6));
	}

	public boolean pay (double amount)
	{
		if (this.type.equals("Student"))
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
		else if (this.type.equals("Adult"))
		{
			if (amount + (0.01 * amount) <= this.SDTK)
			{
				this.SDTK = this.SDTK - (amount + (0.01 * amount));
				return true;
			}
			else
			{
				return false;
			}
		}
		else
		{
			return false;
		}
	}

	public ConvenientCard(IDCard TDD) throws CannotCreateCard 
	{
		this.TDD = TDD;
	 	this.SDTK = 100.0;

        if (getNamSinh() < 12) 
		{
            throw new CannotCreateCard("Not enough age");
        } 
		else if (getNamSinh() <= 18) 
		{
            this.type = "Student";
        } 
		else 
		{
            this.type = "Adult";
        }
    }

	public String toString()
	{
		return this.TDD + "," + this.type + "," + this.SDTK;
	}
}
