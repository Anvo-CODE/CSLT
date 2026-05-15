using System;
namespace bai6
{
    public class program
    {
        static void Main16(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("nhập số bạn muốn lặp lại:");
            string số = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(số))
            {
                Console.WriteLine("Vui lòng nhập số");
            }
            else
            {
                Console.WriteLine("{0}{0}{0}{0}", số);
                Console.WriteLine("{0} {0} {0} {0} ", số);
                Console.WriteLine("{0}{0}{0}{0}", số);
                Console.WriteLine("{0} {0} {0} {0} ", số);
            }
        }
    }
}
