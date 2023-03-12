using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Хэмжээг орж ирэх
        Console.Write("n-ийн утгаа оруулна уу: ");
        int n = int.Parse(Console.ReadLine());

        // n x n хэмжээтэй массив үүсгэх
        int[,] arr = new int[n, n];

        // Массивын 1-р диагонаалаас дээш байрлаж буй бүхэл тоонуудыг 1 болгох
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                arr[i, j] = 1;
            }
        }

        // Массивыг хэвлэх
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
