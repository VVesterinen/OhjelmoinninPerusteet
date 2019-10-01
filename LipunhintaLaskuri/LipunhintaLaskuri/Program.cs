using System;

namespace LipunhintaLaskuri
{
    class Program
    {
        static void Main(string[] args)
        {

            double discount = 0;
            int originalPrice = 16;
            string varusmies;
            string opiskelija;
            string mtkjäsen;
            int age;

            Console.WriteLine("Pääsylippu hinnan laskuri");
            Console.Write("Oletko varusmies? Yes / No: ");
            varusmies = Console.ReadLine();

            if (varusmies.ToUpper() == "Yes");

            {
                discount = 0.5;
                Console.WriteLine($"Lipun hinta on {originalPrice - (discount * originalPrice)} €");
            }

            else

            {
                Console.Write("Oletko opiskelija? Yes / No: ");
                opiskelija = Console.ReadLine();

                    if (opiskelija.ToUpper() == "Yes") ;
                {
                    discount = 0.45;
                    
                }





            }
        }
    }
}
