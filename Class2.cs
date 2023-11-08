using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Car
    {
        String name;
        String model;
        int year;

        public Car(String name, String model, int year)
        {
            this.name = name;
            this.year = year;
            this.model = model;

        }

        public void getDetails()
        {
            Console.WriteLine("Name :" + this.name);
            Console.WriteLine("Model :" + this.model);
            Console.WriteLine("Year :" + this.year);
        }
    }

}
