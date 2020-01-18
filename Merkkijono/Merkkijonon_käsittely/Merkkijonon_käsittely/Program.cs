using System;

namespace Merkkijonon_käsittely
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Write a text: ");
            String str = Console.ReadLine();

            int i = str.Length;

            Console.WriteLine($"Your input was {i} characters long.");

            Console.WriteLine(str.Replace("a", "@"));

            String str2 = "Hello World!";

            int nn = 0;

            for (int n = 0; n < str2.Length; n++)
            {
                if (str2[n] == 'l')
                {
                    n++;
                }
            }
            Console.WriteLine($"There are {nn} L letters.");

            Console.WriteLine("Write a word and this program will check if it is a palindrome. ");
            String strPalindrome = Console.ReadLine();
            strPalindrome = strPalindrome.Replace(" ", "");
            strPalindrome = strPalindrome.Replace(".", "");
            strPalindrome = strPalindrome.Replace(",", "");
            int i2 = 0;
            int i3 = strPalindrome.Length - 1;
            bool check = true;

            for (int i4 = 0;  i4 < strPalindrome.Length - 1; i4++)
            {
                if (strPalindrome[i2] == strPalindrome[i3])
                {
                    i2++;
                    i3--;
                }
                else
                    check = false;
            }
            if (check == true)
            {
                strPalindrome = strPalindrome.ToUpper();
                Console.WriteLine($"Your word {strPalindrome} was a palindrome.");
            }
            else
            {
                strPalindrome = strPalindrome.ToUpper();
                Console.WriteLine($"Your word {strPalindrome} wasn't a palindrome.");
            }
        }
    }
}
