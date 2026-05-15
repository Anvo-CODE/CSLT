using System;

namespace bai18
{ 
    internal class Specified_Formula_with_Three_Numbers
    {
        static void Main18(string[] args)

        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("nhập 3 số: ");
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(x) || string.IsNullOrWhiteSpace(y) || string.IsNullOrWhiteSpace(z))
            {
                Console.WriteLine("vui lòng nhập đủ 3 số");
            }
            else
            {
                int a = ((int.Parse(x) + int.Parse(y)) * int.Parse(z));
                int b = (int.Parse(x) * int.Parse(y) + int.Parse(y) * int.Parse(z));
                Console.WriteLine($"kết quả biểu thức a: {a}");
                Console.WriteLine($"kết quả biểu thức b: {b}");

            }

        }
    }
}



