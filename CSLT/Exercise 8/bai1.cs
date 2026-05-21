using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSLT.Exercise_8
{
    internal class bai1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập 2 số a,b: ");
            int so1= int.Parse(Console.ReadLine());
            int so2= int.Parse(Console.ReadLine());
            int ketqua= Tong(so1, so2);
            Console.WriteLine("Tổng của {0} và {1} là: {2}", so1, so2, ketqua);
        }
            static int Tong(int a, int b)
            {
                return a + b;
            }
        }
    }

