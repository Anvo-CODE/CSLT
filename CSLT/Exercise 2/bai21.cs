using System;
namespace Sum_or_Triple_Sum_of_Integers

{
    public class program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("nhập 2 số nguyên: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            bool bằng = a == b;
            if (bằng)
            {
                Console.WriteLine("kết quả là:" + ((a + b)) * 3);
            }
            else
            {
                Console.WriteLine("kết quả là:" + (a + b));
            }
        }
    }
}