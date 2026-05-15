using System;

namespace bài_tập_15p.Exercise_6
{
    internal class bai1
    {
        public static int MaxatleastOne(int first, params int[] array)
        {
            int max = first;
            foreach (int x in array)
            {
                if (x > max) max = x;
            }
            return max;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Max(7) = " + bai1.MaxatleastOne(7));
            Console.WriteLine("Max(2,5) = " + bai1.MaxatleastOne(2, 5));
            Console.WriteLine("Max(1,4,3,9) = " + bai1.MaxatleastOne(1, 4, 3, 9));

            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}