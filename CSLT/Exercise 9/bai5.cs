using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_9
{
    internal class bai5
    {

        static void TimMaxMin(int[] arr, out int max, out int min)
        {
            max = arr[0];
            min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Nhập các phần tử:");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int max, min;

            TimMaxMin(arr, out max, out min);

            Console.WriteLine($"Giá trị lớn nhất là: {max}");
            Console.WriteLine($"Giá trị nhỏ nhất là: {min}");
        }
    }
}
