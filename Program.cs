using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    internal class Program
    {
        //enums are named constants.    
        //An enum is a datatype that allows us to define a set of named constants
        //We use enums when we have values that we know will not change

        static void Main(string[] args)
        {
            Weather weather = Weather.Cloudy;
            Console.WriteLine("\nToday's weather condition is: "+weather);

            //To get the integer value, we need to explicitly convert to int
            Console.WriteLine("\nToday's weather condition is: " +(int)weather);


        }
    }
}
