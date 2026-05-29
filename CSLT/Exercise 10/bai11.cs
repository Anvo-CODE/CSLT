/*-to check whether a character is an alphabet and not and if so, check for the case.*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_10
{
    internal class bai11
    {
        static int Kiemtra(char c)
        {
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                return 1;
            }
            return 0;

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập vào 1 kí tự:");
           string input = Console.ReadLine();
            char c = input[0];
            int ketqua = Kiemtra(c);
            if (input.Length != 1)
            {
                Console.WriteLine("Vui lòng nhập đúng một ký tự.");
                return;
            }
            if (ketqua == 1)
            {
                if(c>='A' && c<='Z')
                {
                    Console.WriteLine("ký tự bạn nhập là chữ cái in hoa");
                }
                else
                {
                    Console.WriteLine("ký tự bạn nhập là chữ cái thường");
                }
            }
            else
            {
                Console.WriteLine("đây không phải chữ cái");
            }
        }
    }
}
