using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
  
    public class Backpack : Equipment
    {
        public Backpack(decimal price) : base(price) { }

        public override double GetMaxSpeed()
        {
            
            return 0;
        }
    }
}
