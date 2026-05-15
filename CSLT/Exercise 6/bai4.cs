using System;

class Programbai4
{
    static void Main()
    {
        Console.WriteLine("Chọn: 1 = in các số nguyên tố < X, 2 = in N số nguyên tố đầu tiên");
        string c = Console.ReadLine()?.Trim();
        if (c == "1")
        {
            Console.Write("Nhập X (số nguyên > 2): ");
            if (int.TryParse(Console.ReadLine(), out int x) && x > 2)
                PrintPrimesLessThan(x);
            else Console.WriteLine("Giá trị không hợp lệ.");
        }
        else if (c == "2")
        {
            Console.Write("Nhập N (số lượng): ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                PrintFirstNPrimes(n);
            else Console.WriteLine("Giá trị không hợp lệ.");
        }
        else Console.WriteLine("Lựa chọn không hợp lệ.");
    }

    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;
        int r = (int)Math.Sqrt(n);
        for (int i = 3; i <= r; i += 2)
            if (n % i == 0) return false;
        return true;
    }

    static void PrintPrimesLessThan(int limit)
    {
        Console.WriteLine($"Các số nguyên tố nhỏ hơn {limit}:");
        for (int i = 2; i < limit; i++)
            if (IsPrime(i)) Console.Write(i + " ");
        Console.WriteLine();
    }

    static void PrintFirstNPrimes(int n)
    {
        Console.WriteLine($"{n} số nguyên tố đầu tiên:");
        int count = 0;
        int candidate = 2;
        while (count < n)
        {
            if (IsPrime(candidate))
            {
                Console.Write(candidate + " ");
                count++;
            }
            candidate++;
        }
        Console.WriteLine();
    }
}