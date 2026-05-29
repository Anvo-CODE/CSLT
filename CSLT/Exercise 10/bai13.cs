/*to insert a substring before the first occurrence of a string.*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSLT.Exercise_10
{
    internal class bai13
    {
        static string GhepChuoi(string a, string b, string c)
        {
            for (int i = 0; i <= a.Length - b.Length; i++)
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
                    string before = a.Substring(0, i);
                    string after = a.Substring(i);
                    return before + c + after;
                }
           }
        
            return a;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào chuỗi chính:");
            string str = Console.ReadLine();
            Console.WriteLine("Nhập vào chuỗi con:");
            string sub = Console.ReadLine();
            Console.WriteLine("Nhập vào chuỗi cần chèn:");
            string insert = Console.ReadLine();
            string ketqua = GhepChuoi(str, sub, insert);
            Console.WriteLine($"kết quả là: Chuỗi sau khi chèn là '{ketqua}'.");
        }
    }
    }
