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
                userChoise = UserInterface(); //kutustaa käyttöliittymän funktiota
                switch (userChoise)
                {
                    case 'T':
                        SSNchecker(); //kutsutaan hetun tarkastus funktiota
                        break;
                    case 'U':
                        SSNcreator(); //kutsutaa hetun luonti funktiota
                        break;
                    case 'X':

                        break;
                    default:
                        Console.WriteLine("\nPress one of the following T, U or X.");
                        Console.WriteLine("\nPress 'Enter' to continue.");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                        Console.Clear();
                        break;
                }
                Console.ReadLine();
            } while (userChoise != 'X');
        }
        static void SSNcreator()
        {
            Console.WriteLine("\n\nGive your new social-ID [DDMMYY-XXX]: ");
            String userInput = Console.ReadLine();
            userInput = RemoveSpaces(userInput);
            if (isValidLenght(userInput, 10))
            {
                if (isValidDate(userInput))
                {

                }
            }
        }
        static void SSNchecker()
        {
            Console.WriteLine("\n\nGive your social-ID [DDMMYY-XXXX]: ");
            String userInput = Console.ReadLine();
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
        static char UserInterface()
        {
            Console.WriteLine("Social-ID reading.");
            Console.WriteLine("[T] Check the validy of your social-ID.");
            Console.WriteLine("[U] Make a new social-ID.");
            Console.WriteLine("[X] Close the program.");
            Console.Write("Choose what to do. ");
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
        static bool isValidLenght(String userInput, int lenght)
        {
            return userInput.Length == lenght;
            
        }
            static String RemoveSpaces(String userInput)
        {
            String result = userInput.Replace(" ", "");
            result = result.Replace(".", "");
            return result;
        }
        static Char GetUserInputChkMark(String userInput)
        {
            return userInput[userInput.Length - 1];
        }
        static int inputSplitter(String userInput)
        {
            String remove = "";
            if (userInput.Length > 10)
            {
                remove = userInput.Remove(10, 1);
            }
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