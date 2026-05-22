using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CSLT.Exercise_9
{
    internal class bai9
    {
            static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;

                Console.WriteLine("Nhập các phần tử:");
                int[] arr = Array.ConvertAll(
                    Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries),
                    int.Parse
                );

                BubbleSort(arr);

                Console.WriteLine("Mảng sau khi sắp xếp là:");
                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }