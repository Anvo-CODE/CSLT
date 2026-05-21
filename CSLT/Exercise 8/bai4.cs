/*Bài 4: Tính giai thừa của một số
Yêu cầu: Viết hàm `long TinhGiaiThua(int n)` tính và trả về giai thừa của số nguyên dương n
(n!).
Hướng dẫn: Sử dụng một biến lưu kết quả (khởi tạo bằng 1). Dùng vòng lặp `for` chạy từ 1 đến
`n` để nhân dồn vào biến kết quả. Chú ý: dùng kiểu `long` để tránh tràn số lượng giới hạn của
`int`*/



using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_8
{
    internal class bai4
    {
        static long Tinhgiaithua(int n)
        {
            long ketqua = 1;
            for (int i = 1; i <= n; i++)
            {
                ketqua *= i;
            }
            return ketqua;
            }
        static void Main(string[] args)
        {
Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập một số muốn tính gia thừa: ");
            int so= int.Parse(Console.ReadLine());
            long giaithua = Tinhgiaithua(so);
            Console.WriteLine($"Giai thừa của {so} là: {giaithua}");
        }
            }

        }