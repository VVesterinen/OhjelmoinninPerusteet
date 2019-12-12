using System;

namespace HETU
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will ask your social-ID and will check it, " +
                "if its correct.");
            String userInput = "170499-581F";
            int idNumber = inputSplitter(userInput);
            isValidID(idNumber);
        }
        static int inputSplitter(String userInput)
        {
            String result = userInput.Substring(0, 6);
            String remove = userInput.Remove(10, 1);
                   remove = remove.Remove(6, 1);
            return int.Parse(remove);
        }
        static bool isValidID(int idNumber)
        {
            String chkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            int modChecker = idNumber % 31;
            Console.WriteLine(chkMark[modChecker]);
            return true;
        }
    }
}