using System;

namespace ProjektKertoma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int fact = 1;

            Console.WriteLine("Kertoman laskenta");
            Console.Write("Minkä luvun kertoma lasketaan? ");
            n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Virheellinen syöte!");
            }

            else

            {
                while(n > 0)
                {
                    fact = fact * n;
                    n = n - 1;
                }
                Console.WriteLine("Vastaus: " + fact);
            }
        }
    }
}

