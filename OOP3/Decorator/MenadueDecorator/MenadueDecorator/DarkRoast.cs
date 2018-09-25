using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenadueDecorator
{
    public class DarkRoast :Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast";
        }

        public override string Description { get;  set; }

        public override double Cost()
        {
            return .99;
        }
    }
}
