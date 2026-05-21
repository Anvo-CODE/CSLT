/*Bài 15: Sắp xếp mảng tăng dần
Yêu cầu: Viết hàm `void SapXepMang(int[] arr)` sắp xếp và in ra mảng tăng dần.
Kết quả mẫu: Input: [3, 1, 4, 2] -> Output: 1 2 3 4*/

using System;

namespace CSLT.Exercise_8
{
    internal class bai15
    {
        public void SapXepMang(int[] arr)
        {
            if (arr == null || arr.Length <= 1) return;
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
        }

        public void InMang(int[] arr)
        {
            if (arr == null) { Console.WriteLine("Mảng null"); return; }
            Console.WriteLine(string.Join(" ", arr));
        }

        static void Main()
        {
            int[] a = { 3, 1, 4, 2 };
            bai15 obj = new bai15();
            obj.SapXepMang(a);
            obj.InMang(a); // In: 1 2 3 4
        }
    }
}