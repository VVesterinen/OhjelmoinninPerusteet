using System;

namespace FunktiotJaAliohjelmat2
{
    class Program
    {
        #region "Number input"
        static void Main(string[] args)
        {
            Console.WriteLine("Input two numbers: ");
            Console.WriteLine();

            Console.Write("Input 1. number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Input 2. number: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(GetMinNumber(x, y));

        }
        #endregion

        #region "Comparing"
        static string GetMinNumber(int x, int y)
        {

            string text = "";

            if (x < y)
            {
                Console.WriteLine($"Number {x} is smaller than number {y}.");
            }

            else if (x == y)
            {
                Console.WriteLine("Numbers are the same.");
            }

            else
            {
                Console.WriteLine($"Number {y} is smaller than number {x}.");
            }

            return text;

        }
        #endregion
    }
}