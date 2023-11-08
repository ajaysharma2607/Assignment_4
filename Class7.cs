using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Book
    {
            private string bookname;

    public string this[string param]
    {
        get
        {
            return bookname;
        }
        set
        {
            if (param == "title")
                bookname = value.ToString();
            else
            {
                throw new Exception("please use title for index");
            }
        }
    }

}
}
