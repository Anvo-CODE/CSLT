/*to separate individual characters from a string.*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_10
{
    internal class bai3
    {
        static char[] Tachchuoi(string a)
        {
            return a.ToCharArray();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập một chuỗi: ");
            string input = Console.ReadLine();
            char[] result = Tachchuoi(input);
            Console.WriteLine("Các ký tự trong chuỗi:");
            foreach (char c in result)
            {
                Console.WriteLine(c);
            }

        }
    }
}
