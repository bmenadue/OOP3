using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menadue_SimUDuck
{
    public class MiniDuckSimulator
    {
        public static void main(String[] args)
        {
            Duck mallard = new MallardDuck();

            mallard.performQuack();

            mallard.performFly();
        }
    }
}
