using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaDecorator
{
    public class StartNumber : IFormula
    {
       protected double firstNumber;

        public StartNumber(double startNumber)
        {
            this.firstNumber = startNumber;
        }
       public string GetFormula()
        {
            return firstNumber.ToString();
        }

        public double GetResult()
        {
            return firstNumber;
        }

        public void modifyNumber(double newValue)
        {
            this.firstNumber = newValue;
        }
    }
}
