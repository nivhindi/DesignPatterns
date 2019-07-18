using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.QuestionTen
{
    public class ColorfulBorderOption : WindowOptionsDecorator
    {
        public ColorfulBorderOption(IWindow window) : base(window)
        {
        }

        public override string GetDetails()
        {
            return this.window.GetDetails() + " Colorful border";
        }
    }
}
