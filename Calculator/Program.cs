using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            double num1;
            double num2;
            double result;
            string operations;



            Console.WriteLine("Wellcome to simple Calculator\n");
            Console.WriteLine("Please enter first number\n");
            num1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number\n");
            num2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please choose operation\n (+,-,*,%) ");
            operations = Console.ReadLine();


            if (operations == "+")
            {
                result = num1 + num2;
                Console.Write("Result is:" + result);
            }
            if (operations == "-")
            {
                result = num1 - num2;
                Console.Write("Result is:" + result);
            }

            if (operations == "*")
            {
                result = num1 * num2;
                Console.Write("Result is:" + result);
            }
            if (operations == "%")
            {
                result = num1 % num2;
                Console.Write("Result is:" + result);
            }


            Console.Write("\n" + "Press any key to exit");
            Console.ReadKey();

            








        }
    }
}
