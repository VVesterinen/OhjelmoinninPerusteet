using System;

namespace Taulukko3
{
    class Program
    {
        static void Main(string[] args)
        #region "all"
        {
            #region "first array"
            int[] numb = new int[10];
            intro();
            getNumbs(ref numb, 0, 20);
            printNumbs(numb);
            #endregion
            #region "second array"
            int[,] numb2 = new int[10, 20];
            getNumbs2(ref numb2, 0, 100);
            printNumbs2(numb2);
            #endregion
            #region "third array"
            int[] arrT_1 = new int[10];
            int[] arrT_2 = new int[10];
            int[] arrT_3 = new int[10];
            generateRandomNumbsForThreeArrays(ref arrT_1, ref arrT_2, ref arrT_3);
            printAllThreeArrayNumbs(arrT_1, arrT_2, arrT_3);
            #endregion           
        }
        #region "first program"
        static void getNumbs(ref int[] numb, int lowest, int highest)
        {
        #region "making random numbers"
            Random rnd = new Random();
            for (int i = 0; i < numb.Length; i++)
            {
                int rndNumb = rnd.Next(highest);
                if (numb[i] == 0)
                {
                    numb[i] = rndNumb;
                }
            }
        }
        #endregion
        #region "print numbers"
        static void printNumbs(int[] numb)
        {
            Console.WriteLine($"[X] = Arvo");
            for (int i = 0; i < numb.Length; i++)
                if (numb[i] < 10)
                {
                    Console.WriteLine($"[{i}] = 0{numb[i]} ");
                }
                else
                {
                    Console.WriteLine($"[{i}] = {numb[i]} ");
                }
        }
        #endregion
        #region "program intro"
        static void intro()
        {
            Console.WriteLine("This program gives 10 random number between 0 and 20.");
            Console.WriteLine("\nPress 'Right Arrow' to continue!\n");
            while (Console.ReadKey().Key != ConsoleKey.RightArrow) { }
        }
        #endregion
        #endregion
        #region "second program"
            static void getNumbs2(ref int[,] numb2, int x, int y)
            {
        #region "making two seperate variables"
            Random rnd = new Random();
                for (int i = 0; i < numb2.GetLength(0); i++)
                {
                    for (int j = 0; j < numb2.GetLength(1); j++)
                    {
                        numb2[i, j] = rnd.Next(100);
                    }
                }
            }
        #endregion
        #region "printing numbers"
        static void printNumbs2(int[,] numb2)
            {                
            Console.WriteLine("\n\nThis is the second program\n");
            Console.WriteLine("Press 'Right Arrow' to continue!\n");
            while (Console.ReadKey().Key != ConsoleKey.RightArrow) { }
            Console.WriteLine("[X, Y] = Arvo");
                for (int i = 0; i < numb2.GetLength(0); i++)
                {
                    for (int j = 0; j < numb2.GetLength(1); j++)
                    {
                        Console.WriteLine($"[{i}, {j:d2}] = {numb2[i, j]:d2}");
                    }
                }
            }
        #endregion
        #endregion
        #region "third program"
        #region "making random numbers"
        static void generateRandomNumbsForThreeArrays(ref int[] arrT_1, ref int[] arrT_2, ref int[] arrT_3)
        {
            Console.WriteLine("\n\nThis is the third program\n");
            Random rnd = new Random();
            for (int i = 0; i < arrT_1.Length; i++)
            {
                int rndNumb = rnd.Next(50);
                arrT_1[i] = rndNumb;
                int rndNumb2 = rnd.Next(50);
                arrT_2[i] = rndNumb2;
            }
        }
        #endregion
        #region "comparing and printing numbers"
        static void printAllThreeArrayNumbs(int[] arrT_1, int[] arrT_2, int[] arrT_3)
        {           
            for (int i = 0; i < arrT_1.Length; i++)
            {
                if (arrT_1[i] < arrT_2[i])
                {
                    arrT_3[i] = arrT_2[i];
                }
                else arrT_3[i] = arrT_1[i];                                 
            }
            Console.WriteLine("Press 'Right Arrow' to continue!\n");
            while (Console.ReadKey().Key != ConsoleKey.RightArrow) { }
            Console.Write("        ");
            for (int i = 1; i < 11; i++)
            {
                Console.Write($"{i:d2} ");
            }
            Console.WriteLine("\n        -----------------------------");
            Console.Write($"arrT_1: ");
            for (int i = 0; i < arrT_1.Length; i++)
            {
                Console.Write($"{arrT_1[i]:d2} ");
            }
            Console.Write($"\narrT_2: ");
            for (int i = 0; i < arrT_2.Length; i++)
            {
                Console.Write($"{arrT_2[i]:d2} ");
            }
            Console.Write($"\narrT_3: ");
            for (int i = 0; i < arrT_3.Length; i++)
            {
                Console.Write($"{arrT_3[i]:d2} ");
            }

        }
        #endregion
        #endregion
        #endregion
    }
}