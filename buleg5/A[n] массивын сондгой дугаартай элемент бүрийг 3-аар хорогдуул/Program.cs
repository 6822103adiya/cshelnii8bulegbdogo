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

        for (int i = 0; i < n; i++)
        {
            if (A[i] % 2 != 0)
            {
                A[i] -= A[i] % 3;
            }
        }

        Console.WriteLine("3-аар хувааж сондгой дугаартай элементүүд: ");
        for (int i = 0; i < n; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write("{0} ", A[i]);
            }
        }
    }
}
