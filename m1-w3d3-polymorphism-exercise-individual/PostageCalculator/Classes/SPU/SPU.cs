using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
   public abstract class SPU:IDeliveryDriver
    {
        private string classType;

        public string ClassType
        {
            get { return classType; }
            set { classType = value; }
        }


        public abstract double calculateRate(int distance, double weight);
        
            
        
    }
}
