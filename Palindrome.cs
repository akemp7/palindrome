using System;

class Program
{
  static void Main()
  {
      Console.WriteLine("Type a word");
      string userInput = Console.ReadLine();
      string palidromeWord = CheckPalindrome(userInput);
      if(palidromeWord.Length > 1){
          Console.WriteLine(userInput + " is NOT a palindrome");
      } else {
          Console.WriteLine(userInput + " IS a palindrome");
      }
      
      
 } 
    public static string CheckPalindrome(string word){
        if(word.Length > 1 && word[0] == word[word.Length-1]){
            word = word.Substring(1,word.Length-2);
            Console.WriteLine(word);
            return word = CheckPalindrome(word);
        } else {
            return word;
        }
    }

}