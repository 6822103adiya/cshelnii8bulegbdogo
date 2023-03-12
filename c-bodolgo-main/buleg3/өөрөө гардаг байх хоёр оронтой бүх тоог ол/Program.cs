using System;

namespace SumOfDigitSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("n тоог оруулна уу: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Буруу утга орууллаа. n тоог дахин оруулна уу: ");
            }

            Console.WriteLine("n язгуурын доор байгаа хоёр оронтой тоонууд: ");
            for (int i = 1; i <= n; i++)
            {
                int digitSum = SumOfDigitSquares(i);
                int squaredDigitSum = digitSum * digitSum;
                if (squaredDigitSum == i)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }

        static int SumOfDigitSquares(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;
                sum += digit * digit;
                number /= 10;
            }
            return sum;
        }
    }
}
