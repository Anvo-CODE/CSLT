/*Bài 9: Tính lũy thừa
Yêu cầu: Viết hàm `double TinhLuyThua(double x, int y)` tính x^y (không dùng Math.Pow).
Kết quả mẫu: Input: x = 2, y = 3 -> Output: 8*/



using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_8
{
    internal class bai9
    {
        static double TinhLuyThua(double x, int y)
        {
            double result = 1;

            if (y > 0)
            {
                for (int i = 0; i < y; i++)
                {
                    result *= x;
                }
            }
            else if (y < 0)
            {
                for (int i = 0; i < -y; i++)
                {
                    result *= x;
                }
                result = 1 / result;
            }

            return result;
        }

        static void Main()
        {
            Console.WriteLine(TinhLuyThua(2, 3));
            Console.WriteLine(TinhLuyThua(5, 0));
            Console.WriteLine(TinhLuyThua(2, -2));
        }
    }
}















    
