using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Design_Pattern
{
    public class Milk : DrinkDecorator
    {
        public Milk(IDrink drink) : base(drink) { }

        public override void FillDrink()
        {
            base.FillDrink();
            FillMilkDrink();
        }

        private void FillMilkDrink()
        {
            Console.Write("Sütlu ");
        }
    }
}
