using System;
using System.Collections.Generic;
using System.Text;

namespace Велосипед
{
    class Animal
    {
        public DateTime Birthday { get; set; }
        public int Age
        {
            get
            {
                return (int)DateTime.Now.Subtract(Birthday).TotalDays / 365;
            }
        }
    }
}
    

