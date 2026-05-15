using System;

class bai5EX6
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Các số hoàn hảo nhỏ hơn 1000:");
        for (int n = 2; n < 1000; n++)
        {
            if (IsPerfect(n))
                Console.Write(n + " ");
        }
        Console.WriteLine();
    }

    // Trả về true nếu n là số hoàn hảo
    static bool IsPerfect(int n)
    {
        if (n < 2) return false;

        int sum = 1; // 1 luôn là ước thực sự (proper divisor) của mọi n>1
        int r = (int)Math.Sqrt(n);

        for (int i = 2; i <= r; i++)
        {
            if (n % i == 0)
            {
                int other = n / i;
                sum += i;
                if (other != i) sum += other;
            }
        }

        return sum == n;
    }
}