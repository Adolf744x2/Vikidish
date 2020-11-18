using System;
using System.Collections.Generic;
using System.Text;

namespace Велосипед
{
    interface ISwimming
    {
        void Swimm()
        {
            Console.WriteLine(this + " идет в новую точку");
        }
    }
}
