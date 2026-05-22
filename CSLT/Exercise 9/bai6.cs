using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_9
{
    internal class bai6
    {
        static void daochuoi(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập các phần tử:");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            daochuoi(arr);
            Console.WriteLine("Mảng sau khi đảo ngược:");
            Console.WriteLine(string.Join(" ", arr));
    }
    }
}
