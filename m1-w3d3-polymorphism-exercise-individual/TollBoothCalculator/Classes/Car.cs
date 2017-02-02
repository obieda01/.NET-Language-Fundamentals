using System;
using System.Collections.Generic;
using System.Linq;
        using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class Car:IVechicle
    {
        private bool hasTrailer;

        public Car(bool hasTrailer)
        {
            this.hasTrailer = hasTrailer;
        }
        public bool HasTrailer
        {
            get { return hasTrailer; }
            set { hasTrailer = value; }
        }

        public double calculateToll(int distance)
        {
            if (!HasTrailer)
            {
                return distance * 0.02;
            }
            else
            {
                return (distance * 0.02) + 1;
            }
        }
        
    }
}
