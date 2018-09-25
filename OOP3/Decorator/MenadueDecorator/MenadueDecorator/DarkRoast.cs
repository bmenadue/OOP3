﻿using System;
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
            description = "Dark Roast";
        }

        public override double cost()
        {
            return .99;
                }
    }
}
