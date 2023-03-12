using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        string өгүүлбэр = "монгол улсын засгийн газрын дарга";
        string[] үгүүд = өгүүлбэр.Split(' ');
        string[] үг2 = үгүүд.Select(s => s.Substring(0, 2)).ToArray();
        Console.WriteLine(string.Join(", ", үг2));
    }
}
