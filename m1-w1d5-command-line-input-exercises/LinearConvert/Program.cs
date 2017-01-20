using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearConvert
{
    class Program
    {
        /*
         The foot to meter conversion formula is:
 	        m = f * 0.3048
 	
         The meter to foot conversion formula is:
 	        f = m * 3.2808399
 	
         Write a command line program which prompts a user to enter a length, and whether the measurement is in (m)eters or (f)eet.
         Convert the length to the opposite measurement, and display the old and new measurements to the console.
  
         C:\Users> LinearConvert
         Please enter the length: 58
         Is the measurement in (m)eter, or (f)eet? f
         58f is 17m.
         */

        
        static void Main(string[] args)
        {
            try

            {
                Console.WriteLine("C:\\Users> TempConvert \nPlease enter the length: ");
                double measurement = double.Parse(Console.ReadLine());
                Console.WriteLine("Is the measurement in (m)eter, or (f)eet?");
                Char tempType = char.Parse(Console.ReadLine());

                if (tempType == 'm')
                {
                    // f = m * 3.2808399
                    Console.WriteLine(measurement + "m is " + (measurement * 3.2808399) + "f.");
                }
                else if (tempType == 'f')
                {
                    // m = f * 0.3048

                    Console.WriteLine(measurement + "f is " + (measurement * 0.3048) + "m.");
                }
                else Console.WriteLine("The Temperature type is not valid ");


            }

            catch (Exception e)
            {
                Console.WriteLine("An error occurred! \nyou entered a wrong value \n\n", e);
            }

        }
        
    }
}
