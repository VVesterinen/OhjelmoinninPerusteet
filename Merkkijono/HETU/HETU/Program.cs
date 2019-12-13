using System;

namespace HETU
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will ask your social-ID and will check it, " +
                "if its correct.");
            Console.WriteLine("Give your social-ID: ");
            String userInput = "17 04 999 - 581F ";
            userInput = RemoveSpaces(userInput);
            if (isValidLenght(userInput))
            {
                int idNumber = inputSplitter(userInput);
                char getLastChar = GetUserInputChkMark(userInput);
                bool isCorrect = isValidID(idNumber, getLastChar);
                PrintResult(isCorrect);
            }
        }
        static bool isValidDate(String userInput)
        {
            //170499-581F
            bool result = false;

            return true;
        }
        static bool isValidLenght(String userInput)
        {
            return userInput.Length == 11;
            // joko ^ tai alempi
            //if (userInput.Length == 11)
            //    return true;
            //else
            //    return false;
        }
        static String RemoveSpaces(String userInput)
        {
            String result = userInput.Replace(" ", "");
            return result;
        }
        static Char GetUserInputChkMark(String userInput)
        {
            return userInput[userInput.Length - 1];
        }
        static int inputSplitter(String userInput)
        {
            String remove = userInput.Remove(10, 1);
                   remove = remove.Remove(6, 1);
            return int.Parse(remove);
        }
        static bool isValidID(int idNumber, Char userInputChkMark)
        {
            String chkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            int modChecker = idNumber % 31;
            if (chkMark[modChecker] == userInputChkMark)
                return true;
            else
                return false;
        }
        static void PrintResult(bool isValidID)
        {
            if (isValidID)
                Console.WriteLine("Social-ID is correct.");
            else
                Console.WriteLine("Social-ID is incorrect.");
        }
    }
}