using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_9
{
    internal class bai8
    {

        static bool XoaPhanTu(int[] arr, ref int n, int x)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                {
                    for (int j = i; j < n - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    n--;
                    return true;
                }
            }
            return false;
        }

        // Hàm phát sinh mảng ngẫu nhiên
        static void PhatSinhMang(int[] arr, int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(1, 100);
            }
        }

        // Hàm in mảng
        static void InMang(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số phần tử mảng: ");
            int n;

            // ✅ đảm bảo nhập đúng số
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Nhập lại (số nguyên > 0): ");
            }

            int[] arr = new int[n];

            PhatSinhMang(arr, n);

            Console.WriteLine("Mảng ban đầu:");
            InMang(arr, n);

            Console.Write("Nhập phần tử cần xóa: ");
            int x;

            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Nhập lại số hợp lệ: ");
            }

            bool kq = XoaPhanTu(arr, ref n, x);

            if (!kq)
            {
                Console.WriteLine("Không tìm thấy phần tử cần xóa.");
            }
            else
            {
                Console.WriteLine("Mảng sau khi xóa:");
                InMang(arr, n);
            }
        }
    }
}
