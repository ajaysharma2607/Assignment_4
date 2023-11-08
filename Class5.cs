using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class CustomList
    {
        private int[] num = new int[10];

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
