﻿using System;

namespace ToistorakenneJatkuu2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Tulostaa kertotaulun 1*1 - 9*9:");
            Console.WriteLine("");

                int i = 1;
                int n = 1;

                while (n < 10 && i < 10)

                {

                    Console.WriteLine(i + " x " + n + " = " + i * n);
                    i++;

                    if (i == 10)

                    {
                        n++;
                        i = 1;
                    }
                }


                if (n == 10)

                {
                    return;
                }
        }
    }
}
