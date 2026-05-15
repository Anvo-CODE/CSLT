using System;
using System.IO;
namespace File_Size_in_Bytes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("nhap file: ");
            string path = Console.ReadLine();
            FileInfo link = new FileInfo(path);
            if (link.Exists)
            {
                Console.WriteLine("kich thuoc file: " + link.Length + "Bytes");
            }
            else
            {
                Console.WriteLine("File khong ton tai");

            }
        }
    }
}

