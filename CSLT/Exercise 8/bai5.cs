/*Bài 5: Đảo ngược chuỗi ký tự
Yêu cầu: Viết hàm `string DaoNguocChuoi(string input)` nhận vào một chuỗi và trả về chuỗi bị
đảo ngược.
Hướng dẫn: Chuyển chuỗi thành mảng ký tự `char[]` bằng phương thức `.ToCharArray()`. Sau
đó dùng hàm `Array.Reverse()` để đảo mảng, cuối cùng tạo lại chuỗi mới bằng `new
string(char_array)`*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_8
{
    internal class bai5
    {
        static string Daochuoi(string input)
        {
            char[] chuoi= input.ToCharArray();
            Array.Reverse(chuoi);
            return new string(chuoi);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập chuỗi cần đảo ngược:");
            string nhap= Console.ReadLine();
            string ketqua = Daochuoi(nhap);
            Console.WriteLine($"kết quả là: {ketqua}");

        }
    }
}
