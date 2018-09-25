using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenadueDecorator
{
    public abstract class Beverage
    {
        public abstract string Description { get; set; }

        public abstract double Cost();

    }
}
