using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenadueSimUDuck
{
    public class MuteQuack : QuackBehavior
    {
        void QuackBehavior.Quack()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}
