using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int result =Calculator.Sum(25, 17);
            Calculator.Result(result);
            int result1=Calculator.Sub(100, 45);
            Calculator.Result(result1);
            int result2=Calculator.Multip(8, 12);
            Calculator.Result(result2);
            int result3=Calculator.Divis(80, 4);
            Calculator.Result(result3);
        }
    }
}
