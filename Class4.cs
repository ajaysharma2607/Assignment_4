using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Temperature
    {
        float temp;
        public Temperature(float value)
        {
            temp = value;
        }

        public void convertToFahrenheit()
        {
            float f = (temp * 9) / 5 + 32;
            Console.WriteLine("Temperature in Fahrenheit is :" + f);
        }
    }
}
