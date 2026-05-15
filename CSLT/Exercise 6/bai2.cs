using System;
using System.Numerics;

class ProgramEX6b2
{
    static void MainEX6b2()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập n (số nguyên không âm): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
        {
            Console.WriteLine("Giá trị không hợp lệ.");
            return;
        }

        Console.WriteLine($"{n}! = {FactorialBig(n)}");
    }

    static BigInteger FactorialBig(int n)
    {
        if (n < 0) throw new ArgumentException("n phải >= 0");
        BigInteger r = 1;
        for (int i = 2; i <= n; i++) r *= i;
        return r;
    }
}