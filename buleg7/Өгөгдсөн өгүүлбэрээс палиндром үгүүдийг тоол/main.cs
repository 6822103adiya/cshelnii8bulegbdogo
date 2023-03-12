using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Өгүүлбэр: ");
        string өгүүлбэр = Console.ReadLine().ToLower();
        string[] үгүүд = өгүүлбэр.Split(' ');
        int палиндром_үгүүдийн_тоо = 0;
        foreach (string үг in үгүүд)
        {
            bool палиндром_эсэх = true;
            for (int i = 0; i < үг.Length / 2; i++)
            {
                if (үг[i] != үг[үг.Length - i - 1])
                {
                    палиндром_эсэх = false;
                    break;
                }
            }
            if (палиндром_эсэх)
            {
                палиндром_үгүүдийн_тоо++;
            }
        }
        Console.WriteLine("Палиндром үгүүдийн тоо: {палиндром_үгүүдийн_тоо}");
    }
}
