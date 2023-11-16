using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Design_Pattern
{
    public class Sugar : DrinkDecorator
    {
        public Sugar(IDrink drink) : base(drink) { }
        public override void FillDrink()
        {
            base.FillDrink();
            FillSugarDrink();
        }
        private void FillSugarDrink()
        {
            Console.Write("Şekerli ");
        }
    }
}
