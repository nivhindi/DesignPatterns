using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.QuestionTen
{
    public class ShadowingOption : WindowOptionsDecorator
    {
        public ShadowingOption(IWindow window) : base(window)
        {
        }

        public override string GetDetails()
        {
            return this.window.GetDetails() + " Shadowwing";
        }
    }
}
