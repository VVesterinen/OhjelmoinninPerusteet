using System;

namespace ProjektiYhteenlasku
{
    class Program
    {
        static void Main(string[] args)
        {

            int luku;
            int vastaus = 0;
            int i = 0; 


            Console.WriteLine("Yhteenlasku laskuri");
            Console.Write("Syötä luku: ");
            luku = int.Parse(Console.ReadLine());

            if (luku >= 1)
            {
                while (i <= luku)
                {
                    vastaus = (vastaus + i);
                    i++;
                }
                Console.WriteLine("Vastaus on: " + vastaus);

            }

            else
            {
                Console.WriteLine("Virheellinen syöte!");
            }

        }
    }
}
