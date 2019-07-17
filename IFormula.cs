using System;
using System.Collections.Generic;
using System.Text;

namespace FormulaDecorator
{
    public interface IFormula
    {
        string GetFormula();
        double GetResult();
    }
}
