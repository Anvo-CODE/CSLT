using System;

namespace bai17
{
    class Program
    {
        static void Main17(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập chuỗi: ");
            string a = Console.ReadLine();
            string[] b = a.Split(' ');
            Array.Reverse(b);
            string c = string.Join(" ", b);
            Console.WriteLine("Chuỗi sau khi đảo ngược: " + c);
        }
    }
}
