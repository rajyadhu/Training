using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SIMPLE CALCULATOR");
            Console.Write("Enter the first no :");
            double first_no = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second no :");
            double second_no = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operation +,-,*,/ :");
            string operation = Console.ReadLine();

            switch (operation){
                case "+":
                    Console.WriteLine($"Result of {first_no} + {second_no} is :{first_no + second_no}");
                    break;
                case "-":
                    Console.WriteLine($"Result of {first_no} - {second_no} is :{first_no - second_no}");
                    break;
                case "*":
                    Console.WriteLine($"Result of {first_no} + {second_no} is :{first_no * second_no}");
                    break;
                case "/":
                    if(first_no == 0 || second_no == 0)
                    {
                        Console.WriteLine("Division by zero is invalid");
                    }
                    else
                    {
                        Console.WriteLine($"Result of {first_no} - {second_no} is :{first_no / second_no}");
                    }
                    break;
            }
        }
    }
}
