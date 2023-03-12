using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("n тоо: ");
        int n = int.Parse(Console.ReadLine());

        bool[] primes = new bool[n + 1];
        for (int i = 2; i <= n; i++)
        {
            primes[i] = true;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (primes[i])
            {
                for (int j = i * i; j <= n; j += i)
                {
                    primes[j] = false;
                }
            }
        }

        Console.WriteLine("{n}-ээс бага бүх Мерсений тоон дөрвөлүүд:");
        for (int i = 2; i <= n; i++)
        {
            if (primes[i] && primes[i + 2])
            {
                Console.WriteLine("{i}, {i + 2}");
            }
        }

        Console.ReadLine();
    }
}
