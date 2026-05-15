using System;
namespace bai5;
public class Program
    {
        static void Main5(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập 2 số nguyên");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            bool bằng = a == 20 || b == 20 || (a + b) == 20;
            if (bằng)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
