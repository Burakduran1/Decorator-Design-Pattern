using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDrink coffee = new Coffee();
            IDrink milkCoffee = new Milk(new Coffee());
            IDrink sugarCoffee = new Sugar(new Coffee());
            IDrink creamCoffee = new Cream(new Coffee());
            IDrink milkSugarCoffee = new Milk(new Sugar(new Coffee()));
            IDrink creamMilkSugarCoffee = new Cream(new Milk(new Sugar(new Coffee())));

            coffee.FillDrink();
            milkCoffee.FillDrink();
            sugarCoffee.FillDrink();
            creamCoffee.FillDrink();
            milkSugarCoffee.FillDrink();
            creamMilkSugarCoffee.FillDrink();
            Console.ReadKey();
        }
    }
}
