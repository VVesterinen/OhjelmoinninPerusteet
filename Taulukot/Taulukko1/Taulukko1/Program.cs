using System;

namespace Taulukko1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Task1"
            double[] productPrice = { 7.92, 72.0, 99.90  };
            int[] productAmount = { 1, 3, 2 };
            double[] productTotalPrice = { (productPrice[0] * productAmount[0]), (productPrice[1] * productAmount[1]), (productPrice[2] * productAmount[2]) };

            Console.WriteLine($"Product 1: {productTotalPrice[0]}€");
            Console.WriteLine($"Product 2: {productTotalPrice[1]}€");
            Console.WriteLine($"Product 3: {productTotalPrice[2]}€");
            #endregion
            Console.WriteLine("");
            #region "Task2"
            double sum = 0;
            int n = 0;
            int[] iT = new int[100];
            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                iT[n] = rnd.Next(50);
                n++;
            }
            n = 0;
            for (int i = 0; i < 100; i++)
            {
                sum += iT[n];
                Console.WriteLine($"{n + 1}. {iT[n]}");
                n++;
            }
            Console.WriteLine("");
            Console.WriteLine($"The average is {sum / iT.Length}.");
            #endregion
        }
    }
}