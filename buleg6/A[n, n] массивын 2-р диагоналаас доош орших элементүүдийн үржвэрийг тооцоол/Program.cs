using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("A массивын урт: ");
        int n = int.Parse(Console.ReadLine());

        int[,] A = new int[n, n];
        Console.WriteLine("A массивын элементүүдийг оруулна уу:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("A[{0},{1}] = ", i, j);
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int product = 1;
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (i + j == n - 1)
                {
                    product *= A[i, j];
                }
            }
        }

        Console.WriteLine("2-р диагоналаас доош орших элементүүдийн үржвэр: {0}", product);
    }
}
