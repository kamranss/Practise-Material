using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Practicing
{
    internal class Calculator:CalculationMethod
    {
        // Class For calculating the given two number
        public double Num1;
        public double Num2;
        public string Variation;

        public Calculator()
        {

        }
        public Calculator(double num1, double num2, string variation)
        {
            Num1 = num1;
            Num2 = num2;
            Variation = variation;

        }
        public Calculator(double num1, float num2)
        {
            Num1 = num1;
            Num2 = num2;

        }


        public double CalculatorMethod( double a, double b, string variation)
        {
            double result = 0;

            if (variation == "1")
            {
                result = Sum(a, b) ;
            }
            else if (variation == "2")
            {
                result = Product(a, b);
            }
            else if (variation == "3")
            {
                result = Divide(a,b);
            }
            else if (variation == "4")
            {
                result = Deduction(a, b);
            }
            return result;
        }

       
    }
}
