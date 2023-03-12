using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[5, 5];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j % 2 == 0)
                {
                    array[i, j] = 0;
                }
                else
                {
                    array[i, j] = 1;
                }
            }
        }

        // Массивын элементүүдийг хэвлэх
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
