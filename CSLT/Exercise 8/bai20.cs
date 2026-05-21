/*Bài 20: Đếm số từ trong câu
Yêu cầu: Viết hàm `int DemSoTu(string sentence)` trả về số lượng từ có trong câu.
Kết quả mẫu: Input: "Học lập trình C# rất thú vị" -> Output: 7*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_8
{
    internal class bai20
    {
      static int DemSoTu(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence)) return 0;
            var words = sentence.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập câu cần kiểm tra: ");
            string cau = Console.ReadLine();
            int ketqua = DemSoTu(cau);
            Console.WriteLine($"kết quả là: {ketqua}");
        }







    }
}
