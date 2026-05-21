/*Bài 19: Kiểm tra năm nhuận
Yêu cầu: Viết hàm `bool KiemTraNamNhuan(int year)` kiểm tra xem một năm có phải năm
nhuận không.
Kết quả mẫu: Input: 2024 -> Output: True | Input: 2023 -> Output: False*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_8
{
    internal class bai19
    {
        static bool KiemTraNamNhuan(int year)
        {
            year = Math.Abs(year);
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            return (year % 4 == 0);
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập năm cần kiểm tra: ");
            if (int.TryParse(Console.ReadLine(), out int nam))
            {
                bool ketqua = KiemTraNamNhuan(nam);
                Console.WriteLine($"Năm {nam} là năm nhuận: {ketqua}");
            }
            else
            {
                Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập một số nguyên.");
            }
        }
    }
}
