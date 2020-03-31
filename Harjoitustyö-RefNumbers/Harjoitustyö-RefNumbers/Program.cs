using System;
using System.IO;

namespace Harjoitustyö
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            String input = String.Empty;

            char userChoise;
            do
            {
                Console.Clear();
                userChoise = UserInterface();
                switch (userChoise)
                {
                    case '1':
                        try
                        {
                            input = InputValue(input, 4, 20);
                            if (CheckReferenceNumb(input) == true && IsNumb(input) == true && ValidLength(input, 4, 20) == true && firstNumbZero(input) == true)
                            {

                                Console.WriteLine($"Your input {AddSpaces(input)} is valid reference number.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid ref number");
                            }
                            Console.WriteLine("\nPress 'Enter' to continue.");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                        }
                        catch
                        {
                            Console.WriteLine("Wrong input, press 'Enter' to continue!");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                        }
                        break;
                    case '2':
                        try
                        {
                            input = InputValue(input, 3, 19);
                            if (IsNumb(input) == true && ValidLength(input, 3, 19) == true && firstNumbZero(input) == true)
                            {
                                CreateManyRefNumb(input, 1);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                            }
                            Console.WriteLine("\nPress 'Enter' to continue.");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                        }
                        catch
                        {
                            Console.WriteLine("Wrong input, press 'Enter' to continue!");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                        }
                        break;
                    case '3':
                        try
                        {
                            Console.WriteLine("How many: ");
                            int count = int.Parse(Console.ReadLine());
                            Console.WriteLine("Base numb?");
                            String baseNumb = Console.ReadLine();
                            if (IsNumb(baseNumb) == true && ValidLength(baseNumb, 3, 19) == true && firstNumbZero(input) == true)
                            {
                                CreateManyRefNumb(baseNumb, count);
                            }
                            else
                            {
                                Console.WriteLine("Invalid basenumber.");
                            }
                            Console.WriteLine("\nPress 'Enter' to continue.");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                        }
                        catch
                        {
                            Console.WriteLine("Wrong input, press 'Enter' to continue!");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                        }
                        break;
                    case '4':
                        try
                        {
                            Console.WriteLine();
                            ReadFile(@"RefNumberBank.txt");
                            Console.WriteLine("\nPress 'Enter' to continue.");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                        }
                        catch
                        {
                            Console.WriteLine("Folder is empty, press 'Enter' to continue!");
                            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                        }
                        break;
                    case 'X':
                        break;

                    default:
                        Console.WriteLine("\nPress 'Enter' to continue.");
                        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                        break;
                }
            } while (userChoise != 'X');
        }

        static char UserInterface()
        {
            Console.WriteLine("---> Reference number interface <---" +
                                "\n\n[1] Check reference number." +
                                "\n[2] Create new reference number." +
                                "\n[3] Create many ref numb." +
                                "\n[4] Read saved ref numbers." +
                                "\n[X] Close program." +
                                "\nChoose what to do: ");
            return char.ToUpper(Console.ReadKey().KeyChar);
        }

        public static String ReverseString(String inputValue)
        {
            char[] arr = inputValue.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }

        static String AddSpaces(String inputValue)
        {
            String input = ReverseString(inputValue);

            for (int i = 5; i <= input.Length; i += 5)
            {
                input = input.Insert(i, " ");
                i++;
            }
            return ReverseString(input);
        }

        static bool firstNumbZero(String inputValue)
        {
            if (inputValue[0].ToString() != "0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static String InputValue(String inputValue, int minValue, int maxValue)
        {
            Console.WriteLine($"\nInput may only be numbers and it must be between numbers {minValue} to {maxValue}");
            Console.WriteLine("Input: ");
            String input = Console.ReadLine();
            input = input.Replace(" ", "");
            input = input.Replace(",", "");
            input = input.Replace(".", "");
            return input;
        }

        static bool ValidLength(String input, int minValue, int maxValue)
        {
            if (input.Length < minValue || input.Length > maxValue)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static bool IsNumb(String inputValue)
        {
            int n = 0;
            for (int i = 0; i < inputValue.Length; i++)
            {
                bool tryParse = int.TryParse(inputValue[i].ToString(), out _);
                if (tryParse == false)
                    n++;
            }
            if (n == 0)
                return true;
            else
                return false;
        }

        static void CreateManyRefNumb(String baseNumbValue, int countValue)
        {
            int i = 0;
            String path = @"RefNumberBank.txt";
            String baseNumb = baseNumbValue;

            for (int i2 = 0; i2 < countValue; i2++)
            {
                if ((CheckReferenceNumb(baseNumb + i) == true))
                {
                    Console.WriteLine($"{baseNumb}{i} is a new reference number");
                    WriteToFile(path, baseNumb + i);
                    i++;
                }
                else
                {
                    i++;
                    i2--;
                }
            }
        }

        static void CreateRefNumb(String input)
        {
            int i = 0;
            if (CheckReferenceNumb(input) == true && IsNumb(input) == true && ValidLength(input, 4, 20) == true)
            {
                Console.WriteLine($"New reference number is: {input}");
                WriteToFile(@"RefNumberBank.txt", input + i);

            }
            else if (CheckReferenceNumb(input) == false)
                while (CheckReferenceNumb(input) == false)
                {
                    if (CheckReferenceNumb(input + i) == false)
                    {
                        i++;
                    }
                    else
                    {
                        input += i;
                        Console.WriteLine($"New reference number is: {input}");
                        WriteToFile(@"RefNumberBank.txt", input);
                    }
                }
        }
        
        static bool CheckReferenceNumb(String inputValue)
        {
            int summary = 0;
            char lastNumb;               
            int numbLength = 0;
            numbLength = inputValue.Length;
            lastNumb = inputValue[numbLength - 1];
            inputValue = inputValue.Remove(numbLength - 1, 1);

            int n = 3;
            for (int i = inputValue.Length - 1; i >= 0; i--)   
            {                                          
                if (n == 3)
                {
                    summary = summary + int.Parse(inputValue[i].ToString()) * 7;
                    n--;
                }
                else if (n == 2)
                {
                    summary = summary + int.Parse(inputValue[i].ToString()) * 3;
                    n--;
                }
                else if (n == 1)
                {
                    summary = summary + int.Parse(inputValue[i].ToString()) * 1;
                    n = 3;
                }
            }
            int numbValidator = summary + int.Parse(lastNumb.ToString());
            if (numbValidator % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void WriteToFile(String path, String inputValue)
        {
            using StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(inputValue);
        }

        static void ReadFile(String path)
        {
            using StreamReader sr = File.OpenText(path);
            String s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}