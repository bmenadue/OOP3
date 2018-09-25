using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenadueDecorator
{
    public abstract class CondimentDecorator : Beverage
    {
        public override string Description { get; set; }

        public override double Cost()
        {
        }
    }
}
