using System;

namespace FunktiotJaAliohjelmat3
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine("Give a number: ");
                String userInput = Console.ReadLine();

                isValid = numberFromRange(userInput, 1, 50);
            }

            if (isValid == true)
            {
                Console.WriteLine($"Your input {userInput} passes test.");
            }

            else
            {
                Console.WriteLine($"Your input {userInput} is out of range.");
            }

        }

        #region "Solve"
        static bool numberFromRange(String userValue, int lowerBound, int upperBound)

        {

            bool isInRange = false;
            try
            {

                if (userValue >= lowerBound && userValue <= upperBound)
                {
                    isInRange = true;
                }
            }
            return isInRange;
        }
        #endregion
    }
}
