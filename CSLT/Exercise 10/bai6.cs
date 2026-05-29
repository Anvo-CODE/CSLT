/*to compare two strings without using a string library functions.*/ 

using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_10
{
    internal class bai6
    {
        static int Sosanh(string n, string m)
        {
            if (n.Length < m.Length)
            {
                return 1;
            }
            else if (n.Length > m.Length)
            {
                return -1;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập chuỗi n:");
            string n = Console.ReadLine();
            Console.WriteLine("nhập chuỗi m:");
            string m = Console.ReadLine();
            string ketqua = Sosanh(n, m).ToString();
            if (ketqua == "1")
            {
                Console.WriteLine($"kết quả là: {n} < {m}");
            }
            else if (ketqua == "-1")
            {
                Console.WriteLine($"kết quả là: {n} > {m}");
            }
            else
            {
                Console.WriteLine($"kết quả là: {n} = {m}");
            }
        }
    }
}

