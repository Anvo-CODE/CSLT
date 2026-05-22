using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_9
{
    internal class bai3
    {
        static int Timindex(string[] arr, string tim)
        {
            int index = -1;
            for(int i=0; i< arr.Length; i++)
            {
                string tam = arr[i];
                if (tam ==tim)
                {
                    index = i;
                    break;
                }    
            }
            return index;
        }
        static void Main(string[] args)
        { 
          Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập các phần tử:");
            String[] arr = Console.ReadLine().Split(' ');
            Console.WriteLine("nhập giá trị cần tìm vị trí: ");
            String tim = Console.ReadLine();
            int ketqua = Timindex(arr, tim);
            Console.WriteLine($"vị trí của {tim} là: {ketqua + 1}");
        }
        }
        }
    

