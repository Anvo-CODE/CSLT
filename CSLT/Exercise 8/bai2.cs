/*Bài 2: Kiểm tra số chẵn lẻ
Yêu cầu: Viết hàm `bool KiemTraChan(int n)` trả về `true` nếu `n` là số chẵn, `false` nếu là số lẻ.
Hướng dẫn: Sử dụng toán tử chia lấy dư `%`. Nếu biểu thức `n % 2 == 0` đúng thì n là số chẵn.
Bạn có thể return thẳng biểu thức này*/
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSLT.Exercise_8
{
    internal class bai2
    {
        static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập một số: ");
            int so = int.Parse(Console.ReadLine());
            bool ketqua=KiemTraChan(so);
            Console.WriteLine($"số {so} có chẵn không? {ketqua}");
        }
    }
}
