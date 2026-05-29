/*to input a string and print it.*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace CSLT.Exercise_10
{
    internal class bai1
    {
        static string inhchuoi(string str)
        {
            return str;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập một chuỗi: ");
            string input = Console.ReadLine();
            string ketqua = inhchuoi(input);
            Console.WriteLine($"Kết quả: {ketqua}");
        }
    }
}
