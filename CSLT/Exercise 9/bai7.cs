using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_9
{
    internal class bai7
    {
        static string KiemTraTrungNhau(int[] arr)
        {
            string ketqua = "";
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        ketqua += arr[i] + " ";
                        break;
                    }   
                }
            }
            return ketqua;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập các phần tử:");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            string result = KiemTraTrungNhau(arr);
            Console.WriteLine($"phần tử trung lặp là: {result}");
        }
            }
    }
