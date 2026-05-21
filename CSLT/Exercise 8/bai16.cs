/*Bài 16: Xóa ký tự trùng lặpYêu cầu: Viết hàm `string XoaTrungLap(string s)` trả về chuỗi với các ký tự xuất hiện lần đầu
tiên được giữ lại.
Kết quả mẫu: Input: "programming"->Output: "progamin*/
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSLT.Exercise_8
{
    internal class bai16
    {
        static string XoaTrungLap(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return s;
            }
            var seen = new HashSet<char>();
            var result = new StringBuilder();
            foreach (char c in s)
            {
                if (!seen.Contains(c))
                {
                    seen.Add(c);
                    result.Append(c);
                }
            }
            return result.ToString();
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập chuỗi muốn kiểm tra");
            string chuoi = Console.ReadLine();
            string ketqua = XoaTrungLap(chuoi);
            Console.WriteLine($"kết quả là: {ketqua}");
        }
    }
}
