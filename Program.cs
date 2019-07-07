using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourePracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("1. Sum of two numbers");
            Console.WriteLine("2. Divide two numbers");
            Console.WriteLine("Please enter the number of the program you want to execute: ");
            input = int.Parse(Console.ReadLine());
            Calculate calculate = new Calculate();
            switch (input)
            {
                case 1:

                    calculate.SumOfTwoNumbers();
                    break;
                case 2:

                    calculate.Divide();
                    break;

            }           
        }
    }
}
