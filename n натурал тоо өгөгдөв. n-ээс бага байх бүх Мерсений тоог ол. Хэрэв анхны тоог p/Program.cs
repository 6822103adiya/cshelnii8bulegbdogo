using System;
using System.Text;

class Program
{
    static bool IsPrime(int n)
    {
        if (n < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static int MersennePrime(int p)
    {
        if (IsPrime(p))
        {
            return (int)Math.Pow(2, p) - 1;
        }
        return -1;
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // n-ээс бага бүх Мерсений тоонуудыг олох
        Console.Write("n-г оруулна уу: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("n-ээс бага бүх Мерсений тоонууд: ");
        for (int p = 2; p <= n; p++)
        {
            int m = MersennePrime(p);
            if (m != -1)
            {
                Console.Write(m + " ");
            }
        }
        Console.ReadLine();
    }
}
