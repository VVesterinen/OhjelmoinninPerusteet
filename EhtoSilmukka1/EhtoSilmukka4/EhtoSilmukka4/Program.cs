using System;

namespace EhtoSilmukka4
{
    class Program
    {
        static void Main(string[] args)
        {


            int x;
            int y;
            int z;

            Console.WriteLine("Syötä kolme lukua:");
            int luku1, luku2, luku3;

            Console.Write("Ensimmäinen: ");
            luku1 = int.Parse(Console.ReadLine());

            Console.Write("Toinen: ");
            luku2 = int.Parse(Console.ReadLine());

            Console.Write("Kolmas: ");
            luku3 = int.Parse(Console.ReadLine());


            if (luku1 > luku2) { y = luku1; x = luku2; }
            else { y = luku2; x = luku1; }

            if (y > luku3)
            {
                z = y; if (x > luku3)
                {
                    y = x; x = luku3;
                }
                else
                {
                    y = luku3;
                }
            }

            else z = luku3;

            Console.Write("Pienimmästä suurimpaan: " + x + ", " + y + ", " + z + ".");



        }
    }
}
