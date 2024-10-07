import java.io.File;
import java.io.IOException;
import java.io.FileWriter;
import java.util.Scanner;
public class Bai2
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter a sentence: ");
        String s1 = sc.nextLine();
        sc.close();

        File inputFile = new File("input.txt");
        File outputFile = new File("output.txt");
        try
        {
            FileWriter writeFile = new FileWriter(inputFile);
            writeFile.write(s1);
            writeFile.close();
            System.out.println("Write Successfully");
        }
        catch (IOException e)
        {
            System.out.println("An error occurred");
            e.printStackTrace();
        }
        try 
        {
            Scanner readFile = new Scanner(inputFile);
            FileWriter writeData = new FileWriter(outputFile);
            while(readFile.hasNextLine())
            {
                String inputData = readFile.nextLine();
                String outputText = inputData.toUpperCase();
                writeData.write(outputText + "\n");
            }
            readFile.close();
            writeData.close();
            System.out.print("Read and Write successfully");
        }
        catch (IOException e)
        {
            System.out.print("An error occurred");
            e.printStackTrace(); 
        }
    
    }
}