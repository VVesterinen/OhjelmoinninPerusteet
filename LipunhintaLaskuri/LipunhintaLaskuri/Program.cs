using System;

namespace LipunhintaLaskuri
{
    class Program
    {
        static void Main()
        {
            double discount = 0;
            int basePrice = 16;
            string varusmies;
            string opiskelija;
            string mtkjasen;
            int age = 0;


            Console.WriteLine("Ticket counter.");
            Console.Write("Are you in the Army? Yes / No: ");
            varusmies = Console.ReadLine();

            if (varusmies.ToUpper() == "YES")
            {
                discount = 0.5;
                Console.WriteLine($"Ticket price is {basePrice - (discount * basePrice)} €");
            }

            else
            {
                    Console.Write("Are you a student? Yes / No: ");
                    opiskelija = Console.ReadLine();
                    Console.Write("Are you a member of Mtk? Yes / No: ");
                    mtkjasen = Console.ReadLine();

                if (opiskelija.ToUpper() == "YES" && mtkjasen.ToUpper() == "YES") 
                {
                    discount = 0.60;
                    Console.WriteLine($"Ticket price is {basePrice - (discount * basePrice)} €");
                }

                    else if (opiskelija.ToUpper() == "YES" && mtkjasen.ToUpper() == "NO") 
                    {
                        discount = 0.45;
                        Console.WriteLine($"Ticket price is {basePrice - (discount * basePrice)} €");
                    }

                    if (opiskelija.ToUpper() == "NO")
                    {
                    Console.Write("Your age is: ");
                    age=int.Parse(Console.ReadLine());

                    if (age <= 7)
                    {
                        discount = 1;
                        Console.WriteLine($"Ticket price is {basePrice - (discount * basePrice)} €");
                    }

                    else if (age > 65 || age <= 15)
                    {
                        discount = 0.50;
                        Console.WriteLine($"Ticket price is {basePrice - (discount * basePrice)} €");
                    }

                    else if (mtkjasen.ToUpper() == "YES")
                    {
                        discount = 0.15;
                        Console.WriteLine($"Ticket price is {basePrice - (discount * basePrice)} €");
                    }
                    
                    else
                    {
                        Console.WriteLine("Ticket price is 16€");
                    }
                }
            }
            Console.WriteLine("Thanks and byebye!");
        }
    }
}
