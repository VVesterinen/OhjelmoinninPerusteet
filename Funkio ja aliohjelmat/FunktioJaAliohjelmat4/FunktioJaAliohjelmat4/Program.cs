using System;

namespace FunktioJaAliohjelmat4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Input());
        }

        static String Input()
        {
            int userInput;
            int maxNumb = 1;
            int highNumb = 0;
            int count = 1;
            String output = "";
            String lastOutput = "";

            Console.WriteLine("Give 10 Numbers: ");
            while (count <= 10)
            {
                Console.Write($"{count}. ");
                userInput = int.Parse(Console.ReadLine());
                if (userInput > 0)
                {
                    if (userInput > highNumb)
                    {
                        highNumb = userInput;
                        maxNumb = count;
                    }
                    output += ($"{userInput} ");
                    count++;
                }
                else if (userInput < 0)
                {
                    Console.WriteLine("Input a positive number.");
                }
                else
                {
                    Console.WriteLine("Number can't be 0.");
                }                
                    lastOutput = $"You gave the following numbers: {output}\n Highest number was {maxNumb} and it was the {highNumb}. number.";            
            }
            return lastOutput;
        }
    }
}