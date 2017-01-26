using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// A shopping cart class stores items in it.
    /// </summary>
    public class ShoppingCart
    {
        public int totalNumberOfItems = 0;
        public double totalAmountOwed = 0.0;


        public double GetAveragePricePerItem()
        {
            if (totalAmountOwed == 0 || totalNumberOfItems == 0) return 0;
              else  return (double)totalAmountOwed / totalNumberOfItems;
        }

        public void AddItems(int numberOfItem, double pricePerItem)
        {
            this.totalNumberOfItems = numberOfItem;
            this.totalAmountOwed += pricePerItem * (double)numberOfItem;
        }

        public void Empty()
        {
            this.totalNumberOfItems = 0;
            this.totalAmountOwed = 0.0;
        }
    }
}
