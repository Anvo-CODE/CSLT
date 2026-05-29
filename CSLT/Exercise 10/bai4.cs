/*to print individual characters of the string in reverse order.*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_10
{
    internal class bai4
    {
        static String Daochuoi(string a)
        {
            for (int b = a.Length - 1; b >= 0; b--)
            {
                Console.WriteLine(a[b]);
            }
            return a;
        }
static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập một chuỗi: ");
            string input = Console.ReadLine();
            Daochuoi(input);
        }
    }
}

