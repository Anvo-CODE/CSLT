using System;

namespace Sum_of_First_500_Primes
{
    class Program
    {
        static bool Prime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int[] primes = new int[500];
            int count = 0;
            int number = 2;

            while (count < 500)
            {
                if (Prime(number))
                {
                    primes[count] = number;
                    count++;
                }
                number++;
            }

            long sum = 0;
            for (int i = 0; i < primes.Length; i++)
            {
                sum += primes[i];
            }

            Console.WriteLine($"Sum of the first 500 prime numbers: {sum}");
        }
    }
}