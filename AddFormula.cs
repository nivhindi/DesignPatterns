using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaDecorator
{
    public class AddFormula : FormulaDecoratorBase
    {
        public AddFormula(IFormula formula, double numberToBeAdded) : base(formula, numberToBeAdded)
        {

        }

        public override string GetFormula()
        {
            return formula.GetFormula() + "+" + numberToBeCalculated;
        }

        public override double GetResult()
        {
            return formula.GetResult() + numberToBeCalculated;
        }
    }
}
