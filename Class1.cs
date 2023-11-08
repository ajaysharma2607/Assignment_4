using Assignment_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class Bank
    {
        String name;
        float balance;
        public Bank(String name, float balance)
        {
            this.name = name;
            if (balance < 0)
            {
                Console.WriteLine("Enter Correct Balance");
            }
            this.balance = balance;
        }

        public void getDetails()
        {
            Console.WriteLine("Name :" + this.name);
            Console.WriteLine("Balance :" + this.balance);
        }
    }

}
