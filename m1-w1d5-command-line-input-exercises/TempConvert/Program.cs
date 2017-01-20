using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConvert
{
    class Program
    {
        /*
         The Fahrenheit to Celsius conversion formula is:
 	        Tc = (Tf - 32) / 1.8
 	        where 'Tc' is the temperature in Celsius, and 'Tf' is the temperature in Fahrenheit
 	
         The Celsius to Fahrenheit conversion formula is:
 	        Tf = Tc * 1.8 + 32
 	         
        Write a command line program which prompts a user to enter a temperature, and whether its in degrees (C)elsius or (F)arenheit.
        Convert the temperature to the opposite degrees, and display the old and new temperatures to the console.

         C:\Users> TempConvert
         Please enter the temperature: 58
         Is the temperature in (C)elcius, or (F)arenheit? F
         58F is 14C.
        
         */
        static void Main(string[] args)
        {
            try

            {
                Console.WriteLine("C:\\Users> TempConvert \n Please enter the temperature:");
                double temperature = double.Parse(Console.ReadLine());
                Console.WriteLine("Is the temperature in (C)elcius, or (F)arenheit? ");
                Char tempType = char.Parse(Console.ReadLine());

                if (tempType == 'C')
                {
                    // Tf = Tc * 1.8 + 32
                    Console.WriteLine(temperature + "C is " + ((temperature * 1.8) + 32) + "F.");
                }
                else if (tempType == 'F')
                {
                    // Tc = (Tf - 32) / 1.8

                    Console.WriteLine(temperature + "F is " + ((temperature - 32) / 1.8) + "C.");
                }
                else Console.WriteLine("The Temperature type is not valid ");
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred:", e);
            }

        }
    }
}
