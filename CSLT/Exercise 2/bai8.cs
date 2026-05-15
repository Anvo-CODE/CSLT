using System;
namespace Find_Longest_Word_in_String;

public class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập chuỗi: ");
        string a = Console.ReadLine();
        string[] b = a.Split(' ');
        string c = "";
        foreach (string s in b)
        {
            if (s.Length > c.Length)
            {
                c = s;
            }
        }
        Console.WriteLine("từ dài nhất chuỗi" + c);
    }
}