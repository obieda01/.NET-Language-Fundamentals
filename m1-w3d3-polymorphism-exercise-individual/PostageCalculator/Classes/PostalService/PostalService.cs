using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class PostalService : IDeliveryDriver
    {
        private double rate;

        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        private int ounces;

        public int Ounces
        {
            get { return ounces; }
            set { ounces = value; }
        }

        private int pounds;

        public int Pounds
        {
            get { return pounds; }
            set { pounds = value; }
        }
        public int convertPoundsToOunces()
        {
            return (Pounds * 16) + Ounces;
        }

        public virtual double calculateRate(int distance, double weight)
        {
            return Math.Round(Rate, 2);
        }
    }
}
