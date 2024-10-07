import java.io.File;
import java.io.IOException;
import java.io.FileWriter;
import java.util.Scanner;
public class Bai5
{
    public static void main(String[] args)
    {
        File inputFile = new File("inputBai5.txt");
        File outputFile = new File("outputBai5.txt");
    
        int sum = 0;

        try 
        {
            Scanner readFile = new Scanner(inputFile);
            FileWriter writeFile = new FileWriter(outputFile);
            while (readFile.hasNextLine())
            {
                int num = readFile.nextInt();
                sum = sum + num;
            }
            readFile.close();

            writeFile.write(Integer.toString(sum));
            writeFile.close();
            System.out.println("Read and write successfully");
        }
        catch (IOException e)
        {
            System.out.println("An error occurred");
            e.printStackTrace();
        }
    }
}