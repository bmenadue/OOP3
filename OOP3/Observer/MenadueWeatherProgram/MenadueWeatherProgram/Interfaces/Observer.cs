using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenadueWeatherProgram
{
    public interface Observer
    {
        void update(double temp, double humidity, double pressure);
    }
}
