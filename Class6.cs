using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Stack
    {
        private int[] num = new int[3];

        public int this[int i]
        {
            get
            {
                return num[i];
            }
            set
            {
                num[i] = value;
            }
        }

    }
}
