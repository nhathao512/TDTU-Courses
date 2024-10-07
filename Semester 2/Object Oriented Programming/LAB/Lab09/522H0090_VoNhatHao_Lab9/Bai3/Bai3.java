import java.util.ArrayList;
import java.io.File;
import java.io.IOException;
import java.io.FileWriter;

public class Bai3
{
    public <E> boolean writeFile(String path, ArrayList <E> lst)
    {
        try
        {
            FileWriter writeFile = new FileWriter(path);
            for (E obj : lst)
            {
                writeFile.write(obj.toString() + "\n");
            }
            writeFile.close();
            return true;
        }
        catch (IOException e)
        {
            System.out.println("An error occurred");
            e.printStackTrace();
            return false;
        }
    }

    public static void main(String[] args)
    {
        ArrayList <Student> lstStu = new ArrayList <Student> ();
        File outputFile3 = new File("outputFile3.txt");
        lstStu.add(new ITStudent("Vo Nhat Hao", 8.0, 522H0090));
        lstStu.add(new ITStudent("Nguyen Thanh Nhan", 2.0, 522H0051));
        lstStu.add(new ITStudent("Dang Nhan Nhan", 3.0, 522H0006));

        Bai3 write = new Bai3();
        if (write.writeFile("outputFile3.txt", lstStu))
        {
            System.out.println("Write to file successfully");
        }
        else 
        {
             System.out.println("Failed to write");
        }

    }
}