using System;

namespace Taulukot
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Taulukko esimerkki");

            //luodaan numbers taulukko.
            int[] numbers = new int[] { 1, 3, 5, 7, 9 };

            //asetetaan arvo numbers taulukkoon
            numbers[4] = 11;

            
            //luetaan arvo taulukosta
            Console.WriteLine(numbers[2]);
            

            //luetaan arvot silmukassa
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        
    }
}
