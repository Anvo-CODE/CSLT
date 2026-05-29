/*-to count the total number of words in a string.*/
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSLT.Exercise_10
{
    internal class bai5
   {
        static int Demtu(string a, int count)
        {
            count = 1;
           for (int sum=0; sum<a.Length;sum++)
            {
                if (a[sum] == ' ')
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào một chuỗi ký tự:");
            string input = Console.ReadLine();
            Demtu(input, 0);
            Console.WriteLine($"kết quả là: {Demtu(input, 0) }");
        }
    }
}
