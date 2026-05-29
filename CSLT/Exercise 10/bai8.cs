/*to count the number of vowels or consonants in a string.*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_10
{
    internal class bai8
    {
            static void NguyenPhu(string a, out int nguyenam, out int phuam)
            {
                nguyenam = 0;
                phuam = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u' ||
                        a[i] == 'A' || a[i] == 'E' || a[i] == 'I' || a[i] == 'O' || a[i] == 'U')
                    {
                        nguyenam++;
                    }
                    else if ((a[i] >= 'a' && a[i] <= 'z') || (a[i] >= 'A' && a[i] <= 'Z'))
                    {
                        phuam++;
                    }
                }
            }

        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào một chuỗi ký tự:");
            string input = Console.ReadLine();
          int nguyenam, phuam;
            NguyenPhu(input, out nguyenam, out phuam);
            Console.WriteLine("Số lượng nguyên âm: {0}", nguyenam);
            Console.WriteLine("Số lượng phụ âm: {0}", phuam);
        }
    }
}

