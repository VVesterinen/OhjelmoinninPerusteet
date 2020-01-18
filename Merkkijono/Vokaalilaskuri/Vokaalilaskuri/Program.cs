using System;

namespace Vokaalilaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro()
;
            String vocals = "AEIOUYÄÖ";
            String userInput = Console.ReadLine();
            int i = userInput.Length;
            int vocalCount = 0;

            for (int n = 0; n < i; n++)
            {
                for (int nn = 0; nn < vocals.Length; nn++)
                {
                    if (userInput.ToUpper()[n] == vocals[nn])
                    {
                        vocalCount++;
                    }
                }
            }

            Console.WriteLine($"Your {userInput} has {vocalCount} vocals in it.");
        }

        static void Intro()
        {
            Console.WriteLine("Write a word or a sentince. This program will count how many vocals is in it.");
        }
    }
}
