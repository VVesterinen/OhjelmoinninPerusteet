using System;

namespace Itsearviointi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Task1"
            Console.Write("Write a text: ");
            String text = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(text);
            }
            Console.WriteLine();
            #endregion
            #region "Task2"
            Console.Write("Give another text: ");
            String text2 = Console.ReadLine();

            for (int i = 0; i < text2.Length; i++)
            {
                Console.WriteLine(text2);
            }
            Console.WriteLine();
            #endregion
            #region "Task3"
            Console.Write("Give numbers, (-1) will end the task: ");
            int number = 0;
            int sumUp = 0;

            while (number != -1)
            {
                number = int.Parse(Console.ReadLine());
                sumUp += number;
            }
            Console.WriteLine($"Sumup of the numbers given is {sumUp + 1}.");
            Console.WriteLine();
            #endregion
            #region "Task4"
            Console.WriteLine("Give two numbers:");
            Console.Write("First number: ");
            Double first = Double.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            Double second = Double.Parse(Console.ReadLine());

            Console.WriteLine($"{first} + {second} = {first + second}");
            Console.WriteLine($"{first} - {second} = {first - second}");
            Console.WriteLine($"{first} * {second} = {first * second}");
            Console.WriteLine($"{first} / {second} = {first / second}");
            #endregion
        }
    }
}
