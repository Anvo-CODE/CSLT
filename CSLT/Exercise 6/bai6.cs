using System;
using System.Collections.Generic;

class bai6EX6
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập câu để kiểm tra pangram: ");
        string input = Console.ReadLine() ?? "";
        bool isPangram = IsPangram(input);
        Console.WriteLine(isPangram ? "Đây là pangram." : "Không phải pangram.");
    }

    static bool IsPangram(string input)
    {
        if (string.IsNullOrEmpty(input)) return false;
        var seen = new HashSet<char>();
        foreach (char ch in input)
        {
            if (char.IsLetter(ch))
            {
                char lower = char.ToLowerInvariant(ch);
                if (lower >= 'a' && lower <= 'z')
                    seen.Add(lower);
            }
        }
        return seen.Count == 26;
    }
}