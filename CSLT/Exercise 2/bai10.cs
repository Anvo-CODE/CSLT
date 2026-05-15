using System;
namespace Hexadecimal_to_Decial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so hexa: ");
            string hexa = Console.ReadLine();
            int decimalValue = Convert.ToInt32(hexa, 16);
            Console.WriteLine("ket qua: " + decimalValue);
        }
    }
}
