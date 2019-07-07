using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3ResourePracticeProblems
{
    class Calculate
    {
        public void SumOfTwoNumbers()
        {
            int sum, firstNum, secondNum;
            Console.WriteLine("Enter first number: ");
            firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number: ");
            secondNum = int.Parse(Console.ReadLine());
            sum = firstNum + secondNum;
            Console.WriteLine("Sum is:" + sum);
            Console.ReadKey();
        }

        public void Divide()
        {
            int division=0, firstNum, secondNum;
            Console.WriteLine("Enter first number: ");
            firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number: ");
            secondNum = int.Parse(Console.ReadLine());
            try
            {
                division = firstNum / secondNum;
                Console.WriteLine("Division is:" + division);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("A number cannot be divided by zero. Please Enter valid Inputs.");
                Divide();
            }
           
            Console.ReadKey();

        }

    }
}
