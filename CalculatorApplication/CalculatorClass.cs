using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T num1,  T num2);
    internal class CalculatorClass
    {
        public Formula<double> formula;

        private Formula<double> calculateEvent;
        public event Formula<double> CalculateEvent
        {
            add 
            {
                Console.WriteLine("Added The Delegate");
                CalculateEvent += value;
            }

            remove
            {
                Console.WriteLine("Remove The Delegate");
                CalculateEvent -= value;
            }
        }


        public double GetSum(double num1, double num2) { 
            return num1 + num2;
        }

        public double GetDifference(double num1, double num2) { 
            return num1 - num2;
        }
    }
}
