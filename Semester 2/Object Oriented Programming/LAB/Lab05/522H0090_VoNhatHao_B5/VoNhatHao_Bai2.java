import java.util.*;

public class VoNhatHao_Bai2
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);

        System.out.print("Enter your name: ");
        String name = sc.nextLine();
        System.out.print("Enter a string: ");
        String str = sc.nextLine();             
        System.out.println("Shorted name: " + shortName(name));
           
        System.out.println("Hashtaged name: " + hashtagName(name));
          
        System.out.println("Uppercased all vowels in a string: " + uppercaseAllVowel(str));
            
        System.out.println("Upppercased all n letter in a string: " + uppercaseAllNLetter(str));          
    }
    public static String shortName(String name)
    {
        String[] words = name.split(" ");
        return words[0] + " " + words[words.length - 1];
    }

    public static String hashtagName(String name)
    {
        String[] words = name.split(" ");
        return "#" + words[0] + words[words.length - 1];
    }

    public static String uppercaseAllVowel(String str)
    {
        //toCharArray(): chuyen tu kieu du lieu String -> mang Character
        char[] charArr = str.toCharArray();                  
         for(int i = 0; i < charArr.length; i++)
        {
            if(charArr[i] == 'a' || charArr[i] == 'e' || charArr[i] == 'u' || charArr[i] == 'i' || charArr[i] == 'o')
            {
                charArr[i] = Character.toUpperCase(charArr[i]);
            }
        }
        //String.valueOf(mang char): chuyen doi mang character ve kieu du lieu string
        return String.valueOf(charArr);
    }

    public static String uppercaseAllNLetter(String str)
    {
        return str.replaceAll("n", "N");
    }
}