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
            String userInput = Console.ReadLine();
            int idNumber = inputSplitter(userInput);
            bool isCorrect = isValidID(idNumber, 'F');
            PrintResult(isCorrect);
        }
        static int inputSplitter(String userInput)
        {
            String result = userInput.Substring(0, 6);
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