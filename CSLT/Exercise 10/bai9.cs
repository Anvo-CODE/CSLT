/*-to check whether a given substring is present in the given string.*/

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CSLT.Exercise_10
{
    internal class bai9
    {
        static bool Kiemtra(string str, string sub)
        {
            for (int i = 0; i <= str.Length - sub.Length; i++)
            {
                int j;
                for ( j= 0; j < sub.Length; j++)
                {
                    if (str[i + j] != sub[j])
                        break;
                }

                if ( j == sub.Length)
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào chuỗi chính:");
            string str = Console.ReadLine();
            Console.WriteLine("Nhập vào chuỗi con:");
            string sub = Console.ReadLine();
            bool ketqua = Kiemtra(str, sub);
            if (ketqua)
            {
                Console.WriteLine($"kết quả là: Chuỗi con '{sub}' có tồn tại trong chuỗi chính '{str}'.");
            }
            else
            {
                Console.WriteLine($"kết quả là: Chuỗi con '{sub}' không tồn tại trong chuỗi chính '{str}'.");
            }
        }
    }
}





