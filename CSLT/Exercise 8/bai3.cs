/*Bài 3: Tìm số lớn nhất trong ba số
Yêu cầu: Viết hàm `int TimMax(int a, int b, int c)` trả về giá trị lớn nhất trong ba số được
truyền vào.
Hướng dẫn: Bạn có thể sử dụng cấu trúc điều kiện `if-else` lồng nhau. Cách ngắn gọn hơn là
tận dụng hàm có sẵn `Math.Max(Math.Max(a, b), c)*/




using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_8
{
    internal class bai3
    {
        static int Timmax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
        static void Main(string[] args)
        {
                        Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập 3 số a,b,c; ");
            int so1 = int.Parse(Console.ReadLine());
            int so2 = int.Parse(Console.ReadLine());
            int so3 = int.Parse(Console.ReadLine());
            int ketqua = Timmax(so1, so2, so3);
            Console.WriteLine($"Số lớn nhất trong ba số là:{ketqua}");
        }
    }
}
