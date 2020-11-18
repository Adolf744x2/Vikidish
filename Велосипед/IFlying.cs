using System;
using System.Collections.Generic;
using System.Text;

namespace Велосипед
{
    interface IFlying
    {
        void Fly()
        {
            Console.WriteLine(this + " идет в новую точку");
        }
    }
}
