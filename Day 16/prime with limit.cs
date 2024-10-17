using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_with_limit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the limit to print prime numbers");
            int limit = int.Parse(Console.ReadLine());
            int i,number = 2;
            while (limit > 0)
            {
                bool isPrime = true;
                for (i = 2; i <= number/2; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(number);
                    limit--;
                }
                number++;
            }
        }
    }
}
