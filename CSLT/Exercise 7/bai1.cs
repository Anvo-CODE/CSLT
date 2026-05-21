using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_7
{
    internal class bai1
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 12, 3, 24, 15, 66, 17, 28, 59, 10 };
            double tb = avg(arr);
            Console.WriteLine($"Trung binh gia tri trong mang: {tb}");
        }
        static double avg(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return (double)sum / arr.Length;
        }
    }
}

