/*Bài 17: Tìm ước chung lớn nhất (UCLN)
Yêu cầu: Viết hàm `int UCLN(int a, int b)` sử dụng thuật toán Euclid để tìm UCLN của 2 số.
Kết quả mẫu: Input: a = 12, b = 18 -> Output: 6*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_8
{
    internal class bai17
    {
        static int UCLN(int a, int b)
        {
            Math.Abs(a);
            Math.Abs(b);
            while(b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập số a: ");
            int so1 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhập số b: ");
            int so2 = int.Parse(Console.ReadLine());
            int ketqua = UCLN(so1, so2);
            Console.WriteLine($"ước chung lớn nhất là {ketqua}");
        }
    }
}
