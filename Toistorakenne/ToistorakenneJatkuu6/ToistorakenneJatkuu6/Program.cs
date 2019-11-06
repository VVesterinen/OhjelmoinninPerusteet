using System;

namespace ToistorakenneJatkuu6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Dice throw generator.");
            Console.WriteLine();

            Random rnd = new Random();
            int six = 0;

            for (int n = 1; n <= 1000; n++)
            {
                int result = rnd.Next(6);
                Console.WriteLine($"{n}. {result + 1}");

                if (result + 1 == 6)
                {
                    six++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Six was thrown {six} times.");
            return;
        }
    }
}