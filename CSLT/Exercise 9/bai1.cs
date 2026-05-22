using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_9
{
    internal class bai1
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            bool ketqua = so(arr);

            Console.WriteLine($"So 3 co ton tai: {ketqua}");
        } 
        static bool so(int[] arr)
        {
            return arr.Contains(3);
        }
    }

}

