using System;

class Program
{
    static void Main(string[] args)
    {
        // Массив үүсгэх
        int n = 5;
        int m = 5;
        int[,] A = new int[n, m];

        // Элементүүдийг утгаар олгох
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                A[i, j] = i * m + j + 1;
            }
        }

        // Тэгш элементүүдийг өсөх дарааллаар эрэмбэлэх
        int[] evenNumbers = new int[n * m / 2];
        int evenIndex = 0;

        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                if (A[i, j] % 2 == 0)
                {
                    evenNumbers[evenIndex] = A[i, j];
                    evenIndex++;
                }
            }
        }

        // Тэгш элементүүдийг өсөх дарааллаар эрэмбэлэх
        for (int i = 0; i < evenNumbers.Length; i++)
        {
            for (int j = i + 1; j < evenNumbers.Length; j++)
            {
                if (evenNumbers[i] > evenNumbers[j])
                {
                    int temp = evenNumbers[i];
                    evenNumbers[i] = evenNumbers[j];
                    evenNumbers[j] = temp;
                }
            }
        }

        // Тэгш элементүүдийг хэвлэх
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Тэгш элементүүдийн жагсаалт:");
        for (int i = 0; i < evenNumbers.Length; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }

        Console.ReadLine();
    }
}
