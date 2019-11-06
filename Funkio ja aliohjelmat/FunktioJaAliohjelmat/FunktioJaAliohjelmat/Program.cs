using System;

namespace FunktioJaAliohjelmat
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Number input"

            Console.WriteLine("How many stars? ");
            int i = int.Parse(Console.ReadLine());

            if (i < 1)
            {
                Console.WriteLine($"Number {i} isn't allowed.");
            }

            else
            {
                Console.WriteLine($"{Change(i)}");
            }
            #endregion
        }
        #region "Number to Star"

        static string Change(int n)

        {
            string value = "";

            for (int i = 0; i < n; i++)
            {
                value += "*";
            }
            return value; 

        }
        #endregion
    }
}
