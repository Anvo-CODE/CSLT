using System;

class Program12
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập một số nguyên (hoặc để trống để thoát): ");
        string line = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(line)) return;

        if (!long.TryParse(line.Trim(), out long n))
        {
            Console.WriteLine("Giá trị không hợp lệ.");
            return;
        }

        bool prime = IsPrime(n);
        Console.WriteLine(prime ? $"{n} là số nguyên tố." : $"{n} không phải là số nguyên tố.");
    }

    // Kiểm tra số nguyên tố cho n (dùng long)
    static bool IsPrime(long n)
    {
        if (n < 2) return false;
        if (n == 2 || n == 3) return true;
        if (n % 2 == 0) return false;

        long r = (long)Math.Sqrt(n);
        for (long i = 3; i <= r; i += 2)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}