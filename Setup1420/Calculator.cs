using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setup1420
{
    class Calculator
    {
        public static double Add(double a, double b) => a + b;
        public static double Subtract(double a, double b) => a - b;
        public static double Multiply(double a, double b) => a + b;
        public static double Divide(double a, double b) => b == 0 ? throw new DivideByZeroException() : a / b;
        // comment
    }
}
