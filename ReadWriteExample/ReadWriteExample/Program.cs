using System;

namespace ReadWriteExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ReadWriteExample");
            Console.Write("Your name; ");
            string userInput = Console.ReadLine();

            Console.WriteLine("--------------------------");

            Console.WriteLine("Excuse me " + userInput + ", can you hear me?");
            Console.WriteLine("Excuse me {0}, can you hear me?", userInput);
            Console.WriteLine($"Excuse me {userInput}, can you hear me?");





        }




    }
}
