using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class OnionTopping : ToppingDecoratorBase
    {

        public OnionTopping(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return pizza.GetDetails() + " Onion";
        }

        public override double GetPrice()
        {
            return pizza.GetPrice() + 3;
        }
    }
}
