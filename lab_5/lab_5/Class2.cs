using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    public class Skis : Equipment
    {
        public Skis(decimal price) : base(price) { }

        public override double GetMaxSpeed()
        {
            
            return 50; 
        }
        public double CalculateSpeed(double distance, double time)
        {
            return distance / time; 
        }
    }
}
