﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    interface IDeliveryDriver
    {
        double calculateRate(int distance, double weight);
    }
}
