import java.util.HashMap;
import java.util.Scanner;

public class Dictionary
{
    public static void main(String[] args)
    {
        HashMap<String, String> dic = new HashMap<>();

        dic.put("hello", "xin chao");
        dic.put("red", "mau do");
        dic.put("yellow", "mau vang");
        dic.put("book", "sach");
        dic.put("name", "ten");
        dic.put("salary", "luong");
        dic.put("year", "nam");
        dic.put("day", "ngay");
        dic.put("class", "lop");
        dic.put("word", "tu");
        dic.put("group", "nhom");

        Scanner sc = new Scanner(System.in);

        System.out.print("Enter a word to look up or enter 'close' to exit: ");
        String userEnter = sc.nextLine();
        String word = userEnter.toLowerCase();

        while(!word.equals("close"))
        {
            if(dic.containsKey(word))
            {
                System.out.println("The meaning of " + word + " is: " + dic.get(word));
            }
            else
            {
                System.out.println("The word " +  word + " is not exist in the dictionary");
            }
            
            System.out.print("Enter another word to look up or enter 'close' to exit: ");
            userEnter = sc.nextLine();
            word = userEnter.toLowerCase();
        }

        sc.close();
    }
}