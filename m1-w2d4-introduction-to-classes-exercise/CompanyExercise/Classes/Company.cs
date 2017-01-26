using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Company
    {
        public string name;
        public int numberOfEmployees;
        public decimal revenue;
        public decimal expenses;


        public string GetCompanySize()
        {
            if (numberOfEmployees < 50) return "small";
            if (numberOfEmployees >= 50 && numberOfEmployees <= 250) return "medium";
            return "large";
        }

        public decimal GetProfit()
        {
            return revenue - expenses;
        }

      

     
    }
}
