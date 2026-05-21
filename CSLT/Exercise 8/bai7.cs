/*Bài 7: In dãy Fibonacci
Yêu cầu: Viết hàm `void InFibonacci(int n)` in ra n số đầu tiên của dãy Fibonacci.
Kết quả mẫu: Input: 6 -> Output: 0 1 1 2 3 5*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_8
{
    internal class bai7
    {
        static void Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            if (n > 1) Console.WriteLine(a + " ");
            if (n > 2) Console.WriteLine(b + " ");
            for (int i = 3; i <= n; i++)
            {
                int c = a + b;
                Console.WriteLine(c + " ");
                a = b;
                b = c;

            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập số muốn tính: ");
            int so = int.Parse(Console.ReadLine());
            Console.WriteLine("số Fibonacci bằng:");
            Fibonacci(so);
        }
    }   
}
