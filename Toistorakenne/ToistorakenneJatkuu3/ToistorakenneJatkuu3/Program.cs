using System;

namespace ToistorakenneJatkuu3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int x = 0;
            int y = 1;

            while (y < 5)

            {
                Console.Write("Rivi " + y + ": ");

                while (x < 4)
                {
                    Console.Write(rnd.Next(50) + ", ");

                    x++;

                    if (x == 4)
                    {
                        Console.Write(rnd.Next(50) + ".");
                    }
                }

                x = 0;
                y++;
                Console.WriteLine();

            }
        }
    }
}
