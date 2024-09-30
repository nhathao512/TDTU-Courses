public class IDCard 
{
      // code here
      protected int So_Dinh_Danh;
      protected String Ho_Ten;
      protected String Gioi_Tinh;
      protected String Ngay_Thang_Nam_Sinh;
      protected String Dia_Chi;
      protected int So_Dien_Thoai;

      public IDCard(int So_Dinh_Danh, String Ho_Ten, String Gioi_Tinh, String Ngay_Thang_Nam_Sinh, String Dia_Chi, int So_Dien_Thoai)
      {
            this.So_Dinh_Danh = So_Dinh_Danh;
            this.Ho_Ten = Ho_Ten;
            this.Gioi_Tinh = Gioi_Tinh;
            this.Ngay_Thang_Nam_Sinh = Ngay_Thang_Nam_Sinh;
            this.Dia_Chi = Dia_Chi;
            this.So_Dien_Thoai = So_Dien_Thoai;
      }

      public int getSDD()
      {
            return this.So_Dinh_Danh;
      }

      public void setSoDinhDanh(int So_Dinh_Danh)
      {
            this.So_Dinh_Danh = So_Dinh_Danh;
      }

      public String getHoTen()
      {
            return this.Ho_Ten;
      }

      public void setHoTen(String Ho_Ten)
      {
            this.Ho_Ten = Ho_Ten;
      }

      public String getGioiTinh()
      {
            return this.Gioi_Tinh;
      }

      public void setGioiTinh(String Gioi_Tinh)
      {
            this.Gioi_Tinh = Gioi_Tinh;
      }

      public String getNamSinh()
      {
            return this.Ngay_Thang_Nam_Sinh;
      }

      public void setNamSinh(String Ngay_Thang_Nam_Sinh)
      {
            this.Ngay_Thang_Nam_Sinh = Ngay_Thang_Nam_Sinh;
      }

      public String getDiaChi()
      {
            return this.Dia_Chi;
      }

      public void setDiaChi(String Dia_Chi)
      {
            this.Dia_Chi = Dia_Chi;
      }

      public int getSDT()
      {
            return this.So_Dien_Thoai;
      }

      public void setSDT(int So_Dien_Thoai)
      {
            this.So_Dien_Thoai = So_Dien_Thoai;
      }

      public String toString()
      {
            return this.So_Dinh_Danh+","+this.Ho_Ten+","+this.Gioi_Tinh+","+this.Ngay_Thang_Nam_Sinh+","+this.Dia_Chi+","+this.So_Dien_Thoai;
      }
}
