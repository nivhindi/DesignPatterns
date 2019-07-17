using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaDecorator
{
    public class MulFormula : FormulaDecoratorBase
    {
        public MulFormula(IFormula formula, double numberToBeMul) : base(formula, numberToBeMul)
        {

        }

        public override string GetFormula()
        {
            return formula.GetFormula() + "*" + numberToBeCalculated;
        }

        public override double GetResult()
        {
            return formula.GetResult() * numberToBeCalculated;
        }
    }
}
