using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class FexEd : IDeliveryDriver
    {
        private double rate = 20;

        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public double calculateRate(int distance, double weight)
        {
            if (distance == 0 || weight == 0) return 0;
            if (distance > 500) return Rate + 5;
            if (weight > 48) return Rate + 3;
            return Math.Round(Rate, 2);
        }
    }
}
