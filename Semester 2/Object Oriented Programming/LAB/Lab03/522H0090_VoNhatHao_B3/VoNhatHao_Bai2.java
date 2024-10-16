import java.util.Scanner;
public class VoNhatHao_Bai2 {
  
    public static void showMatrix(int arr[][]) {
        for (int i = 0; i < arr.length; i++) {
            for (int j = 0; j < arr[i].length; j++) {
                System.out.print(arr[i][j] + " ");
            }
            System.out.println();
        }
    }
    public static int[][] addMatrix(int arr1[][], int arr2[][]) {
        int arr3[][] = new int[3][3];
        for (int i = 0; i < 3; i++) {
            for (int j = 0 ;j <3 ; j++) {
                arr3[i][j] = arr1[i][j] + arr2[i][j];
            }
        }
        return arr3;
    }
    public static int[][] mulMatrix(int arr[][],int n) {
        int arr3[][] = new int[3][3];
        for (int i = 0; i < 3; i++) {
            for (int j = 0 ;j <3 ; j++) {
                arr3[i][j] = arr[i][j]*n;
            }
        }
        return arr3;
    }
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int arr1[][] = {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
        int arr2[][] = {
            {9,8,7},
            {6,5,4},
            {3,2,1}
        };
        System.out.println("Ma tran sau khi cong lai la ");
        showMatrix(addMatrix(arr1, arr2));
        System.out.println("Moi nhap so muon nhan vao :");
        int n = sc.nextInt();
        System.out.println("Ma tran 1 sau khi nhan la : ");
        showMatrix(mulMatrix(arr1,n));
        sc.close();
    }
}
