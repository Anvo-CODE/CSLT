using System;
namespace bai4;

public class program
{
    static void Main4(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("nhập chuỗi muốn chuyển thành chữ thường");
        string a = Console.ReadLine();
        string b = a.ToLower();
        Console.WriteLine("chuỗi sau khi chuyển thành chữ thường là: {0}", b);
    }
}
