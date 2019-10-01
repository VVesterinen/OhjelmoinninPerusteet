using System;

namespace EhtoSilmukka2
{
    class Program
    {
        static void Main(string[] args)

        {

            int n = 0;


            Console.WriteLine("Syötä luku");
            Console.Write("");

            int lkm = int.Parse(Console.ReadLine());

            if (lkm % 2 == 0)
            {
                Console.WriteLine("Luku on parillinen.");
            }

            else
            {
                Console.WriteLine("Luku on pariton.");
            }

        }
    }
}
