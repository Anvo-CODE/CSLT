using System;
namespace Remove_Character_by_Index
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("nhập chữ:");
            string chữ = Console.ReadLine();
            Console.WriteLine("nhập kí tự muốn xóa: ");
            string a = Console.ReadLine();
            int b = chữ.IndexOf(a);
            string c = chữ.Remove(b, 1);
            Console.WriteLine($"kết quả sau khi xóa kí tự: {c}");
        }
    }
}
