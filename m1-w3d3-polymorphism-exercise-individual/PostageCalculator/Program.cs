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
            try
            {
                Random r = new Random();
                Console.WriteLine("Please enter the weight of the package?");
                int weight = int.Parse(Console.ReadLine());
                Console.WriteLine("(P)ounds or (O)unces?");
                string weightType = Console.ReadLine().Substring(0, 1);
                if (weightType.ToLower() == "p") weight *= 16;
                else if (weightType.ToLower() != "o") Console.WriteLine("There is an Error in the weight type(P)ounds or (O)unces");

                Console.WriteLine("What distance will it be traveling to?");
                int distance = int.Parse(Console.ReadLine());
                writeToConsole("\n\nDelivery Method", "$ cost");
                Console.WriteLine("******************************************************\n");
                printOutput(distance, weight);
              
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("your input is wrong! try again! ");
            }
        }

        public static void printOutput(int distance, int weight)
        {

            List<IDeliveryDriver> allOptions = new List<IDeliveryDriver>() {
                new _1stClass(),
                new _2ndClass(),
                new _3rdClass(),
                new FexEd(),
                new _2_day(),
                new _4_day(),
                new Next_Day()
            };
            foreach (IDeliveryDriver item in allOptions)
            {
                item.calculateRate(distance, weight);
                //  Console.WriteLine(item.GetType());
                if (isContain(item, "FexEd")) 
                    writeToConsole(item.GetType().ToString().Substring(26),
                        "$" + (item.calculateRate(distance, weight).ToString()));
                else if (isContain(item,"_4_day") || isContain(item, "_2_day") || isContain(item, "Next_Day"))
                    writeToConsole("SPU (" + item.GetType().ToString().Substring(27) + " graound)", "$" + (item.calculateRate(distance, weight).ToString()));
                else 
                    writeToConsole("Postal Service (" + item.GetType().ToString().Substring(27) + ")", "$" + (item.calculateRate(distance, weight).ToString()));


            }
        }
        public static bool isContain(IDeliveryDriver item,string str)
        {
            return(item.GetType().ToString().Contains(str)) ;
        }
        public static void writeToConsole(string f, string m)
        {
            Console.WriteLine(f.PadRight(35) + m.PadRight(35));

        }
    }
}
