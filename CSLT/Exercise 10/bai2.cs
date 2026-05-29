/*to find the length of a string without using a library function.*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_10
{
    internal class bai2
    {
            static int dem(string[] arr, int sum)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    sum++; // mỗi phần tử là 1 từ
                }
                return sum;
            }

            static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                Console.Write("Nhập chuỗi: ");
                string a = Console.ReadLine();

                string[] arr = a.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int sum = 0;
                int result = dem(arr, sum);

                Console.WriteLine("Số từ trong chuỗi: " + result);
            }
        }
    }
