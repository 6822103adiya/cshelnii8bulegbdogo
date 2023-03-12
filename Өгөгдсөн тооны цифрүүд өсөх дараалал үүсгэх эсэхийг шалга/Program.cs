using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Тоо оруулна уу: ");
        int number = int.Parse(Console.ReadLine());

        string digits = number.ToString(); // тооны цифрүүдийг string хэлбэрээр авах
        bool isIncreasing = true; // дараалал өсөх гэдгийг шалгах хувьсагч

        // цифрүүдийн дараалалыг шалгах
        for (int i = 0; i < digits.Length - 1; i++)
        {
            if (digits[i] >= digits[i + 1]) // хоёр цифр харьцуулж байвал
            {
                isIncreasing = false; // дараалал өсөхгүй гэж тэмдэглэх
                break; // циклээс гарах
            }
        }

        if (isIncreasing)
        {
            Console.WriteLine("Дараалал өсөх дараалал юм.");
        }
        else
        {
            Console.WriteLine("Дараалал өсөх дараалал биш юм.");
        }

        Console.ReadLine();
    }
}
