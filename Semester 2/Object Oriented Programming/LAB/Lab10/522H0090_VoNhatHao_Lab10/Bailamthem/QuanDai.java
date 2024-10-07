public class QuanDai extends CongTy
{
    private int ChieuDai;
    private int SoTui;

    public QuanDai(String MaSanPham, String TenSanPham, String ChatLieu, String Size, String MauSac, int SoLuong, int ChieuDai, int SoTui)
    {
        super(MaSanPham, TenSanPham, ChatLieu, Size, MauSac, SoLuong);
        this.ChieuDai = ChieuDai;
        this.SoTui = SoTui;
    }

    public int getChieuDai()
    {
        return this.ChieuDai;
    }

    public void setChieuDai(int ChieuDai)
    {
        this.ChieuDai = ChieuDai;
    }

    public int getTui()
    {
        return this.SoTui;
    }

    public void setTui(int SoTui)
    {
        this.SoTui = SoTui;
    }

    public int ChiPhi()
    {
        return 90000 * getSoLuong() + 4000 * getSoLuong();
    }
}