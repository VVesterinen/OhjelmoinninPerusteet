using System;

namespace FunktiotJaAliohjelmat3
{
    class Program
    {
        static void Main(string[] args)
        {
            String userInput = "";
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine("Give a number: ");
                userInput = Console.ReadLine();
                isValid = numberFromRange(userInput, 1, 50);   
            }
        }
        #region "Solve"
        static bool numberFromRange(String userInput, int lowerBound, int upperBound)
        {
            bool isInRange = false;
            try
            {
                int userValue = int.Parse(userInput);
                if (userValue >= lowerBound && userValue <= upperBound)
                {
                    Console.WriteLine($"Your input {userInput} passes test.");
                    isInRange = true;
                }
                else
                {
                    Console.WriteLine($"Your input {userInput} is out of range.");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Your input was not a number.");
            }
            return isInRange;
        }
        #endregion
    }
}
