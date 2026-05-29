using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSLT.Exercise_10
{
    internal class bai7
    {
        static void Demkytu(string a, ref int kytu, ref int so, ref int conlai)
        {
            kytu = 0;
            so = 0;
            conlai = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 'a' && a[i] <= 'z' || a[i] >= 'A' && a[i] <= 'Z')
                {
                    kytu++;
                }
                else if (a[i] >= '0' && a[i] <= '9')
                {
                    so++;
                }
                else
                {
                    conlai++;
                }
            }
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào một chuỗi ký tự:");
            string input = Console.ReadLine();
            int kytu = 0, so = 0, conlai = 0;
            Demkytu(input, ref kytu, ref so, ref conlai);
            Console.WriteLine($"kết quả là: Số ký tự: {kytu}, Số chữ số: {so}, Ký tự khác: {conlai}");
        }
    }
}
