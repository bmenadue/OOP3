using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenadueSimUDuck
{
    public class RubberDuck : Duck
    {
        public void Quack()
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a fake duck");
        }
    }
}
