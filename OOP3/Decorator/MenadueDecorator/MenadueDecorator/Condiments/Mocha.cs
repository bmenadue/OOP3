using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenadueDecorator
{
    public class Mocha : CondimentDecorator
    {
        public Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double cost() {

            return .20 + beverage.cost();
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Mocha";
        }
    }
}
