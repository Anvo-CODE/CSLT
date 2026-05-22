using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Exercise_9
{
    internal class bai10
    {
        static bool TimTu(string sentence, string word)
        {
            string[] arr = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == word)
                {
                    return true;
                }
            }

            return false;
        }
            static void InKetQua(bool found)
            {
                if (found)
                {
                    Console.WriteLine("Tìm thấy từ trong câu");
                }
                else
                {
                    Console.WriteLine("Không tìm thấy từ");
                }
            }

            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;

                Console.Write("Nhập câu: ");
                string sentence = Console.ReadLine();

                Console.Write("Nhập từ cần tìm: ");
                string word = Console.ReadLine();

                bool result = TimTu(sentence, word); 
                InKetQua(result);                     
            }
        }
    }
