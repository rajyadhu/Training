using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the fibonacci series limit: ");
            int limit = int.Parse(Console.ReadLine());

            int firstterm = 0, secondterm = 1,nextterm;
            Console.Write("The Fibonacci series :");

            for (int i = 0; i < limit; i++) {
                Console.Write(firstterm+ " ");
                nextterm = secondterm + firstterm;
                firstterm = secondterm;
                secondterm = nextterm;
            }
        }
    }
}
