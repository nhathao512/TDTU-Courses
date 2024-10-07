public abstract class CongTy
{
    private String MaSanPham;
    private String TenSanPham;
    private String ChatLieu;
    private String Size;
    private String MauSac;
    private int SoLuong;

    public abstract int ChiPhi();
    
    public CongTy()
    {
        this.MaSanPham = "";
        this.TenSanPham = "";
        this.ChatLieu = "";
        this.Size = "";
        this.MauSac = "";
        this.SoLuong = 0;
    }

    public CongTy(String MaSanPham, String TenSanPham, String ChatLieu, String Size, String MauSac, int SoLuong)
    {
        this.MaSanPham = MaSanPham;
        this.TenSanPham = TenSanPham;
        this.ChatLieu = ChatLieu;
        this.Size = Size;
        this.MauSac = MauSac;
        this.SoLuong = SoLuong;
    }

    public String getMaSanPham()
    {
        return this.MaSanPham;
    }

    public void setMaSanPham(String MaSanPham)
    {
        this.MaSanPham = MaSanPham;
    }

    public String getTenSanPham()
    {
        return this.TenSanPham;
    }

    public void setTenSanPham(String TenSanPham)
    {
        this.TenSanPham = TenSanPham;
    }

    public String getChatLieu()
    {
        return this.ChatLieu;
    }

    public void setChatLieu(String ChatLieu)
    {
        this.ChatLieu = ChatLieu;
    }

    public String getSize()
    {
        return this.Size;
    }

    public void setSize(String Size)
    {
        this.Size = Size;
    }

    public String getMauSac()
    {
        return this.MauSac;
    }

    public void setMauSac(String MauSac)
    {
        this.MauSac = MauSac;
    }

    public int getSoLuong()
    {
        return this.SoLuong;
    }

    public void setSoLuong(int SoLuong)
    {
        this.SoLuong = SoLuong;
    }

    public String toString()
    {
        return "Cong Ty[ Ma San Pha = " + MaSanPham + ", Ten San Pham = " + TenSanPham + ", Chat lieu = " + ChatLieu + ", Kich co = " + Size + ", Mau sac = " + MauSac + ", So Luong = " + SoLuong + "]";
    }
}