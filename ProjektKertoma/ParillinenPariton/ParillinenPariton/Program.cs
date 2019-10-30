﻿using System;

namespace ParillinenPariton
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Parillisten ja parittomien lukujen summien yhteenlasku kone.");
            Console.Write("Syötä luku: ");
            int luku = int.Parse(Console.ReadLine());

            int i = 0;
            int pariton = 0;
            int parillinen = 0;

            if (luku >= 1)
            {
                while (i <= luku)
                {
                    if (i % 2 == 0)
                    {
                        parillinen = parillinen + i;
                    }

                    else
                    {
                        pariton = pariton + i;
                }
                i++;
            }

                Console.WriteLine("Vastaus: Pariton summa = " + pariton + "," +
                    " Parillisten summa = " + parillinen + ".");

            }

           else if (luku == 0)
            {
                Console.WriteLine("Vastaus on 0");
            }

            else if (luku <= -1)
            {
                while (i >= luku)
                {
                    if (i % 2 == 0)
                    {
                        parillinen = parillinen + i;
                    }

                    else
                    {
                        pariton = pariton + i;
                    }
                    i--;
                }

                Console.WriteLine("Vastaus: Pariton summa = " + pariton + "," +
                     " Parillisten summa = " + parillinen + ".");

            }
        }
    }
}
