using System;

namespace ToistorakenneJatkuu
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tulostaa 1-10 ja niiden neliöjuuret.");
            Console.WriteLine("Luku   Neliöjuuri");


            double i = 0;

            while (i <= 10)
            {
                double neliojuuri = Math.Sqrt(i);
                Console.WriteLine("{0}      {1}", i, neliojuuri);
                i++;
            }
            return;
        }
    }
}