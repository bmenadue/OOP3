using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenadueDecorator
{
    public class Whip : CondimentDecorator
    {
        public Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double cost()
        {
            return .10 + beverage.cost();
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Whip";
        }
    }
}
