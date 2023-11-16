using System.Text;
using System.Threading.Tasks;

namespace Decorator_Design_Pattern
{
    public class Coffee : IDrink
    {
        void IDrink.FillDrink()
        {
            Console.WriteLine("Kahve");
        }
    }
}
