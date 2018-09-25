using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenadueDecorator
{
    public class Milk : CondimentDecorator
    {
        public Beverage beverage;

        public void cost() {}

        public string Description { get; set; }
    }
}
