/*Bài 14: Tính tổng các chữ số của một số nguyên
Yêu cầu: Viết hàm `int TongCacChuSo(int n)` để tính tổng từng chữ số tạo nên n.
Kết quả mẫu: Input: 1234 -> Output: 10 (Vì 1+2+3+4 = 10)*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_8
{
    internal class bai14
    {
        static int Tong(int x)
        {
            int sum = 0;
            if (x == 0)
            {
                return 0;
            }
            while (x > 0)
            {
                sum += x % 10;
                x /= 10;
            }
            return sum;
        }
        static void Main(String[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập số muốn tính tổng:");
            int so = Convert.ToInt32(Console.ReadLine());
            int ketqua = Tong(so);
            Console.WriteLine("kết quả bằng: " + (ketqua));

        }
    }
}
