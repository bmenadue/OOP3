﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenadueDecorator
{
    public class Soy : CondimentDecorator
    {
        public Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }


        public override double cost() {

            return .15 + beverage.cost();
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }
    }
}
