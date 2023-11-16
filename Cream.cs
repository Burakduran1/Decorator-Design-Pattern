using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Design_Pattern
{
    public class Cream : DrinkDecorator
    {
        public Cream(IDrink drink) : base(drink) { }

        public override void FillDrink()
        {
            base.FillDrink();
            FillCreamDrink();
        }

        private void FillCreamDrink()
        {
            Console.Write("Kremalı ");
        }
    }
}
