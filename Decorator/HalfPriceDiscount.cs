using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class HalfPriceDiscount : DiscountDecoratorBase
    {
        public HalfPriceDiscount(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDetails()
        {
            return pizza.GetDetails() + " pizza with 50% discount";
        }

        public override double GetPrice()
        {
            return pizza.GetPrice() * 0.5;
        }
    }
}
