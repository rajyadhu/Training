using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0, i;
            bool isPrime = true;
            Console.WriteLine("Check prime number or not");
            int number = int.Parse(Console.ReadLine());

            for (i = 2; i <= number / 2; i++)
            {
                if(number%i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime) {
                Console.WriteLine(number + " is prime");
            }
            else
            {
                Console.WriteLine(number + " not a prime");
            }
        }
    }
}
