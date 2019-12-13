using System;

namespace HETU
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("This program will ask your social-ID and will check it, " +
            //     "if its correct.");
            char userChoise;
            do
            {
                Console.Clear();
                userChoise = UserInterface();
                switch (userChoise)
                {
                    case 'T':

                        break;
                    case 'U':

                        break;
                    default:
                        Console.WriteLine("Press one of the following T, U or X.");
                        break;
                } while (userChoise != 'X') ;

                String userInput = "17 04 99 B 581F ";
                userInput = RemoveSpaces(userInput);
                if (isValidLenght(userInput))
                {
                    if (isValidDate(userInput))
                    {
                        int idNumber = inputSplitter(userInput);
                        char getLastChar = GetUserInputChkMark(userInput);
                        bool isCorrect = isValidID(idNumber, getLastChar);
                        PrintResult(isCorrect);
                    }
                }
                else
                {
                    Console.WriteLine("Check your social-ID again.");
                }
            }
        }
        static char UserInterface()
        {
            Console.WriteLine("Social-ID reading.");
            Console.WriteLine("[T] Check the validy of your social-ID.");
            Console.WriteLine("[U] Make a new social-ID.");
            Console.WriteLine("[X] Close the program.");
            Console.Write("Choose what to do.");
            return char.ToUpper(Console.ReadKey().KeyChar);
        }
        static bool isValidDate(String userInput)
        {
            //170499-581F
            bool result = false;
            String day = userInput.Substring(0, 2);
            String month = userInput.Substring(2, 2);
            String year = userInput.Substring(4, 2);
            String century = userInput.Substring(6, 1);
            #region "century"
            if (century == "-")
            {
                year = "19" + year;
            }
            else if (century == "A")
            {
                year = "20" + year;
            }
            else
            {
                Console.WriteLine("Are you a wizard Harry?");
                return result;  //keskeyttää ohjelman komennolla "return"
            }
            #endregion
            // tarkastetaan päivämäärän oikeellisuus try-catch lohkossa
            try
            {
                DateTime birthday = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
                result = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
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