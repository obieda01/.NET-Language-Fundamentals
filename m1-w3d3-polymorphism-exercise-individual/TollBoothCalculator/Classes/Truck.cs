using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    class Truck:IVechicle
    {

        private int numberOfAxel;

        public Truck(int numberOfAxel)
        {
            this.numberOfAxel = numberOfAxel;
        }
        public int NumberOfAxel
        {
            get { return numberOfAxel; }
            set { numberOfAxel = value; }
        }

        public double calculateToll(int distance)
        {
            if (numberOfAxel == 4) return 0.04 * distance;
            if (numberOfAxel == 6) return 0.045 * distance;
            if (numberOfAxel >=8) return 0.048 * distance;

            return 0;
        }
    }
}
