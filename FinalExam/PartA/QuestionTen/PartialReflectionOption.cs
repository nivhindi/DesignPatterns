using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.QuestionTen
{
    public class PartialReflectionOption : WindowOptionsDecorator
    {
        public PartialReflectionOption(IWindow window) : base(window)
        {
        }

        public override string GetDetails()
        {
            return this.window.GetDetails() + " Partial reflection";
        }
    }
}
