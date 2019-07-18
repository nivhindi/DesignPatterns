using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.QuestionTen
{
    public abstract class WindowOptionsDecorator : IWindow
    {
        protected IWindow window;

        public WindowOptionsDecorator(IWindow window)
        {
            this.window = window;
        }

        public abstract string GetDetails();
    }
}
