using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    enum Weather
    {
        //By default the each constant is assigned an integer value starting from zero
        //And then incremented
        Sunny,
        Windy,
        //We can also explicitly assign values if needed
        Cloudy = 10,
        Rainy,
        Snowy
    }
}
