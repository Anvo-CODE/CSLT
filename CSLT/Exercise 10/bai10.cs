using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CSLT.Exercise_10
{
    internal class bai10
    {
        static int Timvitri(string a, string b)
        {
            for (int i = 0; i <= a.Length - b.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i + j] != b[j])
                    {
                        break;
                    }
                    if (j == b.Length - 1)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào chuỗi chính:");
            string str = Console.ReadLine();
            Console.WriteLine("Nhập vào chuỗi con:");
            string sub = Console.ReadLine();
            int ketqua = Timvitri(str, sub);
            if (ketqua == -1)
            {
                Console.WriteLine("chuổi không tồn tại");
            }
            else
            {
                Console.WriteLine($"kết quả là: Chuỗi con '{sub}' có tồn tại trong chuỗi chính '{str}' tại vị trí {ketqua}.");

            }

        }
    }
}
