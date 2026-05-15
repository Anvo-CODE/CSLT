using System;
namespace bai19
{
    class Program 
    {
        static void Main19(string[] args)
        {
            Console.WriteLine("nhap so ");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (a != 0)
            {
                int b = a % 10;
                sum += b;
                a /= 10;

            }
            Console.WriteLine("ket qua:" + sum);
        }
    }
}


