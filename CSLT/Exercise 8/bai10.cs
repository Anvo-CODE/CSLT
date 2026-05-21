/*Bài 10: Tính điểm trung bình của mảng
Yêu cầu: Viết hàm `double TinhTrungBinh(int[] arr)` tính giá trị trung bình của mảng số
nguyên.
Kết quả mẫu: Input: [4, 5, 6, 7] -> Output: 5.5*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_8
{
    internal class bai10
    {
        static double Tinhtb(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return (double)sum / arr.Length;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] a = { 4, 5, 6, 7, };
            double ketqua = Tinhtb(a);
            Console.WriteLine("kết quả là: " + (ketqua));

        }
    }
}
