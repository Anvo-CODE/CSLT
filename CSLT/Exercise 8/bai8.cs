/*Bài 8: Đếm số lượng nguyên âm trong chuỗi
Yêu cầu: Viết hàm `int DemNguyenAm(string s)` đếm số lượng các ký tự nguyên âm (a, e, i, o,
u) trong chuỗi.
Kết quả mẫu: Input: "Hello World" -> Output: 3*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_8
{
    internal class bai8
    {
        static int Dem(string n)
        {
            int dem = 0;
            String nguyenam = "aeiouAEIOU";
            foreach (char luu in n)
            {
                if(nguyenam.Contains(luu))
                {
                    dem++;
                }
            }
            return dem;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập chuỗi cần đếm: ");
            string nhap = Console.ReadLine();
            int ketqua = Dem(nhap);
            Console.WriteLine($"số lượng nguyên âm trong chuỗi là: {ketqua}");
        }





















    }
}
