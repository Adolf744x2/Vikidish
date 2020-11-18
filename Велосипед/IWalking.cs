using System;
using System.Collections.Generic;
using System.Text;

namespace Велосипед
{
    interface IWalking
    {
        void Walk()
        {
            Console.WriteLine(this + " идет в новую точку");
        }
    }
}
