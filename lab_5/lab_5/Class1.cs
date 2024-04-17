using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    public abstract class Equipment
    {
        public decimal Price { get; set; }

        public Equipment(decimal price)
        {
            Price = price;
        }

        public abstract double GetMaxSpeed();
      
    }
}
