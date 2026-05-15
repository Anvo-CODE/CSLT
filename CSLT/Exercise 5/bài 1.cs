using System;

public class Class1
{
    static void Main(string[] args)
    {
        int x = Sum(1, 2, 3, 4, 5);
        int y = Sum(1);
        int z = Sum(1, 2, 3, 4, 5, 6, 7, 8);

        Console.WriteLine("Tổng x = " + x);
        Console.WriteLine("Tổng y = " + y);
        Console.WriteLine("Tổng z = " + z);

        // Ví dụ tìm số lớn nhất trong mảng
        int max = Max(10, 20, 5, 7);
        Console.WriteLine("Số lớn nhất là: " + max);
    }

    static int Sum(params int[] nums)
    {
        int sum = 0;
        foreach (int num in nums)
        {
            sum += num;
        }
        return sum;
    }

    static int Max(params int[] nums)
    {
        int max = nums[0];
        foreach (int num in nums)
        {
            if (num > max)
                max = num;
        }
        return max;
    }
}