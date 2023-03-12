/******************************************************************************

                            Code by hades_dev

*******************************************************************************/

using System;

namespace CountLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Console-ийн хэлбэр UTF8-р солих
            Console.WriteLine("Үг оруулна уу: ");
            string word = Console.ReadLine();

            int count = 0;
            foreach (char letter in word)
            {
                count++;
            }

            Console.WriteLine($"Үгийн урт: {count}");
            Console.ReadKey();
        }
    }
}
