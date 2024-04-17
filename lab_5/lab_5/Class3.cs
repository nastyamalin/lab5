using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
   
    public class Snowboard : Equipment
    {
        public Snowboard(decimal price) : base(price) { }

        public override double GetMaxSpeed()
        {
           
            return 40; 
        }
        public double CalculateSpeed(double distance, double time)
        {
            return distance / time; 
        }
    }
}
