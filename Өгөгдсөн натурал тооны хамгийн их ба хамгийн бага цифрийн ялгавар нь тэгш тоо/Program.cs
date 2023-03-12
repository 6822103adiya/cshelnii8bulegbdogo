using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Тоо оруулна уу: ");
        int number = int.Parse(Console.ReadLine());

        int minDigit = 9;
        int maxDigit = 0;

        while (number != 0)
        {
            int digit = number % 10;

            if (digit % 2 == 1)
            {
                if (digit < minDigit)
                {
                    minDigit = digit;
                }
                if (digit > maxDigit)
                {
                    maxDigit = digit;
                }
            }

            number /= 10;
        }

        if (minDigit % 2 == 0 && maxDigit % 2 == 0)
        {
            Console.WriteLine("Хамгийн их ба хамгийн бага цифрийн ялгавар тэгш тоо биш байна.");
        }
        else
        {
            Console.WriteLine("Хамгийн их ба хамгийн бага цифрийн ялгавар тэгш тоо мөн байна.");
        }
    }
}
