/*Bài 6: Kiểm tra số nguyên tố
Yêu cầu: Viết hàm `bool KiemTraNguyenTo(int n)` kiểm tra xem số nguyên n có phải số nguyên
tố hay không.
Kết quả mẫu: Input: 7->Output: True | Input: 10->Output: False*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_8
{
    internal class bai6
    {
        static bool Kiemtra(int n)
        {
            if (n < 2)
            {
                return false;
            }
            else 
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) 
                    {
                        return false;
                    }
                }

            }
                        return true;
        }
        static void Main(string [] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập số muốn kiểm tra: ");
            int so = int.Parse(Console.ReadLine());
            bool ketqua = Kiemtra(so);
            Console.WriteLine($"số {so} có là số nguyên tố hay không: {ketqua}");
        }
    }
}
