using System;
 
class Program
{
 
    static void Main(string[] args)
    {
 
        char ch;
 
        //Reading an alphabet from user
        Console.WriteLine("Enter any alphabet: ");
        ch = Convert.ToChar(Console.ReadLine());
 
 
    // checking vowel and consonant
        switch (ch)
        {
            case 'a': Console.WriteLine("vowel");
                break;
            case 'e': Console.WriteLine("vowel");
                break;
            case 'i': Console.WriteLine("vowel");
                break;
            case 'o': Console.WriteLine("vowel");
                break;
            case 'u': Console.WriteLine("vowel");
                break;
            case 'A': Console.WriteLine("vowel");
                break;
            case 'E': Console.WriteLine("vowel");
                break;
            case 'I': Console.WriteLine("vowel");
                break;
            case 'O': Console.WriteLine("vowel");
                break;
            case 'U': Console.WriteLine("vowel");
                break;
            default: Console.WriteLine("consonant");
                break;
        }
 
        Console.ReadLine();
 
    }
 
}