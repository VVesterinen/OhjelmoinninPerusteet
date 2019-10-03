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
            int age = 0;



            Console.WriteLine("Pääsylippu hinnan laskuri");
            Console.Write("Oletko varusmies? Yes / No: ");
            varusmies = Console.ReadLine();

            if (varusmies.ToUpper() == "Yes") ;

            {
                discount = 0.5;
                Console.WriteLine($"Lipun hinta on {originalPrice - (discount * originalPrice)} €");
            }

              else if (varusmies.ToUpper() == "No") ;

            {
                Console.Write("Oletko opiskelija? Yes / No: ");
                opiskelija = Console.ReadLine();
                Console.Write("Oletko Mtk:n jäsen? Yes / No: ");
                mtkjäsen = Console.ReadLine();

                if (opiskelija.ToUpper() == "Yes" && mtkjäsen.ToUpper() == "Yes") ;
                {
                    discount = 0.60;
                    Console.WriteLine($"Lipun hinta on {originalPrice - (discount * originalPrice)} €");
                }

                if (opiskelija.ToUpper() == "Yes" && mtkjäsen.ToUpper() == "No") ;
                {
                    discount = 0.45;
                    Console.WriteLine($"Lipun hinta on {originalPrice - (discount * originalPrice)} €");
                }





            }
        }
    }
}
