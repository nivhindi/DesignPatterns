using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.QuestionTen
{
    class _3DLightOption : WindowOptionsDecorator
    {
        public _3DLightOption(IWindow window) : base(window)
        {
        }

        public override string GetDetails()
        {
            return this.window.GetDetails() + " 3D light";
        }
    }
}
