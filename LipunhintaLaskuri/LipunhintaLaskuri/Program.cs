using System;

namespace LipunhintaLaskuri
{
    class Program
    {
        static void Main()
        {

            double discount = 0;
            int x = 16;
            string varusmies;
            string opiskelija;
            string mtkjasen;
            int y = 0;



            Console.WriteLine("Pääsylippu hinnan laskuri");
            Console.Write("Oletko varusmies? Yes / No: ");
            varusmies = Console.ReadLine();

            if (varusmies.ToUpper() == "YES")

            {
                discount = 0.5;
                Console.WriteLine($"Lipun hinta on {x - (discount * x)} €");
            }

            else

            {
                    Console.Write("Oletko opiskelija? Yes / No: ");
                    opiskelija = Console.ReadLine();
                    Console.Write("Oletko Mtk:n jäsen? Yes / No: ");
                    mtkjasen = Console.ReadLine();

                if (opiskelija.ToUpper() == "YES" && mtkjasen.ToUpper() == "YES") 
                    {
                        discount = 0.60;
                        Console.WriteLine($"Lipun hinta on {x - (discount * x)} €");
                    }

                    else if (opiskelija.ToUpper() == "YES" && mtkjasen.ToUpper() == "NO") 
                    {
                        discount = 0.45;
                        Console.WriteLine($"Lipun hinta on {x - (discount * x)} €");
                    }

                if (opiskelija.ToUpper() == "NO")
                {
                    Console.Write("Syötä ikäsi: ");
                    y=int.Parse(Console.ReadLine());

                    if (y <= 7)
                    {
                        discount = 1;
                        Console.WriteLine($"Lipun hinta on {x - (discount * x)} €");
                    }

                    if (y > 65 || y <= 15)
                    {
                        discount = 0.50;
                        Console.WriteLine($"Lipun hinta on {x - (discount * x)} €");
                    }
                    

                }


            }
        }
    }
}
