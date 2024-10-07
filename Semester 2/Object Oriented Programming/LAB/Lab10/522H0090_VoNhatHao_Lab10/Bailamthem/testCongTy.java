import java.util.Scanner;
public class testCongTy
{
    public static void main(String[] arrgsa) 
    {
        Scanner sc = new Scanner(System.in);
        System.out.println("Nhap ma san pham");
        String a = sc.nextLine();
        sc.nextLine();
        System.out.println("Nhap ten san pham");
        String b = sc.nextLine();
        System.out.println("Nhap chat lieu san pham");
        String c = sc.nextLine();
        System.out.println("Nhap size san pham");
        String d = sc.nextLine();
        sc.nextLine();
        System.out.println("Nhap mau sac san pham");
        String e = sc.nextLine();
        System.out.println("Nhap so luong san pham");
        int f = sc.nextInt();
        System.out.println("Nhap do dai san pham");
        int g = sc.nextInt();
        System.out.println("Nhap so luong tui san pham");
        int h = sc.nextInt();
        System.out.println("Nhap loai tay ao");
        String i = sc.nextLine();
        System.out.println("Nhap chieu rong quan");
        int x = sc.nextInt();
        
        QuanDai str1 = new QuanDai(a, b, c, d, e, f,g,h);
        Ao str2 = new Ao(a, b, c, d, e, f, g, i, h);
        QuanShort str3 = new QuanShort(a, b, c, d, e, f, g, h, x);
        System.out.println("Gia tien cua quan dai la:" + str1.ChiPhi());
        System.out.println("Gia tien cua ao la: " + str2.ChiPhi());
        System.out.println("Gia tien cua quan short la: " + str3.ChiPhi());

    }
}