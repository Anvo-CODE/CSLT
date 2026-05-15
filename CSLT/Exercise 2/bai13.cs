using System;
namespace bai13;

public class program
{
    static void Main2(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("nhập tuổi của bạn:");
        string tuoi = Console.ReadLine();
        if (
            string.IsNullOrWhiteSpace(tuoi))


        {
            Console.WriteLine("vui lòng nhập tuổi của bạn");
        }
        else
        {
            Console.WriteLine($"nhìn bạn già hơn {tuoi} tuổi");
        }

    }
}