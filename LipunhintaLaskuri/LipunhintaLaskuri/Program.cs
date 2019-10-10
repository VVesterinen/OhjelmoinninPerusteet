using System;

namespace LipunhintaLaskuri
{
    class Program
    {
        static void Main()
        {
            double discount = 0;
            int basePrice = 16;
            string armyMan;
            string student;
            string memberMTK;
            int age = 0;
            
            Console.WriteLine("Ticket counter.");
            Console.Write("Are you in the Army? Yes / No: ");
            armyMan = Console.ReadLine().ToUpper().Trim();

            if (armyMan[0] == 'Y')
            {
                discount = 0.5;
                Console.WriteLine($"Ticket price is {basePrice - (discount * basePrice)} €");
            }

            else
            {
                    Console.Write("Are you a student? Yes / No: ");
                    student = Console.ReadLine().ToUpper().Trim();
                    Console.Write("Are you a member of Mtk? Yes / No: ");
                    memberMTK = Console.ReadLine().ToUpper().Trim();

                if (student[0] == 'Y' && memberMTK[0] == 'Y') 
                {
                    discount = 0.60;
                    Console.WriteLine($"Ticket price is {basePrice - (discount * basePrice)} €");
                }

                    else if (student[0] == 'Y' && memberMTK[0] == 'N') 
                    {
                        discount = 0.45;
                        Console.WriteLine($"Ticket price is {basePrice - (discount * basePrice)} €");
                    }

                    if (student[0] == 'N')
                    {
                    Console.Write("Your age is: ");
                    age=int.Parse(Console.ReadLine());

                    if (age < 7)
                    {
                        discount = 1;
                        Console.WriteLine("Ticket is free");
                    }

                    else if (age > 65 || age <= 15)
                    {
                        discount = 0.50;
                        Console.WriteLine($"Ticket price is {basePrice - (discount * basePrice)} €");
                    }

                    else if (memberMTK[0] == 'Y')
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
            Console.WriteLine("");
            Console.WriteLine("Thanks and bye!");
        }
    }
}
