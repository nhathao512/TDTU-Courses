public class Ao extends CongTy
{
    private String tayao;
    private int length;
    private int tuis;

    public Ao (String MaSanPham, String TenSanPham, String ChatLieu, String Size, String MauSac, int SoLuong,int length,String tayao,int tuis) {
        super(MaSanPham, TenSanPham, ChatLieu, Size, MauSac, SoLuong);
        this.tayao = tayao;
        this.length = length;
        this.tuis = tuis;
    }
    
    public int getLength() 
    {
        return length;
    }

    public void setLength(int length) 
    {
        this.length = length;
    }

    public String gettayao() 
    {
        return tayao;
    }

    public void settayao(String tayao) 
    {
        this.tayao = tayao;
    }
    public int getsotui() 
    {
        return tuis;
    }

    public void setsotui(int tuis) 
    {
        this.tuis = tuis;
    }

    public int ChiPhi() 
    {
        return 70000 * getSoLuong() + 2000 * getsotui();
    }
}
