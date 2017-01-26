using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Person
    {
        //Class Code Goes Here
        public string firstName;
        public string lastName;
        public int age;

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public bool IsAdult()
        {
            return age >= 18;
        }
     
    }
}
