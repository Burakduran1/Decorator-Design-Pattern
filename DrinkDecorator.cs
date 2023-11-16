using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Design_Pattern
{
    public abstract class DrinkDecorator : IDrink
    {
        private IDrink drink;

        protected DrinkDecorator(IDrink d)
        {
            this.drink = d;
        }
        public virtual void FillDrink()
        {
            drink.FillDrink();
        }
    }
}