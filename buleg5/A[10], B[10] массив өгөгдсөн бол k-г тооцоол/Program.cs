using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] B = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        int n = 10;

        double sum1 = 0, sum2 = 0;
        for (int i = 0; i < n; i++)
        {
            sum1 += Math.Sqrt(A[i] + B[i]) / (2 * n);
            sum2 += (A[i] * A[i] + B[i] * B[i]) / (10 * 2);
        }

        double k = sum1 + sum2;
        Console.WriteLine("k = {0}", k);
    }
}