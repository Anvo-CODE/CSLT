using System;

class ProgramC
{
    static void Main9()
    {
        Console.Write("Input a string: ");
        string str = Console.ReadLine();

        if (str.Length < 4)
        {
            Console.WriteLine(str);
        }
        else
        {
            string lastFour = str.Substring(str.Length - 4);
            string result = lastFour + lastFour + lastFour + lastFour;
            Console.WriteLine(result);
        }
    }
}