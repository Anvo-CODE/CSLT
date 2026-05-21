/*Bài 11: Kiểm tra chuỗi đối xứng (Palindrome)
Yêu cầu: Viết hàm `bool KiemTraDoiXung(string s)` kiểm tra chuỗi có đọc xuôi và ngược giống
nhau không.
Kết quả mẫu: Input: "radar" -> Output: True | Input: "hello" -> Output: False*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_8
{
    internal class bai11
    {
        static bool doixung(string s)
        {
            string xuoi = "";
            string nguoc = "";
            for(int i=0; i<s.Length; i++)
            {
                xuoi += s[i];
            }
            for(int i=s.Length-1; i>=0; i--)
            {
                nguoc += s[i];
            }
            return xuoi == nguoc;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập chuỗi muốn kiểm tra: ");
            string s = Console.ReadLine();
            bool ketqua = doixung(s);
            Console.WriteLine($"chuỗi {s} có phải là chuỗi đối xứng hay không: {ketqua}");
        }
    }
}
