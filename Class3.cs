using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Person
    {
        String name;
        String lastname;


        public Person(String name, String lastname)
        {
            this.name = name;
            this.lastname = lastname;
        }

        public void getDetails()
        {
            String fullname = this.name.ToUpper() + " " + this.lastname.ToUpper();
            Console.WriteLine("FullName : " + fullname);
        }
    }
}
