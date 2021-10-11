using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Calculator
    {
        public static int Sum(int num1,int num2) 
        {
            return num1 + num2;
        }
        public static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multip(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Divis(int num1, int num2)
        {
            return num1 / num2;
        }
        public static void Result(int result) 
        {
            Console.WriteLine(result);
        }
    }
}
