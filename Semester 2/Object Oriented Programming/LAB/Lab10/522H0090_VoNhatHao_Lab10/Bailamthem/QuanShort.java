public class QuanShort extends CongTy
{
    private int length;
    private int tuis;
    private int width;

    public QuanShort (String MaSanPham, String TenSanPham, String ChatLieu, String Size, String MauSac, int SoLuong,int length, int tuis, int width) 
    {
        super(MaSanPham, TenSanPham, ChatLieu, Size, MauSac, SoLuong);
        this.length = length;
        this.tuis = tuis;
        this.width = width;
    }

    public int getLength() 
    {
        return length;
    }

    public void setLength(int length) 
    {
        this.length = length;
    }

    public int getTui()
    {
        return this.tuis;
    }

    public void setTui(int SoTui)
    {
        this.tuis = tuis;
    }

    public int getWidth() 
    {
        return width;
    }

    public void setWidth(int width) 
    {
        this.width = width;
    }

    public int ChiPhi() 
    {
        return 4500 * getSoLuong() + 2000 * getWidth() * getTui();
    }
}