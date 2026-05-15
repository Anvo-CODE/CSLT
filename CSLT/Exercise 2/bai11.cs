using System;

class ProgramB
{
    static void Main11()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());

        int[] array1 = new int[n];
        int[] array2 = new int[n];

        Console.WriteLine("Nhập các phần tử cho mảng 1:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"array1[{i}] = ");
            array1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Nhập các phần tử cho mảng 2:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"array2[{i}] = ");
            array2[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Kết quả nhân các phần tử tương ứng:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(array1[i] * array2[i] + " ");
        }
    }
}