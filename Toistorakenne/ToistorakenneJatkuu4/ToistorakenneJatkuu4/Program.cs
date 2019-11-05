using System;

namespace ToistorakenneJatkuu4
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int x;
            int y = 0;

            int Kruuna = 0, Klaava = 0;

            Console.Write("Monta kertaa kolikkoa heitetään? ");
            x = int.Parse(Console.ReadLine());

            for (y = 0; y < x;y++)
            {
                int result = rnd.Next(2);

                if (result == 1)
                {
                    Kruuna++;
                }

                else if (result == 0)
                {
                    Klaava++;
                }
            }

            Console.WriteLine("Kolikkoa on heitetty " + x + " kertaa.");
            Console.WriteLine("Klaavoja oli " + Klaava + " ja kruunuja " + Kruuna + ".");
            return;
        }
    }
}