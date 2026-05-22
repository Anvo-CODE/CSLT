using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_9
{
    internal class bai4
    {
        static string[] XoaPhanTu(string[] arr, string xoa)
        {
            int cout = 0;
            foreach (string item in arr)
            {
                if (item != xoa)
                {
                    cout++;
                }
            }
            string[] newArr = new string[cout];
            int index = 0;
            foreach (string item in arr)
            {
                if (item != xoa)
                {
                    newArr[index] = item;
                    index++;
                }
            }

            return newArr;
        }

    
         static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8; 
            Console.WriteLine("Nhập mảng:");
            string[] arr = Console.ReadLine().Split(' ');

            Console.Write("Nhập phần tử cần xóa: ");
            string x = Console.ReadLine();

            string[] result = XoaPhanTu(arr, x);

            Console.WriteLine("Mảng sau khi xóa:");
            Console.WriteLine(string.Join(" ", result));

        }
    }
}

