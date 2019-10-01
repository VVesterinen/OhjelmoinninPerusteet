using System;

namespace EhtoSilmukka3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0;




            Console.WriteLine("Luvun ominaisuudet.");
            Console.Write("Syötä luku: ");
            n = int.Parse(Console.ReadLine());



            if (n < 0 && n % 2 == 0)
            {
                Console.WriteLine("Luku on negatiivinen ja parillinen.");
            }

            else if (n > 0 && n % 2 == 0)

            {
                Console.WriteLine("Luku on positiivinen ja parillinen.");
            }

            else if (n == 0 && n % 2 == 0)

            {
                Console.WriteLine("Luku on nolla.");
            }

            else if (n < 0 && n % 2 == -1)

            {
                Console.WriteLine("Luku on negatiivinen ja pariton.");
            }

            else if (n > 0 && n % 2 == 1)

            {
                Console.WriteLine("Luku on positiivinen ja pariton.");
            }

           
        }
    }
}

