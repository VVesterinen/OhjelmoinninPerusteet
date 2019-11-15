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

            String[] arrayString = new String[] { "Hello", "World", "Hei", "Maailma" };

            arrayString[1] = "Hello";





            /*
            //luetaan arvo taulukosta
            Console.WriteLine(numbers[2]);
            */

            //luetaan arvot silmukassa
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            // kutsutaan funktiota, joka asettaa arvot taulukkoon
            numbers = SetNumbers(5);
            Console.WriteLine("Kakkosen potenssi");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        /// <summary>
        /// Asettaa taulukkoon arvoja
        /// arraySize on taulukon koko
        /// Palauttaa 2 potenssit
        /// </summary>
        /// <returns></returns>
        static int[] SetNumbers(int arraySize)
        {
            int[] arrayPower = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                arrayPower[i] = (int)Math.Pow(2, i);
            }
            return arrayPower;
        }       
    }
}
