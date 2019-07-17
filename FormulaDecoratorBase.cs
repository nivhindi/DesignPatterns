using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaDecorator
{
    public abstract class FormulaDecoratorBase : IFormula
    {
        protected IFormula formula;
        protected double numberToBeCalculated;
        public abstract string GetFormula();
        public abstract double GetResult();
        public FormulaDecoratorBase(IFormula formula, double numberToBeCalculated)
        {
            this.formula = formula;
            this.numberToBeCalculated = numberToBeCalculated;
        }
    }
}
