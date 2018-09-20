using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenadueSimUDuck
{
    public abstract class Duck
    {
        public QuackBehavior quackBehavior;

        public FlyBehavior flyBehavior;

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public abstract void Display();
        

        public void performQuack()
        {
            quackBehavior.Quack();
        }

        public void performFly()
        {
            flyBehavior.Fly();
        }

        public FlyBehavior FlyProperty
        {
            get
            {
                return flyBehavior;
            }
            set
            {
                this.flyBehavior = value;
            }
        }

        public QuackBehavior QuackProperty
        {
            get
            {
                return quackBehavior;
            }
            set
            {
                this.quackBehavior = value;
            }
        }
    }
}
