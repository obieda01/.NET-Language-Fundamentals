using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostageCalculator.Classes;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            writeToConsole("Vehicle", "Distance Traveled", "Toll  $");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            List<IVechicle> allVehichles = new List<IVechicle>() {
                new Car(true),
                new Truck(4),
                new Tank(),
                new Car(false),
                new Truck(6),
                new Truck(8 ),

            };

            foreach (IVechicle item in allVehichles)
            {
                int randomDistance = r.Next(10, 240);
                string str = item.ToString();
                writeToConsole(str.Substring(26), randomDistance.ToString(), item.calculateToll(randomDistance).ToString());
            }

            Console.ReadKey();
        }

        public static void writeToConsole(string f, string m, string l)
        {
            Console.WriteLine(f.PadRight(35) + m.PadRight(35) + l);

        }
    }
}
