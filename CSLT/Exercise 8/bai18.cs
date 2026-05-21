/*Bài 18: Chuyển đổi hệ thập phân sang nhị phân
Yêu cầu: Viết hàm `string DecimalToBinary(int n)` nhận vào số thập phân và trả về chuỗi nhị
phân.
Kết quả mẫu: Input: 10 -> Output: "1010"*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_8
{
    internal class bai18
    {
        static string DecimalToBinary(int n)
        {
            return Convert.ToString(n, 2);
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập số cần tính: ");
            int so = int.Parse(Console.ReadLine());
            string ketqua = DecimalToBinary(so);
            Console.WriteLine($"kết quả là: {ketqua}");
        }
    }
}
