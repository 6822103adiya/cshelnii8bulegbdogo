using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int sum = 0;

        // 20-100 хүртэлх бүх тоонуудыг шалгах
        for (int i = 20; i <= 100; i++)
        {
            // 3-д хувааж үлдэгдэл нь 0, 2-д хувааж үлдэгдэл нь 0, 4-д хувааж үлдэгдэл нь 0, 8-д хувааж үлдэгдэл нь 0 байх ёстой
            if (i % 3 == 0 && i % 2 == 0 && i % 4 == 0 && i % 8 == 0)
            {
                sum += i;
            }
        }

        Console.WriteLine("2, 4, 8-аар төгссөн бүх тоонуудын нийлбэр: " + sum);
        Console.ReadLine();
    }
}
