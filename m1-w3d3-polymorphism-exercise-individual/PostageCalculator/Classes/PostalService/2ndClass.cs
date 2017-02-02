using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class _2ndClass : PostalService
    {


        public override double calculateRate(int distance, double weight)
        {
            if (weight == 0 || distance == 0) return 0;
            if (weight >= 0 && weight <= 2)
            {
                Rate = distance * 0.0035;
                return base.calculateRate(distance, weight);
            }
            if (weight >= 3 && weight <= 8)
            {
                Rate = distance * 0.004;
                return base.calculateRate(distance, weight);
            }
            if (weight >= 9 && weight <= 15)
            {
                Rate = distance * 0.0047;
                return base.calculateRate(distance, weight);
            }

            if (weight >= 16 && weight <= 63)
            {
                Rate = distance * 0.0195;
                return base.calculateRate(distance, weight);
            }
            if (weight >= 64 && weight <= 128)
            {
                Rate = distance * 0.0450;
                return base.calculateRate(distance, weight);
            }


            Rate = distance * 0.0500;
            return base.calculateRate(distance, weight);


        }
    }
}
