import java.util.*;
public class VoNhatHao_522H0090_B2
{
	public static void main(String[] args)
	{
		Scanner sc = new Scanner(System.in);
		int n;
		int [] arr = {1, 3, 5, 7, 8, 9, 10, 13, 20};
		do
		{
			System.out.println("0. Thoat chuong trinh");
			System.out.println("1. Tim Max ");
			System.out.println("2. Tim Min ");
			System.out.println("3. Tong chan trong mang ");
			System.out.println("4. Dem so hoan thien ");
			System.out.println("5. Dem so nguyen to ");
			System.out.println("6. Tim phan tu trong mang");
			System.out.println("7. Tinh binh phuong ");
			System.out.println("8. Tim Max BigDecimal ");
			System.out.println("9. Tim so chia het cho k ");
			System.out.println("10. Tim so lon thu 3 trong mang ");
			
			System.out.println("Nhap so: ");
			n = sc.nextInt();
			if (n < 0)
			{
				System.out.println("Nhap Sai...Moi nhap lai");
			}
		
		
			switch(n)
			{
				case 0:
					System.out.println("0. Thoat chuong trinh");
					break;
				case 1:
					System.out.println("1. Gia tri max: " + findMax(arr));
					break;
				case 2:
					System.out.println("2. Gia tri min: " + findMin(arr));
					break;
				case 3:
					System.out.println("3. Tong chan trong mang la: "+ tong_chan(arr));
					break;
				case 4:
					System.out.println("4. Cac phan tu la so hoan thien: " + sht(arr));
					break;
				case 5:
					System.out.println("5. Cac phan tu la so nguyen to: " + snt(arr));
					break;
			/*	case 6:
					System.out.println("6. Phan tu trong mang la: " + phan_tu);
					break;
				case 7:
					System.out.println("7. Binh phuong phan tu la: " + binh_phuong);
					break;
				case 8:
					System.out.println("8. Max BigDecimal la: " + max2);
					break;
				case 9:
					System.out.println("9. So chia het cho k la: " + div);
					break;
				case 10:
					System.out.println("10. So lon thu 3 la: " + max2);
					break; */
			}
		}while(n == 0);
	}

	public static int findMax(int arr[])
	{
		int max1 = 0;
		for(int i = 1; i < arr.length; i++)
		{
			if(arr[i] > max1)
				max1 = arr[i];
		}
		return max1;
	}
	public static int findMin(int arr[])
	{
		int min = 0;
		for(int i = 1; i < arr.length; i++)
		{
			if(arr[i] < min)
				min = arr[i];
		}
		return min;
	}
	public static int tong_chan(int arr[])
	{
		int sum1 = 0;
		for (int i = 1; i < arr.length; i++)
		{
			if(arr[i] % 2 == 0)
				sum1 = sum1 + i;
		}
		return sum1; 
	}	
	public static int sht(int arr[])
	{
		int count = 0;
		for (int i = 1; i < arr.length; i++)
		{	
			int m = arr.length;
			if (m % i == 0)
				count = count + 1;
		}
		return count;
	}
	public static int snt (int arr[])
	{
		int d = 0;
		for (int i = 2; i < arr.length / 2; i++)
		{
			int a = arr.length / 2;
			if (a % i == 0)
				d = d + 1; 
		}
		return d;
	}
}