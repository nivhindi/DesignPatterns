using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaDecorator
{
    public class SubFormula : FormulaDecoratorBase
    {
        public SubFormula(IFormula formula, double numberToBeSub) : base(formula, numberToBeSub)
        {

        }

        public override string GetFormula()
        {
            return formula.GetFormula() + "-" + numberToBeCalculated;
        }

        public override double GetResult()
        {
            return formula.GetResult() - numberToBeCalculated;
        }
    }
}
