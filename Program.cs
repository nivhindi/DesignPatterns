using System;

namespace FormulaDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            StartNumber startNumber = new StartNumber(5);
            IFormula formula = new AddFormula(new MulFormula(new SubFormula(new DivFormula(new AddFormula(new MulFormula(startNumber, 2), 100), 12), 3), 4), 7);
            
            Console.WriteLine("The formula is: " + formula.GetFormula());
            Console.WriteLine("The result of it is: " + formula.GetResult());

            Console.WriteLine("First number changed to 30.....");
            startNumber.modifyNumber(30);

            IFormula formulaAfterChange = new AddFormula(new MulFormula(new SubFormula(new DivFormula(new AddFormula(new MulFormula(startNumber, 2), 100), 12), 3), 4), 7);

            Console.WriteLine("The formula is: " + formulaAfterChange.GetFormula());
            Console.WriteLine("The result of it is: " + formulaAfterChange.GetResult());
        }
    }
}
