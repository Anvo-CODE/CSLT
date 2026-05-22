using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_9
{
    internal class bai2
    {
        static void Main(string[] args)
        {
            string[] arr = { "my", "phuong", "khoi", "ngan" };

            bool kiemtra = a(arr);

            Console.WriteLine($"ket qua kiem tra la {kiemtra}");
        }

        static bool a(string[] arr)
        {
            return Array.IndexOf(arr, "khoi") != -1;

        }
    }
}