using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.title = "LOTR";


            Console.WriteLine(LOTR.title);

        }
    }
}
