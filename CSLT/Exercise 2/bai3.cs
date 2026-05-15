using System;
namespace bai3;

class Program
{
    static void Main3(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("nhập câu muốn đảo: ");
        String câu = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(câu))
        { Console.WriteLine("Vui lòng nhập câu"); }
        else
        {
            string đầu = câu.Substring(0, 1);
            Console.WriteLine($"{đầu}{câu}{đầu}");
        }
    }
}
