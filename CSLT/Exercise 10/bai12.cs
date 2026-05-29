/*to find the number of times a substring appears in a given string.*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CSLT.Exercise_10
{
    internal class bai12
    {
        static int Demsolan(string a, string b)
        {
            int count = 0;
            for (int i = 0; i < a.Length - b.Length; i++)
            {
                int j = 0;
                for (j = 0; j < b.Length; j++)
                {
                    if (a[i + j] != b[j])
                    {
                        break;
                    }
                }
                if (j == b.Length)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào chuỗi chính:");
            string str = Console.ReadLine();
            Console.WriteLine("Nhập vào chuỗi con:");
            string sub = Console.ReadLine();
            int ketqua = Demsolan(str, sub);
            Console.WriteLine($"kết quả là: Chuỗi con '{sub}' xuất hiện {ketqua} lần trong chuỗi chính '{str}'.");
    }
    }
}

