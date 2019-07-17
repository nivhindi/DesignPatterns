using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaDecorator
{
    public class DivFormula : FormulaDecoratorBase
    {
        public DivFormula(IFormula formula, double numberToBeDivided) : base(formula, numberToBeDivided)
        {

        }

        public override string GetFormula()
        {
            return formula.GetFormula() + "/" + numberToBeCalculated;
        }

        public override double GetResult()
        {
            return formula.GetResult() / numberToBeCalculated;
        }
    }
}
