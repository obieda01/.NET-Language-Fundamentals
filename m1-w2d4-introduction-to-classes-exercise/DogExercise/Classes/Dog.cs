﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /**
    * This class represents a dog that can sleep, wake, and make a sound, so it's pretty much like most dogs,
    * with a few essential methods missing. Thankfully.
    */
    public class Dog
    {
        public bool isSleeping = false;

        public string MakeSound()
        {
            if (isSleeping) return "Zzzz...";
            else return "woof!";

        }

        public void Sleep()
        {
            isSleeping = true;
        }
        public void WakeUp()
        {
            isSleeping = false;
        }
        public bool SetGetDogStatus
        {
            get { return isSleeping; }
            set { isSleeping = value; }
        }

        
    }
}
