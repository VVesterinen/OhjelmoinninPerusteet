using System;

namespace BBAN_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a BBAN:\n\n");
            String userInput = Console.ReadLine();
            userInput = userInput.Replace("-", "");
            int i = 0;
            Bank(userInput, ref i);
            PlusZero(ref userInput, i);

            if (Check(userInput))
                Console.WriteLine("This is a valid BBAN");
            else
                Console.WriteLine("This is not a valid BBAN");
        }

        static void Bank(String userInput, ref int i)
        {
            char firstNumber = userInput[0];
            if (firstNumber == '4' || firstNumber == '5' || firstNumber == '7')
            {
                i = 1;
            }
            else
            {
                i = 2;
            }
        }

        static void PlusZero(ref String userInput, int i)
        {
            if (i == 1)
            {
                while (userInput.Length < 14)
                {
                    userInput = userInput.Insert(7, "0");
                }
            }
            else
            {
                while (userInput.Length < 14)
                {
                    userInput = userInput.Insert(6, "0");
                }
            }
        }

        static bool Check(String userInputValue)
        {
            int Digits = userInputValue.Length;

            int Sum = 0;
            bool second = false;
            for (int i = Digits - 1; i >= 0; i--)
            {
                int n = userInputValue[i] - '0';

                if (second == true)
                    n = n * 2;

                Sum += n / 10;
                Sum += n % 10;

                second = !second;
            }
            return (Sum % 10 == 0);
        }
    }
}
