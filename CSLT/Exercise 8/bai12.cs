/*Bài 12: Chuyển đổi nhiệt độ
Yêu cầu: Viết hàm `double CelsiusToFahrenheit(double c)` chuyển đổi từ độ C sang độ F.
Kết quả mẫu: Input: 25 -> Output: 778*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_8
{
    internal class bai12
    {
        static double Chuyendo(double C)
        {
            return (C * 9 / 5) + 32;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập nhiệt độ cần chuyển đổi: ");
            double nhap = double.Parse(Console.ReadLine());
            double ketqua = Chuyendo(nhap);
            Console.WriteLine($"kết quả là: {ketqua}");
        }
    }
}
