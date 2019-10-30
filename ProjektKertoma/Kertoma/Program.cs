using System;

namespace ProjektKertoma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define variables
            int n = 0;
            int fact = 1;

            // Print message to user

            Console.WriteLine("Kertoman laskenta");
            Console.Write("Minkä luvun kertoma lasketaan? ");

            // Read user input and force to int. form
            n = int.Parse(Console.ReadLine());


            // If, where trying users input
            // the logic of the app
            if (n < 0)
            {
                Console.WriteLine("Virheellinen syöte!");
            }

            else

            {

                // Loop, where calculating input
                while(n > 0)
                {
                    fact = fact * n; // Counting input by every lap
                    n = n - 1; // Decreaing input by one
                }
                // Print anwser to screen
                Console.WriteLine("Vastaus: " + fact);
            }
        }
    }
}

