import java.util.*;

public class VoNhatHao_Bai3
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);

        String paragraph = "The Edge Surf is of course also a whole lot better, which will hopefully win Microsoft some converts. It offers time trial, support for other input methods like touch and gamepads, accessibility improvements, high scores, and remastered visuals.";     
        System.out.println("Count word in the paragraph: " + countWord(paragraph));         
        System.out.println("Count the number of sentences in the paragraph: " + countSentences(paragraph));
        Scanner input = new Scanner(System.in);
	System.out.print("Enter a word: ");
        String word = input.nextLine();
        System.out.println();
        System.out.println("Count the number of occurrences of the word in the paragraph: " + countAppear(paragraph, word));            
        
    }   
    public static int countWord(String paragraph)
    {
        String formatedStr = paragraph.replaceAll("[,.!]", "");
        String[] words = formatedStr.split(" ");
        return words.length;
    }

    public static int countSentences(String paragraph)
    {
        int count = 0;
        //tach chuoi thanh mang ki tu -> neu gap dau '.' nghia la het 1 cau
        char[] charArr = paragraph.toCharArray();
        for(int i = 0; i < charArr.length; i++)
        {
            if(charArr[i] == '.')
                count++;
        }
        return count;
    }

    public static int countAppear(String paragraph, String word)
    {
        int count = 0;

        String formatedStr = paragraph.replaceAll("[,.!]", "").toLowerCase();
        String[] words = formatedStr.split(" ");

        for(String part : words)
        {
            //.equals(): so sanh chuoi neu = thi tra ve kieu boolean true/false
            if(part.equals(word))           
                count++;
        }
        return count;
    }
}