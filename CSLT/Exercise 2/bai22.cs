using System;
namespace bai22
{
    class Program
    {
        static void Main22(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập chữ muốn đảo: ");
            string a = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(a))
            {
                Console.WriteLine("Vui lòng nhâp chữ ");
            }
            else if (a.Length == 1)
            {
                Console.WriteLine("Kết quả: " + a);
            }
            else
            {
                char đầu = a[0];
                char cuối = a[a.Length - 1];
                string giữa = a.Substring(1, a.Length - 2);
                string kếtQuả = cuối + giữa + đầu;
                Console.WriteLine("Kết quả: " + kếtQuả);
            }

        }
    }
}
