﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenadueWeatherProgram
{
    public interface Subject
    {
        void registerObserver(Observer o);

        void removeObserver(Observer o);

        void notifyObserver();
    }
}
