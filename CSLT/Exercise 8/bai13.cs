/*Bài 13: Tìm giá trị nhỏ nhất trong mảng
Yêu cầu: Viết hàm `int TimMin(int[] arr)` trả về phần tử nhỏ nhất trong mảng.
Kết quả mẫu: Input: [10, 5, 8, 2, 9] -> Output: 2*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_8
{
    internal class bai13
    {
static int Timmin(int[] arr)
        {
            if (arr == null || arr.Length == 0)     
            {
                throw new ArgumentException("Mảng không được rỗng");
            }
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            { 
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] a = { 10, 5, 8, 2, 9 };
            Console.WriteLine("Giá trị nhỏ nhất trong mảng là: " + Timmin(a));
        }
    }
}
 