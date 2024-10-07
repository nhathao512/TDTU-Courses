import java.util.*;

public class VoNhatHao_Bai1
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);

        System.out.print("Enter n elements: ");
        int n = sc.nextInt();

        int[] arr = new int[n];

        for(int i = 0; i < n; i++)
        {
            System.out.print("Enter a[" + i + "]: ");
            arr[i] = sc.nextInt();
        }
        System.out.println();
        System.out.println("Greatest even number in an array: " + maxEven(arr));
  	System.out.println("Smallest odd number in an array: " + minOdd(arr));
	System.out.println("Sum of greatest even number and smallest odd number in an array: " + sumMEMO(arr));
	System.out.println("Sum of even number in an array: " + sumEven(arr));
	System.out.println("Product of odd number in an array: " + proOdd(arr));
  	System.out.println("Position of first even number in an array: " + idxFirstEven(arr));
	System.out.println("Position of last odd number in an array: " + idxLastOdd(arr));
	System.out.println("Array: " + Arrays.toString(input(n)));
         
    }
    public static int maxEven(int[] arr)
    {
        int max = arr[0];
        for(int i = 1; i < arr.length; i++)
        {
            if(arr[i] % 2 == 0)
            {
                if(arr[i] > max)
                    max = arr[i];
            }
        }
        return max;
    }

    public static int minOdd(int[] arr)
    {
        int min = arr[0];
        for(int i = 1; i < arr.length; i++)
        {
            if(arr[i] % 2 != 0)
            {
                if(arr[i] < min)
                    min = arr[i];
            }
        }
        return min;
    }

    public static int sumMEMO(int[] arr)
    {
        int maxEven = maxEven(arr);
        int minOdd = minOdd(arr);
        return maxEven + minOdd;
    }

    public static int sumEven(int[] arr)
    {
        int sum = 0;
        for(int num : arr)
        {
            if(num % 2 == 0)
            {
                sum += num;
            }
        }
        return sum;
    }

    public static int proOdd(int[] arr)
    {
        int pro = 1;
        for(int num : arr)
        {
            if(num % 2 != 0)
            {
                pro *= num;
            }
        }
        return pro;
    }

    public static int idxFirstEven(int[] arr)
    {
        int index = -1;
        for(int i = 0; i < arr.length; i++)
        {
            if(arr[i] % 2 == 0)
            {
                index = i;
                break;
            }
        }
        return index;
    }

    public static int idxLastOdd(int[] arr)
    {
        int index = -1;
        for(int i = arr.length - 1; i >= 0; i--)
        {
            if(arr[i] % 2 != 0)
            {
                index = i;
                break;
            }
        }
        return index;
    }

    public static int[] input(int n)
    {
        Scanner sc = new Scanner(System.in);
        int[] arrNew = new int[n];
        for(int i = 0; i < arrNew.length; i++)
        {
            System.out.print("Enter arrNew[" + i + "]: ");
            arrNew[i] = sc.nextInt();
        }
        return arrNew;
    }
}