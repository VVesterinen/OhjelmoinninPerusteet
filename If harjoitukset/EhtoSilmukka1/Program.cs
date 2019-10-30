using System;

namespace EhtoSilmukka1
{
    class Program
    {
        static void Main(string[] args)


        {

            int n = 0;
           



            Console.WriteLine("Negatiivinen, Positiivinen vai Nolla?");
            Console.Write("Syötä luku: ");
            n = int.Parse(Console.ReadLine());


            if (n < 0)           
            {
                Console.WriteLine("Luku on negatiivinen.");
            }

            else if (n > 0)

            {
                Console.WriteLine("Luku on positiivinen.");
            }

            else if (n == 0)

            {
                Console.WriteLine("Luku on nolla.");
            }

        }
    }
}
