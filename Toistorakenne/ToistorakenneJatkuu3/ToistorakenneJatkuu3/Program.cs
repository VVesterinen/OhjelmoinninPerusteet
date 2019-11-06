using System;

namespace ToistorakenneJatkuu3
{
    class Program
    {
        static void Main(string[] args)
        {


            #region "Number generator"
            Console.WriteLine("Random Numbergenerator.");
            Console.WriteLine();

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
            #endregion
        }
    }
}