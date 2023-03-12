using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("A массивын урт: ");
        int n = int.Parse(Console.ReadLine());

        int[] A = new int[n];
        Console.WriteLine("A массивын элементүүдийг оруулна уу:");

        for (int i = 0; i < n; i++)
        {
            Console.Write("A[{0}] = ", i);
            A[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            if (A[i] % 2 == 0)
            {
                sum += A[i];
            }
        }

        Console.WriteLine("A массивын тэгш элементүүдийн нийлбэр: {0}", sum);
    }
}
