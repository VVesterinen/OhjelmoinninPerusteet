using System;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lotto = new int[40];
            intro();
            rndLottoNumbs(ref lotto, 7, 1);
            rndLottoNumbs(ref lotto, 1, 2);
            printLottoNumbs(lotto);
        }
#region "intro"
        static void intro()
        {
            Console.WriteLine("Lotto-line generator.\n\nGives you one line + extra and double number.");
            Console.WriteLine("\nPress 'Spacebar' to continue!");
            while (Console.ReadKey() .Key != ConsoleKey.Spacebar) { }
        }
#endregion
#region "making numbers"
        static void rndLottoNumbs(ref int[] arrlotto, int count, int value)
        {
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                int rndnumb = rnd.Next(arrlotto.Length);
                if (arrlotto[rndnumb] == 0)
                {
                    arrlotto[rndnumb] = value;
                }
                else
                    i--;
            }
        }
#endregion
#region "printing numbers"
        static void printLottoNumbs(int[] arrlotto)
        {
            Random rnd = new Random();
            Console.WriteLine("\n\nYour lotto line is as following:");
            for (int i = 0; i < arrlotto.Length; i++)
            {
                if (arrlotto[i] == 1)
                {
                    Console.Write($"{i+1}, ");
                }
            }
            Console.WriteLine("\n\nExtra number is:");
            for (int i = 0; i < arrlotto.Length; i++)
                if (arrlotto[i] == 2)
            {
                    Console.WriteLine($"{i}");
            }
            Console.WriteLine($"\nDouble number is:\n{rnd.Next(arrlotto.Length)}");
            Console.WriteLine("\nGood luck!");
#endregion
        }
    }
}